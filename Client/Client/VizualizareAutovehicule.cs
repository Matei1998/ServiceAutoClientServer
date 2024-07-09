using Server.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Client
{
    public partial class VizualizareAutovehicule : Form, IVizualizareAutovehicule


    {


        private ControlAutovehicule controlAutovehicule;
        private Limba limba;
        private string limba_selectata = "romana";


        public VizualizareAutovehicule(string limba_selectata)
        {
            InitializeComponent();
            this.dataGridView1.AllowUserToAddRows = false;
            this.Width = 1150;
            this.limba_selectata = limba_selectata;
            this.limba = new Limba();
            this.Traducere();
        }

        public void SetareControl(ControlAutovehicule controlAutovehicule)
        {
            this.controlAutovehicule = controlAutovehicule;
        }





        public string Proprietar
        {
            get
            {
                if (this.txtProprietar.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus numele proprietarului", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.txtProprietar.Text;
            }

            set
            {
                this.txtProprietar.Text = value;
            }
        }
        public string Marca {
            get
            {
                if (this.txtMarca.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus denumirea marcii", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.txtMarca.Text;
            }

            set
            {
                this.txtMarca.Text = value;
            }
        }
        public string Culoare
        {
            get
            {
                if (this.txtCuloare.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus culoarea", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.txtCuloare.Text;
            }

            set
            {
                this.txtCuloare.Text = value;
            }
        }
        public string Combustibil
        {
            get
            {
                if (this.txtCombustibil.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus combustibilul", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.txtCombustibil.Text;
            }

            set
            {
                this.txtCombustibil.Text = value;
            }
        }

        public string CautareMarcaAutovehicul
        {
            get
            {
                if (this.txtCautareMarca.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus marca autovehiculului", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.txtCautareMarca.Text;
            }

            set
            {
                this.txtCautareMarca.Text = value;
            }
        }


        public string CriteriuSortare
        {
            get
            {
                if (this.cmbSortare.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a selectat criteriul de sortare", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.cmbSortare.Text;
            }

            set
            {
                this.cmbSortare.Text = value;
            }
        }
        public string CritriuSelectatFiltrare
        {
            get
            {
                if (this.cmbCriteriu.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus criteriul de filtrare", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.cmbCriteriu.Text;
            }

            set
            {
                this.cmbCriteriu.Text = value;
            }
        }

        public string CriteriuCautareFiltrare {
            get
            {
                if (this.txtFiltrare.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus textul de filtrare", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.txtFiltrare.Text;
            }

            set
            {
                this.txtFiltrare.Text = value;
            }
        }







        public void AddAutovehicul(Autovehicul autovehicul)
        {
            DataGridViewRow rand = new DataGridViewRow();
            rand.CreateCells(this.dataGridView1);
            rand.Cells[0].Value = autovehicul.Proprietar;
            rand.Cells[1].Value = autovehicul.Marca;
            rand.Cells[2].Value = autovehicul.Culoare;
            rand.Cells[3].Value = autovehicul.Combustibil;
            this.dataGridView1.Rows.Add(rand);
        }

        public void DeleteAutovehicul(string proprietar)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Proprietar1"].Value != null && row.Cells["Proprietar1"].Value.ToString() == proprietar)
                {
                    dataGridView1.Rows.Remove(row);
                    break; 
                }
            }
        }


        public void Grafic(Dictionary<string, int> lista)
        {
            this.graficStatistica.Series.Clear();
            this.graficStatistica.Legends.Clear();

            string numeSerie = this.cbCriteriu.SelectedItem.ToString();

            this.graficStatistica.Legends.Add(numeSerie);
            this.graficStatistica.Legends[0].LegendStyle = LegendStyle.Table;
            this.graficStatistica.Legends[0].Docking = Docking.Bottom;
            this.graficStatistica.Legends[0].Alignment = StringAlignment.Center;
            this.graficStatistica.Legends[0].Title = numeSerie;
            this.graficStatistica.Legends[0].BorderColor = Color.Black;

            this.graficStatistica.Series.Add(numeSerie);
            this.graficStatistica.Series[numeSerie].ChartType = SeriesChartType.Doughnut;
            foreach (KeyValuePair<string, int> pereche in lista)
                this.graficStatistica.Series[numeSerie].Points.AddXY(pereche.Key, pereche.Value);
            foreach (DataPoint p in this.graficStatistica.Series[numeSerie].Points)
                p.Label = "#PERCENT";
            this.graficStatistica.Series[numeSerie].LegendText = "#VALX";
        }

        public void ReinitializareLista()
        {
            this.dataGridView1.Rows.Clear();
        }

        

        public void UpdateAutovehicul(string proprietar, Autovehicul autovehicul)
        {
            DataGridViewRow rand = new DataGridViewRow();
            rand.CreateCells(this.dataGridView1);
            rand.Cells[0].Value = autovehicul.Proprietar;
            rand.Cells[1].Value = autovehicul.Marca; ;
            rand.Cells[2].Value = autovehicul.Culoare;
            rand.Cells[3].Value = autovehicul.Combustibil;
            this.dataGridView1.Rows.Add(rand);
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int randSelectat = this.dataGridView1.SelectedRows[0].Index;
                DataGridViewRow rand = this.dataGridView1.Rows[randSelectat];
                this.txtProprietar.Text =(string) rand.Cells[0].Value;
                this.txtMarca.Text = (string)rand.Cells[1].Value;
                this.txtCuloare.Text = (string)rand.Cells[2].Value;
                this.txtCombustibil.Text = (string)rand.Cells[3].Value;


            }
            else
            {
                this.txtProprietar.Text = "";
                this.txtMarca.Text = "";
                this.txtCuloare.Text = "";
                this.txtCombustibil.Text = "";
            }
        }

        private void btnAdaugareAutovehicul_Click(object sender, EventArgs e)
        {
            if (this.Proprietar != null && this.Marca != null && this.Culoare != null && this.Combustibil != null)
            {


                Autovehicul autovehicul = new Autovehicul(this.Proprietar, this.Marca, this.Culoare, this.Combustibil);
                if (this.controlAutovehicule.CautareAutovehicul(autovehicul.Proprietar))
                    MessageBox.Show("Exista un autovehicul cu acest proprietar. Introduceti alt proprietar");
                else
                {
                    if (!this.controlAutovehicule.AdaugareAutovehicul(autovehicul))
                        MessageBox.Show("EROARE LA ADAUGARE", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        this.txtProprietar.Text = "";
                        this.txtMarca.Text = "";
                        this.txtCuloare.Text = "";
                        this.txtCombustibil.Text = "";

                    }
                }
            }
        }



        private void btnActualizareAutovehicul_Click(object sender, EventArgs e)
        {
            string proprietar = this.txtProprietar.Text;

            if (!string.IsNullOrEmpty(proprietar))
            {
                string marca = this.txtMarca.Text;
                string culoare = this.txtCuloare.Text;
                string combustibil = this.txtCombustibil.Text;

                Autovehicul autovehicul = new Autovehicul(proprietar, marca, culoare, combustibil);

                if (!this.controlAutovehicule.ActualizareAutovehicul(proprietar, autovehicul))
                {
                    MessageBox.Show("EROARE LA ACTUALIZARE", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Curățăm câmpurile text după actualizare
                    this.txtProprietar.Text = "";
                    this.txtMarca.Text = "";
                    this.txtCuloare.Text = "";
                    this.txtCombustibil.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Proprietarul autovehiculului este necompletat", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void btnStergereAutovehicul_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                string proprietarSelectat = this.dataGridView1.SelectedRows[0].Cells["Proprietar1"].Value.ToString(); 
                var confirmare = MessageBox.Show("Doriți să ștergeți autovehiculul selectat?",
                        "ȘTERGERE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmare == DialogResult.Yes)
                {
                    if (!this.controlAutovehicule.StergereAutovehicul(proprietarSelectat))
                        MessageBox.Show("EROARE LA ȘTERGERE", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Nu s-a selectat niciun autovehicul", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnSortare_Click(object sender, EventArgs e)
        {
            if (this.CriteriuSortare != null)
            {
                this.controlAutovehicule.SortareAutovehicule(this.CriteriuSortare);
            }
        }
    

        private void btnCautareDupaMarca_Click(object sender, EventArgs e)
        {
            if (this.CautareMarcaAutovehicul != null)
            {
                this.controlAutovehicule.CautareDupaMarca(this.CautareMarcaAutovehicul);
            }
        }

        public string CriteriuSelectatFiltrare
        {
            get
            {
                if (this.cmbCriteriu.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a selectat criteriu de filtrare!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.cmbCriteriu.Text;
            }

            set
            {
                this.cmbCriteriu.Text = value;
            }
        }

        private void btnFiltrare_Click(object sender, EventArgs e)
        {
            if (this.CriteriuSelectatFiltrare != null && this.CriteriuCautareFiltrare != null)
            {
                this.controlAutovehicule.FiltrareAutovehicule(this.CriteriuSelectatFiltrare, this.CriteriuCautareFiltrare);
            }
        }

        private void btnSalvareCSV_JSON_Click(object sender, EventArgs e)
        {




            List<Autovehicul> lista = new List<Autovehicul>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Autovehicul autovehicul = new Autovehicul();
                autovehicul.Proprietar = (string)row.Cells["Proprietar1"].Value;
                autovehicul.Marca = (string)row.Cells["Marca1"].Value;
                autovehicul.Culoare = (string)row.Cells["Culoare1"].Value;
                autovehicul.Combustibil = (string)row.Cells["Combustibil1"].Value;
                lista.Add(autovehicul);
            }
            this.controlAutovehicule.SalvareAutovehiculeFiltrare(lista);



        }

        private void cbCriteriu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbCriteriu.SelectedIndex >= 0)
                this.controlAutovehicule.Statistica(this.cbCriteriu.SelectedItem.ToString());
        }


        public void Grafic(Dictionary<string, uint> lista)
        {
            this.graficStatistica.Series.Clear();
            this.graficStatistica.Legends.Clear();

            string numeSerie = this.cbCriteriu.SelectedItem.ToString();

            this.graficStatistica.Legends.Add(numeSerie);
            this.graficStatistica.Legends[0].LegendStyle = LegendStyle.Table;
            this.graficStatistica.Legends[0].Docking = Docking.Bottom;
            this.graficStatistica.Legends[0].Alignment = StringAlignment.Center;
            this.graficStatistica.Legends[0].Title = numeSerie;
            this.graficStatistica.Legends[0].BorderColor = Color.Black;

            this.graficStatistica.Series.Add(numeSerie);
            this.graficStatistica.Series[numeSerie].ChartType = SeriesChartType.Column;
            foreach (KeyValuePair<string, uint> pereche in lista)
                this.graficStatistica.Series[numeSerie].Points.AddXY(pereche.Key, pereche.Value);
            foreach (DataPoint p in this.graficStatistica.Series[numeSerie].Points)
                p.Label = "#PERCENT";
            this.graficStatistica.Series[numeSerie].LegendText = "#VALX";
        }


        private void btnDeconectare_Click(object sender, EventArgs e)
        {
            this.Hide();
            VizualizareAutentificare vizualizareAutentificare = new VizualizareAutentificare();
            vizualizareAutentificare.Visible = false;
            ControlAutentificare control = new ControlAutentificare(vizualizareAutentificare);
            vizualizareAutentificare.ShowDialog();
        }


        public void Traducere()
        {
            try
            {
                Dictionary<string, string> date = this.limba.Traducere_VizualizareAutovehicule(limba_selectata);
                this.label1.Text = date["proprietar"];
                this.label2.Text = date["marca"];
                this.label3.Text = date["culoare"];
                this.label4.Text = date["combustibil"];

                

                this.btnDeconectare.Text = date["deconectare"];
                this.btnAdaugare.Text = date["adaugare_autovehicul"];
                this.btnActualizare.Text = date["actualizare_autovehicul"];
                this.btnStergere.Text = date["stergere_autovehicul"];

                this.dataGridView1.Columns[0].HeaderText = date["tabel_proprietar"];
                this.dataGridView1.Columns[1].HeaderText = date["tabel_marca"];
                this.dataGridView1.Columns[2].HeaderText = date["tabel_combustibil"];
                this.dataGridView1.Columns[3].HeaderText = date["tabel_culoare"];

                this.btnSalvare.Text = date["btnSalvareCsvJson"];
                this.btnLista.Text = date["btnLista_Autovehicule"];
                this.label5.Text = date["lbSortare"];
                this.btnSortare.Text = date["btnSortare"];

                this.cmbSortare.Items.Clear();
                this.cmbSortare.Items.Add(date["cmbSortare_Cres_Marca"]);
                this.cmbSortare.Items.Add(date["cmbSortare_Desc_Marca"]);
              

                this.label8.Text = date["lbCautare_Marca"];
                this.btnCautareDupaDenumire.Text = date["btnCauta"];
                this.cbStatistica.Text = date["checkboxStatistica"];
                this.label6.Text = date["lbFiltre"];

                this.cmbCriteriu.Items.Clear();
                this.cmbCriteriu.Items.Add(date["cmbFiltre_proprietar"]);
                this.cmbCriteriu.Items.Add(date["cmbFiltre_marca"]);
                this.cmbCriteriu.Items.Add(date["cmbFiltre_culoare"]);
                this.btnFiltrare.Text = date["btnFiltrare"];
                this.lbCriteriu.Text = date["lbCriteriu"];

                this.cbCriteriu.Items.Clear();
                this.cbCriteriu.Items.Add(date["cmbStatistica_Marca"]);
                this.cbCriteriu.Items.Add(date["cmbStatistica_Culoare"]);
                this.cbCriteriu.Items.Add(date["cmbStatistica_Combustibil"]);




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }





        private void VizualizareAutovehicule_Load(object sender, EventArgs e)
        {

        }

        private void cbStatistica_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbStatistica.Checked)
            {
                this.Width = 1150;
                this.lbCriteriu.Visible = true;
                this.cbCriteriu.Visible = true;
                this.graficStatistica.Visible = true;
            }
            else
            {
                this.Width = 1150;
                this.lbCriteriu.Visible = false;
                this.cbCriteriu.Visible = false;
                this.graficStatistica.Visible = false;
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            this.controlAutovehicule.Vizualizare();
        }

        private void graficStatistica_Click(object sender, EventArgs e)
        {

        }

        private void cmbCriteriu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
