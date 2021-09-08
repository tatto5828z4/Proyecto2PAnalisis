
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
            // pruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NavegadorPrototipo.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.navegador1);
            this.Name = "pruebas";
            this.Text = "Prototipo No Funcional - Navegador";
            this.ResumeLayout(false);

        }

        #endregion

        private navegador navegador1;
    }
}