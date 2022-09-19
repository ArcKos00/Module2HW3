using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Object_Model_Lib;

namespace Module2HW3_Object_Model
{
    public static class ExtensionMethods
    {
        public static void NameSearch(this Weapon[] arr, string name)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Name == name)
                {
                    Drawler.Draw(arr[i]);
                }
            }
        }

        public static void WeaponTypeSearch(this Weapon[] arr, AllWeaponTypes type)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]._weaponType == type)
                {
                    Drawler.Draw(arr[i]);
                }
            }
        }

        public static void RangeTypeSearch(this Weapon[] arr, TypeWeapon type)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].WType == type)
                {
                    Drawler.Draw(arr[i]);
                }
            }
        }

        public static void TypeAmmoSearch(this Weapon[] arr, TypeAmmo type)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].TypeAmmo == type)
                {
                    Drawler.Draw(arr[i]);
                }
            }
        }

        public static void CostSearch(this Weapon[] arr, int cost)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Cost == cost)
                {
                    Drawler.Draw(arr[i]);
                }
            }
        }

        public static void AccuracySearch(this Weapon[] arr, float accuracy)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Accuracy == accuracy)
                {
                    Drawler.Draw(arr[i]);
                }
            }
        }

        public static void RangeSearch(this Weapon[] arr, float range)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Range == range)
                {
                    Drawler.Draw(arr[i]);
                }
            }
        }

        public static void DamageSearch(this Weapon[] arr, int damage)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Damage == damage)
                {
                    Drawler.Draw(arr[i]);
                }
            }
        }
    }
}
