using Object_Model_Lib;

namespace Module2HW3_Object_Model
{
    public class Inventory
    {
        private readonly AllWeaponTypes _types;
        private Weapon[] _weapons;
        private static Inventory _instance = new Inventory();
        private Inventory()
        {
            _weapons = new Weapon[10];
            AddRandomWeaponToInventory();
        }

        public static Inventory GetInstance
        {
            get
            {
                return _instance;
            }
            set
            {
                if (_instance == null)
                {
                    _instance = new Inventory();
                }
                else
                {
                    _instance = value;
                }
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
                default:
                    return null;
            }
        }

        public void RemoveWeaponFromInventory(int index)
        {
            _weapons[index] = null;
        }
    }
}
