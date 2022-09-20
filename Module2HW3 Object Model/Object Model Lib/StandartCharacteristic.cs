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
        // Последовательность значений в консрукторе для ближнего боя: тип атаки оружия, урон, стоимость,
        // (для щита шанс оглушить, для меча шанс нанести дополнительный урон), дальность атаки и имя
        // Последовательность значений в консрукторе для дальнего боя: тип атаки оружия, Тип боеприпаса, урон, стоимость, дальность атаки, точность и имя
        public static Shield ReturnShield()
        {
            return new Shield(TypeWeapon.MeleeDamage, 5, 100, 0.1f, 1f, "Щит");
        }

        public static Sword ReturnSword()
        {
            return new Sword(TypeWeapon.MeleeDamage, 10, 140, 1.5f, 2f, "Меч");
        }

        public static Bow ReturnBow()
        {
            return new Bow(TypeWeapon.RangeDamage, TypeAmmo.Arrow, 13, 145, 8, 0.65f, "Лук");
        }

        public static Crossbow ReturnCrossbow()
        {
            return new Crossbow(TypeWeapon.RangeDamage, TypeAmmo.Bolt, 10, 170, 13, 0.75f, "Арбалет");
        }

        public static Rifle ReturnRifle()
        {
            return new Rifle(TypeWeapon.RangeDamage, TypeAmmo.Bullet, 13, 200, 15, 1f, "Винтовка");
        }

        public static Rifle ReturnAutoRifle()
        {
            return new Rifle(TypeWeapon.RangeDamage, TypeAmmo.Bullet, 13, 230, 11, 0.9f, "Автоматическая Винтовка");
        }
    }
}