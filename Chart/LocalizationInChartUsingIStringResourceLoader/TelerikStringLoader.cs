using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Core;

namespace LocalizationInChartUsingIStringResourceLoader
{
    class TelerikStringLoader : IStringResourceLoader
    {
        public string GetString(string key)
        {
            switch (key)
            {
                case "NoHorizontalAxis":
                    return "There is no Horizontal Axis!";
                case "NoVerticalAxis":
                    return "There is no Vertical Axis!";
                default:
                    return null;
            }
        }
    }
}
