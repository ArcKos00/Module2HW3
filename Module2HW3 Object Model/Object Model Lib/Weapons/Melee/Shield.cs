using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Model_Lib
{
    /// <summary>
    /// Оружие: Щит
    /// Ближний бой
    /// Наносит урон ниже среднего так как не предназначен для атаки
    /// </summary>
    public class Shield : Weapon
    {
        protected int _extraArmor;
        private float _chanceBashEnemy;
        public Shield(TypeWeapon type, int damage, int cost, float chanceBash, string name, int extraArm, float range)
            : base(type, name, damage, cost, range)
        {
            _extraArmor = extraArm;
            _chanceBashEnemy = chanceBash;
            _weaponType = AllWeaponTypes.Shield;
        }

        public override void ActionDamage()
        {
            Console.WriteLine("Удар {0}ом", Name);
            base.ActionDamage();
            Console.WriteLine("Нанесено урона: {0}", Damage);
            if (new Random().NextDouble() < _chanceBashEnemy)
            {
                Console.WriteLine("Враг оглушен...");
            }
        }
    }
}
