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
        public Bow(TypeWeapon type, TypeAmmo typeAmmo, int damage, int cost, float range, float accuracy, string name)
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
            }
            else
            {
                Console.WriteLine("Упс, ты промахнулся...");
            }

            Reload(150);
            Console.WriteLine("______________________________");
        }

        public override void Reload(int delay)
        {
            Console.WriteLine("Заряжаю {0}", Name);
            base.Reload(delay);
            Console.WriteLine("Готово, можно дальше в бой...");
        }
    }
}
