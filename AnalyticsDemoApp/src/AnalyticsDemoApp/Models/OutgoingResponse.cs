using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnalyticsDemoApp.Models
{
    public class OutgoingResponse
    {
        public string NewCartItem { get; set; }

        public Dictionary<string, string> CartItemsOfOthers { get; set; }
    }
}
