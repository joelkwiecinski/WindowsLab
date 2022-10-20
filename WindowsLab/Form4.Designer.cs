namespace WindowsLab
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdBtnRectangulo = new System.Windows.Forms.RadioButton();
            this.rdBtnCirculo = new System.Windows.Forms.RadioButton();
            this.rdBtnTrapecio = new System.Windows.Forms.RadioButton();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona la forma para calcular el área";
            // 
            // rdBtnRectangulo
            // 
            this.rdBtnRectangulo.AutoSize = true;
            this.rdBtnRectangulo.Checked = true;
            this.rdBtnRectangulo.Location = new System.Drawing.Point(189, 77);
            this.rdBtnRectangulo.Name = "rdBtnRectangulo";
            this.rdBtnRectangulo.Size = new System.Drawing.Size(135, 29);
            this.rdBtnRectangulo.TabIndex = 1;
            this.rdBtnRectangulo.TabStop = true;
            this.rdBtnRectangulo.Text = "Rectángulo";
            this.rdBtnRectangulo.UseVisualStyleBackColor = true;
            // 
            // rdBtnCirculo
            // 
            this.rdBtnCirculo.AutoSize = true;
            this.rdBtnCirculo.Location = new System.Drawing.Point(360, 77);
            this.rdBtnCirculo.Name = "rdBtnCirculo";
            this.rdBtnCirculo.Size = new System.Drawing.Size(98, 29);
            this.rdBtnCirculo.TabIndex = 2;
            this.rdBtnCirculo.Text = "Círculo";
            this.rdBtnCirculo.UseVisualStyleBackColor = true;
            // 
            // rdBtnTrapecio
            // 
            this.rdBtnTrapecio.AutoSize = true;
            this.rdBtnTrapecio.Location = new System.Drawing.Point(498, 77);
            this.rdBtnTrapecio.Name = "rdBtnTrapecio";
            this.rdBtnTrapecio.Size = new System.Drawing.Size(114, 29);
            this.rdBtnTrapecio.TabIndex = 3;
            this.rdBtnTrapecio.Text = "Trapecio";
            this.rdBtnTrapecio.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(315, 137);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(170, 53);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 215);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.rdBtnTrapecio);
            this.Controls.Add(this.rdBtnCirculo);
            this.Controls.Add(this.rdBtnRectangulo);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Área de forma geométrica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBtnRectangulo;
        private System.Windows.Forms.RadioButton rdBtnCirculo;
        private System.Windows.Forms.RadioButton rdBtnTrapecio;
        private System.Windows.Forms.Button btnContinuar;
    }
}