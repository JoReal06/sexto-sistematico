namespace sexto_sistematico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgv_tabla = new System.Windows.Forms.DataGridView();
            this.btn_bateadores = new System.Windows.Forms.Button();
            this.btn_peloteros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_tabla
            // 
            this.dtgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_tabla.Location = new System.Drawing.Point(12, 115);
            this.dtgv_tabla.Name = "dtgv_tabla";
            this.dtgv_tabla.RowTemplate.Height = 25;
            this.dtgv_tabla.Size = new System.Drawing.Size(613, 323);
            this.dtgv_tabla.TabIndex = 0;
            // 
            // btn_bateadores
            // 
            this.btn_bateadores.Location = new System.Drawing.Point(26, 36);
            this.btn_bateadores.Name = "btn_bateadores";
            this.btn_bateadores.Size = new System.Drawing.Size(103, 43);
            this.btn_bateadores.TabIndex = 1;
            this.btn_bateadores.Text = "bateadores";
            this.btn_bateadores.UseVisualStyleBackColor = true;
            this.btn_bateadores.Click += new System.EventHandler(this.btn_bateadores_Click);
            // 
            // btn_peloteros
            // 
            this.btn_peloteros.Location = new System.Drawing.Point(193, 36);
            this.btn_peloteros.Name = "btn_peloteros";
            this.btn_peloteros.Size = new System.Drawing.Size(103, 43);
            this.btn_peloteros.TabIndex = 2;
            this.btn_peloteros.Text = "Peloteros";
            this.btn_peloteros.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 471);
            this.Controls.Add(this.btn_peloteros);
            this.Controls.Add(this.btn_bateadores);
            this.Controls.Add(this.dtgv_tabla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtgv_tabla;
        private Button btn_bateadores;
        private Button btn_peloteros;
    }
}