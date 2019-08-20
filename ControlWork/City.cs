using System;

namespace ControlWork
{
    struct City
    {
        public int Populated;
        public string Name;
        public int Area;
        public double Density;
        public City(string result)
        {
            string[] nameSplit = result.Split('=');
            string[] values = nameSplit[1].Split(',');
            Name = nameSplit[0];
            Populated = int.Parse(values[0]);
            Area = int.Parse(values[1]);
            Density = Convert.ToDouble(Populated) / Convert.ToDouble(Area);
        }
    }
}
