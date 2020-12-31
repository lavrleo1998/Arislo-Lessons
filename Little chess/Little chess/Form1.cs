using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Little_chess
{
    public partial class Form1 : Form
    {

        bool who = true;
        int[] status = new int[9] {1,1,1,1,1,1,1,1,1 };// 7-X, 0-O, 1-_
        List<Button> buttons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            buttons.Add(Cube0);
            buttons.Add(Cube1);
            buttons.Add(Cube2);
            buttons.Add(Cube3);
            buttons.Add(Cube4);
            buttons.Add(Cube5);
            buttons.Add(Cube6);
            buttons.Add(Cube7);
            buttons.Add(Cube8);

        }
        private void Forbuttons(bool a)
        {
            for (int i = 0; i < 9; i++)
            {
                buttons[i].Enabled = a;
            }
        }
        private void Step(int kto)
        {
            string what = "";//Какой символ(О или Х)
            string where;
            if (who == false)
            {
                what = "O";
                status[kto] = 0;
            }
            if (who == true)
            {
                what = "X";
                status[kto] = 7;
            }
            where = "images//" + what + "//" + what+".bmp";//Путь к файлу
            buttons[kto].BackgroundImage = Image.FromFile(where);
            buttons[kto].Enabled = false;            
            who = !who;
            Finish();
        }
        private void Finish()
        {
            int kto = 7,a=5,b=5,c=5;
            string where="мимо", what="",gde;
            bool finish = false;
            { 
            if(status[0] == kto && status[1] == kto && status[2] == kto)
            {
                a = 0;
                b = 1;
                c = 2;
                where = "-";
                finish = true;
            }//-
            if(status[0] == kto && status[4] == kto && status[8] == kto)
            {
                a = 0;
                b = 4;
                c = 8;
                where = "leftup";
                    finish = true;
                }//\
            if(status[0] == kto && status[3] == kto && status[6] == kto)
            {
                a = 0;
                b = 3;
                c = 6;
                where = "up";
                    finish = true;
                }//|
            if(status[1] == kto && status[4] == kto && status[7] == kto)
            {
                a = 1;
                b = 4;
                c = 7;
                where = "up";
                    finish = true;
                }//|
            if(status[2] == kto && status[5] == kto && status[8] == kto)
            {
                a = 2;
                b = 5;
                c = 8;
                where = "up";
                    finish = true;
                }//|
            if(status[2] == kto && status[4] == kto && status[6] == kto)
            {
                a = 2;
                b = 4;
                c = 6;
                where = "rightup";
                    finish = true;
                }///
            if(status[3] == kto && status[4] == kto && status[5] == kto)
            {
                a = 3;
                b = 4;
                c = 5;
                where = "-";
                    finish = true;
                }//-
            if(status[6] == kto && status[7] == kto && status[8] == kto) 
            {
                a = 6;
                b = 7;
                c = 8;
                where = "-";
                finish = true;
                }//-
            if (where=="мимо")kto = 0;
            if (status[0] == kto && status[1] == kto && status[2] == kto)
            {
                a = 0;
                b = 1;
                c = 2;
                where = "-";
                    finish = true;
                }//-
            if (status[0] == kto && status[4] == kto && status[8] == kto)
            {
                a = 0;
                b = 4;
                c = 8;
                where = "leftup";
                    finish = true;
                }//\
            if (status[0] == kto && status[3] == kto && status[6] == kto)
            {
                a = 0;
                b = 3;
                c = 6;
                where = "up";
                    finish = true;
                }//|
            if (status[1] == kto && status[4] == kto && status[7] == kto)
            {
                a = 1;
                b = 4;
                c = 7;
                where = "up";
                    finish = true;
                }//|
            if (status[2] == kto && status[5] == kto && status[8] == kto)
            {
                a = 2;
                b = 5;
                c = 8;
                where = "up";
                    finish = true;
                }//|
            if (status[2] == kto && status[4] == kto && status[6] == kto)
            {
                a = 2;
                b = 4;
                c = 6;
                where = "rightup";
                    finish = true;
                }///
            if (status[3] == kto && status[4] == kto && status[5] == kto)
            {
                a = 3;
                b = 4;
                c = 5;
                where = "-";
                    finish = true;
                }//-
            if (status[6] == kto && status[7] == kto && status[8] == kto)
            {
                a = 6;
                b = 7;
                c = 8;
                where = "-";
                    finish = true;
                }//-
            }           
            if (finish == true)
            {
                if (kto == 7) what = "X";
                if (kto == 0) what = "O";
                gde = "images//"+what+"//"+what+where+".bmp";
                buttons[a].BackgroundImage = Image.FromFile(gde);
                buttons[b].BackgroundImage = Image.FromFile(gde);
                buttons[c].BackgroundImage = Image.FromFile(gde);
                TextLabel.Text = "Победил "+what+".";
                TextLabel.Visible = true;
                TextLabel.Enabled = true;
                for (int i = 0; i < 9; i++)
                    Forbuttons(false);
            }
            else
            {
                int schet=0;
                for (int i = 0; i < 9; i++)
                {
                    if (buttons[i].Enabled == false) schet = schet + 1;
                }
                if (schet == 9)
                {
                    Forbuttons(false);
                    TextLabel.Text = "Ничья ";
                    TextLabel.Visible = true;
                    TextLabel.Enabled = true;
                }
            }
        }
        private void Sbros()
        {
            for (int i = 0; i < 9; i++)
            {               
                buttons[i].BackgroundImage = Image.FromFile("images//_.bmp");
                status[i] = 1;
            }
            Forbuttons(true);
            TextLabel.Enabled = false;
            TextLabel.Visible = false;
        }
        private void Rokirovka(bool a)//Панель работающая в данный момент
        {
            bool b = !a;
            Menu.Visible = a;
            Menu.Enabled = a;
            Game.Visible = b;
            Game.Enabled = b;
        }
        private void ButtonWithFriend_Click(object sender, EventArgs e)
        {
            Rokirovka(false);
        }
        //Кнопки
        private void Cube0_Click(object sender, EventArgs e)
        {
            Step(0);
        }
        private void Cube1_Click(object sender, EventArgs e)
        {
            Step(1);
        }
        private void Cube2_Click(object sender, EventArgs e)
        {
            Step(2);
        }
        private void Cube3_Click(object sender, EventArgs e)
        {
            Step(3);
        }
        private void Cube4_Click(object sender, EventArgs e)
        {
            Step(4);
        }
        private void Cube5_Click(object sender, EventArgs e)
        {
            Step(5);
        }
        private void Cube6_Click(object sender, EventArgs e)
        {
            Step(6);
        }
        private void Cube7_Click(object sender, EventArgs e)
        {
            Step(7);
        }
        private void Cube8_Click(object sender, EventArgs e)
        {
            Step(8);
        }
        private void TextLabel_Click(object sender, EventArgs e)
        {
            Rokirovka(true);
            Sbros();
        }
        //Конец кнопок
    }
}