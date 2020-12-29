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
        Boolean cristal=true;
        int hpe;
        int dge;
        int ct;
        int AmmountEnemy;

        private void DarkORgood()
        {
            if (cristal == false)
            {
                //C:\\Users\\Дом\\Documents\\GitHub\\Arislo-Lessons\\Igra\\Igra\\images\\darkMap.bmp
                Map.BackgroundImage = Image.FromFile("images\\goodMap.bmp");
                Bar.Image = Image.FromFile("images\\goodBar.bmp");
            }
            if (cristal == true)
            {
                Map.BackgroundImage = Image.FromFile("images\\darkMap.bmp");
                Bar.Image = Image.FromFile("images\\darkBar.bmp");
            }
        }
        private void Show()
        {
            if (hpplayer > maxhpplayer) hpplayer = maxhpplayer;
            if (maplayer > maxmaplayer) maplayer = maxmaplayer;
            if (saplayer > maxsaplayer) saplayer = maxsaplayer;
            if (hpe < 0) hpe = 0;
            if (hpplayer < 0) hpplayer = 0;
            BARHP.Text = "Жизнь:" + hpplayer;
            BARST.Text = "Выносливость:" + saplayer;
            BARMA.Text = "Мана:" + maplayer;
            BARY.Text = "Деньги:" + money;
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
        }
        private void BuyHP_Click(object sender, EventArgs e)
        {
            if (money >= 10)
            {
                money -= 10;
                maxhpplayer += 10;
            }
            MinToMax();
            Show();
        }
        private void BuyMA_Click(object sender, EventArgs e)
        {
            if (money >= 0)
            {
                money -= 10;
                maxmaplayer += 10;
            }
            MinToMax();
            Show();
        }
        private void BuyST_Click(object sender, EventArgs e)
        {
            if (money >= 0)
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
            Map.Enabled = false;
            BarInside.Visible = true;
            BarInside.Enabled = true;
        }
        private void Battle1_Click(object sender, EventArgs e)
        {            
            MinToMax();
            AmmountEnemy = 2;
            Game();
            Fight(false);        
        }
        private void Battle2_Click(object sender, EventArgs e)
        {
            MinToMax();
            AmmountEnemy = 6;
            Game();
            Fight(false);
        }
        private void Battle3_Click(object sender, EventArgs e)
        {
            MinToMax();
            AmmountEnemy = 20;
            Game();
            Fight(false);
        }
        private void BossBattle_Click(object sender, EventArgs e)
        {
            MinToMax();
            AmmountEnemy = 16;
            Game();
            Fight(false);
        }
        //Battle
        Enemy Wolf = new Enemy("Злой волк", 75, 8, "images\\enemy\\wolf.bmp", 34, 177, 76);
        //C:\\Users\\Дом\\Documents\\GitHub\\Arislo-Lessons\\Igra\\Igra\\images\\enemy\\wolf.bmp);
        Enemy Wood = new Enemy("Злой дуб", 100, 10, "images\\enemy\\wood.bmp", 34, 177, 76);
        Enemy Spider = new Enemy("Гигантский паук.", 150, 15, "images\\enemy\\spider.bmp", 127, 127, 127);
        Enemy Boss = new Enemy("Босс.", 500, 30, "images\\enemy\\boss.bmp", 81, 81, 81);
        private void AddEnemy(string n, int hp, int dg, string enemy, int a, int b, int c)
        {
            BarNameEnemy.Text = n;
            ShowEnemy.Image = Image.FromFile(enemy);
            Battle.BackColor = Color.FromArgb(a, b, c);
            hpe = hp;
            dge = dg;
            ct = 3;
            this.c.BackColor = Color.FromArgb(a, b, c);
        }               
        private void Game()
        {
            if (AmmountEnemy == 2 || AmmountEnemy == 10)//Волк
                AddEnemy(Wolf.Name, Wolf.MaxHpEnemy, Wolf.Damage, Wolf.placeOfenemy, Wolf.a, Wolf.b, Wolf.c);
            if (AmmountEnemy == 6 || AmmountEnemy == 3 || AmmountEnemy == 20 || AmmountEnemy == 5 || AmmountEnemy == 16)//Дерево
                AddEnemy(Wood.Name, Wood.MaxHpEnemy, Wood.Damage, Wood.placeOfenemy, Wood.a, Wood.b, Wood.c);
            if (AmmountEnemy == 8)//Паук
                AddEnemy(Spider.Name, Spider.MaxHpEnemy, Spider.Damage, Spider.placeOfenemy, Spider.a, Spider.b, Spider.c);
            if (AmmountEnemy == 4)//Босс
                AddEnemy(Boss.Name, Boss.MaxHpEnemy, Boss.Damage, Boss.placeOfenemy, Boss.a, Boss.b, Boss.c);
            FightShow();
        }
        private void Finish()
        {
            c.Location = new Point(300, 150);
            string itog = "";
            string kto = "";
            int earning = 0;

            if (AmmountEnemy == 2 || AmmountEnemy == 10)
            {
                kto = Wolf.Name;
                earning = 25;
            }//Волк
            if (AmmountEnemy == 6 || AmmountEnemy == 3 || AmmountEnemy == 20 || AmmountEnemy == 5 || AmmountEnemy == 16)
            {
                kto = Wood.Name;
                earning = 75;
            }//Дерево
            if (AmmountEnemy == 8)
            {
                kto = Spider.Name;
                earning = 100;
            }//Паук
            if (AmmountEnemy == 4)
            {
                kto = Boss.Name;
                earning = 250;
            }//Босс

            if (hpe >= 0 && hpplayer <= 0)//Проигрышь
            {
                itog = "Вас победил ";
                earning = 0;
                c.Enabled = true;
            }
            if (hpplayer >= 0 && hpe <= 0)//Победа
            {
                itog = "Вам проиграл ";
                c.Enabled = true;
            }

            c.Text = itog + kto +". Вы заработали " + earning + " монет. Чтобы продолжить нажми на меня.";
            money += earning;
            Attack.Enabled = false;
            Hill.Enabled = false;
            c.Enabled = true;
            MinToMax();
            Show();
        }
        private void FightShow()
        {
            c.Location = new Point(600, 100);
            c.Text = "Количество ходов:" + Convert.ToString(ct);
            Show();
            BarHPEnemy.Text = "Жизнь:" + hpe;
            if (hpplayer <= 0 || hpe <= 0)
            {
                Finish();
            }
            else c.Enabled = false;
        }//Показывает статус боя
        private void EnemyAttack()
        {
            hpplayer -= dge * 3;
            saplayer += dge / 2 * 3;

            Count(false);
        }
        private void Count(bool who)
        {
            ct -= 1;
            if (ct <= 0)
            {
                if (who == true)
                {
                    ct = 4;
                    EnemyAttack();
                }
            }
        }
        private void Hill_Click(object sender, EventArgs e)
        {
            if (maplayer > 0 && hpplayer < maxhpplayer && maplayer >= maxmaplayer / 10)
            {
                maplayer -= maxmaplayer / 10;
                hpplayer += maxmaplayer / 10;
                Count(true);
            }
            FightShow();
        }
        private void Attack_Click(object sender, EventArgs e)
        {
            if (saplayer > 0 && saplayer >= maxsaplayer / 10)
            {
                saplayer -= maxsaplayer / 10;
                hpe -= maxsaplayer / 10;
                Count(true);
            }
            FightShow();
        }
        private void But_Click(object sender, EventArgs e)
        {
            if (AmmountEnemy == 2 || AmmountEnemy == 3 || AmmountEnemy == 5 || AmmountEnemy == 4)
            {
                Fight(true);                
            }
            else
            {
                hpplayer += maxhpplayer / 2;
                saplayer += maxsaplayer / 2;
                maplayer += maxmaplayer / 2;
                if (AmmountEnemy == 6) AmmountEnemy = 3;
                if (AmmountEnemy == 10) AmmountEnemy = 5;
                if (AmmountEnemy == 20) AmmountEnemy = 10;
                if (AmmountEnemy == 8) AmmountEnemy = 4;
                if (AmmountEnemy == 16) AmmountEnemy = 8;
                Game();
            }
            if (AmmountEnemy == 4) cristal = false;
            DarkORgood();
        }      
        private void Fight(bool a)
        {
           bool b= !a;
            Map.Enabled = a;
            Battle.Enabled = b;
            Map.Visible = a;
            Battle.Visible = b;
        }

       
    }
}
