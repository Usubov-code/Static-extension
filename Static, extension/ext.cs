using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__extension
{
   public static class ext
    {
        public static int Extensions(this int a)
        {
            int pows = 3;
            int powa = 1;

            for (int i = 0; i < pows; i++)
            {
                powa = powa * a;

            }



            return powa;
        }
    }
}
