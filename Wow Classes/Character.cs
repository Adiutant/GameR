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
      private int hp;
      public int Hp
      {
          get { return hp; }
          set
          {
            if (value < 0)   
            {
              hp = 0;
       
            }
            else
            {
                hp = value;

            }
          }
      
          }
      public int dmg;
      public int mp;
      public Character target;
      public void Attack()
      {
          
          target.hp -= dmg;
      }
    }
}
