using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_with_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ct = 3;
        Class1 first = new Class1(123, 100, 100, 100);
        Class1 second = new Class1(234, 100, 100, 100);

        private void Showbut(int id)
        {
            if (id == second.id)
            {
                FP.Visible = false;
                FP.Enabled = false;
                SP.Visible = true;
                SP.Enabled = true;
            }
            if (id == first.id)
            {
                FP.Visible = true;
                FP.Enabled = true;
                SP.Visible = false;
                SP.Enabled = false;
               
            }

        }//Показывает кнопки в зависимости от очереди. 
        private void Show()
        {
            HB1.Text = "Здоровье:" + first.helth;
            HB2.Text = "Здоровье:" + second.helth;
            SA1.Text = "Выносливость:" + first.stamina;
            SA2.Text = "Выносливость:" + second.stamina;
            MA1.Text = "Мана:" + first.mana;
            MA2.Text = "Мана:" + second.mana;
            CT.Text = "Ходов осталось:"+Convert.ToString(ct);
            if(first.helth<=0 || second.helth <= 0)
            {
                FP.Visible = false;
                FP.Enabled = false;
                SP.Visible = false;
                SP.Enabled = false;
                if (first.helth <= 0 && second.helth > 0)  CT.Text = "Победил правый игрок.";
                if (second.helth <= 0 && first.helth > 0) CT.Text = "Победил левый игрок.";
                if (second.helth<=0 && first.helth<=0) CT.Text = "Ничья.";
            }          
        }    //Показывает значения и проверяет здоровье.
        private void Start(int id)
        {
            panel1.Visible = false;
            panel1.Enabled = false;
            panel2.Visible = true;
            panel2.Enabled = true;
            Showbut(id);
            Show();
        }//Начинает игру
        private void CheckBreak(int id2,int damag,int id1)
        {
            if (id1 == first.id) second.BreakTo(damag);
            if (id1 == second.id) first.BreakTo(damag);
            if (id2 == first.id) first.BreakFrom(damag);
            if (id2 == second.id) second.BreakFrom(damag);
        }//Определяет какого игрока бить,бьёт
        private void CheckHill(int id)
        {
            if (id == first.id) first.Hill();
            if (id == second.id) second.Hill();
        }//Определяет какого игрока лечить,лечит 
        private void Hill(int id)
        {
            CheckHill(id);
            Count(id);
            Show();
        }//Кто
        private void  Break(int id1,int c, int id2)
        {
            int damag = 0;
            for (int i = 1; i <= c; i++)
                damag += 5;
            CheckBreak(id1, damag, id2);
            Count(id2);
            Show();
        }//Кого ; сколько; кто
        private void Skip(int id)
        {
            Count(id);
            Show();
        }
            
        private void Count(int id)
        {
            ct--;
            if (ct <= 0)
            {
                ct = 3;
                if (id == first.id) Showbut(second.id);
                if (id == second.id) Showbut(first.id);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Start(first.id);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Start(second.id);
        }
        //Кнопки игры 
        private void BK11_Click(object sender, EventArgs e)
        {
            Break(second.id, 1, first.id);
        }
        private void BK21_Click(object sender, EventArgs e)
        {
            Break(second.id, 2, first.id);
        }
        private void BK31_Click(object sender, EventArgs e)
        {
            Break(second.id, 3, first.id);
        }
        private void HL1_Click(object sender, EventArgs e)
        {
            Hill(first.id);
        }
        private void SP1_Click(object sender, EventArgs e)
        {
            Skip(first.id);
        }

        private void BK12_Click(object sender, EventArgs e)
        {
            Break(first.id, 1,second.id);
        }
        private void BK22_Click(object sender, EventArgs e)
        {
            Break(first.id, 2, second.id);
        }
        private void BK32_Click(object sender, EventArgs e)
        {
            Break(first.id, 3, second.id);
        }
        private void HL2_Click(object sender, EventArgs e)
        {
            Hill(second.id);
        }

        private void SP2_Click(object sender, EventArgs e)
        {
            Skip(second.id);
        }
    }
}
