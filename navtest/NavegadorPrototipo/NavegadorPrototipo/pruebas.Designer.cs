
namespace NavegadorPrototipo
{
    partial class pruebas
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
            this.navegador1 = new NavegadorPrototipo.navegador();
            this.dgvPrueba = new System.Windows.Forms.DataGridView();
            this.txtPrueba1 = new System.Windows.Forms.TextBox();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.rdbPrueba = new System.Windows.Forms.RadioButton();
            this.chckBPreubas = new System.Windows.Forms.CheckBox();
            this.cmbBoxPrueba = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrueba)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(170)))), ((int)(((byte)(146)))));
            this.navegador1.Location = new System.Drawing.Point(1, 1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(981, 85);
            this.navegador1.TabIndex = 0;
            // 
            // dgvPrueba
            // 
            this.dgvPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrueba.Location = new System.Drawing.Point(493, 152);
            this.dgvPrueba.Name = "dgvPrueba";
            this.dgvPrueba.ReadOnly = true;
            this.dgvPrueba.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrueba.Size = new System.Drawing.Size(240, 150);
            this.dgvPrueba.TabIndex = 1;
            // 
            // txtPrueba1
            // 
            this.txtPrueba1.Location = new System.Drawing.Point(134, 170);
            this.txtPrueba1.Name = "txtPrueba1";
            this.txtPrueba1.Size = new System.Drawing.Size(100, 20);
            this.txtPrueba1.TabIndex = 2;
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.Location = new System.Drawing.Point(43, 173);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(81, 13);
            this.lblPrueba.TabIndex = 3;
            this.lblPrueba.Text = "label de Prueba";
            // 
            // rdbPrueba
            // 
            this.rdbPrueba.AutoSize = true;
            this.rdbPrueba.Location = new System.Drawing.Point(46, 250);
            this.rdbPrueba.Name = "rdbPrueba";
            this.rdbPrueba.Size = new System.Drawing.Size(64, 17);
            this.rdbPrueba.TabIndex = 4;
            this.rdbPrueba.TabStop = true;
            this.rdbPrueba.Text = "Pruebas";
            this.rdbPrueba.UseVisualStyleBackColor = true;
            // 
            // chckBPreubas
            // 
            this.chckBPreubas.AutoSize = true;
            this.chckBPreubas.Location = new System.Drawing.Point(154, 251);
            this.chckBPreubas.Name = "chckBPreubas";
            this.chckBPreubas.Size = new System.Drawing.Size(74, 17);
            this.chckBPreubas.TabIndex = 5;
            this.chckBPreubas.Text = "Pruebas 2";
            this.chckBPreubas.UseVisualStyleBackColor = true;
            // 
            // cmbBoxPrueba
            // 
            this.cmbBoxPrueba.FormattingEnabled = true;
            this.cmbBoxPrueba.Location = new System.Drawing.Point(134, 303);
            this.cmbBoxPrueba.Name = "cmbBoxPrueba";
            this.cmbBoxPrueba.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxPrueba.TabIndex = 6;
            // 
            // pruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NavegadorPrototipo.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.cmbBoxPrueba);
            this.Controls.Add(this.chckBPreubas);
            this.Controls.Add(this.rdbPrueba);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.txtPrueba1);
            this.Controls.Add(this.dgvPrueba);
            this.Controls.Add(this.navegador1);
            this.Name = "pruebas";
            this.Text = "Prototipo No Funcional - Navegador";
            this.Load += new System.EventHandler(this.pruebas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrueba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private navegador navegador1;
        private System.Windows.Forms.DataGridView dgvPrueba;
        private System.Windows.Forms.TextBox txtPrueba1;
        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.RadioButton rdbPrueba;
        private System.Windows.Forms.CheckBox chckBPreubas;
        private System.Windows.Forms.ComboBox cmbBoxPrueba;
    }
}