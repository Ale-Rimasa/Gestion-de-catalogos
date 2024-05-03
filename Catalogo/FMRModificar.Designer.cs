namespace Catalogo
{
    partial class FMRModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMRModificar));
            this.BTNBack = new System.Windows.Forms.Button();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.TxtURL = new System.Windows.Forms.TextBox();
            this.TXTBDescripcion = new System.Windows.Forms.TextBox();
            this.TXTCodigo = new System.Windows.Forms.TextBox();
            this.LBLCategoria = new System.Windows.Forms.Label();
            this.LBLMarca = new System.Windows.Forms.Label();
            this.LBLDescripcion = new System.Windows.Forms.Label();
            this.LBLNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNBuscarModificar = new System.Windows.Forms.Button();
            this.LBLID = new System.Windows.Forms.Label();
            this.cbBoxBuscar = new System.Windows.Forms.ComboBox();
            this.cboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.BTNSearc = new System.Windows.Forms.Button();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.CboMarca = new System.Windows.Forms.ComboBox();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.ErrorProvBuscar = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProvCboNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProvCod = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProvCodDescrip = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProvCboCat = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProvPrecio = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProvUrl = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProvMarca = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvCboNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvCodDescrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvCboCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNBack
            // 
            this.BTNBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTNBack.Image = ((System.Drawing.Image)(resources.GetObject("BTNBack.Image")));
            this.BTNBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBack.Location = new System.Drawing.Point(388, 398);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(78, 25);
            this.BTNBack.TabIndex = 30;
            this.BTNBack.Text = "Volver";
            this.BTNBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // BTNModificar
            // 
            this.BTNModificar.Location = new System.Drawing.Point(128, 305);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(167, 20);
            this.BTNModificar.TabIndex = 17;
            this.BTNModificar.Text = "Modificar";
            this.BTNModificar.UseVisualStyleBackColor = true;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // TxtURL
            // 
            this.TxtURL.AcceptsReturn = true;
            this.TxtURL.AcceptsTab = true;
            this.TxtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtURL.Location = new System.Drawing.Point(104, 259);
            this.TxtURL.MaximumSize = new System.Drawing.Size(565, 21);
            this.TxtURL.MinimumSize = new System.Drawing.Size(237, 21);
            this.TxtURL.Name = "TxtURL";
            this.TxtURL.Size = new System.Drawing.Size(253, 20);
            this.TxtURL.TabIndex = 15;
            // 
            // TXTBDescripcion
            // 
            this.TXTBDescripcion.AcceptsReturn = true;
            this.TXTBDescripcion.AcceptsTab = true;
            this.TXTBDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBDescripcion.Location = new System.Drawing.Point(104, 117);
            this.TXTBDescripcion.MaximumSize = new System.Drawing.Size(565, 21);
            this.TXTBDescripcion.MinimumSize = new System.Drawing.Size(237, 21);
            this.TXTBDescripcion.Name = "TXTBDescripcion";
            this.TXTBDescripcion.Size = new System.Drawing.Size(253, 20);
            this.TXTBDescripcion.TabIndex = 7;
            // 
            // TXTCodigo
            // 
            this.TXTCodigo.AcceptsReturn = true;
            this.TXTCodigo.AcceptsTab = true;
            this.TXTCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTCodigo.Location = new System.Drawing.Point(104, 81);
            this.TXTCodigo.MaximumSize = new System.Drawing.Size(565, 21);
            this.TXTCodigo.MinimumSize = new System.Drawing.Size(237, 21);
            this.TXTCodigo.Name = "TXTCodigo";
            this.TXTCodigo.Size = new System.Drawing.Size(253, 20);
            this.TXTCodigo.TabIndex = 5;
            // 
            // LBLCategoria
            // 
            this.LBLCategoria.AutoSize = true;
            this.LBLCategoria.Location = new System.Drawing.Point(14, 192);
            this.LBLCategoria.Name = "LBLCategoria";
            this.LBLCategoria.Size = new System.Drawing.Size(55, 13);
            this.LBLCategoria.TabIndex = 10;
            this.LBLCategoria.Text = "Categoria:";
            // 
            // LBLMarca
            // 
            this.LBLMarca.AutoSize = true;
            this.LBLMarca.Location = new System.Drawing.Point(14, 156);
            this.LBLMarca.Name = "LBLMarca";
            this.LBLMarca.Size = new System.Drawing.Size(40, 13);
            this.LBLMarca.TabIndex = 8;
            this.LBLMarca.Text = "Marca:";
            // 
            // LBLDescripcion
            // 
            this.LBLDescripcion.AutoSize = true;
            this.LBLDescripcion.Location = new System.Drawing.Point(14, 120);
            this.LBLDescripcion.Name = "LBLDescripcion";
            this.LBLDescripcion.Size = new System.Drawing.Size(66, 13);
            this.LBLDescripcion.TabIndex = 6;
            this.LBLDescripcion.Text = "Descripcion:";
            // 
            // LBLNombre
            // 
            this.LBLNombre.AutoSize = true;
            this.LBLNombre.Location = new System.Drawing.Point(14, 48);
            this.LBLNombre.Name = "LBLNombre";
            this.LBLNombre.Size = new System.Drawing.Size(47, 13);
            this.LBLNombre.TabIndex = 2;
            this.LBLNombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "URL Imagen:";
            // 
            // BTNBuscarModificar
            // 
            this.BTNBuscarModificar.Location = new System.Drawing.Point(358, 16);
            this.BTNBuscarModificar.Name = "BTNBuscarModificar";
            this.BTNBuscarModificar.Size = new System.Drawing.Size(86, 23);
            this.BTNBuscarModificar.TabIndex = 32;
            this.BTNBuscarModificar.Text = "Buscar";
            this.BTNBuscarModificar.UseVisualStyleBackColor = true;
            // 
            // LBLID
            // 
            this.LBLID.AutoSize = true;
            this.LBLID.Location = new System.Drawing.Point(13, 84);
            this.LBLID.Name = "LBLID";
            this.LBLID.Size = new System.Drawing.Size(46, 13);
            this.LBLID.TabIndex = 4;
            this.LBLID.Text = "Codigo :";
            // 
            // cbBoxBuscar
            // 
            this.cbBoxBuscar.FormattingEnabled = true;
            this.cbBoxBuscar.Location = new System.Drawing.Point(98, 14);
            this.cbBoxBuscar.Name = "cbBoxBuscar";
            this.cbBoxBuscar.Size = new System.Drawing.Size(253, 21);
            this.cbBoxBuscar.TabIndex = 34;
            // 
            // cboBoxBusqueda
            // 
            this.cboBoxBusqueda.FormattingEnabled = true;
            this.cboBoxBusqueda.Location = new System.Drawing.Point(104, 45);
            this.cboBoxBusqueda.Name = "cboBoxBusqueda";
            this.cboBoxBusqueda.Size = new System.Drawing.Size(253, 21);
            this.cboBoxBusqueda.TabIndex = 3;
            this.cboBoxBusqueda.SelectedIndexChanged += new System.EventHandler(this.cboSeleccionado);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = " buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(104, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(253, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // BTNSearc
            // 
            this.BTNSearc.Location = new System.Drawing.Point(391, 10);
            this.BTNSearc.Name = "BTNSearc";
            this.BTNSearc.Size = new System.Drawing.Size(75, 23);
            this.BTNSearc.TabIndex = 16;
            this.BTNSearc.Text = "Buscar";
            this.BTNSearc.UseVisualStyleBackColor = true;
            this.BTNSearc.Click += new System.EventHandler(this.BuscarAmodificar);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(104, 225);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(253, 20);
            this.TxtPrecio.TabIndex = 13;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(14, 228);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(40, 13);
            this.LblPrecio.TabIndex = 12;
            this.LblPrecio.Text = "Precio:";
            // 
            // CboMarca
            // 
            this.CboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMarca.FormattingEnabled = true;
            this.CboMarca.Location = new System.Drawing.Point(104, 153);
            this.CboMarca.Name = "CboMarca";
            this.CboMarca.Size = new System.Drawing.Size(253, 21);
            this.CboMarca.TabIndex = 9;
            this.CboMarca.SelectedIndexChanged += new System.EventHandler(this.SeleccionMarca);
            // 
            // CboCategoria
            // 
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(104, 189);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(253, 21);
            this.CboCategoria.TabIndex = 11;
            this.CboCategoria.SelectedIndexChanged += new System.EventHandler(this.SeleccionCategoria);
            // 
            // ErrorProvBuscar
            // 
            this.ErrorProvBuscar.ContainerControl = this;
            // 
            // ErrorProvCboNombre
            // 
            this.ErrorProvCboNombre.ContainerControl = this;
            // 
            // ErrorProvCod
            // 
            this.ErrorProvCod.ContainerControl = this;
            // 
            // ErrorProvCodDescrip
            // 
            this.ErrorProvCodDescrip.ContainerControl = this;
            // 
            // ErrorProvCboCat
            // 
            this.ErrorProvCboCat.ContainerControl = this;
            // 
            // ErrorProvPrecio
            // 
            this.ErrorProvPrecio.ContainerControl = this;
            // 
            // ErrorProvUrl
            // 
            this.ErrorProvUrl.ContainerControl = this;
            // 
            // ErrorProvMarca
            // 
            this.ErrorProvMarca.ContainerControl = this;
            // 
            // FMRModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 435);
            this.Controls.Add(this.CboCategoria);
            this.Controls.Add(this.CboMarca);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.BTNSearc);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboBoxBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNBack);
            this.Controls.Add(this.BTNModificar);
            this.Controls.Add(this.TxtURL);
            this.Controls.Add(this.TXTBDescripcion);
            this.Controls.Add(this.TXTCodigo);
            this.Controls.Add(this.LBLCategoria);
            this.Controls.Add(this.LBLMarca);
            this.Controls.Add(this.LBLDescripcion);
            this.Controls.Add(this.LBLID);
            this.Controls.Add(this.LBLNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(478, 388);
            this.Name = "FMRModificar";
            this.Text = "FMRModificar";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvCboNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvCodDescrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvCboCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNBack;
        private System.Windows.Forms.Button BTNModificar;
        private System.Windows.Forms.TextBox TxtURL;
        private System.Windows.Forms.TextBox TXTBDescripcion;
        private System.Windows.Forms.TextBox TXTCodigo;
        private System.Windows.Forms.Label LBLCategoria;
        private System.Windows.Forms.Label LBLMarca;
        private System.Windows.Forms.Label LBLDescripcion;
        private System.Windows.Forms.Label LBLNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNBuscarModificar;
        
        private System.Windows.Forms.Label LBLID;
        private System.Windows.Forms.ComboBox cbBoxBuscar;
        private System.Windows.Forms.ComboBox cboBoxBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button BTNSearc;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.ComboBox CboMarca;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.ErrorProvider ErrorProvBuscar;
        private System.Windows.Forms.ErrorProvider ErrorProvCboNombre;
        private System.Windows.Forms.ErrorProvider ErrorProvCod;
        private System.Windows.Forms.ErrorProvider ErrorProvCodDescrip;
        private System.Windows.Forms.ErrorProvider ErrorProvCboCat;
        private System.Windows.Forms.ErrorProvider ErrorProvPrecio;
        private System.Windows.Forms.ErrorProvider ErrorProvUrl;
        private System.Windows.Forms.ErrorProvider ErrorProvMarca;
    }
}