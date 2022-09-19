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
        protected int holder = 5;
        protected int _currentHolder;
        public Rifle(float range, float accuracy, TypeAmmo typeAmmo, TypeWeapon type, int cost, int damage, string name)
            : base(range, accuracy, typeAmmo, type, name, damage, cost)
        {
            _currentHolder = holder;
            _weaponType = AllWeaponTypes.Rifle;
        }

        public override void ActionDamage()
        {
            while (true)
            {
                Console.WriteLine("Выстрел из {0}", Name);
                base.ActionDamage();
                Console.WriteLine("Нанесено урона: {0}", Damage);
                base.Reload(40);
                _currentHolder--;
                if (_currentHolder == 0)
                {
                    Reload(150);
                    holder = _currentHolder;
                    break;
                }
            }
        }

        public override void Reload(int delay)
        {
            Console.WriteLine("Заряжаю {0}", Name);
            base.Reload(delay);
            Console.WriteLine("Готово, можно дальше в бой...");
        }
    }
}
