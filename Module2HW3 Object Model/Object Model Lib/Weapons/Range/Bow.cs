using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Model_Lib
{
    /// <summary>
    /// Оружие: Лук
    /// Стреляет на среднюю-далю=ьнюю дистанцию
    /// Поскольку нужно рукой держать натяжение тетевы
    /// Имеет сниженую точность
    /// </summary>
    public class Bow : ShootingWeapon
    {
        public Bow(float range, float accuracy, TypeAmmo typeAmmo, TypeWeapon type, int cost, int damage, string name)
            : base(range, accuracy, typeAmmo, type, name, damage, cost)
        {
            _weaponType = AllWeaponTypes.Bow;
        }

        public override void ActionDamage()
        {
            Console.WriteLine("Выстрел из {0}а", Name);
            base.ActionDamage();
            if (new Random().NextDouble() < _accuracy)
            {
                Console.WriteLine("Нанесено урона: {0}", Damage);
                Reload(150);
            }
            else
            {
                Console.WriteLine("Упс, ты промахнулся...");
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
