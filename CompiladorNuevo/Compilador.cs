using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompiladorNuevo
{
    public partial class Compilador : Form
    {
        public Compilador()
        {
            InitializeComponent();
            this.Size = new Size(100, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            Form formulario = new CargaDatos();
            formulario.Show();
        }

        private void btnTablaComponentes_Click(object sender, EventArgs e)
        {
            Form formulario = new TablaComponentes();
            formulario.Show();
        }

        private void btnTablaErrores_Click(object sender, EventArgs e)
        {
            Form formulario = new TablaErrores();
            formulario.Show();
        }

        private void panelOpciones_Paint(object sender, PaintEventArgs e)
        {
            panelOpciones.Location = new Point(5, 20);
            this.Size = new Size(450, 200);
        }

        private void panelCargaDatos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
