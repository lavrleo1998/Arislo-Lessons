using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aristo_lesson
{
    class Kletki
    {
        public int status { get; set; }
        public bool character { get; set; }       

        public Kletki (int n, bool s)
        {
            this.status = n;
            this.character = s;            
        }
    }

}
