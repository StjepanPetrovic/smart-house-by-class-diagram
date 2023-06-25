using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house_by_class_diagram
{
    internal class Reporter
    {
        public string CreateDailySumReport(Meter meter)
        {
            if (meter.Unit == "kWh")
            {
                return "Daily total value is " + meter.CalculateDailySum() + " kWh";
            } 
            else if (meter.Unit == "m3")
            {
                return "Daily total value is " + meter.CalculateDailySum() + " m3";
            }

            return "Unit not found";
        }
    }
}
