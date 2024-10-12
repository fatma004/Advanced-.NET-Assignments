using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_Day1
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public int Age
        {
            get { return DateTime.Now.Year - Year; }
        }
        public Car(string make, string model, int year, int mileage)
        {
           Make = make;
           Model = model;
           Year = year;
           Mileage = mileage;
        }
        public void Drive(int distance)
        {
            if (distance < 0)
            {
                throw new ArgumentException("Distance cannot be negative!");
            }
            Mileage += distance;
        }
    }
}
