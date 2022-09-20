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
                    Console.WriteLine("Ячейка: " + i);
                    if (inv.Bag[i]._weaponType == AllWeaponTypes.Bow
                     || inv.Bag[i]._weaponType == AllWeaponTypes.Shield
                     || inv.Bag[i]._weaponType == AllWeaponTypes.Sword)
                    {
                        Console.Write("Название: " + inv.Bag[i].Name + "\t\t");
                    }
                    else
                    {
                        Console.Write("Название: " + inv.Bag[i].Name + "\t");
                    }

                    Console.WriteLine("Вид оружия: " + inv.Bag[i]._weaponType);
                    Console.Write("Цена: " + inv.Bag[i].Cost + "\t\t");
                    Console.WriteLine("Тип оружия: " + inv.Bag[i].WType);
                    Console.Write("Точность: " + inv.Bag[i].Accuracy + "\t\t");
                    Console.WriteLine("Дальность поражения: " + inv.Bag[i].Range);
                    Console.WriteLine("-----------------------------------------------");
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
