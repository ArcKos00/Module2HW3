using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Model_Lib
{
    public static class StandartCharacteristic
    {
        // Стандартные характеристики всего оружия, довольно средние и без особого баланса
        // Все цены поставил в диапазоне от 100 до 230
        public static Shield ReturnShield()
        {
            return new Shield(TypeWeapon.MeleeDamage, 5, 100, 0.1f, "Щит", 2, 1f);
        }

        public static Sword ReturnSword()
        {
            return new Sword(TypeWeapon.MeleeDamage, 10, 140, 1.2f, "Меч", 2f);
        }

        public static Bow ReturnBow()
        {
            return new Bow(13, 0.65f, TypeAmmo.Arrow, TypeWeapon.RangeDamage, 145, 8, "Лук");
        }

        public static Crossbow ReturnCrossbow()
        {
            return new Crossbow(10, 0.75f, TypeAmmo.Bolt, TypeWeapon.RangeDamage, 170, 13, "Арбалет");
        }

        public static Rifle ReturnRifle()
        {
            return new Rifle(15, 1f, TypeAmmo.Bullet, TypeWeapon.RangeDamage, 200, 13, "Винтовка");
        }

        public static Rifle ReturnAutoRifle()
        {
            return new Rifle(13, 0.9f, TypeAmmo.Bullet, TypeWeapon.RangeDamage, 230, 11, "Автоматическая Винтовка");
        }
    }
}