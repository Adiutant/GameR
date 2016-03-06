using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Shaman:Character
    {
             public Shaman(int hp, int mp, int dmg)
        {
            this.Hp = hp;
            this.mp = mp;
            this.dmg = dmg;

        }
        public int stormdmg = 60;
    }
}
