using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Model_Lib
{
    /// <summary>
    /// Оружие: Меч
    /// Стандартный средневековый меч
    /// Отличное оружие ближнего боя
    /// </summary>
    public class Sword : Weapon
    {
        public float _critChance = 0.1f;
        public float _crit;
        public Sword(TypeWeapon type, int damage, int cost, float crit, string name, float range)
            : base(type, name, damage, cost, range)
        {
            _crit = crit;
            _weaponType = AllWeaponTypes.Sword;
        }

        public override void ActionDamage()
        {
            Console.WriteLine("Удар {0}ом", Name);
            base.ActionDamage();
            if (new Random().NextDouble() < _critChance)
            {
                Console.WriteLine("Крит!!!");
                Console.WriteLine("Нанесено урона: {0}", Damage * _crit);
            }
            else
            {
                Console.WriteLine("Нанесено урона: {0}", Damage);
            }
        }
    }
}
