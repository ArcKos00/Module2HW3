using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object_Model_Lib;

namespace Module2HW3_Object_Model
{
    public class Manager
    {
        public static void Starter()
        {
            Drawler drawler = new Drawler();
            while (true)
            {
                Inventory bag = Inventory.GetInstance;
                drawler.Draw(bag);
            }
        }
    }
}
