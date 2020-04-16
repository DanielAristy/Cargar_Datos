namespace CompiladorNuevo
{
    partial class CargaDatos
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
            this.vistaCargaArchivo.SuspendLayout();
            this.vistaConsola.SuspendLayout();
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
            this.btnCompilarArchivo.Click += new System.EventHandler(this.btnCompilarArchivo_Click);
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
            // CargaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 580);
            this.Controls.Add(this.vistaConsola);
            this.Controls.Add(this.vistaCargaArchivo);
            this.Controls.Add(this.radBtnConsola);
            this.Controls.Add(this.radBtnArchivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CargaDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Datos";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.vistaCargaArchivo.ResumeLayout(false);
            this.vistaCargaArchivo.PerformLayout();
            this.vistaConsola.ResumeLayout(false);
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
    }
}

