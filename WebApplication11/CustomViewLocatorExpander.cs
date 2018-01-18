using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11
{
    public class CustomViewLocatorExpander : IViewLocationExpander
    {
        public virtual IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            var viewLocationsFinal = new List<string>();
            if (!string.IsNullOrEmpty(context.Values["viewCustom"]))
            {
                foreach (var viewLocation in viewLocations)
                {
                    viewLocationsFinal.Add(viewLocation.Replace(".cshtml", ".mobile.cshtml"));
                }
            }
            viewLocationsFinal.AddRange(viewLocations);

            return viewLocationsFinal;
        }


        public void PopulateValues(ViewLocationExpanderContext context)
        {
            var userAgent = context.ActionContext.HttpContext.Request.Headers["User-Agent"].ToString().ToLower();
            var viewCustom = userAgent.Contains("android") || userAgent.Contains("ios") ? "mobile" : "";
            context.Values["viewCustom"] = viewCustom;
        }
    }
}
