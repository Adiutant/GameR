using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  public  class Character: Button
    {
      public int hp;
      public int dmg;
      public int mp;
      public Character target;
      public void Attack()
      {
          target.hp -= dmg;
      }
    }
}
