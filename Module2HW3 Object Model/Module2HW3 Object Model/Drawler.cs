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
        public static void Draw(Inventory inv)
        {
            Console.Clear();
            for (int i = 0; i < inv.Bag.Length; i++)
            {
                if (inv.Bag[i] != null)
                {
                    Console.WriteLine("Индекс: " + i);
                    Console.WriteLine("Название: " + inv.Bag[i].Name);
                    Console.WriteLine("Тип оружия: " + inv.Bag[i]._weaponType);
                    Console.WriteLine("Цена: " + inv.Bag[i].Cost);
                    Console.WriteLine();
                }
            }
        }

        public static void Draw(Weapon weapon)
        {
            Console.WriteLine("Название: " + weapon.Name);
            Console.WriteLine("Тип оружия: " + weapon._weaponType);
            Console.WriteLine("Тип дальнобойности оружия: " + weapon.WType);
            if (weapon is ShootingWeapon)
            {
                Console.WriteLine("Тип Боеприпасов: " + weapon.TypeAmmo);
                Console.WriteLine("Дальность поражения: " + weapon.Range);
                Console.WriteLine("Точность: " + weapon.Accuracy);
            }

            Console.WriteLine("Урон: " + weapon.Damage);
            Console.WriteLine("Цена: " + weapon.Cost);
            Console.WriteLine();
        }
    }
}
