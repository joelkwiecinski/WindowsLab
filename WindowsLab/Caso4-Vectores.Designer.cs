namespace WindowsLab
{
    partial class Form10
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
            this.btnCargarPersonas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarPersonas
            // 
            this.btnCargarPersonas.Location = new System.Drawing.Point(130, 87);
            this.btnCargarPersonas.Name = "btnCargarPersonas";
            this.btnCargarPersonas.Size = new System.Drawing.Size(310, 68);
            this.btnCargarPersonas.TabIndex = 0;
            this.btnCargarPersonas.Text = "Cargar datos de personas";
            this.btnCargarPersonas.UseVisualStyleBackColor = true;
            this.btnCargarPersonas.Click += new System.EventHandler(this.btnCargarPersonas_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 243);
            this.Controls.Add(this.btnCargarPersonas);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarPersonas;
    }
}