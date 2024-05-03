namespace Catalogo
{
    partial class FMRBusqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMRBusqueda));
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lbl_busquedad = new System.Windows.Forms.Label();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.LBListaBusqueda = new System.Windows.Forms.ListBox();
            this.cmboxFiltrado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            resources.ApplyResources(this.txtBusqueda, "txtBusqueda");
            this.txtBusqueda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusqueda.Name = "txtBusqueda";
            // 
            // lbl_busquedad
            // 
            resources.ApplyResources(this.lbl_busquedad, "lbl_busquedad");
            this.lbl_busquedad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_busquedad.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_busquedad.Name = "lbl_busquedad";
            // 
            // btnBusqueda
            // 
            resources.ApplyResources(this.btnBusqueda, "btnBusqueda");
            this.btnBusqueda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolver
            // 
            resources.ApplyResources(this.btnVolver, "btnVolver");
            this.btnVolver.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LBListaBusqueda
            // 
            resources.ApplyResources(this.LBListaBusqueda, "LBListaBusqueda");
            this.LBListaBusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.LBListaBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBListaBusqueda.FormattingEnabled = true;
            this.LBListaBusqueda.MultiColumn = true;
            this.LBListaBusqueda.Name = "LBListaBusqueda";
            this.LBListaBusqueda.SelectedIndexChanged += new System.EventHandler(this.LBListaBusqueda_SelectedIndexChanged);
            // 
            // cmboxFiltrado
            // 
            this.cmboxFiltrado.FormattingEnabled = true;
            resources.ApplyResources(this.cmboxFiltrado, "cmboxFiltrado");
            this.cmboxFiltrado.Name = "cmboxFiltrado";
            this.cmboxFiltrado.Click += new System.EventHandler(this.cmboxFiltrado_Click);
            // 
            // FMRBusqueda
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.cmboxFiltrado);
            this.Controls.Add(this.LBListaBusqueda);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.lbl_busquedad);
            this.Controls.Add(this.txtBusqueda);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FMRBusqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lbl_busquedad;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ListBox LBListaBusqueda;
        private System.Windows.Forms.ComboBox cmboxFiltrado;
    }
}