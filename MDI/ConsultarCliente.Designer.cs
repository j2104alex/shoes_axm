namespace MDI
{
    partial class ConsultarClienteVentana
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
            this.DGCliente = new System.Windows.Forms.DataGridView();
            this.BtnConsulltar = new System.Windows.Forms.Button();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.LbIdentificacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // DGCliente
            // 
            this.DGCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCliente.Location = new System.Drawing.Point(45, 82);
            this.DGCliente.Name = "DGCliente";
            this.DGCliente.Size = new System.Drawing.Size(557, 150);
            this.DGCliente.TabIndex = 0;
            // 
            // BtnConsulltar
            // 
            this.BtnConsulltar.Location = new System.Drawing.Point(298, 38);
            this.BtnConsulltar.Name = "BtnConsulltar";
            this.BtnConsulltar.Size = new System.Drawing.Size(86, 23);
            this.BtnConsulltar.TabIndex = 1;
            this.BtnConsulltar.Text = "CONSULTAR";
            this.BtnConsulltar.UseVisualStyleBackColor = true;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(135, 38);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(140, 20);
            this.txtIdentificacion.TabIndex = 2;
            // 
            // LbIdentificacion
            // 
            this.LbIdentificacion.AutoSize = true;
            this.LbIdentificacion.Location = new System.Drawing.Point(56, 41);
            this.LbIdentificacion.Name = "LbIdentificacion";
            this.LbIdentificacion.Size = new System.Drawing.Size(73, 13);
            this.LbIdentificacion.TabIndex = 3;
            this.LbIdentificacion.Text = "Identificacion:";
            this.LbIdentificacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConsultarClienteVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 281);
            this.Controls.Add(this.LbIdentificacion);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.BtnConsulltar);
            this.Controls.Add(this.DGCliente);
            this.Name = "ConsultarClienteVentana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.DGCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGCliente;
        private System.Windows.Forms.Button BtnConsulltar;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label LbIdentificacion;
    }
}