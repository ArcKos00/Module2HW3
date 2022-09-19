using Object_Model_Lib;

namespace Module2HW3_Object_Model
{
    public class Inventory
    {
        private readonly AllWeaponTypes _types;
        private Weapon[] _weapons;
        private static Inventory _instance;
        private Inventory(int count)
        {
            _weapons = new Weapon[count];
            AddRandomWeaponToInventory();
        }

        public static int SetInstance
        {
            set
            {
                if (_instance == null)
                {
                    _instance = new Inventory(value);
                }
            }
        }

        public static Inventory GetInstance
        {
            get
            {
                return _instance;
            }
        }

        public Weapon[] Bag
        {
            get
            {
                return _weapons;
            }
        }

        public void AddRandomWeaponToInventory()
        {
            for (int i = 0; i < _weapons.Length; i++)
            {
                _weapons[i] = WeaponSpawner.Spawner((AllWeaponTypes)new Random().Next(0, 5));
            }
        }

        public Weapon AddToInventory()
        {
            Console.WriteLine();
            Console.WriteLine("Индекс оружия для спавна");
            Console.WriteLine("1 - Sword, 2 - Shield, 3 - Bow, 4 - Crossbow, 5 - Rifle, 6 - AutoRifle");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    return WeaponSpawner.Spawner(AllWeaponTypes.Shield);
                case ConsoleKey.D2:
                    return WeaponSpawner.Spawner(AllWeaponTypes.Sword);
                case ConsoleKey.D3:
                    return WeaponSpawner.Spawner(AllWeaponTypes.Bow);
                case ConsoleKey.D4:
                    return WeaponSpawner.Spawner(AllWeaponTypes.Crossbow);
                case ConsoleKey.D5:
                    return WeaponSpawner.Spawner(AllWeaponTypes.Rifle);
                case ConsoleKey.D6:
                    return WeaponSpawner.Spawner(AllWeaponTypes.AutoRifle);
                default:
                    Console.WriteLine("Ничего не заспавнено...");
                    return null;
            }
        }

        public void RemoveWeaponFromInventory(int index)
        {
            if (index < _weapons.Length)
            {
                if (_weapons[index] != null)
                {
                    _weapons[index] = null;
                }
            }
        }
    }
}
