using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mockup1_848
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 historial = new Form2();
            historial.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 historial = new Form2();
            historial.ShowDialog();
            this.Show();
        }
    }
}
