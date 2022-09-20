using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Model_Lib
{
    public class AutoRifle : Rifle
    {
        public AutoRifle(TypeWeapon type, TypeAmmo typeAmmo, int damage, int cost, float range, float accuracy, string name)
            : base(type, typeAmmo, damage, cost, range, accuracy, name)
        {
            holder = 7;
            _currentHolder = holder;
        }

        public override void ActionDamage()
        {
            base.ActionDamage();
        }
    }
}
