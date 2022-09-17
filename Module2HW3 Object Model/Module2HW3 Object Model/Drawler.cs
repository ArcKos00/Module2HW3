using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object_Model_Lib;

namespace Module2HW3_Object_Model
{
    public class Drawler
    {
        public void Draw(Inventory inv)
        {
            for (int i = 0; i < inv.Bag.Length; i++)
            {
                Console.WriteLine("Индекс: " + i);
                Console.WriteLine("Название: " + inv.Bag[i].Name);
                Console.WriteLine("Тип оружия: " + inv.Bag[i]._weaponType);
                Console.WriteLine("Цена: " + inv.Bag[i].Cost + "\n");
            }
        }
    }
}
