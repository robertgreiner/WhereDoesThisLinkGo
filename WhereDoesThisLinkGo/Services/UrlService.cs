using System;
using System.Net;

namespace WhereDoesThisLinkGo.Services
{
    public class UrlService : IUrlService
    {
        public Uri Expand(string url)
        {
            try
            {
                if (!url.Contains("http"))
                {
                    url = string.Format("{0}{1}", "http://", url);
                }
                var request = (HttpWebRequest)WebRequest.Create(url);
                var response = (HttpWebResponse)request.GetResponse();
                return response.ResponseUri;    
            }
            catch
            {
                return null;
            }
        }
    }
}