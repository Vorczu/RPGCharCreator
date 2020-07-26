using System;
using System.Collections.Generic;
using System.Text;

namespace RPGCharCreator
{
    abstract class BaseCharacter
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public string FirstName { get; set; }
        public string LastNMame { get; set; }

        public int Stamina { get; set; }
        public int Intellect { get; set; }
        public int Agility { get; set; }
        public int Strength { get; set; }

        public int HP { get;  }
        public int MP { get;  }

    }
}
