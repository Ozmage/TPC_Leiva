namespace Presentacion
{
    partial class frmAgregarVersion
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
            this.txtBoxAgregarNombreDeVersiones = new System.Windows.Forms.TextBox();
            this.lblModelos = new System.Windows.Forms.Label();
            this.lblNombreDeVersiones = new System.Windows.Forms.Label();
            this.dgvAgregarVersiones = new System.Windows.Forms.DataGridView();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.lblVersionNueva = new System.Windows.Forms.Label();
            this.btnAgregarVersion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarVersiones)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxAgregarNombreDeVersiones
            // 
            this.txtBoxAgregarNombreDeVersiones.Location = new System.Drawing.Point(639, 178);
            this.txtBoxAgregarNombreDeVersiones.Name = "txtBoxAgregarNombreDeVersiones";
            this.txtBoxAgregarNombreDeVersiones.Size = new System.Drawing.Size(149, 20);
            this.txtBoxAgregarNombreDeVersiones.TabIndex = 16;
            // 
            // lblModelos
            // 
            this.lblModelos.AutoSize = true;
            this.lblModelos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelos.ForeColor = System.Drawing.Color.White;
            this.lblModelos.Location = new System.Drawing.Point(12, 82);
            this.lblModelos.Name = "lblModelos";
            this.lblModelos.Size = new System.Drawing.Size(105, 24);
            this.lblModelos.TabIndex = 15;
            this.lblModelos.Text = "Versiones";
            this.lblModelos.Click += new System.EventHandler(this.lblModelos_Click);
            // 
            // lblNombreDeVersiones
            // 
            this.lblNombreDeVersiones.AutoSize = true;
            this.lblNombreDeVersiones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeVersiones.ForeColor = System.Drawing.Color.White;
            this.lblNombreDeVersiones.Location = new System.Drawing.Point(489, 178);
            this.lblNombreDeVersiones.Name = "lblNombreDeVersiones";
            this.lblNombreDeVersiones.Size = new System.Drawing.Size(131, 17);
            this.lblNombreDeVersiones.TabIndex = 14;
            this.lblNombreDeVersiones.Text = "Nombre de versión";
            // 
            // dgvAgregarVersiones
            // 
            this.dgvAgregarVersiones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvAgregarVersiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAgregarVersiones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAgregarVersiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgregarVersiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAgregarVersiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgregarVersiones.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAgregarVersiones.EnableHeadersVisualStyles = false;
            this.dgvAgregarVersiones.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAgregarVersiones.Location = new System.Drawing.Point(12, 113);
            this.dgvAgregarVersiones.Name = "dgvAgregarVersiones";
            this.dgvAgregarVersiones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgregarVersiones.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAgregarVersiones.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAgregarVersiones.Size = new System.Drawing.Size(455, 256);
            this.dgvAgregarVersiones.TabIndex = 17;
            this.dgvAgregarVersiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgregarVersiones_CellContentClick);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(489, 254);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(57, 17);
            this.lblModelo.TabIndex = 18;
            this.lblModelo.Text = "Modelo";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(639, 217);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(150, 21);
            this.cboMarca.TabIndex = 27;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMarca.ForeColor = System.Drawing.Color.White;
            this.lblIdMarca.Location = new System.Drawing.Point(490, 217);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(49, 17);
            this.lblIdMarca.TabIndex = 26;
            this.lblIdMarca.Text = "Marca";
            // 
            // cboModelo
            // 
            this.cboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(638, 253);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(150, 21);
            this.cboModelo.TabIndex = 28;
            // 
            // lblVersionNueva
            // 
            this.lblVersionNueva.AutoSize = true;
            this.lblVersionNueva.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionNueva.ForeColor = System.Drawing.Color.White;
            this.lblVersionNueva.Location = new System.Drawing.Point(488, 130);
            this.lblVersionNueva.Name = "lblVersionNueva";
            this.lblVersionNueva.Size = new System.Drawing.Size(159, 24);
            this.lblVersionNueva.TabIndex = 29;
            this.lblVersionNueva.Text = "Version Nueva";
            // 
            // btnAgregarVersion
            // 
            this.btnAgregarVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgregarVersion.FlatAppearance.BorderSize = 0;
            this.btnAgregarVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVersion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVersion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarVersion.Location = new System.Drawing.Point(492, 308);
            this.btnAgregarVersion.Name = "btnAgregarVersion";
            this.btnAgregarVersion.Size = new System.Drawing.Size(296, 37);
            this.btnAgregarVersion.TabIndex = 30;
            this.btnAgregarVersion.Text = "Agregar";
            this.btnAgregarVersion.UseVisualStyleBackColor = false;
            this.btnAgregarVersion.Click += new System.EventHandler(this.btnAgregarVersion_Click);
            // 
            // frmAgregarVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarVersion);
            this.Controls.Add(this.lblVersionNueva);
            this.Controls.Add(this.cboModelo);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblIdMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.dgvAgregarVersiones);
            this.Controls.Add(this.txtBoxAgregarNombreDeVersiones);
            this.Controls.Add(this.lblModelos);
            this.Controls.Add(this.lblNombreDeVersiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarVersion";
            this.Text = "frmAgregarVersion";
            this.Load += new System.EventHandler(this.frmAgregarVersion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarVersiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxAgregarNombreDeVersiones;
        private System.Windows.Forms.Label lblModelos;
        private System.Windows.Forms.Label lblNombreDeVersiones;
        private System.Windows.Forms.DataGridView dgvAgregarVersiones;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.Label lblVersionNueva;
        private System.Windows.Forms.Button btnAgregarVersion;
    }
}