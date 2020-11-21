using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_aristotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ct=3;        
        int hp1 = 100;
        int hp2 = 100;
        int ma1 = 100;
        int ma2 = 100;
        int sa1 = 100;
        int sa2 = 100;
        int id1 = 234;
        int id2 = 345;       
        private void Show()
        {
            HB1.Text = "Здоровье:" + hp1;
            HB2.Text = "Здоровье:" + hp2;
            SA1.Text = "Выносливость:" + sa1;
            SA2.Text = "Выносливость:" + sa2;
            MA1.Text = "Мана:" + ma1;
            MA2.Text = "Мана:" + ma2;
            CT.Text = Convert.ToString(ct);
            if (hp1 <= 0 || hp2 <= 0)
            {
                HL1.Visible = false;
                HL2.Visible = false;
                BK11.Visible = false;
                BK12.Visible = false;
                BK21.Visible = false;
                BK22.Visible = false;
                BK31.Visible = false;
                BK32.Visible = false;
                CT.Visible = false;
                status.Visible = true;
                SP1.Visible = false;
                SP2.Visible = false;
                if (hp1 <= 0)
                {
                    hp1 = 0;
                    status.Text = "Конец, победил правый игрок.";
                }
                if (hp2 <= 0)
                {
                    hp2 = 0;
                    status.Text = "Конец, победил левый игрок.";
                }
                HB1.Text = "Здоровье:" + hp1;
                HB2.Text = "Здоровье:" + hp2;

            }
        }
        private void Break(int id, int count)
        {
            if (id==id1 && sa1!=0 || id == id2 && sa2!=0)
            Count(id);
            for (int i = 1; i <= count; i++)
            {
                if (id == id1 && sa1 != 0)
                {
                        sa1 -= 10;
                        hp2 -= 5;
                        if (sa2 != 100) sa2 += 10;                    
                }
                if (id == id2 && sa2 != 0)
                {
                    sa2 -= 10;
                    hp1 -= 5;
                    if (sa1 != 100) sa1 += 10;
                }
            }
            Show();
        }
        private void Hill(int id)
        {
            if (id == id1)
            {
                if (hp1 != 100 && ma1 > 0)
                {
                    hp1 += 10;
                    ma1 -= 10;
                }

            }
           if (id==id2)
            {
                if (hp2 != 100 && ma2 != 0)
                {
                    hp2 += 10;
                    ma2 -= 10;
                }
            }
            if (hp1 > 100)
                hp1 = 100;
            if (hp2 > 100)
                hp2 = 100;
            if (id==id1 && ma1!=0 && hp1!=100 || id==id2 && ma2!=0 && hp2 != 100)
            Count(id);
            Show();

        }
        private void Showbut(int id)
        {
            if (id == id1)
            {
                HL1.Visible = true;
                HL2.Visible = false;
                BK11.Visible = true;
                BK12.Visible = false;
                BK21.Visible = true;
                BK22.Visible = false;
                BK31.Visible = true;
                BK32.Visible = false;
                SP1.Visible = true;
                SP2.Visible = false;
            }
            if (id == id2)
            {
                HL1.Visible = false;
                HL2.Visible = true;
                BK11.Visible = false;
                BK12.Visible = true;
                BK21.Visible = false;
                BK22.Visible = true;
                BK31.Visible = false;
                BK32.Visible = true;
                SP1.Visible = false;
                SP2.Visible = true;
            }
        }
        private void Count(int id)
        {
            ct -= 1;
            if (ct == 0)
            {
                if (id == id1)
                    Showbut(id2);
                if(id==id2)
                    Showbut(id1);
                ct = 3;
            }
            
        }
        private void HL1_Click(object sender, EventArgs e)
        {
            Hill(id1);
        }
        private void HL2_Click(object sender, EventArgs e)
        {
            Hill(id2);
        }
        private void BK11_Click(object sender, EventArgs e)
        {
            Break(id1, 1);
        }
        private void BK12_Click(object sender, EventArgs e)
        {
            Break(id2, 1);
        }
        private void BK22_Click(object sender, EventArgs e)
        {
            Break(id2, 2);
        }
        private void BR21_Click(object sender, EventArgs e)
        {
            Break(id1, 2);
        }
        private void BK31_Click(object sender, EventArgs e)
        {
            Break(id1, 3);
        }
        private void BK32_Click(object sender, EventArgs e)
        {
            Break(id2, 3);
        }
        private void ST_Click(object sender, EventArgs e)
        {
            SP1.Visible = true;
            SP2.Visible = true;
            CT.Visible = true;
            ST.Visible = false;
            HB1.Visible = true;
            HB2.Visible = true;
            SA1.Visible = true;
            SA2.Visible = true;
            MA1.Visible = true;
            MA2.Visible = true;
            kolvo.Visible = true;
            Show();
            Showbut(id1);

        }
        private void SP1_Click(object sender, EventArgs e)
        {
            Count(id1);
            Show();
        }
        private void SP2_Click(object sender, EventArgs e)
        {
            Count(id2);
            Show();
        }
    }
}