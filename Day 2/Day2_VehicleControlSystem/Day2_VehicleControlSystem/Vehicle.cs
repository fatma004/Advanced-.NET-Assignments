using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_VehicleControlSystem
{
   public abstract class Vehicle
    {
        public void Start() 
        {
            Console.WriteLine($"{GetType().Name} started!");
        }
        public void Stop() 
        {
            Console.WriteLine($"{GetType().Name} stoopped!");

        }
        public abstract void Describe();
    }
}
