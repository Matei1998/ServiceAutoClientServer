namespace Client
{
    partial class VizualizareAutentificare
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
            this.txtUserAutentificare = new System.Windows.Forms.TextBox();
            this.txtParolaAutentificare = new System.Windows.Forms.TextBox();
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Romana = new System.Windows.Forms.Button();
            this.Engleza = new System.Windows.Forms.Button();
            this.Italiana = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserAutentificare
            // 
            this.txtUserAutentificare.Location = new System.Drawing.Point(178, 121);
            this.txtUserAutentificare.Name = "txtUserAutentificare";
            this.txtUserAutentificare.Size = new System.Drawing.Size(228, 22);
            this.txtUserAutentificare.TabIndex = 0;
            this.txtUserAutentificare.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtParolaAutentificare
            // 
            this.txtParolaAutentificare.Location = new System.Drawing.Point(178, 199);
            this.txtParolaAutentificare.Name = "txtParolaAutentificare";
            this.txtParolaAutentificare.PasswordChar = '*';
            this.txtParolaAutentificare.Size = new System.Drawing.Size(228, 22);
            this.txtParolaAutentificare.TabIndex = 1;
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.Location = new System.Drawing.Point(511, 143);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(135, 66);
            this.btnAutentificare.TabIndex = 2;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = true;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Utilizator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parola";
            // 
            // Romana
            // 
            this.Romana.Location = new System.Drawing.Point(153, 347);
            this.Romana.Name = "Romana";
            this.Romana.Size = new System.Drawing.Size(102, 63);
            this.Romana.TabIndex = 5;
            this.Romana.Text = "Romana";
            this.Romana.UseVisualStyleBackColor = true;
            this.Romana.Click += new System.EventHandler(this.Romana_Click);
            // 
            // Engleza
            // 
            this.Engleza.Location = new System.Drawing.Point(312, 347);
            this.Engleza.Name = "Engleza";
            this.Engleza.Size = new System.Drawing.Size(94, 63);
            this.Engleza.TabIndex = 6;
            this.Engleza.Text = "Engleza";
            this.Engleza.UseVisualStyleBackColor = true;
            this.Engleza.Click += new System.EventHandler(this.Engleza_Click);
            // 
            // Italiana
            // 
            this.Italiana.Location = new System.Drawing.Point(456, 347);
            this.Italiana.Name = "Italiana";
            this.Italiana.Size = new System.Drawing.Size(92, 63);
            this.Italiana.TabIndex = 7;
            this.Italiana.Text = "Italiana";
            this.Italiana.UseVisualStyleBackColor = true;
            this.Italiana.Click += new System.EventHandler(this.Italiana_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Limba";
            // 
            // VizualizareAutentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 531);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Italiana);
            this.Controls.Add(this.Engleza);
            this.Controls.Add(this.Romana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.txtParolaAutentificare);
            this.Controls.Add(this.txtUserAutentificare);
            this.Name = "VizualizareAutentificare";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserAutentificare;
        private System.Windows.Forms.TextBox txtParolaAutentificare;
        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Romana;
        private System.Windows.Forms.Button Engleza;
        private System.Windows.Forms.Button Italiana;
        private System.Windows.Forms.Label label4;
    }
}

