namespace Presentacion
{
    partial class frmAgregarMarca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNombreDeMarca = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtBoxAgregarNombreDeMarca = new System.Windows.Forms.TextBox();
            this.dgvAgregarMarca = new System.Windows.Forms.DataGridView();
            this.lblMarcaNueva = new System.Windows.Forms.Label();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreDeMarca
            // 
            this.lblNombreDeMarca.AutoSize = true;
            this.lblNombreDeMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeMarca.ForeColor = System.Drawing.Color.White;
            this.lblNombreDeMarca.Location = new System.Drawing.Point(489, 225);
            this.lblNombreDeMarca.Name = "lblNombreDeMarca";
            this.lblNombreDeMarca.Size = new System.Drawing.Size(127, 17);
            this.lblNombreDeMarca.TabIndex = 4;
            this.lblNombreDeMarca.Text = "Nombre de Marca";
            this.lblNombreDeMarca.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(12, 82);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(85, 24);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marcas";
            // 
            // txtBoxAgregarNombreDeMarca
            // 
            this.txtBoxAgregarNombreDeMarca.Location = new System.Drawing.Point(639, 225);
            this.txtBoxAgregarNombreDeMarca.Name = "txtBoxAgregarNombreDeMarca";
            this.txtBoxAgregarNombreDeMarca.Size = new System.Drawing.Size(149, 20);
            this.txtBoxAgregarNombreDeMarca.TabIndex = 6;
            // 
            // dgvAgregarMarca
            // 
            this.dgvAgregarMarca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvAgregarMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAgregarMarca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAgregarMarca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgregarMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgregarMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgregarMarca.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAgregarMarca.EnableHeadersVisualStyles = false;
            this.dgvAgregarMarca.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAgregarMarca.Location = new System.Drawing.Point(12, 113);
            this.dgvAgregarMarca.Name = "dgvAgregarMarca";
            this.dgvAgregarMarca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgregarMarca.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAgregarMarca.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAgregarMarca.Size = new System.Drawing.Size(455, 256);
            this.dgvAgregarMarca.TabIndex = 7;
            // 
            // lblMarcaNueva
            // 
            this.lblMarcaNueva.AutoSize = true;
            this.lblMarcaNueva.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaNueva.ForeColor = System.Drawing.Color.White;
            this.lblMarcaNueva.Location = new System.Drawing.Point(488, 173);
            this.lblMarcaNueva.Name = "lblMarcaNueva";
            this.lblMarcaNueva.Size = new System.Drawing.Size(153, 24);
            this.lblMarcaNueva.TabIndex = 8;
            this.lblMarcaNueva.Text = "Marca Nueva";
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgregarMarca.FlatAppearance.BorderSize = 0;
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMarca.Location = new System.Drawing.Point(492, 285);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(296, 37);
            this.btnAgregarMarca.TabIndex = 14;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.lblMarcaNueva);
            this.Controls.Add(this.dgvAgregarMarca);
            this.Controls.Add(this.txtBoxAgregarNombreDeMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNombreDeMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarMarca";
            this.Text = "frmAgregarMarca";
            this.Load += new System.EventHandler(this.frmAgregarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombreDeMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtBoxAgregarNombreDeMarca;
        private System.Windows.Forms.DataGridView dgvAgregarMarca;
        private System.Windows.Forms.Label lblMarcaNueva;
        private System.Windows.Forms.Button btnAgregarMarca;
    }
}