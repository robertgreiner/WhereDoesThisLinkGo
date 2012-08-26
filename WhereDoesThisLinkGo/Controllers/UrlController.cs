using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhereDoesThisLinkGo.Models;
using WhereDoesThisLinkGo.Services;

namespace WhereDoesThisLinkGo.Controllers
{
    public class UrlController : Controller
    {
        private readonly IUrlService urlService;

        public UrlController()
        {
            urlService = new UrlService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new UrlViewModel {Result = string.Empty, ErrorMessage = string.Empty};
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(UrlViewModel model)
        {
            model.ExpandedUri = urlService.Expand(model.ShortenedUri);

            if (model.ExpandedUri == null)
            {
                model.ErrorMessage = "Error!";
            }
            else
            {
                model.Result = model.ExpandedUri.AbsoluteUri;
            }

            return View(model);
        }
    }
}
