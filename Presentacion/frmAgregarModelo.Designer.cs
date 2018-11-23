namespace Presentacion
{
    partial class frmAgregarModelo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBoxAgregarNombreDeModelo = new System.Windows.Forms.TextBox();
            this.lblModelos = new System.Windows.Forms.Label();
            this.lblNombreDeModelo = new System.Windows.Forms.Label();
            this.dgvAgregarModelos = new System.Windows.Forms.DataGridView();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblModeloNuevo = new System.Windows.Forms.Label();
            this.btnAgregarModelo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxAgregarNombreDeModelo
            // 
            this.txtBoxAgregarNombreDeModelo.Location = new System.Drawing.Point(639, 194);
            this.txtBoxAgregarNombreDeModelo.Name = "txtBoxAgregarNombreDeModelo";
            this.txtBoxAgregarNombreDeModelo.Size = new System.Drawing.Size(149, 20);
            this.txtBoxAgregarNombreDeModelo.TabIndex = 11;
            // 
            // lblModelos
            // 
            this.lblModelos.AutoSize = true;
            this.lblModelos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelos.ForeColor = System.Drawing.Color.White;
            this.lblModelos.Location = new System.Drawing.Point(12, 82);
            this.lblModelos.Name = "lblModelos";
            this.lblModelos.Size = new System.Drawing.Size(98, 24);
            this.lblModelos.TabIndex = 10;
            this.lblModelos.Text = "Modelos";
            // 
            // lblNombreDeModelo
            // 
            this.lblNombreDeModelo.AutoSize = true;
            this.lblNombreDeModelo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeModelo.ForeColor = System.Drawing.Color.White;
            this.lblNombreDeModelo.Location = new System.Drawing.Point(489, 194);
            this.lblNombreDeModelo.Name = "lblNombreDeModelo";
            this.lblNombreDeModelo.Size = new System.Drawing.Size(135, 17);
            this.lblNombreDeModelo.TabIndex = 9;
            this.lblNombreDeModelo.Text = "Nombre de Modelo";
            // 
            // dgvAgregarModelos
            // 
            this.dgvAgregarModelos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvAgregarModelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAgregarModelos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAgregarModelos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgregarModelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAgregarModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgregarModelos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAgregarModelos.EnableHeadersVisualStyles = false;
            this.dgvAgregarModelos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAgregarModelos.Location = new System.Drawing.Point(12, 113);
            this.dgvAgregarModelos.Name = "dgvAgregarModelos";
            this.dgvAgregarModelos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgregarModelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAgregarModelos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAgregarModelos.Size = new System.Drawing.Size(455, 256);
            this.dgvAgregarModelos.TabIndex = 12;
            this.dgvAgregarModelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgregarModelos_CellContentClick);
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMarca.ForeColor = System.Drawing.Color.White;
            this.lblIdMarca.Location = new System.Drawing.Point(489, 234);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(49, 17);
            this.lblIdMarca.TabIndex = 13;
            this.lblIdMarca.Text = "Marca";
            this.lblIdMarca.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(638, 234);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(150, 21);
            this.cboMarca.TabIndex = 25;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // lblModeloNuevo
            // 
            this.lblModeloNuevo.AutoSize = true;
            this.lblModeloNuevo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloNuevo.ForeColor = System.Drawing.Color.White;
            this.lblModeloNuevo.Location = new System.Drawing.Point(488, 149);
            this.lblModeloNuevo.Name = "lblModeloNuevo";
            this.lblModeloNuevo.Size = new System.Drawing.Size(166, 24);
            this.lblModeloNuevo.TabIndex = 26;
            this.lblModeloNuevo.Text = "Modelo Nuevo";
            // 
            // btnAgregarModelo
            // 
            this.btnAgregarModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgregarModelo.FlatAppearance.BorderSize = 0;
            this.btnAgregarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarModelo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarModelo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarModelo.Location = new System.Drawing.Point(492, 285);
            this.btnAgregarModelo.Name = "btnAgregarModelo";
            this.btnAgregarModelo.Size = new System.Drawing.Size(296, 37);
            this.btnAgregarModelo.TabIndex = 27;
            this.btnAgregarModelo.Text = "Agregar";
            this.btnAgregarModelo.UseVisualStyleBackColor = false;
            this.btnAgregarModelo.Click += new System.EventHandler(this.btnAgregarModelo_Click);
            // 
            // frmAgregarModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarModelo);
            this.Controls.Add(this.lblModeloNuevo);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblIdMarca);
            this.Controls.Add(this.dgvAgregarModelos);
            this.Controls.Add(this.txtBoxAgregarNombreDeModelo);
            this.Controls.Add(this.lblModelos);
            this.Controls.Add(this.lblNombreDeModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarModelo";
            this.Text = "frmAgregarModelo";
            this.Load += new System.EventHandler(this.frmAgregarModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarModelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxAgregarNombreDeModelo;
        private System.Windows.Forms.Label lblModelos;
        private System.Windows.Forms.Label lblNombreDeModelo;
        private System.Windows.Forms.DataGridView dgvAgregarModelos;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblModeloNuevo;
        private System.Windows.Forms.Button btnAgregarModelo;
    }
}