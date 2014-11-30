using Moq;
using ShowCase.Domain.Abstract;
using ShowCase.Domain.Concrete;
using ShowCase.Domain.Entities;
using ShowCase.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShowCase.WebUI.Controllers
{
    public class ThemeController : Controller
    {
        private IThemeRepository repository;

        public int PageSize = 4;

        public ThemeController()
        {
            IThemeRepository t = new EFThemeRepository();
            repository = t;
        }

        public ViewResult List(string name, int page = 1)
        {
            ThemeListViewModel model = new ThemeListViewModel
            {
                Themes = repository.Themes.Where(t => name == null || t.Name == name)
                                           .OrderBy(t => t.ThemeId)
                                          .Skip((page - 1) * PageSize)
                                          .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = name == null ? 
                                         repository.Themes.Count() : 
                                         repository.Themes.Where(t => t.Name == name).Count()
                },
                ThemeName = name
            };
            return View(model);
        }
    }
}