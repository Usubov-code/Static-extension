using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__extension
{

    class Milk : Product
    {
        public Milk(string name) : base(name)
        {
            this.Name = name;
        }

        public static List<Milk> Add(List<Milk> milks, Milk milk)
        {
            milks.Add(milk);
            return milks;
        }

        public int Volume;
        public int FatRate;

     


        
    }
}
