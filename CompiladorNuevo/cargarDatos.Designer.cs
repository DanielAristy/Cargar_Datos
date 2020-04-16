﻿namespace CompiladorNuevo
{
    partial class CargarDatos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.radBtnArchivo = new System.Windows.Forms.RadioButton();
            this.radBtnConsola = new System.Windows.Forms.RadioButton();
            this.vistaCargaArchivo = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxArchivo = new System.Windows.Forms.ListBox();
            this.btnCompilarArchivo = new System.Windows.Forms.Button();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.vistaConsola = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCompilarConsola = new System.Windows.Forms.Button();
            this.listBoxConsola = new System.Windows.Forms.ListBox();
            this.btnConsola = new System.Windows.Forms.Button();
            this.richTextConsola = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoria_simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lexema_simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linea_simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicial_simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.final_simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.categoria_dummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lexema_dummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linea_dummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicial_dummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.final_dummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.categoria_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lexema_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linea_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicial_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.final_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.falla_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.causa_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solucion_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaCargaArchivo.SuspendLayout();
            this.vistaConsola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // radBtnArchivo
            // 
            this.radBtnArchivo.AutoSize = true;
            this.radBtnArchivo.Location = new System.Drawing.Point(35, 30);
            this.radBtnArchivo.Name = "radBtnArchivo";
            this.radBtnArchivo.Size = new System.Drawing.Size(106, 17);
            this.radBtnArchivo.TabIndex = 0;
            this.radBtnArchivo.Text = "Archivo de Texto";
            this.radBtnArchivo.UseVisualStyleBackColor = true;
            this.radBtnArchivo.CheckedChanged += new System.EventHandler(this.radBtnArchivo_CheckedChanged);
            // 
            // radBtnConsola
            // 
            this.radBtnConsola.AutoSize = true;
            this.radBtnConsola.Location = new System.Drawing.Point(178, 30);
            this.radBtnConsola.Name = "radBtnConsola";
            this.radBtnConsola.Size = new System.Drawing.Size(82, 17);
            this.radBtnConsola.TabIndex = 1;
            this.radBtnConsola.Text = "Por Consola";
            this.radBtnConsola.UseVisualStyleBackColor = true;
            this.radBtnConsola.CheckedChanged += new System.EventHandler(this.radBtnConsola_CheckedChanged);
            // 
            // vistaCargaArchivo
            // 
            this.vistaCargaArchivo.Controls.Add(this.button2);
            this.vistaCargaArchivo.Controls.Add(this.listBoxArchivo);
            this.vistaCargaArchivo.Controls.Add(this.btnCompilarArchivo);
            this.vistaCargaArchivo.Controls.Add(this.btnCargarArchivo);
            this.vistaCargaArchivo.Controls.Add(this.btnBuscar);
            this.vistaCargaArchivo.Controls.Add(this.txtURL);
            this.vistaCargaArchivo.Location = new System.Drawing.Point(678, 12);
            this.vistaCargaArchivo.Name = "vistaCargaArchivo";
            this.vistaCargaArchivo.Size = new System.Drawing.Size(417, 254);
            this.vistaCargaArchivo.TabIndex = 2;
            this.vistaCargaArchivo.Paint += new System.Windows.Forms.PaintEventHandler(this.vistaCargaArchivo_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_limpiar_archivo);
            // 
            // listBoxArchivo
            // 
            this.listBoxArchivo.FormattingEnabled = true;
            this.listBoxArchivo.Location = new System.Drawing.Point(4, 78);
            this.listBoxArchivo.Name = "listBoxArchivo";
            this.listBoxArchivo.Size = new System.Drawing.Size(405, 134);
            this.listBoxArchivo.TabIndex = 4;
            // 
            // btnCompilarArchivo
            // 
            this.btnCompilarArchivo.Location = new System.Drawing.Point(4, 218);
            this.btnCompilarArchivo.Name = "btnCompilarArchivo";
            this.btnCompilarArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnCompilarArchivo.TabIndex = 4;
            this.btnCompilarArchivo.Text = "Compilar";
            this.btnCompilarArchivo.UseVisualStyleBackColor = true;
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.Location = new System.Drawing.Point(4, 38);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnCargarArchivo.TabIndex = 2;
            this.btnCargarArchivo.Text = "Cargar";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(299, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(4, 11);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(267, 20);
            this.txtURL.TabIndex = 0;
            // 
            // vistaConsola
            // 
            this.vistaConsola.Controls.Add(this.button1);
            this.vistaConsola.Controls.Add(this.btnCompilarConsola);
            this.vistaConsola.Controls.Add(this.listBoxConsola);
            this.vistaConsola.Controls.Add(this.btnConsola);
            this.vistaConsola.Controls.Add(this.richTextConsola);
            this.vistaConsola.Location = new System.Drawing.Point(678, 272);
            this.vistaConsola.Name = "vistaConsola";
            this.vistaConsola.Size = new System.Drawing.Size(413, 283);
            this.vistaConsola.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_limpiar_consola);
            // 
            // btnCompilarConsola
            // 
            this.btnCompilarConsola.Location = new System.Drawing.Point(4, 249);
            this.btnCompilarConsola.Name = "btnCompilarConsola";
            this.btnCompilarConsola.Size = new System.Drawing.Size(75, 23);
            this.btnCompilarConsola.TabIndex = 3;
            this.btnCompilarConsola.Text = "Compilar";
            this.btnCompilarConsola.UseVisualStyleBackColor = true;
            // 
            // listBoxConsola
            // 
            this.listBoxConsola.FormattingEnabled = true;
            this.listBoxConsola.Location = new System.Drawing.Point(4, 148);
            this.listBoxConsola.Name = "listBoxConsola";
            this.listBoxConsola.Size = new System.Drawing.Size(372, 95);
            this.listBoxConsola.TabIndex = 2;
            // 
            // btnConsola
            // 
            this.btnConsola.Location = new System.Drawing.Point(4, 118);
            this.btnConsola.Name = "btnConsola";
            this.btnConsola.Size = new System.Drawing.Size(75, 23);
            this.btnConsola.TabIndex = 1;
            this.btnConsola.Text = "Cargar";
            this.btnConsola.UseVisualStyleBackColor = true;
            this.btnConsola.Click += new System.EventHandler(this.btnConsola_Click);
            // 
            // richTextConsola
            // 
            this.richTextConsola.Location = new System.Drawing.Point(4, 4);
            this.richTextConsola.Name = "richTextConsola";
            this.richTextConsola.Size = new System.Drawing.Size(406, 107);
            this.richTextConsola.TabIndex = 0;
            this.richTextConsola.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoria_simbolo,
            this.lexema_simbolo,
            this.linea_simbolo,
            this.inicial_simbolo,
            this.final_simbolo});
            this.dataGridView1.Location = new System.Drawing.Point(564, 561);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 80);
            this.dataGridView1.TabIndex = 4;
            // 
            // categoria_simbolo
            // 
            this.categoria_simbolo.HeaderText = "Categoria";
            this.categoria_simbolo.Name = "categoria_simbolo";
            // 
            // lexema_simbolo
            // 
            this.lexema_simbolo.HeaderText = "Lexema";
            this.lexema_simbolo.Name = "lexema_simbolo";
            // 
            // linea_simbolo
            // 
            this.linea_simbolo.HeaderText = "Numero Linea";
            this.linea_simbolo.Name = "linea_simbolo";
            // 
            // inicial_simbolo
            // 
            this.inicial_simbolo.HeaderText = "Posicion Inicial";
            this.inicial_simbolo.Name = "inicial_simbolo";
            // 
            // final_simbolo
            // 
            this.final_simbolo.HeaderText = "Posicion Final";
            this.final_simbolo.Name = "final_simbolo";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoria_dummy,
            this.lexema_dummy,
            this.linea_dummy,
            this.inicial_dummy,
            this.final_dummy});
            this.dataGridView2.Location = new System.Drawing.Point(564, 647);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(541, 69);
            this.dataGridView2.TabIndex = 5;
            // 
            // categoria_dummy
            // 
            this.categoria_dummy.HeaderText = "Categoria";
            this.categoria_dummy.Name = "categoria_dummy";
            // 
            // lexema_dummy
            // 
            this.lexema_dummy.HeaderText = "Lexema";
            this.lexema_dummy.Name = "lexema_dummy";
            // 
            // linea_dummy
            // 
            this.linea_dummy.HeaderText = "Numero Linea";
            this.linea_dummy.Name = "linea_dummy";
            // 
            // inicial_dummy
            // 
            this.inicial_dummy.HeaderText = "Posicion Inicial";
            this.inicial_dummy.Name = "inicial_dummy";
            // 
            // final_dummy
            // 
            this.final_dummy.HeaderText = "Posicion Final";
            this.final_dummy.Name = "final_dummy";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoria_error,
            this.lexema_error,
            this.linea_error,
            this.inicial_error,
            this.final_error,
            this.falla_error,
            this.causa_error,
            this.solucion_error});
            this.dataGridView3.Location = new System.Drawing.Point(268, 737);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(837, 96);
            this.dataGridView3.TabIndex = 6;
            // 
            // categoria_error
            // 
            this.categoria_error.HeaderText = "Categoria";
            this.categoria_error.Name = "categoria_error";
            // 
            // lexema_error
            // 
            this.lexema_error.HeaderText = "Lexema";
            this.lexema_error.Name = "lexema_error";
            // 
            // linea_error
            // 
            this.linea_error.HeaderText = "Numero Linea";
            this.linea_error.Name = "linea_error";
            // 
            // inicial_error
            // 
            this.inicial_error.HeaderText = "Posicion Inicial";
            this.inicial_error.Name = "inicial_error";
            // 
            // final_error
            // 
            this.final_error.HeaderText = "Posicion Final";
            this.final_error.Name = "final_error";
            // 
            // falla_error
            // 
            this.falla_error.HeaderText = "Falla";
            this.falla_error.Name = "falla_error";
            // 
            // causa_error
            // 
            this.causa_error.HeaderText = "Causa";
            this.causa_error.Name = "causa_error";
            // 
            // solucion_error
            // 
            this.solucion_error.HeaderText = "Solucion";
            this.solucion_error.Name = "solucion_error";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 845);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.vistaConsola);
            this.Controls.Add(this.vistaCargaArchivo);
            this.Controls.Add(this.radBtnConsola);
            this.Controls.Add(this.radBtnArchivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Compilador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.vistaCargaArchivo.ResumeLayout(false);
            this.vistaCargaArchivo.PerformLayout();
            this.vistaConsola.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBtnArchivo;
        private System.Windows.Forms.RadioButton radBtnConsola;
        private System.Windows.Forms.Panel vistaCargaArchivo;
        private System.Windows.Forms.Button btnCompilarArchivo;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Panel vistaConsola;
        private System.Windows.Forms.Button btnCompilarConsola;
        private System.Windows.Forms.ListBox listBoxConsola;
        private System.Windows.Forms.Button btnConsola;
        private System.Windows.Forms.RichTextBox richTextConsola;
        private System.Windows.Forms.ListBox listBoxArchivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexema_simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn linea_simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicial_simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn final_simbolo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_dummy;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexema_dummy;
        private System.Windows.Forms.DataGridViewTextBoxColumn linea_dummy;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicial_dummy;
        private System.Windows.Forms.DataGridViewTextBoxColumn final_dummy;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexema_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn linea_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicial_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn final_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn falla_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn causa_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn solucion_error;
    }
}

