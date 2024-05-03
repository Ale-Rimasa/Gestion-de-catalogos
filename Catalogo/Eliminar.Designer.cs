namespace Catalogo
{
    partial class Eliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminar));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listSeleccion = new System.Windows.Forms.ListBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BTNBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(83, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ingrese el nombre del articulo";
           
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(177, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listSeleccion
            // 
            this.listSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold);
            this.listSeleccion.FormattingEnabled = true;
            this.listSeleccion.Location = new System.Drawing.Point(48, 132);
            this.listSeleccion.Name = "listSeleccion";
            this.listSeleccion.Size = new System.Drawing.Size(252, 134);
            this.listSeleccion.TabIndex = 3;
            this.listSeleccion.SelectedIndexChanged += new System.EventHandler(this.listSeleccion_SelectedIndexChanged);
            // 
            // txtEliminar
            // 
            this.txtEliminar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEliminar.Location = new System.Drawing.Point(58, 58);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(232, 20);
            this.txtEliminar.TabIndex = 4;

           
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeleccionado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold);
            this.lblSeleccionado.Location = new System.Drawing.Point(34, 288);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(280, 23);
            this.lblSeleccionado.TabIndex = 5;
            this.lblSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(34, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTNBack
            // 
            this.BTNBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTNBack.Image = ((System.Drawing.Image)(resources.GetObject("BTNBack.Image")));
            this.BTNBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBack.Location = new System.Drawing.Point(261, 318);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(78, 25);
            this.BTNBack.TabIndex = 17;
            this.BTNBack.Text = "Volver";
            this.BTNBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(351, 356);
            this.Controls.Add(this.BTNBack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.listSeleccion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(367, 395);
            this.MinimumSize = new System.Drawing.Size(367, 395);
            this.Name = "Eliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
        
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listSeleccion;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BTNBack;
    }
}