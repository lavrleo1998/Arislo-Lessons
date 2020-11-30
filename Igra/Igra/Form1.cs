using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int money = 100;
        int maxhpplayer = 100;
        int maxmaplayer = 100;
        int maxsaplayer = 100;
        int hpplayer;
        int maplayer;
        int saplayer;
        Boolean cristal = false;
        private void DarkORgood()
        {
            if (cristal == true)
            {
                Bar.Image = System.Drawing.Image.FromFile(@"‪C:\\Users\\Дом\\Documents\\GitHub\\Arislo-Lessons\\Igra\\Igra\\images\\darkBar.bmp");
                 Map.BackgroundImage = System.Drawing.Image.FromFile(@"‪C: \\Users\\Дом\\Documents\\GitHub\\Arislo - Lessons\\Igra\\Igra\\images\\darkMap.bmp");
               // Bar.Load("‪C:\\darkBar.bmp"); 

            }
            if (cristal == false)
            {
                Bar.Image = System.Drawing.Image.FromFile(@"‪C: \\Users\\Дом\\Documents\\GitHub\\Arislo - Lessons\\Igra\\Igra\\images\\goodBar.bmp");
                Map.BackgroundImage = System.Drawing.Image.FromFile(@"‪C: \\Users\\Дом\\Documents\\GitHub\\Arislo - Lessons\\Igra\\Igra\\images\\goodMap.bmp");
            }
        }
        private void Show()
        {
            BARHP.Text = "Жизнь:" + hpplayer;
            BARST.Text = "Выносливость:" + saplayer;
            BARMA.Text = "Мана:" + maplayer;
            BARY.Text = "Деньги" + money;
        }
        private void MinToMax()
        {
            hpplayer = maxhpplayer;
            maplayer = maxmaplayer;
            saplayer = maxsaplayer;
        }
        //Bar      
        private void BarInside_Click(object sender, EventArgs e)
        {
            Map.Visible = true;
            Map.Enabled = true;
            BarInside.Visible = false;
            BarInside.Enabled = false;
            DarkORgood();
        }
        private void BuyHP_Click(object sender, EventArgs e)
        {
            if (money != 0)
            {
                money -= 10;
                maxhpplayer += 10;
            }
            MinToMax();
            Show();
        }
        private void BuyMA_Click(object sender, EventArgs e)
        {
            if (money != 0)
            {
                money -= 10;
                maxmaplayer += 10;
            }
            MinToMax();
            Show();
        }
        private void BuyST_Click(object sender, EventArgs e)
        {
            if (money != 0)
            {
                money -= 10;
                maxsaplayer += 10;
            }
            MinToMax();
            Show();
        }
        //Map
        private void Bar_Click(object sender, EventArgs e)
        {
            Map.Visible = false;
            BarInside.Visible = true;
            Map.Enabled = false;
            BarInside.Enabled = true;
        }
        //Battle
        private void Battlefield(string n,int mxhp, int hp, int dg)
        {
            Battle.Visible = true;
            Battle.Enabled = true;
            Map.Visible = false;
            Map.Enabled = false;
            BarNameEnemy.Text = n;

        }
    }
}
