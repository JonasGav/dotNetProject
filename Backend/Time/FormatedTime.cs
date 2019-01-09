using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetProject.Time
{
    class FormatedTime : IFormatedTime
    {
        public string GetTimestamp(String Timestamp)
        {
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            long unixTimeStampInTicks = (long)(Convert.ToDouble(Timestamp) * TimeSpan.TicksPerSecond);
            var result = new DateTime(unixStart.Ticks + unixTimeStampInTicks, System.DateTimeKind.Utc);
            return result.ToString("d");
        }
    }
}
