using ShowCase.Domain.Abstract;
using ShowCase.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShowCase.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IThemeRepository repository;

        public NavController()
        {
            IThemeRepository t = new EFThemeRepository();
            repository = t;
        }

        // GET: /Nav/
        public PartialViewResult Menu(string name=null)
        {
            ViewBag.SelectedName = name;
            IEnumerable<string> themes = repository.Themes
                                                   .Select(x => x.Name)
                                                   .Distinct()
                                                   .OrderBy(x => x);
            return PartialView(themes);
                                                   
        }
    }
}