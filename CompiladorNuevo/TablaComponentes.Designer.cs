namespace CompiladorNuevo
{
    partial class TablaComponentes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(23, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 211);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.dataGridView2.Location = new System.Drawing.Point(590, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(541, 211);
            this.dataGridView2.TabIndex = 6;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tabla de Simbolos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(779, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tabla de DUMMYS";
            // 
            // TablaComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 308);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TablaComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablaComponentes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}