namespace Navegador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dtProducto = new System.Windows.Forms.DateTimePicker();
            this.cbxCodMarca = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCodigoMarca = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblNP = new System.Windows.Forms.Label();
            this.lblFechaP = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCM = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dvgConsulta = new System.Windows.Forms.DataGridView();
            this.navegador1 = new DLL.nav.navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(178, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 23);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "PruebaFecha";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(348, 302);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 45;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Inactivo";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(464, 281);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(27, 20);
            this.txtEstatus.TabIndex = 44;
            this.txtEstatus.Tag = "estado";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(348, 284);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 43;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Activo";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // dtProducto
            // 
            this.dtProducto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtProducto.Location = new System.Drawing.Point(46, 322);
            this.dtProducto.Name = "dtProducto";
            this.dtProducto.Size = new System.Drawing.Size(121, 20);
            this.dtProducto.TabIndex = 42;
            this.dtProducto.Value = new System.DateTime(2021, 9, 11, 0, 0, 0, 0);
            // 
            // cbxCodMarca
            // 
            this.cbxCodMarca.FormattingEnabled = true;
            this.cbxCodMarca.Location = new System.Drawing.Point(46, 228);
            this.cbxCodMarca.Name = "cbxCodMarca";
            this.cbxCodMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxCodMarca.TabIndex = 41;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(178, 321);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(118, 20);
            this.txtFecha.TabIndex = 40;
            this.txtFecha.Tag = "fecha";
            // 
            // txtCodigoMarca
            // 
            this.txtCodigoMarca.Location = new System.Drawing.Point(182, 227);
            this.txtCodigoMarca.Name = "txtCodigoMarca";
            this.txtCodigoMarca.Size = new System.Drawing.Size(27, 20);
            this.txtCodigoMarca.TabIndex = 39;
            this.txtCodigoMarca.Tag = "idMarca";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(348, 228);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 38;
            this.txtPrecio.Tag = "precio";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(348, 165);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 37;
            this.txtStock.Tag = "stock";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(46, 367);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 36;
            this.txtDescripcion.Tag = "descripcion";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(345, 149);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(81, 13);
            this.lblStock.TabIndex = 35;
            this.lblStock.Text = "Stock Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(345, 212);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(83, 13);
            this.lblPrecio.TabIndex = 34;
            this.lblPrecio.Text = "Precio Producto";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(345, 265);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(88, 13);
            this.lblEstatus.TabIndex = 33;
            this.lblEstatus.Text = "Estatus Producto";
            // 
            // lblNP
            // 
            this.lblNP.AutoSize = true;
            this.lblNP.Location = new System.Drawing.Point(43, 265);
            this.lblNP.Name = "lblNP";
            this.lblNP.Size = new System.Drawing.Size(90, 13);
            this.lblNP.TabIndex = 32;
            this.lblNP.Text = "Nombre Producto";
            // 
            // lblFechaP
            // 
            this.lblFechaP.AutoSize = true;
            this.lblFechaP.Location = new System.Drawing.Point(43, 306);
            this.lblFechaP.Name = "lblFechaP";
            this.lblFechaP.Size = new System.Drawing.Size(83, 13);
            this.lblFechaP.TabIndex = 31;
            this.lblFechaP.Text = "Fecha Producto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(43, 351);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(109, 13);
            this.lblDescripcion.TabIndex = 30;
            this.lblDescripcion.Text = "Descripcion Producto";
            // 
            // lblCM
            // 
            this.lblCM.AutoSize = true;
            this.lblCM.Location = new System.Drawing.Point(46, 212);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(90, 13);
            this.lblCM.TabIndex = 29;
            this.lblCM.Text = "Codigo De Marca";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(46, 149);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(86, 13);
            this.lblCP.TabIndex = 28;
            this.lblCP.Text = "Codigo Producto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(46, 281);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 27;
            this.txtNombre.Tag = "nombre";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(46, 168);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 26;
            this.txtID.Tag = "idProducto";
            // 
            // dvgConsulta
            // 
            this.dvgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgConsulta.Location = new System.Drawing.Point(511, 117);
            this.dvgConsulta.Name = "dvgConsulta";
            this.dvgConsulta.ReadOnly = true;
            this.dvgConsulta.RowHeadersWidth = 47;
            this.dvgConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgConsulta.Size = new System.Drawing.Size(650, 342);
            this.dvgConsulta.TabIndex = 48;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(-1, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1191, 87);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1189, 500);
            this.Controls.Add(this.dvgConsulta);
            this.Controls.Add(this.btnGuardar);
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
            this.Controls.Add(this.navegador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Pruebas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker dtProducto;
        private System.Windows.Forms.ComboBox cbxCodMarca;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCodigoMarca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label lblNP;
        private System.Windows.Forms.Label lblFechaP;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCM;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dvgConsulta;
    }
}

