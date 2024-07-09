namespace Client
{
    partial class VizualizareUtilizatori
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
            this.btnAdaugaU = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnFiltrareRol = new System.Windows.Forms.Button();
            this.txtLegitimatie = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.cmbRolU = new System.Windows.Forms.ComboBox();
            this.cmbFiltrareRol = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parola1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeconectare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugaU
            // 
            this.btnAdaugaU.Location = new System.Drawing.Point(371, 11);
            this.btnAdaugaU.Name = "btnAdaugaU";
            this.btnAdaugaU.Size = new System.Drawing.Size(123, 68);
            this.btnAdaugaU.TabIndex = 0;
            this.btnAdaugaU.Text = "Adauga utilizator";
            this.btnAdaugaU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdaugaU.UseVisualStyleBackColor = true;
            this.btnAdaugaU.Click += new System.EventHandler(this.btnAdaugareU_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(371, 104);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(123, 63);
            this.btnActualizare.TabIndex = 1;
            this.btnActualizare.Text = "Actualizeaza utilizator";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(371, 194);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(123, 72);
            this.btnStergere.TabIndex = 2;
            this.btnStergere.Text = "Sterge utilizator";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(803, 386);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(223, 63);
            this.btnLista.TabIndex = 3;
            this.btnLista.Text = "Afisare Lista Utilizatori";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnFiltrareRol
            // 
            this.btnFiltrareRol.Location = new System.Drawing.Point(632, 577);
            this.btnFiltrareRol.Name = "btnFiltrareRol";
            this.btnFiltrareRol.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrareRol.TabIndex = 4;
            this.btnFiltrareRol.Text = "Filtreaza";
            this.btnFiltrareRol.UseVisualStyleBackColor = true;
            this.btnFiltrareRol.Click += new System.EventHandler(this.btnFiltrareRol_Click);
            // 
            // txtLegitimatie
            // 
            this.txtLegitimatie.Location = new System.Drawing.Point(117, 37);
            this.txtLegitimatie.Name = "txtLegitimatie";
            this.txtLegitimatie.Size = new System.Drawing.Size(189, 22);
            this.txtLegitimatie.TabIndex = 5;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(117, 79);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(188, 22);
            this.txtNume.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(117, 127);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(188, 22);
            this.txtUser.TabIndex = 7;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(117, 170);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(184, 22);
            this.txtParola.TabIndex = 8;
            // 
            // cmbRolU
            // 
            this.cmbRolU.FormattingEnabled = true;
            this.cmbRolU.Items.AddRange(new object[] {
            "",
            "Administrator",
            "Angajat",
            "Manager"});
            this.cmbRolU.Location = new System.Drawing.Point(121, 214);
            this.cmbRolU.Name = "cmbRolU";
            this.cmbRolU.Size = new System.Drawing.Size(184, 24);
            this.cmbRolU.TabIndex = 9;
            this.cmbRolU.SelectedIndexChanged += new System.EventHandler(this.cmbRolU_SelectedIndexChanged);
            // 
            // cmbFiltrareRol
            // 
            this.cmbFiltrareRol.FormattingEnabled = true;
            this.cmbFiltrareRol.Items.AddRange(new object[] {
            "Angajat",
            "Manager",
            "Administrator"});
            this.cmbFiltrareRol.Location = new System.Drawing.Point(605, 532);
            this.cmbFiltrareRol.Name = "cmbFiltrareRol";
            this.cmbFiltrareRol.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltrareRol.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 16);
            this.label15.TabIndex = 11;
            this.label15.Text = "Id";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Parola";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Rol";
            // 
            // label6
            // 
            this.label6.AccessibleDescription = "Filtrare dupa rol";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(616, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Filtrare dupa rol";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id1,
            this.Nume1,
            this.User1,
            this.Parola1,
            this.Rol1});
            this.dataGridView1.Location = new System.Drawing.Point(588, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 341);
            this.dataGridView1.TabIndex = 17;
            // 
            // Id1
            // 
            this.Id1.HeaderText = "Id";
            this.Id1.MinimumWidth = 6;
            this.Id1.Name = "Id1";
            this.Id1.Width = 125;
            // 
            // Nume1
            // 
            this.Nume1.HeaderText = "Nume";
            this.Nume1.MinimumWidth = 6;
            this.Nume1.Name = "Nume1";
            this.Nume1.Width = 125;
            // 
            // User1
            // 
            this.User1.HeaderText = "User";
            this.User1.MinimumWidth = 6;
            this.User1.Name = "User1";
            this.User1.Width = 125;
            // 
            // Parola1
            // 
            this.Parola1.HeaderText = "Parola";
            this.Parola1.MinimumWidth = 6;
            this.Parola1.Name = "Parola1";
            this.Parola1.Width = 125;
            // 
            // Rol1
            // 
            this.Rol1.HeaderText = "Rol";
            this.Rol1.MinimumWidth = 6;
            this.Rol1.Name = "Rol1";
            this.Rol1.Width = 125;
            // 
            // btnDeconectare
            // 
            this.btnDeconectare.Location = new System.Drawing.Point(12, 532);
            this.btnDeconectare.Name = "btnDeconectare";
            this.btnDeconectare.Size = new System.Drawing.Size(190, 84);
            this.btnDeconectare.TabIndex = 18;
            this.btnDeconectare.Text = "Deconectare";
            this.btnDeconectare.UseVisualStyleBackColor = true;
            this.btnDeconectare.Click += new System.EventHandler(this.btnDeconectare_Click);
            // 
            // VizualizareUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 662);
            this.Controls.Add(this.btnDeconectare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbFiltrareRol);
            this.Controls.Add(this.cmbRolU);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtLegitimatie);
            this.Controls.Add(this.btnFiltrareRol);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.btnAdaugaU);
            this.Name = "VizualizareUtilizatori";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VizualizareAdministrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugaU;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnFiltrareRol;
        private System.Windows.Forms.TextBox txtLegitimatie;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.ComboBox cmbRolU;
        private System.Windows.Forms.ComboBox cmbFiltrareRol;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume1;
        private System.Windows.Forms.DataGridViewTextBoxColumn User1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parola1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol1;
        private System.Windows.Forms.Button btnDeconectare;
    }
}