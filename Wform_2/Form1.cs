using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wform_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int a=1;
        //private void button16_Click(object sender, EventArgs e)
        //{
        //    //Desyn.Start();

        //    a = int.Parse(textBox1.Text);
        //}

        //Saga getmeyi uchun

        private void timer1_Tick(object sender, EventArgs e)
        {
            //a = int.Parse(textBox1.Text);

            button20.Left = button20.Left + a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Bir.Enabled = false;
            Iki.Enabled = false;
            Yuxari.Enabled = false;
            Ashagi.Enabled = false;
            Uch.Enabled = false;
            Dord.Enabled = false;
            En_daire.Enabled = false;
            Uzun_daire.Enabled = false;
            Paxlava.Enabled = false;
            Sol.Enabled = false;
            Sag.Enabled = true;
        }


        //Sola getmeyi uchun

        private void timer2_Tick(object sender, EventArgs e)
        {
            //a = int.Parse(textBox1.Text);

            button20.Left = button20.Left - a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Bir.Enabled = false;
            Iki.Enabled = false;
            Yuxari.Enabled = false;
            Ashagi.Enabled = false;
            Uch.Enabled = false;
            Dord.Enabled = false;
            En_daire.Enabled = false;
            Uzun_daire.Enabled = false;
            Paxlava.Enabled = false;
            Sag.Enabled = false;
            Sol.Enabled = true;
        }

        //yuxari getmeyi uchun

        private void Yuxari_Tick(object sender, EventArgs e)
        {
            //a = int.Parse(textBox1.Text);

            button20.Top = button20.Top - a;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Bir.Enabled = false;
            Iki.Enabled = false;
            Ashagi.Enabled = false;
            Uch.Enabled = false;
            Dord.Enabled = false;
            En_daire.Enabled = false;
            Uzun_daire.Enabled = false;
            Paxlava.Enabled = false;
            Sag.Enabled = false;
            Sol.Enabled = false;
            Yuxari.Enabled = true;
        }

        //Ashagi hereket

        private void Ashagi_Tick(object sender, EventArgs e)
        {
            //a = int.Parse(textBox1.Text);

            button20.Top = button20.Top + a;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Bir.Enabled = false;
            Iki.Enabled = false;
            Ashagi.Enabled = true;
            Uch.Enabled = false;
            Dord.Enabled = false;
            En_daire.Enabled = false;
            Uzun_daire.Enabled = false;
            Paxlava.Enabled = false;
            Sag.Enabled = false;
            Sol.Enabled = false;
            Yuxari.Enabled = false;
        }

        //Bire hereket

        private void Bir_Tick(object sender, EventArgs e)
        {
            //a = int.Parse(textBox1.Text);

            button20.Top = button20.Top - a;
            button20.Left = button20.Left - a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Bir.Enabled = true;
            Iki.Enabled = false;
            Ashagi.Enabled = false;
            Uch.Enabled = false;
            Dord.Enabled = false;
            En_daire.Enabled = false;
            Uzun_daire.Enabled = false;
            Paxlava.Enabled = false;
            Sag.Enabled = false;
            Sol.Enabled = false;
            Yuxari.Enabled = false;
        }

        // Ikiye hereket

        private void Iki_Tick(object sender, EventArgs e)
        {
            //a = int.Parse(textBox1.Text);

            button20.Top = button20.Top - a;
            button20.Left = button20.Left + a;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Bir.Enabled = false;
            Iki.Enabled = true;
            Ashagi.Enabled = false;
            Uch.Enabled = false;
            Dord.Enabled = false;
            En_daire.Enabled = false;
            Uzun_daire.Enabled = false;
            Paxlava.Enabled = false;
            Sag.Enabled = false;
            Sol.Enabled = false;
            Yuxari.Enabled = false;
        }

        //Uch e hereket

        private void Uch_Tick(object sender, EventArgs e)
        {
            //a = int.Parse(textBox1.Text);

            button20.Top = button20.Top + a;
            button20.Left = button20.Left - a;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Bir.Enabled = false;
            Iki.Enabled = false;
            Ashagi.Enabled = false;
            Uch.Enabled = true;
            Dord.Enabled = false;
            En_daire.Enabled = false;
            Uzun_daire.Enabled = false;
            Paxlava.Enabled = false;
            Sag.Enabled = false;
            Sol.Enabled = false;
            Yuxari.Enabled = false;
        }

        // Dorde hereket

        private void Dord_Tick(object sender, EventArgs e)
        {
            //a = int.Parse(textBox1.Text);

            button20.Top = button20.Top + a;
            button20.Left = button20.Left + a;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Bir.Enabled = false;
            Iki.Enabled = false;
            Ashagi.Enabled = false;
            Uch.Enabled = false;
            Dord.Enabled = true;
            En_daire.Enabled = false;
            Uzun_daire.Enabled = false;
            Paxlava.Enabled = false;
            Sag.Enabled = false;
            Sol.Enabled = false;
            Yuxari.Enabled = false;
        }

        //paxlava

        private void Paxlava_Tick(object sender, EventArgs e)
        {
            //a = int.Parse(textBox1.Text);

            button20.Top = button20.Top + a;
            button20.Left = button20.Left + a;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Bir.Enabled = false;
            Iki.Enabled = false;
            Ashagi.Enabled = false;
            Uch.Enabled = false;
            Dord.Enabled = false;
            En_daire.Enabled = false;
            Uzun_daire.Enabled = false;
            Paxlava.Enabled = true;
            Sag.Enabled = false;
            Sol.Enabled = false;
            Yuxari.Enabled = false;
        }

        // En daire

        private void En_daire_Tick(object sender, EventArgs e)
        {
            //a = int.Parse(textBox1.Text);

            if (button20.Left>this.ClientSize.Width)
            {
                button20.Left = -button20.Width;
            }
            button20.Left = button20.Left + a;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Bir.Enabled = false;
            Iki.Enabled = false;
            Ashagi.Enabled = false;
            Uch.Enabled = false;
            Dord.Enabled = false;
            En_daire.Enabled = true;
            Uzun_daire.Enabled = false;
            Paxlava.Enabled = false;
            Sag.Enabled = false;
            Sol.Enabled = false;
            Yuxari.Enabled = false;
        }

        //uzun daire

        private void Uzun_daire_Tick(object sender, EventArgs e)
        {
            //a = int.Parse(textBox1.Text);

            if (button20.Top > this.ClientSize.Height)
            {
                button20.Top = -button20.Width;
            }
            button20.Top = button20.Top + a;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Bir.Enabled = false;
            Iki.Enabled = false;
            Ashagi.Enabled = false;
            Uch.Enabled = false;
            Dord.Enabled = false;
            En_daire.Enabled = false;
            Uzun_daire.Enabled = true;
            Paxlava.Enabled = false;
            Sag.Enabled = false;
            Sol.Enabled = false;
            Yuxari.Enabled = false;
        }

        //stop

        private void button17_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Bir.Enabled = false;
            Iki.Enabled = false;
            Ashagi.Enabled = false;
            Uch.Enabled = false;
            Dord.Enabled = false;
            En_daire.Enabled = false;
            Uzun_daire.Enabled = false;
            Paxlava.Enabled = false;
            Sag.Enabled = false;
            Sol.Enabled = false;
            Yuxari.Enabled = false;
        }

        //start
        private void button15_Click(object sender, EventArgs e)
        {
            Start.Enabled = true;
            Bir.Enabled = false;
            Iki.Enabled = false;
            Ashagi.Enabled = false;
            Uch.Enabled = false;
            Dord.Enabled = false;
            En_daire.Enabled = false;
            Uzun_daire.Enabled = false;
            Paxlava.Enabled = false;
            Sag.Enabled = false;
            Sol.Enabled = false;
            Yuxari.Enabled = false;
        }

        private void Start_Tick(object sender, EventArgs e)
        {
            //4 teref
            if (button20.Left>420&&button20.Top>223)
            {
                button20.Top = button20.Top - a;
                button20.Left = button20.Left - a;
              
                if (button20.Location==temp)
                {
                    Start.Stop();
                }
            }

            //3 teref
            if (button20.Left < 420 && button20.Top > 223)
            {
                button20.Top = button20.Top - a;
                button20.Left = button20.Left + a;

                if (button20.Location == temp)
                {
                    Start.Stop();
                }
            }

            //1 teref
            if (button20.Left < 420 && button20.Top < 223)
            {
                button20.Top = button20.Top + a;
                button20.Left = button20.Left + a;

                if (button20.Location == temp)
                {
                    Start.Stop();
                }
            }

            //2 teref
            if (button20.Left > 420 && button20.Top < 223)
            {
                button20.Top = button20.Top + a;
                button20.Left = button20.Left - a;

                if (button20.Location == temp)
                {
                    Start.Stop();
                }
            }

            //sag teref
            if (button20.Left > 420 && button20.Top == 223)
            {
                button20.Top = button20.Top - a;

                if (button20.Location == temp)
                {
                    Start.Stop();
                }
            }

            //sol teref
            if (button20.Left < 420&&button20.Top==223)
            {
                button20.Top = button20.Top + a;

                if (button20.Location == temp)
                {
                    Start.Stop();
                }
            }

            //Ashagi teref
            if (button20.Top > 223&&button20.Left==420)
            {
                button20.Top = button20.Top - a;

                if (button20.Location == temp)
                {
                    Start.Stop();
                }
            }

            //Yuxari teref
            if (button20.Top < 223 && button20.Left == 420)
            {
                button20.Top = button20.Top + a;

                if (button20.Location == temp)
                {
                    Start.Stop();
                }
            }

        }


        //Restart
        Point temp = new Point(420,223);
        private void button18_Click(object sender, EventArgs e)
        {
            Bir.Enabled = false;
            Iki.Enabled = false;
            Ashagi.Enabled = false;
            Uch.Enabled = false;
            Dord.Enabled = false;
            En_daire.Enabled = false;
            Uzun_daire.Enabled = false;
            Paxlava.Enabled = false;
            Sag.Enabled = false;
            Sol.Enabled = false;
            Yuxari.Enabled = false;

            button20.Location = temp;
        }




  

      



     



     
       
       

  
        

        



      

  
    }
}
