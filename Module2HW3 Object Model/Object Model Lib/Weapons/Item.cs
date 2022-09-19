using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Object_Model_Lib.Weapons
{
    public static class Item
    {
        public static void DeleteItem(this object item)
        {
            item = null;
        }
    }
}
