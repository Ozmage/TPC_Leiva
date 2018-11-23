namespace Presentacion
{
    partial class frmMostrarMarcas
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
            this.dgvMostrarMarcas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarMarcas
            // 
            this.dgvMostrarMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMostrarMarcas.Location = new System.Drawing.Point(130, 117);
            this.dgvMostrarMarcas.MultiSelect = false;
            this.dgvMostrarMarcas.Name = "dgvMostrarMarcas";
            this.dgvMostrarMarcas.Size = new System.Drawing.Size(541, 217);
            this.dgvMostrarMarcas.TabIndex = 0;
            this.dgvMostrarMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarMarcas_CellContentClick);
            // 
            // frmMostrarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMostrarMarcas);
            this.Name = "frmMostrarMarcas";
            this.Text = "frmMostrarMarcas";
            this.Load += new System.EventHandler(this.frmMostrarMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarMarcas;
    }
}