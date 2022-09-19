using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3_Object_Model
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WindowHeight = 56;
            Console.WriteLine("Задайте размер инвентаря(реккомендую 10): ");
            Inventory.SetInstance = int.Parse(Console.ReadLine());
            Manager.Starter();
        }
    }
}
