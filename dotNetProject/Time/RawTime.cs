using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetProject.Time
{
    class RawTime : IRawTime
    {
        public string GetTimestamp(String Timestamp)
        {
            return Timestamp;
        }
    }
}
