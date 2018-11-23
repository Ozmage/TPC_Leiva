namespace Presentacion
{
    partial class frmEditarVersion
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
            this.lblEditarVersion = new System.Windows.Forms.Label();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.dgvMostrarVersion = new System.Windows.Forms.DataGridView();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblModelos = new System.Windows.Forms.Label();
            this.lblNombreDeVersiones = new System.Windows.Forms.Label();
            this.btnAceptarVersiones = new System.Windows.Forms.Button();
            this.btnSeleccionarModelo = new System.Windows.Forms.Button();
            this.txtVersionNueva = new System.Windows.Forms.TextBox();
            this.lblVNueva = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditarVersion
            // 
            this.lblEditarVersion.AutoSize = true;
            this.lblEditarVersion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarVersion.ForeColor = System.Drawing.Color.White;
            this.lblEditarVersion.Location = new System.Drawing.Point(487, 117);
            this.lblEditarVersion.Name = "lblEditarVersion";
            this.lblEditarVersion.Size = new System.Drawing.Size(144, 24);
            this.lblEditarVersion.TabIndex = 39;
            this.lblEditarVersion.Text = "Editar Versión";
            // 
            // cboModelo
            // 
            this.cboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(637, 240);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(150, 21);
            this.cboModelo.TabIndex = 38;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(638, 204);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(150, 21);
            this.cboMarca.TabIndex = 37;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMarca.ForeColor = System.Drawing.Color.White;
            this.lblIdMarca.Location = new System.Drawing.Point(489, 204);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(49, 17);
            this.lblIdMarca.TabIndex = 36;
            this.lblIdMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(488, 241);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(57, 17);
            this.lblModelo.TabIndex = 35;
            this.lblModelo.Text = "Modelo";
            // 
            // dgvMostrarVersion
            // 
            this.dgvMostrarVersion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvMostrarVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMostrarVersion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMostrarVersion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarVersion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostrarVersion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostrarVersion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostrarVersion.EnableHeadersVisualStyles = false;
            this.dgvMostrarVersion.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMostrarVersion.Location = new System.Drawing.Point(12, 113);
            this.dgvMostrarVersion.Name = "dgvMostrarVersion";
            this.dgvMostrarVersion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarVersion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMostrarVersion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMostrarVersion.Size = new System.Drawing.Size(455, 256);
            this.dgvMostrarVersion.TabIndex = 34;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(638, 165);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(149, 20);
            this.txtVersion.TabIndex = 33;
            // 
            // lblModelos
            // 
            this.lblModelos.AutoSize = true;
            this.lblModelos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelos.ForeColor = System.Drawing.Color.White;
            this.lblModelos.Location = new System.Drawing.Point(12, 82);
            this.lblModelos.Name = "lblModelos";
            this.lblModelos.Size = new System.Drawing.Size(105, 24);
            this.lblModelos.TabIndex = 32;
            this.lblModelos.Text = "Versiones";
            // 
            // lblNombreDeVersiones
            // 
            this.lblNombreDeVersiones.AutoSize = true;
            this.lblNombreDeVersiones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeVersiones.ForeColor = System.Drawing.Color.White;
            this.lblNombreDeVersiones.Location = new System.Drawing.Point(488, 165);
            this.lblNombreDeVersiones.Name = "lblNombreDeVersiones";
            this.lblNombreDeVersiones.Size = new System.Drawing.Size(131, 17);
            this.lblNombreDeVersiones.TabIndex = 31;
            this.lblNombreDeVersiones.Text = "Nombre de versión";
            // 
            // btnAceptarVersiones
            // 
            this.btnAceptarVersiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAceptarVersiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarVersiones.ForeColor = System.Drawing.Color.White;
            this.btnAceptarVersiones.Location = new System.Drawing.Point(492, 312);
            this.btnAceptarVersiones.Name = "btnAceptarVersiones";
            this.btnAceptarVersiones.Size = new System.Drawing.Size(296, 44);
            this.btnAceptarVersiones.TabIndex = 30;
            this.btnAceptarVersiones.Text = "Editar";
            this.btnAceptarVersiones.UseVisualStyleBackColor = false;
            this.btnAceptarVersiones.Click += new System.EventHandler(this.btnAceptarVersiones_Click);
            // 
            // btnSeleccionarModelo
            // 
            this.btnSeleccionarModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSeleccionarModelo.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarModelo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarModelo.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarModelo.Location = new System.Drawing.Point(98, 390);
            this.btnSeleccionarModelo.Name = "btnSeleccionarModelo";
            this.btnSeleccionarModelo.Size = new System.Drawing.Size(119, 23);
            this.btnSeleccionarModelo.TabIndex = 40;
            this.btnSeleccionarModelo.Text = "Seleccionar";
            this.btnSeleccionarModelo.UseVisualStyleBackColor = false;
            this.btnSeleccionarModelo.Click += new System.EventHandler(this.btnSeleccionarModelo_Click);
            // 
            // txtVersionNueva
            // 
            this.txtVersionNueva.Location = new System.Drawing.Point(638, 277);
            this.txtVersionNueva.Name = "txtVersionNueva";
            this.txtVersionNueva.Size = new System.Drawing.Size(149, 20);
            this.txtVersionNueva.TabIndex = 42;
            // 
            // lblVNueva
            // 
            this.lblVNueva.AutoSize = true;
            this.lblVNueva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVNueva.ForeColor = System.Drawing.Color.White;
            this.lblVNueva.Location = new System.Drawing.Point(488, 277);
            this.lblVNueva.Name = "lblVNueva";
            this.lblVNueva.Size = new System.Drawing.Size(131, 17);
            this.lblVNueva.TabIndex = 41;
            this.lblVNueva.Text = "Nombre de versión";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(580, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(245, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 23);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmEditarVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtVersionNueva);
            this.Controls.Add(this.lblVNueva);
            this.Controls.Add(this.btnSeleccionarModelo);
            this.Controls.Add(this.lblEditarVersion);
            this.Controls.Add(this.cboModelo);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblIdMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.dgvMostrarVersion);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.lblModelos);
            this.Controls.Add(this.lblNombreDeVersiones);
            this.Controls.Add(this.btnAceptarVersiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarVersion";
            this.Text = "frmEditarVersion";
            this.Load += new System.EventHandler(this.frmEditarVersion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarVersion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditarVersion;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.DataGridView dgvMostrarVersion;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lblModelos;
        private System.Windows.Forms.Label lblNombreDeVersiones;
        private System.Windows.Forms.Button btnAceptarVersiones;
        private System.Windows.Forms.Button btnSeleccionarModelo;
        private System.Windows.Forms.TextBox txtVersionNueva;
        private System.Windows.Forms.Label lblVNueva;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
    }
}