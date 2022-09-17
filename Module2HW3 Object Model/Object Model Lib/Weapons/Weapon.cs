using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object_Model_Lib.Weapons;

namespace Object_Model_Lib
{
    public abstract class Weapon : Item
    {
        public AllWeaponTypes _weaponType;
        private float _range;
        private string _name;
        private TypeWeapon _type;
        private int _damage;
        private int _cost;
        public Weapon(TypeWeapon type, string name, int damage, int cost, float range)
        {
            _type = type;
            _name = name;
            _damage = damage;
            _cost = cost;
            _range = range;
        }

        public float Range
        {
            get { return _range; }
        }

        public string Name
        {
            get { return _name; }
        }

        public TypeWeapon Type
        {
            get { return _type; }
        }

        public int Damage
        {
            get { return _damage; }
        }

        public int Cost
        {
            get { return _cost; }
        }

        public virtual void ActionDamage()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
        }
    }
}
