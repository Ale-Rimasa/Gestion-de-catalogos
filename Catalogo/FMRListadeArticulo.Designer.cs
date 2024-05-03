namespace Catalogo
{
    partial class FMRListadeArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMRListadeArticulo));
            this.DGVArticulosLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticulosLista)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVArticulosLista
            // 
            this.DGVArticulosLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVArticulosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVArticulosLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVArticulosLista.Location = new System.Drawing.Point(12, 12);
            this.DGVArticulosLista.MultiSelect = false;
            this.DGVArticulosLista.Name = "DGVArticulosLista";
            this.DGVArticulosLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVArticulosLista.Size = new System.Drawing.Size(714, 429);
            this.DGVArticulosLista.TabIndex = 0;
            this.DGVArticulosLista.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVArticulosLista_CellMouseClick);
            // 
            // FMRListadeArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(738, 453);
            this.Controls.Add(this.DGVArticulosLista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(754, 492);
            this.Name = "FMRListadeArticulo";
            this.Text = "FMRListadeArticulo";
            this.Load += new System.EventHandler(this.FMRListadeArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticulosLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVArticulosLista;
    }
}