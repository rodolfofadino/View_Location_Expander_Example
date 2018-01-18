using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11
{

public class CustomViewLocatorExpander : IViewLocationExpander
{
    public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
    {
        throw new NotImplementedException();
    }

    public void PopulateValues(ViewLocationExpanderContext context)
    {
        throw new NotImplementedException();
    }
}




    //public class CustomViewLocatorExpander : IViewLocationExpander
    //{
    //    public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
    //    {
    //        //alterar o caminho das views
    //        foreach (var viewLocation in viewLocations)
    //        {
    //            yield return viewLocation.Replace("/Views/", $"/Views/{context.Values["tema"]}/");
    //        }
    //    }

public void PopulateValues(ViewLocationExpanderContext context)
{
    //acesssar o context e pegar o tema do usuário
    var userName = context.ActionContext.HttpContext.User.Identity.Name;
    //ex: loadTema by user
    var tema = "tema-1";
    context.Values["tema"] = tema;
}
    //}
}
