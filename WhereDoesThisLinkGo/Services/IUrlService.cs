using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereDoesThisLinkGo.Services
{
    public interface IUrlService
    {
        Uri Expand(string url);
    }
}
