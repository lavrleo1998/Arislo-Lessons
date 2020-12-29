using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igra
{
    class Enemy
    {
        public string Name { get; set; }
        public int MaxHpEnemy { get; set; }
        public int Damage { get; set; }
        public string placeOfenemy { get; set; }
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public Enemy(string n,int mxhp, int dg,string place,int a, int b, int c)
        {
            this.Name = n;
            this.MaxHpEnemy = mxhp;        
            this.Damage = dg;
            this.placeOfenemy = place;
            this.a = a ;
            this.b = b;
            this.c = c;
        }
    }

}
