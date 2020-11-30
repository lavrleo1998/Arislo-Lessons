using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igra
{
    class Enemy
    {
        string Name;
        int MaxHpEnemy;
        int HpEnemy;
        int Damage;
        private Enemy(string n,int mxhp, int hp, int dg)
        {
            this.Name = n;
            this.MaxHpEnemy = mxhp;
            this.HpEnemy = hp;
            this.Damage = dg;
        }
    }
}
