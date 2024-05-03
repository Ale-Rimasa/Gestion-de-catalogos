namespace Catalogo
{
    partial class FMRArticulo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMRArticulo));
            this.LBLNombre = new System.Windows.Forms.Label();
            this.LBLID = new System.Windows.Forms.Label();
            this.LBLDescripcion = new System.Windows.Forms.Label();
            this.LBLMarca = new System.Windows.Forms.Label();
            this.LBLCategoria = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LblUrl = new System.Windows.Forms.Label();
            this.TXTBNombre = new System.Windows.Forms.TextBox();
            this.TXTBDescripcion = new System.Windows.Forms.TextBox();
            this.TXTBPrecio = new System.Windows.Forms.TextBox();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNBack = new System.Windows.Forms.Button();
            this.TXTBID = new System.Windows.Forms.TextBox();
            this.txtbUrlImagen = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.ErrorProvCargaArticulo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvCargaArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLNombre
            // 
            this.LBLNombre.AutoSize = true;
            this.LBLNombre.Location = new System.Drawing.Point(85, 86);
            this.LBLNombre.Name = "LBLNombre";
            this.LBLNombre.Size = new System.Drawing.Size(62, 15);
            this.LBLNombre.TabIndex = 10;
            this.LBLNombre.Text = "Nombre:";
            // 
            // LBLID
            // 
            this.LBLID.AutoSize = true;
            this.LBLID.Location = new System.Drawing.Point(85, 48);
            this.LBLID.Name = "LBLID";
            this.LBLID.Size = new System.Drawing.Size(60, 15);
            this.LBLID.TabIndex = 9;
            this.LBLID.Text = "Codigo :";
            // 
            // LBLDescripcion
            // 
            this.LBLDescripcion.AutoSize = true;
            this.LBLDescripcion.Location = new System.Drawing.Point(85, 123);
            this.LBLDescripcion.Name = "LBLDescripcion";
            this.LBLDescripcion.Size = new System.Drawing.Size(87, 15);
            this.LBLDescripcion.TabIndex = 11;
            this.LBLDescripcion.Text = "Descripcion:";
            // 
            // LBLMarca
            // 
            this.LBLMarca.AutoSize = true;
            this.LBLMarca.Location = new System.Drawing.Point(85, 165);
            this.LBLMarca.Name = "LBLMarca";
            this.LBLMarca.Size = new System.Drawing.Size(51, 15);
            this.LBLMarca.TabIndex = 12;
            this.LBLMarca.Text = "Marca:";
            // 
            // LBLCategoria
            // 
            this.LBLCategoria.AutoSize = true;
            this.LBLCategoria.Location = new System.Drawing.Point(85, 199);
            this.LBLCategoria.Name = "LBLCategoria";
            this.LBLCategoria.Size = new System.Drawing.Size(73, 15);
            this.LBLCategoria.TabIndex = 13;
            this.LBLCategoria.Text = "Categoria:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(120, 120);
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(85, 243);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(52, 15);
            this.LblUrl.TabIndex = 14;
            this.LblUrl.Text = "Precio:";
            this.LblUrl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TXTBNombre
            // 
            this.TXTBNombre.AcceptsReturn = true;
            this.TXTBNombre.AcceptsTab = true;
            this.TXTBNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBNombre.Location = new System.Drawing.Point(179, 83);
            this.TXTBNombre.MaximumSize = new System.Drawing.Size(565, 21);
            this.TXTBNombre.MinimumSize = new System.Drawing.Size(237, 21);
            this.TXTBNombre.Name = "TXTBNombre";
            this.TXTBNombre.Size = new System.Drawing.Size(237, 21);
            this.TXTBNombre.TabIndex = 1;
            // 
            // TXTBDescripcion
            // 
            this.TXTBDescripcion.AcceptsReturn = true;
            this.TXTBDescripcion.AcceptsTab = true;
            this.TXTBDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBDescripcion.Location = new System.Drawing.Point(179, 123);
            this.TXTBDescripcion.MaximumSize = new System.Drawing.Size(565, 21);
            this.TXTBDescripcion.MinimumSize = new System.Drawing.Size(237, 21);
            this.TXTBDescripcion.Name = "TXTBDescripcion";
            this.TXTBDescripcion.Size = new System.Drawing.Size(237, 21);
            this.TXTBDescripcion.TabIndex = 2;
            // 
            // TXTBPrecio
            // 
            this.TXTBPrecio.AcceptsReturn = true;
            this.TXTBPrecio.AcceptsTab = true;
            this.TXTBPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBPrecio.Location = new System.Drawing.Point(179, 240);
            this.TXTBPrecio.MaximumSize = new System.Drawing.Size(565, 21);
            this.TXTBPrecio.MinimumSize = new System.Drawing.Size(237, 21);
            this.TXTBPrecio.Name = "TXTBPrecio";
            this.TXTBPrecio.Size = new System.Drawing.Size(237, 21);
            this.TXTBPrecio.TabIndex = 5;
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(215, 325);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(167, 23);
            this.BTNAdd.TabIndex = 7;
            this.BTNAdd.Text = "Agregar";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click_1);
            // 
            // BTNBack
            // 
            this.BTNBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTNBack.Image = ((System.Drawing.Image)(resources.GetObject("BTNBack.Image")));
            this.BTNBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBack.Location = new System.Drawing.Point(437, 381);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(78, 25);
            this.BTNBack.TabIndex = 8;
            this.BTNBack.Text = "Volver";
            this.BTNBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // TXTBID
            // 
            this.TXTBID.AcceptsReturn = true;
            this.TXTBID.AcceptsTab = true;
            this.TXTBID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBID.Location = new System.Drawing.Point(179, 48);
            this.TXTBID.MaximumSize = new System.Drawing.Size(565, 21);
            this.TXTBID.MinimumSize = new System.Drawing.Size(237, 21);
            this.TXTBID.Name = "TXTBID";
            this.TXTBID.Size = new System.Drawing.Size(237, 21);
            this.TXTBID.TabIndex = 0;
            // 
            // txtbUrlImagen
            // 
            this.txtbUrlImagen.AcceptsReturn = true;
            this.txtbUrlImagen.AcceptsTab = true;
            this.txtbUrlImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbUrlImagen.Location = new System.Drawing.Point(179, 278);
            this.txtbUrlImagen.MaximumSize = new System.Drawing.Size(565, 21);
            this.txtbUrlImagen.MinimumSize = new System.Drawing.Size(237, 21);
            this.txtbUrlImagen.Name = "txtbUrlImagen";
            this.txtbUrlImagen.Size = new System.Drawing.Size(237, 21);
            this.txtbUrlImagen.TabIndex = 6;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(85, 284);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(78, 15);
            this.lblUrlImagen.TabIndex = 15;
            this.lblUrlImagen.Text = "Urlimagen:";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(179, 165);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(237, 23);
            this.cboMarca.TabIndex = 3;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(179, 199);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(237, 23);
            this.cboCategoria.TabIndex = 4;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // ErrorProvCargaArticulo
            // 
            this.ErrorProvCargaArticulo.ContainerControl = this;
            // 
            // FMRArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(527, 418);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.txtbUrlImagen);
            this.Controls.Add(this.BTNBack);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.TXTBPrecio);
            this.Controls.Add(this.TXTBDescripcion);
            this.Controls.Add(this.TXTBNombre);
            this.Controls.Add(this.TXTBID);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.LBLCategoria);
            this.Controls.Add(this.LBLMarca);
            this.Controls.Add(this.LBLDescripcion);
            this.Controls.Add(this.LBLID);
            this.Controls.Add(this.LBLNombre);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(543, 457);
            this.Name = "FMRArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.FMRArticulo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvCargaArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNombre;
        private System.Windows.Forms.Label LBLID;
        private System.Windows.Forms.Label LBLDescripcion;
        private System.Windows.Forms.Label LBLMarca;
        private System.Windows.Forms.Label LBLCategoria;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.TextBox TXTBNombre;
        private System.Windows.Forms.TextBox TXTBDescripcion;
        private System.Windows.Forms.TextBox TXTBPrecio;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.Button BTNBack;
        private System.Windows.Forms.TextBox TXTBID;
        private System.Windows.Forms.TextBox txtbUrlImagen;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ErrorProvider ErrorProvCargaArticulo;
    }
}