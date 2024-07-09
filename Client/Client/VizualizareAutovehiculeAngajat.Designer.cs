namespace Client
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProprietar = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCuloare = new System.Windows.Forms.TextBox();
            this.txtCombustibil = new System.Windows.Forms.TextBox();
            this.btnDeconectare = new System.Windows.Forms.Button();
            this.btnFiltrare = new System.Windows.Forms.Button();
            this.btnCautareDupaDenumire = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Proprietar1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Culoare1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combustibil1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCriteriu = new System.Windows.Forms.ComboBox();
            this.txtFiltrare = new System.Windows.Forms.TextBox();
            this.txtCautareMarca = new System.Windows.Forms.TextBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proprietar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Culoare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Combustibil";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Filtreaza";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(867, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cauta dupa marca";
            // 
            // txtProprietar
            // 
            this.txtProprietar.Location = new System.Drawing.Point(137, 56);
            this.txtProprietar.Name = "txtProprietar";
            this.txtProprietar.Size = new System.Drawing.Size(162, 22);
            this.txtProprietar.TabIndex = 6;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(137, 104);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(162, 22);
            this.txtMarca.TabIndex = 7;
            // 
            // txtCuloare
            // 
            this.txtCuloare.Location = new System.Drawing.Point(137, 154);
            this.txtCuloare.Name = "txtCuloare";
            this.txtCuloare.Size = new System.Drawing.Size(162, 22);
            this.txtCuloare.TabIndex = 8;
            // 
            // txtCombustibil
            // 
            this.txtCombustibil.Location = new System.Drawing.Point(137, 206);
            this.txtCombustibil.Name = "txtCombustibil";
            this.txtCombustibil.Size = new System.Drawing.Size(162, 22);
            this.txtCombustibil.TabIndex = 9;
            // 
            // btnDeconectare
            // 
            this.btnDeconectare.Location = new System.Drawing.Point(34, 492);
            this.btnDeconectare.Name = "btnDeconectare";
            this.btnDeconectare.Size = new System.Drawing.Size(200, 79);
            this.btnDeconectare.TabIndex = 10;
            this.btnDeconectare.Text = "Deconectare";
            this.btnDeconectare.UseVisualStyleBackColor = true;
            this.btnDeconectare.Click += new System.EventHandler(this.btnDeconectare_Click);
            // 
            // btnFiltrare
            // 
            this.btnFiltrare.Location = new System.Drawing.Point(538, 514);
            this.btnFiltrare.Name = "btnFiltrare";
            this.btnFiltrare.Size = new System.Drawing.Size(90, 50);
            this.btnFiltrare.TabIndex = 11;
            this.btnFiltrare.Text = "Filtreaza";
            this.btnFiltrare.UseVisualStyleBackColor = true;
            this.btnFiltrare.Click += new System.EventHandler(this.btnFiltrare_Click);
            // 
            // btnCautareDupaDenumire
            // 
            this.btnCautareDupaDenumire.Location = new System.Drawing.Point(891, 513);
            this.btnCautareDupaDenumire.Name = "btnCautareDupaDenumire";
            this.btnCautareDupaDenumire.Size = new System.Drawing.Size(93, 51);
            this.btnCautareDupaDenumire.TabIndex = 12;
            this.btnCautareDupaDenumire.Text = "Cauta";
            this.btnCautareDupaDenumire.UseVisualStyleBackColor = true;
            this.btnCautareDupaDenumire.Click += new System.EventHandler(this.btnCautareDupaMarca_Click);
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(705, 291);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(183, 48);
            this.btnLista.TabIndex = 13;
            this.btnLista.Text = "Afiseaza lista autovehicule";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btn_Lista_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proprietar1,
            this.Marca1,
            this.Culoare1,
            this.Combustibil1});
            this.dataGridView1.Location = new System.Drawing.Point(538, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(526, 259);
            this.dataGridView1.TabIndex = 14;
            // 
            // Proprietar1
            // 
            this.Proprietar1.HeaderText = "Proprietar";
            this.Proprietar1.MinimumWidth = 6;
            this.Proprietar1.Name = "Proprietar1";
            this.Proprietar1.Width = 125;
            // 
            // Marca1
            // 
            this.Marca1.HeaderText = "Marca";
            this.Marca1.MinimumWidth = 6;
            this.Marca1.Name = "Marca1";
            this.Marca1.Width = 125;
            // 
            // Culoare1
            // 
            this.Culoare1.HeaderText = "Culoare";
            this.Culoare1.MinimumWidth = 6;
            this.Culoare1.Name = "Culoare1";
            this.Culoare1.Width = 125;
            // 
            // Combustibil1
            // 
            this.Combustibil1.HeaderText = "Combustibil";
            this.Combustibil1.MinimumWidth = 6;
            this.Combustibil1.Name = "Combustibil1";
            this.Combustibil1.Width = 125;
            // 
            // cmbCriteriu
            // 
            this.cmbCriteriu.FormattingEnabled = true;
            this.cmbCriteriu.Items.AddRange(new object[] {
            "Marca",
            "Culoare",
            "Combustibil"});
            this.cmbCriteriu.Location = new System.Drawing.Point(505, 432);
            this.cmbCriteriu.Name = "cmbCriteriu";
            this.cmbCriteriu.Size = new System.Drawing.Size(149, 24);
            this.cmbCriteriu.TabIndex = 15;
            this.cmbCriteriu.SelectedIndexChanged += new System.EventHandler(this.cmbCriteriu_SelectedIndexChanged);
            // 
            // txtFiltrare
            // 
            this.txtFiltrare.Location = new System.Drawing.Point(505, 477);
            this.txtFiltrare.Name = "txtFiltrare";
            this.txtFiltrare.Size = new System.Drawing.Size(149, 22);
            this.txtFiltrare.TabIndex = 16;
            // 
            // txtCautareMarca
            // 
            this.txtCautareMarca.Location = new System.Drawing.Point(870, 477);
            this.txtCautareMarca.Name = "txtCautareMarca";
            this.txtCautareMarca.Size = new System.Drawing.Size(124, 22);
            this.txtCautareMarca.TabIndex = 17;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(367, 12);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(111, 79);
            this.btnAdaugare.TabIndex = 18;
            this.btnAdaugare.Text = "Adauga Autovehicul";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugareAutovehicul_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(367, 104);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(111, 82);
            this.btnActualizare.TabIndex = 19;
            this.btnActualizare.Text = "Actualizeaza Autovehicul";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizareAutovehicul_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(367, 197);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(111, 74);
            this.btnStergere.TabIndex = 20;
            this.btnStergere.Text = "Sterge Autovehicul";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergereAutovehicul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 632);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.txtCautareMarca);
            this.Controls.Add(this.txtFiltrare);
            this.Controls.Add(this.cmbCriteriu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnCautareDupaDenumire);
            this.Controls.Add(this.btnFiltrare);
            this.Controls.Add(this.btnDeconectare);
            this.Controls.Add(this.txtCombustibil);
            this.Controls.Add(this.txtCuloare);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtProprietar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProprietar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCuloare;
        private System.Windows.Forms.TextBox txtCombustibil;
        private System.Windows.Forms.Button btnDeconectare;
        private System.Windows.Forms.Button btnFiltrare;
        private System.Windows.Forms.Button btnCautareDupaDenumire;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbCriteriu;
        private System.Windows.Forms.TextBox txtFiltrare;
        private System.Windows.Forms.TextBox txtCautareMarca;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proprietar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Culoare1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combustibil1;
    }
}