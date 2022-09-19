using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object_Model_Lib;

namespace Module2HW3_Object_Model
{
    public class Manager
    {
        public static void Starter()
        {
            while (true)
            {
                Inventory inventory = Inventory.GetInstance;
                Drawler.Draw(inventory);
                Console.WriteLine("Если хотите убрать несколько оружий — нажмите \"1\", введите индекс оружия и нажмите enter");
                Console.WriteLine("Если хотите добавить оружие в пустую ячейку после удаления, нажмите \"2\"");
                Console.WriteLine("Если хотите, чтобы каждое оружие выстрелило \"3\"");
                Console.WriteLine("Перейти к поиску \"4\": ");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Console.WriteLine("Укажите ячейку для удаления: ");
                        inventory.RemoveWeaponFromInventory(int.Parse(Console.ReadLine()));
                        Drawler.Draw(inventory);
                        break;
                    case ConsoleKey.D2:
                        for (int i = 0; i < inventory.Bag.Length; i++)
                        {
                            if (inventory.Bag[i] == null)
                            {
                                inventory.Bag[i] = inventory.AddToInventory();
                                Drawler.Draw(Inventory.GetInstance);
                                break;
                            }
                        }

                        Console.WriteLine("Нету свободных ячеек");
                        break;
                    case ConsoleKey.D3:
                        foreach (var weapon in inventory.Bag)
                        {
                            if (weapon != null)
                            {
                                weapon.ActionDamage();
                            }
                        }

                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("Введите критерий поиска: ");
                        Console.WriteLine("\"range\", \"accuracy\", \"cost\", \"name\", \"damage\", \"weaponstype\", \"typeammo\", \"typerangeweapon\": ");
                        Search();
                        break;
                }
            }
        }

        private static void Search()
        {
            Inventory inv = Inventory.GetInstance;
            switch (Console.ReadLine())
            {
                case "range":
                    Console.Write("Bведите критерий поиска \"Радиус поражения\": ");
                    float val1 = float.Parse(Console.ReadLine());
                    inv.Bag.RangeSearch(val1);
                    break;
                case "accuracy":
                    Console.Write("Bведите критерий поиска \"Точность\": ");
                    float val2 = float.Parse(Console.ReadLine());
                    inv.Bag.AccuracySearch(val2);
                    break;
                case "typerangeammo":
                    Console.WriteLine("Bведите критерий поиска \"Тип боеприпаса\": ");
                    Console.Write("1 - Стрела, 2 - Болт, 3 - Пуля");
                    int val3 = int.Parse(Console.ReadLine());
                    inv.Bag.TypeAmmoSearch((TypeAmmo)val3);
                    break;
                case "typeweapon":
                    Console.WriteLine("Bведите критерий поиска \"Тип оружия дальности оружия\": ");
                    Console.Write("1 - Melee damage, 2 - Range damage");
                    int val4 = int.Parse(Console.ReadLine());
                    inv.Bag.RangeTypeSearch((TypeWeapon)val4);
                    break;
                case "cost":
                    Console.Write("Bведите критерий поиска \"Цена\": ");
                    int val5 = int.Parse(Console.ReadLine());
                    inv.Bag.CostSearch(val5);
                    break;
                case "name":
                    Console.Write("Bведите критерий поиска \"Имя\": ");
                    string val6 = Console.ReadLine();
                    inv.Bag.NameSearch(val6);
                    break;
                case "weaponstype":
                    Console.Write("Bведите критерий поиска \"Вид оружия\": ");
                    Console.WriteLine("1 - Sword, 2 - Shield, 3 - Bow, 4 - Crossbow, 5 - Rifle, 6 - AutoRifle");
                    int val7 = int.Parse(Console.ReadLine());
                    inv.Bag.WeaponTypeSearch((AllWeaponTypes)val7);
                    break;
                case "damage":
                    Console.Write("Bведите критерий поиска \"Урон\": ");
                    int val8 = int.Parse(Console.ReadLine());
                    inv.Bag.DamageSearch(val8);
                    break;
                default:
                    break;
            }
        }
    }
}
