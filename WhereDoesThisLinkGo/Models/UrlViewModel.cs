using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhereDoesThisLinkGo.Models
{
    public class UrlViewModel
    {
        public string ShortenedUri { get; set; }
        public Uri ExpandedUri { get; set; }
        public string Result { get; set; }
        public string ErrorMessage { get; set; }
    }
}