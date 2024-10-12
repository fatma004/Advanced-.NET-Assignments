using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_Day1
{
    public class Product
    {
        public string Name { get; set; }

        private double price;

        private int stockQuantity;
        public double Price
        {
            get { return price; } 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative.");
                }
                price = value; 
            }
        }

        public int StockQuantity
        {
            get { return stockQuantity; } 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Stock quantity cannot be negative!");
                }
                stockQuantity = value;
            }
        }
        public bool IsAvailable
        {
            get { return StockQuantity > 0; }
        }

        public void UpdateStock(int amount)
        {
            StockQuantity += amount; 
        }
    }
}
