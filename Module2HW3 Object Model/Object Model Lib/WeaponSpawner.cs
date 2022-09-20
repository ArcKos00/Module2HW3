using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Model_Lib
{
    public class WeaponSpawner
    {
        public static Weapon Spawner(AllWeaponTypes type)
        {
            switch (type)
            {
                case AllWeaponTypes.Shield:
                    return StandartCharacteristic.ReturnShield();
                case AllWeaponTypes.Sword:
                    return StandartCharacteristic.ReturnSword();
                case AllWeaponTypes.Bow:
                    return StandartCharacteristic.ReturnBow();
                case AllWeaponTypes.Crossbow:
                    return StandartCharacteristic.ReturnCrossbow();
                case AllWeaponTypes.Rifle:
                    return StandartCharacteristic.ReturnRifle();
                case AllWeaponTypes.AutoRifle:
                    return StandartCharacteristic.ReturnAutoRifle();
                default:
                    return StandartCharacteristic.ReturnShield();
            }
        }
    }
}
