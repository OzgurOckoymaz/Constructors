using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            Triangle t = new Triangle(10, 20);
            t.H = Convert.ToDecimal(textBox1.Text);
            t.Bottom = Convert.ToDecimal(textBox2.Text);

            MessageBox.Show($" The area of the triangle is {t.area_triangle} ");

            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnPerimeter_Click(object sender, EventArgs e)
        {
            Triangle t = new Triangle(1, 2);
            t.Left = Convert.ToDecimal(textBox3.Text);
            t.Right = Convert.ToDecimal(textBox4.Text);
            t.Bottom = Convert.ToDecimal(textBox5.Text);
            MessageBox.Show($"the perimeter of the triangle is {t.perimeter_triangle(t.Left, t.Right, t.Bottom)}");

            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }
    }
}
