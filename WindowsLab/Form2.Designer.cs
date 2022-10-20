namespace WindowsLab
{
    partial class Form2
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
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnChequear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa tu edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(307, 61);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(187, 29);
            this.txtEdad.TabIndex = 1;
            // 
            // btnChequear
            // 
            this.btnChequear.Location = new System.Drawing.Point(334, 105);
            this.btnChequear.Name = "btnChequear";
            this.btnChequear.Size = new System.Drawing.Size(133, 54);
            this.btnChequear.TabIndex = 2;
            this.btnChequear.Text = "Chequear";
            this.btnChequear.UseVisualStyleBackColor = true;
            this.btnChequear.Click += new System.EventHandler(this.btnChequear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 187);
            this.Controls.Add(this.btnChequear);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Chequeo de edad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnChequear;
    }
}