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
        obtenerValores usuarios = new obtenerValores();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            datos.DataSource = CGlobal.listaValores;
            datos.Columns[0].HeaderText = "NOMBRE";
            datos.Columns[0].Width = 150;
            datos.Columns[1].HeaderText = "FECHA";
            datos.Columns[1].Width = 150;
            datos.Columns[2].HeaderText = "TELEFONO";
            datos.Columns[2].Width = 150;
            datos.Columns[3].HeaderText = "CEDULA";
            datos.Columns[3].Width = 150;
            datos.Columns[4].HeaderText = "COMPUT";
            datos.Columns[4].Width = 150;
            datos.Columns[5].HeaderText = "DESCRIPCION";
            datos.Columns[5].Width = 150;
            datos.Columns[6].HeaderText = "COSTO";
            datos.Columns[6].Width = 150;
            datos.Columns[7].HeaderText = "ESTADO";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 registro = new Form1();
            registro.ShowDialog();
            this.Close();
        }

        private void finalizado_Click(object sender, EventArgs e)
        {
            obtenerValores ag = CGlobal.listaValores[datos.CurrentRow.Index];
            CGlobal.listaValores.Remove(ag);
            datos.DataSource = null;
            datos.Update();
            datos.Refresh();

            datos.DataSource = CGlobal.listaValores;
            datos.Columns[0].HeaderText = "NOMBRE";
            datos.Columns[0].Width = 150;
            datos.Columns[1].HeaderText = "FECHA";
            datos.Columns[1].Width = 150;
            datos.Columns[2].HeaderText = "TELEFONO";
            datos.Columns[2].Width = 150;
            datos.Columns[3].HeaderText = "CEDULA";
            datos.Columns[3].Width = 150;
            datos.Columns[4].HeaderText = "COMPUT";
            datos.Columns[4].Width = 150;
            datos.Columns[5].HeaderText = "DESCRIPCION";
            datos.Columns[5].Width = 150;
            datos.Columns[6].HeaderText = "COSTO";
            datos.Columns[6].Width = 150;
            datos.Columns[7].HeaderText = "ESTADO";
        }

        private void pendiente_Click(object sender, EventArgs e)
        {
            obtenerValores modificar1 = CGlobal.listaValores[datos.CurrentRow.Index];
            datos.BeginEdit(true);
        }
    }
}
