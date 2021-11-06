using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__extension
{
    class Student
    {
        
        
        

        private static int instanceCount { get; set; } = 0;

        public Student()
        {
            instanceCount++;
        }

      public static void ShowInstanceCount()
        {
            Console.WriteLine($"{instanceCount}");


        }

    }
}
