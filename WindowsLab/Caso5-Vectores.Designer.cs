namespace WindowsLab
{
    partial class Caso5_Vectores
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
            this.btnIngresarTemperaturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarTemperaturas
            // 
            this.btnIngresarTemperaturas.Location = new System.Drawing.Point(135, 77);
            this.btnIngresarTemperaturas.Name = "btnIngresarTemperaturas";
            this.btnIngresarTemperaturas.Size = new System.Drawing.Size(398, 88);
            this.btnIngresarTemperaturas.TabIndex = 0;
            this.btnIngresarTemperaturas.Text = "Ingresar temperaturas";
            this.btnIngresarTemperaturas.UseVisualStyleBackColor = true;
            this.btnIngresarTemperaturas.Click += new System.EventHandler(this.btnIngresarTemperaturas_Click);
            // 
            // Caso5_Vectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 242);
            this.Controls.Add(this.btnIngresarTemperaturas);
            this.Name = "Caso5_Vectores";
            this.Text = "Caso5_Vectores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarTemperaturas;
    }
}