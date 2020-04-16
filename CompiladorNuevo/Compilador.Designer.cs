namespace CompiladorNuevo
{
    partial class Compilador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCarga = new System.Windows.Forms.Button();
            this.btnTablaComponentes = new System.Windows.Forms.Button();
            this.btnTablaErrores = new System.Windows.Forms.Button();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(14, 46);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(122, 40);
            this.btnCarga.TabIndex = 0;
            this.btnCarga.Text = "Carga";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // btnTablaComponentes
            // 
            this.btnTablaComponentes.Location = new System.Drawing.Point(142, 46);
            this.btnTablaComponentes.Name = "btnTablaComponentes";
            this.btnTablaComponentes.Size = new System.Drawing.Size(122, 40);
            this.btnTablaComponentes.TabIndex = 1;
            this.btnTablaComponentes.Text = "Tabla de Componentes";
            this.btnTablaComponentes.UseVisualStyleBackColor = true;
            this.btnTablaComponentes.Click += new System.EventHandler(this.btnTablaComponentes_Click);
            // 
            // btnTablaErrores
            // 
            this.btnTablaErrores.Location = new System.Drawing.Point(270, 46);
            this.btnTablaErrores.Name = "btnTablaErrores";
            this.btnTablaErrores.Size = new System.Drawing.Size(122, 40);
            this.btnTablaErrores.TabIndex = 2;
            this.btnTablaErrores.Text = "Tabla de Errores";
            this.btnTablaErrores.UseVisualStyleBackColor = true;
            this.btnTablaErrores.Click += new System.EventHandler(this.btnTablaErrores_Click);
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.btnCarga);
            this.panelOpciones.Controls.Add(this.btnTablaErrores);
            this.panelOpciones.Controls.Add(this.btnTablaComponentes);
            this.panelOpciones.Location = new System.Drawing.Point(12, 12);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(408, 131);
            this.panelOpciones.TabIndex = 3;
            this.panelOpciones.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOpciones_Paint);
            // 
            // Compilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 749);
            this.Controls.Add(this.panelOpciones);
            this.Name = "Compilador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compilador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.Button btnTablaComponentes;
        private System.Windows.Forms.Button btnTablaErrores;
        private System.Windows.Forms.Panel panelOpciones;
    }
}