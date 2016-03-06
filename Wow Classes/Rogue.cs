using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Rogue : Character
    {
         public Rogue(int hp, int mp, int dmg)
        {
            this.hp = hp;
            this.mp = mp;
            this.dmg = dmg;

        }
        public int kritikal = 60;
    }
}
