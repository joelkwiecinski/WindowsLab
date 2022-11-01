namespace WindowsLab
{
    partial class Form9
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
            this.btnCargarSueldos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarSueldos
            // 
            this.btnCargarSueldos.Location = new System.Drawing.Point(169, 83);
            this.btnCargarSueldos.Name = "btnCargarSueldos";
            this.btnCargarSueldos.Size = new System.Drawing.Size(393, 65);
            this.btnCargarSueldos.TabIndex = 0;
            this.btnCargarSueldos.Text = "Cargar ingresos de sueldo";
            this.btnCargarSueldos.UseVisualStyleBackColor = true;
            this.btnCargarSueldos.Click += new System.EventHandler(this.btnCargarSueldos_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 231);
            this.Controls.Add(this.btnCargarSueldos);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarSueldos;
    }
}