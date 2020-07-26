using System;
using System.Collections.Generic;
using System.Text;

namespace RPGCharCreator
{
    abstract class PlayerClassInfo
    {
        public static Dictionary<string, string> ArmorTypes { get; set; }

        public static void PlayerClassInit()
        {
            ArmorTypes = new Dictionary<string, string>();

            ArmorTypes.Add("Light","Cloth");
            ArmorTypes.Add("Light", "Leather");

            ArmorTypes.Add("Medium", "Mail");
            ArmorTypes.Add("Medium", "Scale");

            ArmorTypes.Add("Heavy", "Plate");
            ArmorTypes.Add("Heavy", "Dragon Scale");
        }


    }
}
