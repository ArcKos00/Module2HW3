using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Model_Lib
{
    public class ShootingWeapon : Weapon
    {
        protected float _accuracy;
        protected TypeAmmo _typeAmmo;

        public ShootingWeapon(float range, float accuracy, TypeAmmo typeAmmo, TypeWeapon type, string name, int damage, int cost)
            : base(type, name, damage, cost, range)
        {
            _accuracy = accuracy;
            _typeAmmo = typeAmmo;
        }

        public virtual void Reload(string str, int delay)
        {
            Console.WriteLine("Заряжаю {0}", str);
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(delay);
            }

            Console.WriteLine("Готово, можно дальше в бой...");
        }
    }
}
