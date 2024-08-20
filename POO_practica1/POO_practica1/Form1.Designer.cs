namespace POO_practica1
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
            this.btn_llamar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_llamar
            // 
            this.btn_llamar.Location = new System.Drawing.Point(212, 133);
            this.btn_llamar.Name = "btn_llamar";
            this.btn_llamar.Size = new System.Drawing.Size(357, 187);
            this.btn_llamar.TabIndex = 0;
            this.btn_llamar.Text = "LLamar";
            this.btn_llamar.UseVisualStyleBackColor = true;
            this.btn_llamar.Click += new System.EventHandler(this.btn_llamar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_llamar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_llamar;
    }
}

