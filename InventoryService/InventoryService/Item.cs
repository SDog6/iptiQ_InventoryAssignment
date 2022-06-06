using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService
{
    internal class Item
    {

        public int Id { get; set; }

        private string name;
        private int quantity;
        private double price;

        public Item(string name, int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public Item(int id,string name, int quantity, double price)
        {
            this.Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public string Name { get { return this.name; } set { 
                if (value == null) {
                    throw new ArgumentNullException("value");
                }
                this.name = value;
                    } }

        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                if (value <= 0 && int.TryParse(Console.ReadLine(), out value))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                this.quantity = value;
            }
        }


        public double Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0 && double.TryParse(Console.ReadLine(), out value))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                this.price = value;
            }
        }

    }
}
