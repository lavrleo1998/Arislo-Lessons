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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image =System.Drawing.Image.FromFile("*Снимок экрана (10).png");
        }
    }
}
