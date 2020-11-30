using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_with_class
{
    class Class1
    {
        public int id;
        public int helth;
        public int stamina;
        public int mana;
        public Class1(int i, int h, int s,int m)
        {
            this.id = i;
            this.helth = h;
            this.stamina = s;
            this.mana = m;
        }
        public void BreakTo(int damag)
        {
            this.helth -= damag;
            this.stamina += 10;
        }
        public void BreakFrom(int damag) => this.stamina -= 10;
        public void Hill()
        {
            this.helth += 10;
            this.mana -= 10;
        }    
    }
}
