using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int classcode;
        Character paladin1= new Paladin(800,70,80);
        Character paladin2= new Paladin(800,70,80);
        Character priest1 = new Priest(300, 100, 30);
        Character priest2 = new Priest(300, 100, 30);
        Character rogue1 = new Rogue(350, 90, 90);
        Character rogue2=new Rogue(350, 90, 90);
        Character shaman1=new Shaman(400, 100,50);
        Character shaman2 = new Shaman(400, 100, 50);

        private void Form1_Load(object sender, EventArgs e)
        {
            Skill1.Text = ("AutoAtack");
           
         
        }
        public int Chose;

        public int target;
  
      

    
      

 

        private void Skill1_Click(object sender, EventArgs e)
        {
            if(paladin1.target!=null&&priest1.target!=null&&rogue1.target!=null&&shaman1.target!=null)
            { }
            switch (classcode)
            {
                case 1:
                    paladin1.Attack();
                    turn = 0;
                    if (Mp.Value > 0)
                    {
                        Mp.Value -= 5;
                    }

                    break;
                case 2:
                    priest1.Attack();
                    turn = 0;
                    if (Mp.Value > 0)
                    {
                        Mp.Value -= 5;
                    }
                    break;
                case 3:
                    turn = 0;
                    rogue1.Attack();
                    if (Mp.Value > 0)
                    {
                        Mp.Value -= 5;
                    }
                    break;
                case 4:
                    shaman1.Attack();
                    if (Mp.Value > 0)
                    {
                        Mp.Value -= 5;
                    }
                    turn = 0;
                    break;
            }
        }
    }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = paladin2.hp.ToString();
            label2.Text = priest2.hp.ToString();
            label3.Text = rogue2.hp.ToString();
            label4.Text = shaman2.hp.ToString();
            label8.Text = paladin1.hp.ToString();
            label7.Text = priest1.hp.ToString();
            label6.Text = rogue1.hp.ToString();
            label5.Text = shaman1.hp.ToString();

            if (paladin2.hp <= 0)
            {
                button9.Visible = false;
                button9.Enabled = false;
                label1.Visible = false;
            }

            if (priest2.hp <= 0)
            {
                button8.Visible = false;
                button8.Enabled = false;
                label2.Visible = false;
            }

            if (rogue2.hp <= 0)
            {
                button7.Visible = false;
                button7.Enabled = false;
                label3.Visible = false;
            }

            if (shaman2.hp <= 0)
            {
                button6.Visible = false;
                button6.Enabled = false;
                label4.Visible = false;
            }

            if (paladin1.hp <= 0)
            {
                button2.Visible = false;
                button2.Enabled = false;
                label5.Visible = false;
            }

            if (priest1.hp <= 0)
            {
                button3.Visible = false;
                button3.Enabled = false;
                label6.Visible = false;
            }

            if (rogue1.hp <= 0)
            {
                button4.Visible = false;
                button4.Enabled = false;
                label7.Visible = false;
            }

            if (shaman1.hp <= 0)
            {
                button5.Visible = false;
                button5.Enabled = false;
                label8.Visible = false;
            }
            if (paladin1.hp <= 0 & priest1.hp <= 0 & rogue1.hp <= 0 & shaman1.hp <= 0)
            {
         
                timer1.Stop();
                MessageBox.Show("You loose");
         
                this.Close();

            }
            if (paladin2.hp <= 0 & priest2.hp <= 0 & rogue2.hp <= 0 & shaman2.hp <= 0)
            {
                timer1.Stop();
                MessageBox.Show("You Win");
              
                this.Close();

            }

        }


        public int turn = 1;
        private void Skill2_Click(object sender, EventArgs e)
        {
            //switch (target)
            //{
            //    case 1:
            //        if (classcode == 1)
            //        {
            //            paladin2.hp -= paladin2.holystrikedmg;
            //            turn = 0;
            //        }

            //        if (classcode == 2)
            //        {
            //            paladin2.hp -= priest1.lightn;
            //            priest1.hp += priest1.lightn;
            //            turn = 0;
            //        }
            //        if (classcode == 3)
            //        {
            //            paladin2.hp -= shaman1.stormdmg;
            //            priest2.hp -= shaman1.stormdmg;
            //            shaman2.hp -= shaman1.stormdmg;
            //            rogue2.hp -= shaman1.stormdmg;
            //            turn = 0;

            //        }
            //        if (classcode == 4)
            //        {
            //            Random r = new Random();
            //            int krit = r.Next(1, 3);
            //            if (krit == 2)
            //            {
            //                paladin2.hp -= rogue1.kritikal * 2;
            //            }
            //            if (krit == 1)
            //            {
            //                paladin2.hp -= rogue1.kritikal;
            //            }
            //            turn = 0;

            //        }
            //        break;
            //    case 2:
            //        if (classcode == 1)
            //        {
            //            priest2.hp -= paladin2.holystrikedmg;
            //            turn = 0;
            //        }

            //        if (classcode == 2)
            //        {
            //            priest2.hp -= priest1.lightn;
            //            priest1.hp += priest1.lightn;
            //            turn = 0;
            //        }
            //        if (classcode == 3)
            //        {
            //            paladin2.hp -= shaman1.stormdmg;
            //            priest2.hp -= shaman1.stormdmg;
            //            shaman2.hp -= shaman1.stormdmg;

            //            rogue2.hp -= shaman1.stormdmg;
            //            turn = 0;

            //        }
            //        if (classcode == 4)
            //        {
            //            Random r = new Random();
            //            int krit = r.Next(1, 3);
            //            if (krit == 2)
            //            {
            //                priest2.hp -= rogue1.kritikal * 2;
            //            }
            //            if (krit == 1)
            //            {
            //                priest2.hp -= rogue1.kritikal;
            //            }
            //            turn = 0;
            //        }
            //        break;
            //    case 3:
            //        if (classcode == 1)
            //        {
            //            shaman2.hp -= paladin2.holystrikedmg;
            //            turn = 0;
            //        }

            //        if (classcode == 2)
            //        {
            //            shaman2.hp -= priest1.lightn;
            //            priest1.hp += priest1.lightn;
            //            turn = 0;
            //        }
            //        if (classcode == 3)
            //        {
            //            paladin2.hp -= shaman1.stormdmg;
            //            priest2.hp -= shaman1.stormdmg;
            //            shaman2.hp -= shaman1.stormdmg;
            //            rogue2.hp -= shaman1.stormdmg;
            //            turn = 0;

            //        }
            //        if (classcode == 4)
            //        {
            //            Random r = new Random();
            //            int krit = r.Next(1, 3);
            //            if (krit == 2)
            //            {
            //                shaman2.hp -= rogue1.kritikal * 2;
            //            }
            //            if (krit == 1)
            //            {
            //                shaman2.hp -= rogue1.kritikal;
            //            }
            //            turn = 0;
            //        }
            //        break;
            //    case 4:
            //        if (classcode == 1)
            //        {
            //            rogue2.hp -= paladin2.holystrikedmg;
            //            turn = 0;
            //        }

            //        if (classcode == 2)
            //        {
            //            rogue2.hp -= priest1.lightn;
            //            priest1.hp += priest1.lightn;
            //            turn = 0;
            //        }
            //        if (classcode == 3)
            //        {
            //            paladin2.hp -= shaman1.stormdmg;
            //            priest2.hp -= shaman1.stormdmg;
            //            shaman2.hp -= shaman1.stormdmg;
            //            rogue2.hp -= shaman1.stormdmg;
            //            turn = 0;

            //        }
            //        if (classcode == 4)
            //        {
            //            Random r = new Random();
            //            int krit = r.Next(1, 3);
            //            if (krit == 2)
            //            {
            //                rogue2.hp -= rogue1.kritikal * 2;
            //            }
            //            if (krit == 1)
            //            {
            //                rogue2.hp -= rogue1.kritikal;
            //            }
            //            turn = 0;
            //        }
            //        break;
            //}

        }
        Random r2 = new Random();
        //Bots
     
        

        private void button1_Click(object sender, EventArgs e)
        {
            int botclasscode = r2.Next(1,5);
            if (turn == 0)
            {
             switch (botclasscode)
             {

                 case 1:
                       
                       
                       
                      
                            paladin1.hp -= paladin2.dmg;
                        
          
                        turn = 1;
                    break;

                    case 2:



                         
                            
                                priest1.hp -= priest2.dmg;
                           
                            
                            turn = 1;

                        break;

                    case 3:


                              
                           
                                    shaman1.hp -= shaman2.dmg;
                                
                               
                                
                                
                                turn = 1;
                            break;
                    case 4:


                                   
                                        rogue1.hp -= rogue2.dmg;
                                  
                                    turn = 1;
                                break;
                                }
                            }
                        }
        

        private void button9_Click(object sender, EventArgs e)
        {
            
            switch (classcode)
            {
                case 1:

                    paladin1.target = paladin2;
                    break;
                case 2:
                    priest1.target = paladin2;
                    break;
                case 3:
                    rogue1.target = paladin2;
                    break;
                case 4:
                    shaman1.target = paladin2;
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            switch (classcode)
            {
                case 1:

                    paladin1.target = priest2;

                    break;
                case 2:
                    priest1.target = priest2;
                    break;
                case 3:
                    rogue1.target = priest2;
                    break;
                case 4:
                    shaman1.target = priest2;
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            switch (classcode)
            {
                case 1:

                    paladin1.target = rogue2;
                    break;
                case 2:
                    priest1.target = rogue2;
                    break;
                case 3:
                    rogue1.target = rogue2;
                    break;
                case 4:
                    shaman1.target = rogue2;
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (classcode)
            {
                case 1:

                    paladin1.target = shaman2;
                    break;
                case 2:
                    priest1.target = shaman2;
                    break;
                case 3:
                    rogue1.target = shaman2;
                    break;
                case 4:
                    shaman1.target = shaman2;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            classcode = 1;
            Skill2.Text = ("Holystrike");
            Mp.Value = paladin1.mp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            classcode = 2;
            Skill2.Text = ("Lightheal");
            Mp.Value = priest1.mp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            classcode = 3;
            Skill2.Text = ("ElementStorm");
            Mp.Value = shaman1.mp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            classcode = 4;
            Skill2.Text = ("CritikalStrike");
            Mp.Value = rogue1.mp;
        }
        

    }
}
            
        
    




            

