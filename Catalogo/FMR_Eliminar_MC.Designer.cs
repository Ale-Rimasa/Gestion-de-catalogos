namespace Catalogo
{
    partial class FMR_Eliminar_MC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMR_Eliminar_MC));
            this.BTNBack = new System.Windows.Forms.Button();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.TB_ingresar_MC = new System.Windows.Forms.TextBox();
            this.GB_MC = new System.Windows.Forms.GroupBox();
            this.RD_Categoria = new System.Windows.Forms.RadioButton();
            this.RD_marca = new System.Windows.Forms.RadioButton();
            this.GB_MC.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNBack
            // 
            this.BTNBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTNBack.Image = ((System.Drawing.Image)(resources.GetObject("BTNBack.Image")));
            this.BTNBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBack.Location = new System.Drawing.Point(236, 145);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(78, 25);
            this.BTNBack.TabIndex = 22;
            this.BTNBack.Text = "Volver";
            this.BTNBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.Location = new System.Drawing.Point(12, 145);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(88, 23);
            this.BTNDELETE.TabIndex = 21;
            this.BTNDELETE.Text = "ELIMINAR";
            this.BTNDELETE.UseVisualStyleBackColor = true;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // TB_ingresar_MC
            // 
            this.TB_ingresar_MC.Location = new System.Drawing.Point(12, 91);
            this.TB_ingresar_MC.Name = "TB_ingresar_MC";
            this.TB_ingresar_MC.Size = new System.Drawing.Size(296, 20);
            this.TB_ingresar_MC.TabIndex = 20;
            // 
            // GB_MC
            // 
            this.GB_MC.Controls.Add(this.RD_Categoria);
            this.GB_MC.Controls.Add(this.RD_marca);
            this.GB_MC.Location = new System.Drawing.Point(12, 12);
            this.GB_MC.Name = "GB_MC";
            this.GB_MC.Size = new System.Drawing.Size(296, 51);
            this.GB_MC.TabIndex = 19;
            this.GB_MC.TabStop = false;
            this.GB_MC.Text = "Seleccione";
            // 
            // RD_Categoria
            // 
            this.RD_Categoria.AutoSize = true;
            this.RD_Categoria.Location = new System.Drawing.Point(159, 19);
            this.RD_Categoria.Name = "RD_Categoria";
            this.RD_Categoria.Size = new System.Drawing.Size(87, 17);
            this.RD_Categoria.TabIndex = 1;
            this.RD_Categoria.TabStop = true;
            this.RD_Categoria.Text = "CATEGORIA";
            this.RD_Categoria.UseVisualStyleBackColor = true;
            // 
            // RD_marca
            // 
            this.RD_marca.AutoSize = true;
            this.RD_marca.Checked = true;
            this.RD_marca.Location = new System.Drawing.Point(25, 19);
            this.RD_marca.Name = "RD_marca";
            this.RD_marca.Size = new System.Drawing.Size(63, 17);
            this.RD_marca.TabIndex = 0;
            this.RD_marca.TabStop = true;
            this.RD_marca.Text = "MARCA";
            this.RD_marca.UseVisualStyleBackColor = true;
            // 
            // FMR_Eliminar_MC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(329, 201);
            this.Controls.Add(this.BTNBack);
            this.Controls.Add(this.BTNDELETE);
            this.Controls.Add(this.TB_ingresar_MC);
            this.Controls.Add(this.GB_MC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMR_Eliminar_MC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELIMINAR MARCA O CATEGORIA";
            this.GB_MC.ResumeLayout(false);
            this.GB_MC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNBack;
        public System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.TextBox TB_ingresar_MC;
        private System.Windows.Forms.GroupBox GB_MC;
        private System.Windows.Forms.RadioButton RD_Categoria;
        private System.Windows.Forms.RadioButton RD_marca;
    }
}