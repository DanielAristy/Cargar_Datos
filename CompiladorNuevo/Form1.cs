using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using CompiladorNuevo.Transversal;
using CompiladorNuevo.AnalisisLexico;
using CompiladorNuevo.Caches;

namespace CompiladorNuevo
{
    public partial class Form1 : Form
    {
        String linea;

        public Form1()
        {
            InitializeComponent();
;            this.Size = new Size(291, 116);
        }

        private void radBtnArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnArchivo.Checked)
            {
                radBtnConsola.Enabled = false;
                vistaConsola.Location = new Point(694, 62);
                vistaCargaArchivo.Location = new Point(12, 62);
                dataGridView1.Location = new Point(504, 454);
                this.Size = new Size(516, 336);
            }
        }

        private void radBtnConsola_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnConsola.Checked)
            {
                radBtnArchivo.Enabled = false;
                vistaCargaArchivo.Location = new Point(35, 413);
                vistaConsola.Location = new Point(12, 75);
                tablaSimbolo.Location = new Point(512, 444);
                this.Size = new Size(457, 381);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtURL.Text = openFile.FileName;
                linea = openFile.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vistaCargaArchivo.Location = new Point(35, 413);
            vistaConsola.Location = new Point(694, 62);
        }

        private void ActualizarTextoSalidaConsola()
        {
            foreach (Linea linea in Cache.ObtenerLineas())
            {
                richTextBoxSalida.SelectedText = linea.Numero + "-> " + linea.Contenido + '\n';
            }
        }
        private void ActualizaTextoSalida()
        {
            foreach(Linea linea in Cache.ObtenerLineas())
            {
                richTextBoxArchivo.SelectedText = linea.Numero + "-> "+ linea.Contenido+ '\n';
            }
        }
        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {

            StreamReader stream = new StreamReader(linea);

            while ((linea = stream.ReadLine()) != null)
            {
                Cache.AgregarLinea(linea);
            }
            ActualizaTextoSalida();

        }

        private void btnConsola_Click(object sender, EventArgs e)
        {
            String[] datos = richTextConsola.Text.Split('\n');

            if (radBtnConsola.Checked)
            {
                for(int i = 0; i < datos.Length; i++)
                {
                    Cache.AgregarLinea(datos[i]);
                }
                ActualizarTextoSalidaConsola();
            }
        }

        private void button_limpiar_archivo(object sender, EventArgs e)
        {
            richTextBoxArchivo.Clear();
            txtURL.Clear();
            Cache.LimpiarLineas();
            radBtnConsola.Enabled = true;
        }

        private void button_limpiar_consola(object sender, EventArgs e)
        {
            richTextConsola.Clear();
            richTextBoxSalida.Clear();
            Cache.LimpiarLineas();
            radBtnArchivo.Enabled = true;
            dataGridView1.Rows.Clear();
        }

        private void vistaCargaArchivo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void analisis()
        {
            dataGridView1.Rows.Clear();
            AnalizadorLexico analex = new AnalizadorLexico();
            ComponenteLexico tmp = analex.Analizar();

            while (!"@EOF@".Equals(tmp.Lexema))
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = tmp.Tipo;
                dataGridView1.Rows[n].Cells[1].Value = tmp.Lexema;
                dataGridView1.Rows[n].Cells[2].Value = tmp.NumeroLinea;
                dataGridView1.Rows[n].Cells[3].Value = tmp.PosicionInicial;
                dataGridView1.Rows[n].Cells[4].Value = tmp.PosicionFinal;
                tmp = analex.Analizar();
            }
            
        }

        private void btnTablaSimbolo_Click(object sender, EventArgs e)
        {
            tablaSimbolo.Location = new Point(211, 65);
            dataGridView1.Location = new Point(12, 87);
            vistaCargaArchivo.Location = new Point(35, 401);
            this.Size = new Size(594, 265);
        }

        private void btnCompilarArchivo_Click(object sender, EventArgs e)
        {
           analisis();
        }

        private void btnCompilarConsola_Click(object sender, EventArgs e)
        {
            analisis();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void vistaConsola_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextConsola_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTablaSimbolos_Click(object sender, EventArgs e)
        {
            tablaSimbolo.Location = new Point(211, 65);
            dataGridView1.Location = new Point(12, 87);
            vistaConsola.Location = new Point(615, 41);
            this.Size = new Size(588, 263);
        }
    }
}
//numero   :=0
//      /* Suma de  números
//	    positivos
//      */
//      numero:= suma* (2   /  25)

//            numero:= suma*2
//numero  :=   2, + 45 / numero

//  final :=  numero*  3,3

//      /*Hallar resultado final*/