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
            Drawler drawler = new Drawler();
            while (true)
            {
                Inventory bag = Inventory.GetInstance;
                drawler.Draw(bag);
                
            }
        }

        public void Search(string value)
        {
            Inventory inv = Inventory.GetInstance;
            switch (value)
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
                case "typeammo":
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
                case "allweaponstype":
                    Console.Write("Bведите критерий поиска \"Вид оружия\": ");
                    Console.WriteLine("1 - Sword, 2 - Shield, 3 - Bow, 4 - Crossbow, 5 - Rifle");
                    int val7 = int.Parse(Console.ReadLine());
                    inv.Bag.WeaponTypeSearch((AllWeaponTypes)val7);
                    break;
                case "damage":
                    Console.Write("Bведите критерий поиска \"Урон\": ");
                    int val8 = int.Parse(Console.ReadLine());
                    inv.Bag.DamageSearch(val8);
                    break;
                default:
                    return;
            }
        }
    }
}
