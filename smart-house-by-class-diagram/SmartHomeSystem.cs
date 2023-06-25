using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house_by_class_diagram
{
    internal class SmartHomeSystem
    {
        public List<Meter> Meters { get; set; } = new List<Meter>();

        public string GetReports()
        {
            Reporter reporter = new Reporter();
            string report = "";

            foreach (Meter meter in Meters)
            {
               report += reporter.CreateDailySumReport(meter);
            }

            return report;
        }
    }
}
