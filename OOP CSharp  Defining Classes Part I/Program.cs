using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp__Defining_Classes_Part_I
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Type integer = typeof(int);
            int i = 12312;
            System.Type iint = i.GetType();
            if (integer == iint)
            {
                Console.WriteLine("Validated");
            }
            else
            {
                Console.WriteLine("Not Validated");
            
            }
            Console.WriteLine("Please Enter HP");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Brand");
            string b = Console.ReadLine();
            Console.WriteLine("Please Enter Model");
            string c = Console.ReadLine();
            BMW myBMW = new BMW(a, b, c);
            Console.WriteLine("Your car is {0},{1},{2}", myBMW.HP, myBMW.Brand, myBMW.Model);

        }
    }
}
