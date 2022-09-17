using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Model_Lib
{
    /// <summary>
    /// Оружие: Винтовка
    /// Отличное оружие для дальнего боя
    /// Имеет обойму на 20 патронов
    /// </summary>
    public class Rifle : ShootingWeapon
    {
        public int Holder = 20;
        public Rifle(float range, float accuracy, TypeAmmo typeAmmo, TypeWeapon type, int cost, int damage, string name)
            : base(range, accuracy, typeAmmo, type, name, damage, cost)
        {
            _weaponType = AllWeaponTypes.Rifle;
        }

        public override void ActionDamage()
        {
            Console.WriteLine("Выстрел из {0}", Name);
            base.ActionDamage();
            Console.WriteLine("Нанесено урона: {0}", Damage);
            Holder--;
            if (Holder == 0)
            {
                Reload(Name, 150);
                Holder = 20;
            }
        }

        public override void Reload(string str, int delay)
        {
            base.Reload(str, delay);
        }
    }
}
