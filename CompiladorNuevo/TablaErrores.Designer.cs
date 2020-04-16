namespace CompiladorNuevo
{
    partial class TablaErrores
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.categoria_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lexema_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linea_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicial_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.final_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.falla_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.causa_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solucion_error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView3.Location = new System.Drawing.Point(22, 90);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(847, 258);
            this.dataGridView3.TabIndex = 7;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Errores Léxicos";
            // 
            // TablaErrores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Name = "TablaErrores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablaErrores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexema_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn linea_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicial_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn final_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn falla_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn causa_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn solucion_error;
        private System.Windows.Forms.Label label1;
    }
}