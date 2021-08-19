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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 registro = new Form1();
            registro.ShowDialog();
            this.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CGlobal.listaValores;
            dataGridView1.Columns[0].HeaderText = "Nombre";
            dataGridView1.Columns[1].HeaderText = "Fecha";
            dataGridView1.Columns[2].HeaderText = "Telefono";
            dataGridView1.Columns[3].HeaderText = "Cedula";
            dataGridView1.Columns[4].HeaderText = "Comput";
            dataGridView1.Columns[5].HeaderText = "Descripción";
            dataGridView1.Columns[6].HeaderText = "Costo";

        }
    }
}
