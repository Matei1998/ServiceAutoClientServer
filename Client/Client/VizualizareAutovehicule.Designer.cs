namespace Client
{
    partial class VizualizareAutovehicule
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtProprietar = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCuloare = new System.Windows.Forms.TextBox();
            this.txtCombustibil = new System.Windows.Forms.TextBox();
            this.txtFiltrare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnDeconectare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Proprietar1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Culoare1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combustibil1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.cbStatistica = new System.Windows.Forms.CheckBox();
            this.cmbSortare = new System.Windows.Forms.ComboBox();
            this.btnSortare = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCriteriu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFiltrare = new System.Windows.Forms.Button();
            this.lbCriteriu = new System.Windows.Forms.Label();
            this.cbCriteriu = new System.Windows.Forms.ComboBox();
            this.graficStatistica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCautareMarca = new System.Windows.Forms.TextBox();
            this.btnCautareDupaDenumire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficStatistica)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProprietar
            // 
            this.txtProprietar.Location = new System.Drawing.Point(125, 56);
            this.txtProprietar.Name = "txtProprietar";
            this.txtProprietar.Size = new System.Drawing.Size(154, 22);
            this.txtProprietar.TabIndex = 0;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(125, 104);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(154, 22);
            this.txtMarca.TabIndex = 1;
            // 
            // txtCuloare
            // 
            this.txtCuloare.Location = new System.Drawing.Point(125, 159);
            this.txtCuloare.Name = "txtCuloare";
            this.txtCuloare.Size = new System.Drawing.Size(154, 22);
            this.txtCuloare.TabIndex = 2;
            // 
            // txtCombustibil
            // 
            this.txtCombustibil.Location = new System.Drawing.Point(125, 217);
            this.txtCombustibil.Name = "txtCombustibil";
            this.txtCombustibil.Size = new System.Drawing.Size(154, 22);
            this.txtCombustibil.TabIndex = 3;
            // 
            // txtFiltrare
            // 
            this.txtFiltrare.Location = new System.Drawing.Point(588, 519);
            this.txtFiltrare.Name = "txtFiltrare";
            this.txtFiltrare.Size = new System.Drawing.Size(100, 22);
            this.txtFiltrare.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Proprietar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Culoare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Combustibil";
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(324, 46);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(114, 74);
            this.btnAdaugare.TabIndex = 10;
            this.btnAdaugare.Text = "Adauga autovehicul";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugareAutovehicul_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(324, 140);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(114, 79);
            this.btnActualizare.TabIndex = 11;
            this.btnActualizare.Text = "Actualizare Autovehicul";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizareAutovehicul_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(324, 232);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(114, 81);
            this.btnStergere.TabIndex = 12;
            this.btnStergere.Text = "Stergere autovehicul";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergereAutovehicul_Click);
            // 
            // btnDeconectare
            // 
            this.btnDeconectare.Location = new System.Drawing.Point(35, 541);
            this.btnDeconectare.Name = "btnDeconectare";
            this.btnDeconectare.Size = new System.Drawing.Size(202, 77);
            this.btnDeconectare.TabIndex = 13;
            this.btnDeconectare.Text = "Deconectare";
            this.btnDeconectare.UseVisualStyleBackColor = true;
            this.btnDeconectare.Click += new System.EventHandler(this.btnDeconectare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proprietar1,
            this.Marca1,
            this.Culoare1,
            this.Combustibil1});
            this.dataGridView1.Location = new System.Drawing.Point(480, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 295);
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
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(480, 328);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(143, 53);
            this.btnSalvare.TabIndex = 15;
            this.btnSalvare.Text = "Salvare fisier CSV si JSON";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvareCSV_JSON_Click);
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(658, 328);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(121, 53);
            this.btnLista.TabIndex = 16;
            this.btnLista.Text = "Lista Autovehicule";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // cbStatistica
            // 
            this.cbStatistica.AutoSize = true;
            this.cbStatistica.Location = new System.Drawing.Point(840, 345);
            this.cbStatistica.Name = "cbStatistica";
            this.cbStatistica.Size = new System.Drawing.Size(83, 20);
            this.cbStatistica.TabIndex = 17;
            this.cbStatistica.Text = "Statistica";
            this.cbStatistica.UseVisualStyleBackColor = true;
            this.cbStatistica.CheckedChanged += new System.EventHandler(this.cbStatistica_CheckedChanged);
            // 
            // cmbSortare
            // 
            this.cmbSortare.FormattingEnabled = true;
            this.cmbSortare.Items.AddRange(new object[] {
            "Sortare_marca_crescator",
            "Sortare_marca_descrescator"});
            this.cmbSortare.Location = new System.Drawing.Point(384, 517);
            this.cmbSortare.Name = "cmbSortare";
            this.cmbSortare.Size = new System.Drawing.Size(121, 24);
            this.cmbSortare.TabIndex = 18;
            // 
            // btnSortare
            // 
            this.btnSortare.Location = new System.Drawing.Point(401, 559);
            this.btnSortare.Name = "btnSortare";
            this.btnSortare.Size = new System.Drawing.Size(92, 47);
            this.btnSortare.TabIndex = 19;
            this.btnSortare.Text = "Sortare";
            this.btnSortare.UseVisualStyleBackColor = true;
            this.btnSortare.Click += new System.EventHandler(this.btnSortare_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sortare";
            // 
            // cmbCriteriu
            // 
            this.cmbCriteriu.FormattingEnabled = true;
            this.cmbCriteriu.Items.AddRange(new object[] {
            "Proprietar",
            "Marca",
            "Culoare"});
            this.cmbCriteriu.Location = new System.Drawing.Point(578, 464);
            this.cmbCriteriu.Name = "cmbCriteriu";
            this.cmbCriteriu.Size = new System.Drawing.Size(121, 24);
            this.cmbCriteriu.TabIndex = 21;
            this.cmbCriteriu.SelectedIndexChanged += new System.EventHandler(this.cmbCriteriu_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(622, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Filtre";
            // 
            // btnFiltrare
            // 
            this.btnFiltrare.Location = new System.Drawing.Point(588, 559);
            this.btnFiltrare.Name = "btnFiltrare";
            this.btnFiltrare.Size = new System.Drawing.Size(100, 45);
            this.btnFiltrare.TabIndex = 23;
            this.btnFiltrare.Text = "Filtrare";
            this.btnFiltrare.UseVisualStyleBackColor = true;
            this.btnFiltrare.Click += new System.EventHandler(this.btnFiltrare_Click);
            // 
            // lbCriteriu
            // 
            this.lbCriteriu.AutoSize = true;
            this.lbCriteriu.Location = new System.Drawing.Point(1150, 334);
            this.lbCriteriu.Name = "lbCriteriu";
            this.lbCriteriu.Size = new System.Drawing.Size(48, 16);
            this.lbCriteriu.TabIndex = 24;
            this.lbCriteriu.Text = "Criteriu";
            // 
            // cbCriteriu
            // 
            this.cbCriteriu.FormattingEnabled = true;
            this.cbCriteriu.Items.AddRange(new object[] {
            "Marca",
            "Culoare",
            "Combustibil"});
            this.cbCriteriu.Location = new System.Drawing.Point(1121, 354);
            this.cbCriteriu.Name = "cbCriteriu";
            this.cbCriteriu.Size = new System.Drawing.Size(121, 24);
            this.cbCriteriu.TabIndex = 25;
            this.cbCriteriu.SelectedIndexChanged += new System.EventHandler(this.cbCriteriu_SelectedIndexChanged);
            // 
            // graficStatistica
            // 
            chartArea4.Name = "ChartArea1";
            this.graficStatistica.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.graficStatistica.Legends.Add(legend4);
            this.graficStatistica.Location = new System.Drawing.Point(946, 18);
            this.graficStatistica.Name = "graficStatistica";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.graficStatistica.Series.Add(series4);
            this.graficStatistica.Size = new System.Drawing.Size(460, 295);
            this.graficStatistica.TabIndex = 26;
            this.graficStatistica.Text = "chart1";
            this.graficStatistica.Click += new System.EventHandler(this.graficStatistica_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(777, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Cautare dupa marca ";
            // 
            // txtCautareMarca
            // 
            this.txtCautareMarca.Location = new System.Drawing.Point(797, 506);
            this.txtCautareMarca.Name = "txtCautareMarca";
            this.txtCautareMarca.Size = new System.Drawing.Size(100, 22);
            this.txtCautareMarca.TabIndex = 28;
            // 
            // btnCautareDupaDenumire
            // 
            this.btnCautareDupaDenumire.Location = new System.Drawing.Point(797, 559);
            this.btnCautareDupaDenumire.Name = "btnCautareDupaDenumire";
            this.btnCautareDupaDenumire.Size = new System.Drawing.Size(112, 45);
            this.btnCautareDupaDenumire.TabIndex = 29;
            this.btnCautareDupaDenumire.Text = "Cauta";
            this.btnCautareDupaDenumire.UseVisualStyleBackColor = true;
            this.btnCautareDupaDenumire.Click += new System.EventHandler(this.btnCautareDupaMarca_Click);
            // 
            // VizualizareAutovehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 670);
            this.Controls.Add(this.btnCautareDupaDenumire);
            this.Controls.Add(this.txtCautareMarca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.graficStatistica);
            this.Controls.Add(this.cbCriteriu);
            this.Controls.Add(this.lbCriteriu);
            this.Controls.Add(this.btnFiltrare);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCriteriu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSortare);
            this.Controls.Add(this.cmbSortare);
            this.Controls.Add(this.cbStatistica);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeconectare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltrare);
            this.Controls.Add(this.txtCombustibil);
            this.Controls.Add(this.txtCuloare);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtProprietar);
            this.Name = "VizualizareAutovehicule";
            this.Text = "VizualizareAutovehicule";
            this.Load += new System.EventHandler(this.VizualizareAutovehicule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficStatistica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProprietar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCuloare;
        private System.Windows.Forms.TextBox txtCombustibil;
        private System.Windows.Forms.TextBox txtFiltrare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnDeconectare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.CheckBox cbStatistica;
        private System.Windows.Forms.ComboBox cmbSortare;
        private System.Windows.Forms.Button btnSortare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCriteriu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFiltrare;
        private System.Windows.Forms.Label lbCriteriu;
        private System.Windows.Forms.ComboBox cbCriteriu;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficStatistica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCautareMarca;
        private System.Windows.Forms.Button btnCautareDupaDenumire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proprietar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Culoare1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combustibil1;
    }
}