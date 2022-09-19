using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Model_Lib
{
    public class AutoRifle : Rifle
    {
        public AutoRifle(float range, float accuracy, TypeAmmo typeAmmo, TypeWeapon type, int cost, int damage, string name)
            : base(range, accuracy, typeAmmo, type, cost, damage, name)
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
