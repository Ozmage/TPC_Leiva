namespace Presentacion
{
    partial class MostrarVersiones
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
            this.dgvMostrarVersiones = new System.Windows.Forms.DataGridView();
            this.txtBoxBuscarPorNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarPorNombre = new System.Windows.Forms.Button();
            this.txtBoxBuscarPorId = new System.Windows.Forms.TextBox();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.lblVersiones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarVersiones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarVersiones
            // 
            this.dgvMostrarVersiones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvMostrarVersiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMostrarVersiones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMostrarVersiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarVersiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostrarVersiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostrarVersiones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostrarVersiones.EnableHeadersVisualStyles = false;
            this.dgvMostrarVersiones.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMostrarVersiones.Location = new System.Drawing.Point(36, 75);
            this.dgvMostrarVersiones.Name = "dgvMostrarVersiones";
            this.dgvMostrarVersiones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarVersiones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMostrarVersiones.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMostrarVersiones.Size = new System.Drawing.Size(680, 280);
            this.dgvMostrarVersiones.TabIndex = 0;
            this.dgvMostrarVersiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarVersion_CellContentClick);
            // 
            // txtBoxBuscarPorNombre
            // 
            this.txtBoxBuscarPorNombre.Location = new System.Drawing.Point(360, 385);
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
            this.btnBuscarPorNombre.Location = new System.Drawing.Point(235, 384);
            this.btnBuscarPorNombre.Name = "btnBuscarPorNombre";
            this.btnBuscarPorNombre.Size = new System.Drawing.Size(119, 23);
            this.btnBuscarPorNombre.TabIndex = 8;
            this.btnBuscarPorNombre.Text = "Buscar por Nombre";
            this.btnBuscarPorNombre.UseVisualStyleBackColor = false;
            // 
            // txtBoxBuscarPorId
            // 
            this.txtBoxBuscarPorId.Location = new System.Drawing.Point(127, 384);
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
            this.btnBuscarPorId.Location = new System.Drawing.Point(35, 381);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(86, 23);
            this.btnBuscarPorId.TabIndex = 6;
            this.btnBuscarPorId.Text = "Buscar por ID";
            this.btnBuscarPorId.UseVisualStyleBackColor = false;
            // 
            // lblVersiones
            // 
            this.lblVersiones.AutoSize = true;
            this.lblVersiones.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersiones.ForeColor = System.Drawing.Color.White;
            this.lblVersiones.Location = new System.Drawing.Point(32, 40);
            this.lblVersiones.Name = "lblVersiones";
            this.lblVersiones.Size = new System.Drawing.Size(170, 22);
            this.lblVersiones.TabIndex = 11;
            this.lblVersiones.Text = "Lista de Versiones";
            // 
            // MostrarVersiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(758, 460);
            this.Controls.Add(this.lblVersiones);
            this.Controls.Add(this.txtBoxBuscarPorNombre);
            this.Controls.Add(this.btnBuscarPorNombre);
            this.Controls.Add(this.txtBoxBuscarPorId);
            this.Controls.Add(this.btnBuscarPorId);
            this.Controls.Add(this.dgvMostrarVersiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarVersiones";
            this.Text = "MostrarVersiones";
            this.Load += new System.EventHandler(this.MostrarVersiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarVersiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarVersiones;
        private System.Windows.Forms.TextBox txtBoxBuscarPorNombre;
        private System.Windows.Forms.Button btnBuscarPorNombre;
        private System.Windows.Forms.TextBox txtBoxBuscarPorId;
        private System.Windows.Forms.Button btnBuscarPorId;
        private System.Windows.Forms.Label lblVersiones;
    }
}