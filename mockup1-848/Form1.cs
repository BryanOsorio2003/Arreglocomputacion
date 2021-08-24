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
        obtenerValores obValor = new obtenerValores();
        //List<obtenerValores> listaValores = new List<obtenerValores>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obValor = new obtenerValores();
            obValor.nombre = nombre.Text;
            obValor.fecha = Convert.ToDateTime(fecha.Text);
            obValor.telefono = telefono.Text;
            obValor.cedula = Convert.ToInt32(cedula.Text);
            obValor.opcionesElegir = opcionesElegir.Text;
            obValor.descripcion = descripcion.Text;
            obValor.costo = Convert.ToInt32(costo.Text);
            obValor.estado = estado.Text;
            CGlobal.listaValores.Add(obValor);
            nombre.Text = "";
            fecha.Text = "";
            telefono.Text = "";
            cedula.Text = "";
            opcionesElegir.Text = "";
            descripcion.Text = "";
            costo.Text = "";
            estado.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 historial = new Form2();
            historial.ShowDialog();
            this.Close();
        }
    }
}
