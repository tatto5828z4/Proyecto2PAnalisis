namespace NavegadorG13
{
    partial class Frm2
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblCM = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaP = new System.Windows.Forms.Label();
            this.lblNP = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCodigoMarca = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.cbxCodMarca = new System.Windows.Forms.ComboBox();
            this.dtProducto = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.navegador1 = new NavegadorPrototipo.navegador();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(14, 148);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Tag = "idProducto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(14, 261);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Tag = "nombre";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(14, 129);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(86, 13);
            this.lblCP.TabIndex = 3;
            this.lblCP.Text = "Codigo Producto";
            // 
            // lblCM
            // 
            this.lblCM.AutoSize = true;
            this.lblCM.Location = new System.Drawing.Point(14, 192);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(90, 13);
            this.lblCM.TabIndex = 4;
            this.lblCM.Text = "Codigo De Marca";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(11, 331);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(109, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripcion Producto";
            // 
            // lblFechaP
            // 
            this.lblFechaP.AutoSize = true;
            this.lblFechaP.Location = new System.Drawing.Point(11, 286);
            this.lblFechaP.Name = "lblFechaP";
            this.lblFechaP.Size = new System.Drawing.Size(83, 13);
            this.lblFechaP.TabIndex = 7;
            this.lblFechaP.Text = "Fecha Producto";
            // 
            // lblNP
            // 
            this.lblNP.AutoSize = true;
            this.lblNP.Location = new System.Drawing.Point(11, 245);
            this.lblNP.Name = "lblNP";
            this.lblNP.Size = new System.Drawing.Size(90, 13);
            this.lblNP.TabIndex = 8;
            this.lblNP.Text = "Nombre Producto";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(267, 249);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(88, 13);
            this.lblEstatus.TabIndex = 9;
            this.lblEstatus.Text = "Estatus Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(267, 196);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(83, 13);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio Producto";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(267, 133);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(81, 13);
            this.lblStock.TabIndex = 11;
            this.lblStock.Text = "Stock Producto";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(14, 347);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 12;
            this.txtDescripcion.Tag = "descripcion";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(270, 149);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 13;
            this.txtStock.Tag = "stock";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(270, 212);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 14;
            this.txtPrecio.Tag = "precio";
            // 
            // txtCodigoMarca
            // 
            this.txtCodigoMarca.Location = new System.Drawing.Point(150, 207);
            this.txtCodigoMarca.Name = "txtCodigoMarca";
            this.txtCodigoMarca.Size = new System.Drawing.Size(27, 20);
            this.txtCodigoMarca.TabIndex = 16;
            this.txtCodigoMarca.Tag = "idMarca";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(146, 301);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(118, 20);
            this.txtFecha.TabIndex = 17;
            this.txtFecha.Tag = "fecha";
            // 
            // cbxCodMarca
            // 
            this.cbxCodMarca.FormattingEnabled = true;
            this.cbxCodMarca.Location = new System.Drawing.Point(14, 208);
            this.cbxCodMarca.Name = "cbxCodMarca";
            this.cbxCodMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxCodMarca.TabIndex = 18;
            // 
            // dtProducto
            // 
            this.dtProducto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtProducto.Location = new System.Drawing.Point(14, 302);
            this.dtProducto.Name = "dtProducto";
            this.dtProducto.Size = new System.Drawing.Size(121, 20);
            this.dtProducto.TabIndex = 19;
            this.dtProducto.Value = new System.DateTime(2021, 9, 11, 0, 0, 0, 0);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(270, 268);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Activo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(386, 265);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(27, 20);
            this.txtEstatus.TabIndex = 21;
            this.txtEstatus.Tag = "estado";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(270, 286);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Inactivo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(170)))), ((int)(((byte)(146)))));
            this.navegador1.Location = new System.Drawing.Point(0, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(981, 85);
            this.navegador1.TabIndex = 23;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(263, 351);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 23);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "PruebaFecha";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dtProducto);
            this.Controls.Add(this.cbxCodMarca);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCodigoMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.lblNP);
            this.Controls.Add(this.lblFechaP);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCM);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblCM;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaP;
        private System.Windows.Forms.Label lblNP;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCodigoMarca;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ComboBox cbxCodMarca;
        private System.Windows.Forms.DateTimePicker dtProducto;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.RadioButton radioButton2;
        private NavegadorPrototipo.navegador navegador1;
        private System.Windows.Forms.Button btnGuardar;
    }
}