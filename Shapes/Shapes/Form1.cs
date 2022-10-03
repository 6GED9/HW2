using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Rectang rectang = new Rectang();
        Circle circle = new Circle();
        public static Graphics shape;
        private void button1_Click(object sender, EventArgs e)
        {
            shape = CreateGraphics();
            rectang.draw(textBox1.Text);
            circle.draw(textBox1.Text);
        }
    }
}
