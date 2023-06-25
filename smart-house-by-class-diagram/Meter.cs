using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house_by_class_diagram
{
    public abstract class Meter
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        protected string RawData { get; set; }

        public Meter(string name, string unit, string rawData)
        {
            Name = name;
            Unit = unit;
            RawData = rawData;
        }

        public abstract double[] GetDailyData();

        public double CalculateDailySum()
        {
            double sum = 0;

            foreach (var item in GetDailyData())
            {
                sum += item;
            }

            return sum;
        }
    }
}
