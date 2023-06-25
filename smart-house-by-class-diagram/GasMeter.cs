using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_house_by_class_diagram
{
    internal class GasMeter : Meter
    {
        public new string Name { get; set; }
        public new string Unit { get; set; }
        protected new string RawData { get; set; }

        public GasMeter(string name, string unit, string rawData) : base(name, unit, rawData)
        {
            Name = name;
            Unit = unit;
            RawData = rawData;
        }

        public override double[] GetDailyData()
        {
            string[] dailyDataString = RawData.Split(';');
            double[] dailyDataDouble = null;
            int counter = 0;

            foreach (var item in dailyDataString)
            {
                dailyDataDouble[counter] = double.Parse(item) / 1000;

                counter++;
            }

            return dailyDataDouble;
        }
    }
}
