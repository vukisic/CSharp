using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    public class ProgressReportModel
    {
        public List<WebsiteDataModel> WebSites { get; set; } = new List<WebsiteDataModel>();

        public int Progress { get; set; } = 0;
    }
}
