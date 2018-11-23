namespace Presentacion
{
    partial class frmEditarModelo
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
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnGuardarModelo = new System.Windows.Forms.Button();
            this.btnSeleccionarModelo = new System.Windows.Forms.Button();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.dgvMostrarModelo = new System.Windows.Forms.DataGridView();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblModeloNuevo = new System.Windows.Forms.Label();
            this.lblEditarModelo = new System.Windows.Forms.Label();
            this.txtModeloNuevo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(518, 188);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 25;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(602, 185);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(115, 20);
            this.txtModelo.TabIndex = 24;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // btnGuardarModelo
            // 
            this.btnGuardarModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGuardarModelo.FlatAppearance.BorderSize = 0;
            this.btnGuardarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarModelo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModelo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarModelo.Location = new System.Drawing.Point(598, 345);
            this.btnGuardarModelo.Name = "btnGuardarModelo";
            this.btnGuardarModelo.Size = new System.Drawing.Size(119, 23);
            this.btnGuardarModelo.TabIndex = 22;
            this.btnGuardarModelo.Text = "Guardar";
            this.btnGuardarModelo.UseVisualStyleBackColor = false;
            this.btnGuardarModelo.Click += new System.EventHandler(this.btnGuardarModelo_Click);
            // 
            // btnSeleccionarModelo
            // 
            this.btnSeleccionarModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSeleccionarModelo.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarModelo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarModelo.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarModelo.Location = new System.Drawing.Point(125, 389);
            this.btnSeleccionarModelo.Name = "btnSeleccionarModelo";
            this.btnSeleccionarModelo.Size = new System.Drawing.Size(119, 23);
            this.btnSeleccionarModelo.TabIndex = 21;
            this.btnSeleccionarModelo.Text = "Seleccionar";
            this.btnSeleccionarModelo.UseVisualStyleBackColor = false;
            this.btnSeleccionarModelo.Click += new System.EventHandler(this.btnEditarModelo_Click);
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.ForeColor = System.Drawing.Color.White;
            this.lblMarcas.Location = new System.Drawing.Point(58, 53);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(160, 22);
            this.lblMarcas.TabIndex = 19;
            this.lblMarcas.Text = "Lista de Modelos";
            // 
            // dgvMostrarModelo
            // 
            this.dgvMostrarModelo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvMostrarModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMostrarModelo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMostrarModelo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarModelo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMostrarModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostrarModelo.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMostrarModelo.EnableHeadersVisualStyles = false;
            this.dgvMostrarModelo.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMostrarModelo.Location = new System.Drawing.Point(62, 88);
            this.dgvMostrarModelo.Name = "dgvMostrarModelo";
            this.dgvMostrarModelo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarModelo.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMostrarModelo.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMostrarModelo.Size = new System.Drawing.Size(420, 280);
            this.dgvMostrarModelo.TabIndex = 18;
            this.dgvMostrarModelo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarModelo_CellContentClick);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(518, 232);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 27;
            this.lblMarca.Text = "Marca:";
            this.lblMarca.UseMnemonic = false;
            this.lblMarca.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(602, 228);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(115, 21);
            this.cboMarca.TabIndex = 28;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // lblModeloNuevo
            // 
            this.lblModeloNuevo.AutoSize = true;
            this.lblModeloNuevo.ForeColor = System.Drawing.Color.White;
            this.lblModeloNuevo.Location = new System.Drawing.Point(518, 276);
            this.lblModeloNuevo.Name = "lblModeloNuevo";
            this.lblModeloNuevo.Size = new System.Drawing.Size(80, 13);
            this.lblModeloNuevo.TabIndex = 29;
            this.lblModeloNuevo.Text = "Modelo Nuevo:";
            this.lblModeloNuevo.UseMnemonic = false;
            // 
            // lblEditarModelo
            // 
            this.lblEditarModelo.AutoSize = true;
            this.lblEditarModelo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarModelo.ForeColor = System.Drawing.Color.White;
            this.lblEditarModelo.Location = new System.Drawing.Point(515, 110);
            this.lblEditarModelo.Name = "lblEditarModelo";
            this.lblEditarModelo.Size = new System.Drawing.Size(136, 22);
            this.lblEditarModelo.TabIndex = 31;
            this.lblEditarModelo.Text = "Editar Modelo";
            // 
            // txtModeloNuevo
            // 
            this.txtModeloNuevo.Location = new System.Drawing.Point(602, 272);
            this.txtModeloNuevo.Name = "txtModeloNuevo";
            this.txtModeloNuevo.Size = new System.Drawing.Size(115, 20);
            this.txtModeloNuevo.TabIndex = 32;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(269, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 23);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmEditarModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtModeloNuevo);
            this.Controls.Add(this.lblEditarModelo);
            this.Controls.Add(this.lblModeloNuevo);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.btnGuardarModelo);
            this.Controls.Add(this.btnSeleccionarModelo);
            this.Controls.Add(this.lblMarcas);
            this.Controls.Add(this.dgvMostrarModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarModelo";
            this.Text = "frmEditarModelo";
            this.Load += new System.EventHandler(this.frmEditarModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnGuardarModelo;
        private System.Windows.Forms.Button btnSeleccionarModelo;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.DataGridView dgvMostrarModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblModeloNuevo;
        private System.Windows.Forms.Label lblEditarModelo;
        private System.Windows.Forms.TextBox txtModeloNuevo;
        private System.Windows.Forms.Button btnCancelar;
    }
}