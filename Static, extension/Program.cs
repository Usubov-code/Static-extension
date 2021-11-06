using System;
using System.Collections.Generic;

namespace Static__extension
{
    class Program
    {
        static void Main(string[] args)
        {
            #region extensions
            //Console.WriteLine("Please enter the number");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(ext.Extensions(a));
            #endregion
            #region Class Task

            //Student st1 = new Student();
            //Student.ShowInstanceCount();

            //Student st2 = new Student();
            //Student.ShowInstanceCount();

            #endregion
            #region Clask Taks Milk

            List<Milk> milks = new List<Milk>();

            while (true)
            {
                Milk milk = new Milk("Milla");
                Console.WriteLine("Please enter milk price");
                milk.Price = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter milk Count");
                milk.Count = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter milk Liter");
                milk.Volume = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter milk fat content");
                milk.FatRate = Convert.ToInt32(Console.ReadLine());


                milks = Milk.Add(milks, milk);

                Console.Write("Do you want to create new Milk(y/n): ");

                string response = Console.ReadLine();
                if (response.ToLower() == "n")
                {
                    foreach (Milk milkItem in milks)
                    {
                        Console.WriteLine($"Product Name{milkItem.Name} -Price {milkItem.Price}- Milk fat content{milkItem.FatRate}");
                    }
                    break;
                }

               
            }

            
            



            #endregion



        }


    }
}
