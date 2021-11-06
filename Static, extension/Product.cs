using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__extension
{
    //baseclass - superclass
    public class Product
    {
        public Product(string name)
        {
            this.Name = name;

        }



        public string Name;
        public int Price;
        public int Count;
        public int Totalincome;


        public void Sell(int a)
        {


            if (Count < a)
            {
                Console.WriteLine("Kifayet qeder meshul yoxdur");

            }
            else if (Count >= a)
            {
                Totalincome += a * Price;
                Count -= a;

            }
        }
    }
}
