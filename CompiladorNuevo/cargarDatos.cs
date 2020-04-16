using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace CompiladorNuevo
{
    public partial class CargarDatos : Form
    {
        String linea;
        public CargarDatos()
        {
            InitializeComponent();
            this.Size = new Size(291, 116);
        }

        private void radBtnArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnArchivo.Checked)
            {
                radBtnConsola.Enabled = false;
                vistaConsola.Location = new Point(645, 12);
                vistaCargaArchivo.Location = new Point(12, 62);
                this.Size = new Size(449, 381);
            }
        }

        private void radBtnConsola_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnConsola.Checked)
            {
                radBtnArchivo.Enabled = false;
                vistaCargaArchivo.Location = new Point(572, 12);
                vistaConsola.Location = new Point(12, 57);
                this.Size = new Size(457, 381);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                txtURL.Text = openFile.FileName;
                linea = openFile.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vistaCargaArchivo.Location = new Point(381, 12);
            vistaConsola.Location = new Point(690, 12);
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {

            StreamReader stream = new StreamReader(linea);

            while((linea = stream.ReadLine()) != null)
            {
                listBoxArchivo.Items.Add(linea);
            }
        }

        private void btnConsola_Click(object sender, EventArgs e)
        {
            String[] datos = richTextConsola.Text.Split('\n');

            if (radBtnConsola.Checked)
            {
                listBoxConsola.Items.AddRange(datos);
            }
        }

        private void button_limpiar_archivo(object sender, EventArgs e)
        {
            listBoxArchivo.Items.Clear();
            txtURL.Clear();
            radBtnConsola.Enabled = true;

        }

        private void button_limpiar_consola(object sender, EventArgs e)
        {
            richTextConsola.Clear();
            listBoxConsola.Items.Clear();
            radBtnArchivo.Enabled = true;
        }
    
        private void vistaCargaArchivo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
