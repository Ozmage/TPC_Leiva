namespace Presentacion
{
    partial class MostrarMarcas
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
            this.dgvMostrarMarca = new System.Windows.Forms.DataGridView();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.txtBoxBuscarPorId = new System.Windows.Forms.TextBox();
            this.txtBoxBuscarPorNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarPorNombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarMarca
            // 
            this.dgvMostrarMarca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvMostrarMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMostrarMarca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMostrarMarca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMostrarMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostrarMarca.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMostrarMarca.EnableHeadersVisualStyles = false;
            this.dgvMostrarMarca.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMostrarMarca.Location = new System.Drawing.Point(36, 75);
            this.dgvMostrarMarca.Name = "dgvMostrarMarca";
            this.dgvMostrarMarca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarMarca.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMostrarMarca.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMostrarMarca.Size = new System.Drawing.Size(680, 280);
            this.dgvMostrarMarca.TabIndex = 0;
            this.dgvMostrarMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.ForeColor = System.Drawing.Color.White;
            this.lblMarcas.Location = new System.Drawing.Point(32, 40);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(152, 22);
            this.lblMarcas.TabIndex = 1;
            this.lblMarcas.Text = "Lista de Marcas";
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuscarPorId.FlatAppearance.BorderSize = 0;
            this.btnBuscarPorId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorId.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorId.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorId.Location = new System.Drawing.Point(46, 391);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(86, 23);
            this.btnBuscarPorId.TabIndex = 2;
            this.btnBuscarPorId.Text = "Buscar por ID";
            this.btnBuscarPorId.UseVisualStyleBackColor = false;
            // 
            // txtBoxBuscarPorId
            // 
            this.txtBoxBuscarPorId.Location = new System.Drawing.Point(138, 394);
            this.txtBoxBuscarPorId.Name = "txtBoxBuscarPorId";
            this.txtBoxBuscarPorId.Size = new System.Drawing.Size(86, 20);
            this.txtBoxBuscarPorId.TabIndex = 3;
            this.txtBoxBuscarPorId.TextChanged += new System.EventHandler(this.txtBoxBuscarPorId_TextChanged);
            // 
            // txtBoxBuscarPorNombre
            // 
            this.txtBoxBuscarPorNombre.Location = new System.Drawing.Point(371, 395);
            this.txtBoxBuscarPorNombre.Name = "txtBoxBuscarPorNombre";
            this.txtBoxBuscarPorNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBuscarPorNombre.TabIndex = 5;
            this.txtBoxBuscarPorNombre.TextChanged += new System.EventHandler(this.txtBoxBuscarPorNombre_TextChanged);
            // 
            // btnBuscarPorNombre
            // 
            this.btnBuscarPorNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuscarPorNombre.FlatAppearance.BorderSize = 0;
            this.btnBuscarPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorNombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorNombre.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorNombre.Location = new System.Drawing.Point(246, 394);
            this.btnBuscarPorNombre.Name = "btnBuscarPorNombre";
            this.btnBuscarPorNombre.Size = new System.Drawing.Size(119, 23);
            this.btnBuscarPorNombre.TabIndex = 4;
            this.btnBuscarPorNombre.Text = "Buscar por Nombre";
            this.btnBuscarPorNombre.UseVisualStyleBackColor = false;
            // 
            // MostrarMarcas
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(758, 460);
            this.Controls.Add(this.txtBoxBuscarPorNombre);
            this.Controls.Add(this.btnBuscarPorNombre);
            this.Controls.Add(this.txtBoxBuscarPorId);
            this.Controls.Add(this.btnBuscarPorId);
            this.Controls.Add(this.lblMarcas);
            this.Controls.Add(this.dgvMostrarMarca);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarMarcas";
            this.Load += new System.EventHandler(this.MostrarMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

//        private System.Windows.Forms.DataGridView dgvMostrarMarcas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvMostrarMarca;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.Button btnBuscarPorId;
        private System.Windows.Forms.TextBox txtBoxBuscarPorId;
        private System.Windows.Forms.TextBox txtBoxBuscarPorNombre;
        private System.Windows.Forms.Button btnBuscarPorNombre;
    }
}