namespace Presentacion
{
    partial class MostrarModelos
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
            this.txtBoxBuscarPorNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarPorNombre = new System.Windows.Forms.Button();
            this.txtBoxBuscarPorId = new System.Windows.Forms.TextBox();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.lblModelos = new System.Windows.Forms.Label();
            this.dgvMostrarModelos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxBuscarPorNombre
            // 
            this.txtBoxBuscarPorNombre.Location = new System.Drawing.Point(362, 393);
            this.txtBoxBuscarPorNombre.Name = "txtBoxBuscarPorNombre";
            this.txtBoxBuscarPorNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBuscarPorNombre.TabIndex = 9;
            // 
            // btnBuscarPorNombre
            // 
            this.btnBuscarPorNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuscarPorNombre.FlatAppearance.BorderSize = 0;
            this.btnBuscarPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorNombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorNombre.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorNombre.Location = new System.Drawing.Point(237, 392);
            this.btnBuscarPorNombre.Name = "btnBuscarPorNombre";
            this.btnBuscarPorNombre.Size = new System.Drawing.Size(119, 23);
            this.btnBuscarPorNombre.TabIndex = 8;
            this.btnBuscarPorNombre.Text = "Buscar por Nombre";
            this.btnBuscarPorNombre.UseVisualStyleBackColor = false;
            // 
            // txtBoxBuscarPorId
            // 
            this.txtBoxBuscarPorId.Location = new System.Drawing.Point(129, 392);
            this.txtBoxBuscarPorId.Name = "txtBoxBuscarPorId";
            this.txtBoxBuscarPorId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBuscarPorId.TabIndex = 7;
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuscarPorId.FlatAppearance.BorderSize = 0;
            this.btnBuscarPorId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorId.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorId.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorId.Location = new System.Drawing.Point(37, 389);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(86, 23);
            this.btnBuscarPorId.TabIndex = 6;
            this.btnBuscarPorId.Text = "Buscar por ID";
            this.btnBuscarPorId.UseVisualStyleBackColor = false;
            // 
            // lblModelos
            // 
            this.lblModelos.AutoSize = true;
            this.lblModelos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelos.ForeColor = System.Drawing.Color.White;
            this.lblModelos.Location = new System.Drawing.Point(32, 40);
            this.lblModelos.Name = "lblModelos";
            this.lblModelos.Size = new System.Drawing.Size(160, 22);
            this.lblModelos.TabIndex = 10;
            this.lblModelos.Text = "Lista de Modelos";
            // 
            // dgvMostrarModelos
            // 
            this.dgvMostrarModelos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvMostrarModelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMostrarModelos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMostrarModelos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarModelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostrarModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostrarModelos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostrarModelos.EnableHeadersVisualStyles = false;
            this.dgvMostrarModelos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMostrarModelos.Location = new System.Drawing.Point(36, 75);
            this.dgvMostrarModelos.Name = "dgvMostrarModelos";
            this.dgvMostrarModelos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarModelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMostrarModelos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMostrarModelos.Size = new System.Drawing.Size(680, 280);
            this.dgvMostrarModelos.TabIndex = 11;
            this.dgvMostrarModelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarModelos_CellContentClick);
            // 
            // MostrarModelos
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(758, 460);
            this.Controls.Add(this.dgvMostrarModelos);
            this.Controls.Add(this.lblModelos);
            this.Controls.Add(this.txtBoxBuscarPorNombre);
            this.Controls.Add(this.btnBuscarPorNombre);
            this.Controls.Add(this.txtBoxBuscarPorId);
            this.Controls.Add(this.btnBuscarPorId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarModelos";
            this.Text = "Mostrar Modelos";
            this.Load += new System.EventHandler(this.Mostrar_Modelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarModelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxBuscarPorNombre;
        private System.Windows.Forms.Button btnBuscarPorNombre;
        private System.Windows.Forms.TextBox txtBoxBuscarPorId;
        private System.Windows.Forms.Button btnBuscarPorId;
        private System.Windows.Forms.Label lblModelos;
        private System.Windows.Forms.DataGridView dgvMostrarModelos;
    }
}