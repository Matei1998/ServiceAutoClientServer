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

namespace Client
{
    public partial class VizualizareUtilizatori : Form, IVizualizareUtilizatori
    {
        private ControlUtilizatori controlUtilizatori;
        private Limba limba;
        private string limba_selectata = "romana";
        public VizualizareUtilizatori(string limba_selectata)
        {
            InitializeComponent();
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoResizeColumns();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.limba_selectata = limba_selectata;
            this.limba = new Limba();
            this.Traducere();
        }

        public int Id_Utilizator
        {
            get
            {
                if (this.txtLegitimatie.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus ID-ul utilizatorului", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                else
                {
                    try
                    {
                        int m = Convert.ToInt32(this.txtLegitimatie.Text);
                        if (m > 0)
                            return m;
                        else
                        {
                            MessageBox.Show("Nu s-a introdus corect id-ul. Introduceti un numar natural nenul!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return -1;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Nu s-a introdus corect id-ul. Introduceti un numar natural nenul!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }
            }
            set
            {
                this.txtLegitimatie.Text = value.ToString();
            }
        }

        public string Nume
        {
            get
            {
                if (this.txtNume.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus numele utilizatorului", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.txtNume.Text;
            }

            set
            {
                this.txtNume.Text = value;
            }
        }

        public string Cont
        {
            get
            {
                if (this.txtUser.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus userul utilizatorului", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.txtUser.Text;
            }

            set
            {
                this.txtUser.Text = value;
            }
        }
        public string Parola
        {
            get
            {
                if (this.txtParola.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus parola utilizatorului", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.txtParola.Text;
            }

            set
            {
                this.txtParola.Text = value;
            }
        }

        public string Rol
        {
            get
            {
                if (this.cmbRolU.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus rolul utilizatorului", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.cmbRolU.Text;
            }

            set
            {
                this.cmbRolU.Text = value;
            }
        }

        public string FiltrareRol
        {
            get
            {
                if (this.cmbFiltrareRol.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus criteriul de filtrare ", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.cmbFiltrareRol.Text;
            }

            set
            {
                this.cmbFiltrareRol.Text = value;
            }
        }

        public void SetareControl(ControlUtilizatori controlUtilizatori)
        {
            this.controlUtilizatori = controlUtilizatori;
        }

        public void AdaugareUtilizator(Utilizator utilizator)
        {
            DataGridViewRow rand = new DataGridViewRow();
            rand.CreateCells(this.dataGridView1);
            rand.Cells[0].Value = utilizator.Legitimatie;
            rand.Cells[1].Value = utilizator.Nume;
            rand.Cells[2].Value = utilizator.Cont;
            rand.Cells[3].Value = utilizator.Parola;
            rand.Cells[4].Value = utilizator.Rol;
            this.dataGridView1.Rows.Add(rand);
        }

        public void ActualizareUtilizator(Utilizator utilizator)
        {
            DataGridViewRow rand = new DataGridViewRow();
            rand.CreateCells(this.dataGridView1);
            rand.Cells[0].Value = utilizator.Legitimatie;
            rand.Cells[1].Value = utilizator.Nume;
            rand.Cells[2].Value = utilizator.Cont;
            rand.Cells[3].Value = utilizator.Parola;
            rand.Cells[4].Value = utilizator.Rol;
            this.dataGridView1.Rows.Add(rand);
        }

        public void StergereUtilizator(int indexRand)
        {
            this.dataGridView1.Rows.RemoveAt(indexRand);
        }

        private void btnAdaugareU_Click(object sender, EventArgs e)
        {
            if (this.Id_Utilizator != -1 && this.Nume != null && this.Cont != null && this.Parola != null && this.Rol != null)
             {
                 string rol = this.Rol;
                 if (rol == "Angestellter" || rol == "Employee") rol = "Angajat";
                 if (rol == "Administrator" || rol == "Administrator") rol = "Administrator";
                if (rol == "Manager" || rol == "Manager") rol = "Manager";


                Utilizator utilizator = new Utilizator(this.Id_Utilizator, this.Nume, this.Cont, this.Parola, rol);
                 if (this.controlUtilizatori.CautareUtilizator(utilizator.Legitimatie))
                     MessageBox.Show("Exista un utilizator cu aceast ID. Introduceti alt ID");
                 else
                 {
                     if (!this.controlUtilizatori.AdaugareUtilizator(utilizator))
                         MessageBox.Show("EROARE LA ADAUGARE", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     else
                     {
                         this.txtLegitimatie.Text = "";
                         this.txtNume.Text = "";
                         this.txtUser.Text = "";
                         this.txtParola.Text = "";
                         this.cmbRolU.Text = "";

                     }
                 }
             }
        }

        public void ReinitializareLista()
        {
            this.dataGridView1.Rows.Clear();
        }


        private void btnLista_Click(object sender, EventArgs e)
        {
            this.controlUtilizatori.Vizualizare();
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int randSelectat = this.dataGridView1.SelectedRows[0].Index;

                if (this.Id_Utilizator != -1 && this.Nume != null && this.Cont != null && this.Parola != null && this.Rol != null)
                {

                    string rol = this.Rol;
                    if (rol == "Angestellter" || rol == "Employee") rol = "Angajat";
                    if (rol == "Administrator" || rol == "Administrator") rol = "Administrator";
                    if (rol == "Manager" || rol == "Manager") rol = "Manager";


                    Utilizator utilizator = new Utilizator(this.Id_Utilizator, this.Nume, this.Cont, this.Parola, rol);
                    if (this.controlUtilizatori.CautareUtilizator(randSelectat, utilizator.Legitimatie))
                        MessageBox.Show("Exista un utilizator cu aceast ID. Introduceti alt ID");
                    else
                    {
                        if (!this.controlUtilizatori.ActualizareUtilizator(randSelectat, utilizator))
                            MessageBox.Show("EROARE LA ACTUALIZARE", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            this.txtLegitimatie.Text = "";
                            this.txtNume.Text = "";
                            this.txtUser.Text = "";
                            this.txtParola.Text = "";
                            this.cmbRolU.Text = "";

                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Nu s-a selectat niciun utilizator", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int randSelectat = this.dataGridView1.SelectedRows[0].Index;
                DataGridViewRow rand = this.dataGridView1.Rows[randSelectat];
                this.txtLegitimatie.Text = rand.Cells[0].Value.ToString();
                this.txtNume.Text = (string)rand.Cells[1].Value;
                this.txtUser.Text = (string)rand.Cells[2].Value;
                this.txtParola.Text = (string)rand.Cells[3].Value;
                this.cmbRolU.Text = (string)rand.Cells[4].Value;


            }
            else
            {
                this.txtLegitimatie.Text = "";
                this.txtNume.Text = "";
                this.txtUser.Text = "";
                this.txtParola.Text = "";
                this.cmbRolU.Text = "";
            }
        }

        private void btnFiltrareRol_Click(object sender, EventArgs e)
        {
            if (this.FiltrareRol != null)
            {
                this.controlUtilizatori.FiltrareUtilizatori(this.FiltrareRol);
            }

        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int randSelectat = this.dataGridView1.SelectedRows[0].Index;
                var confirmare = MessageBox.Show("Doriti sa stergeti utilizatorul selectat?",
                        "STERGERE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmare == DialogResult.Yes)
                {
                    if (!this.controlUtilizatori.StergereUtilizator(randSelectat))
                        MessageBox.Show("EROARE LA STERGERE", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Nu s-a selectat niciun utilizator", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Dictionary<string, string> date = this.limba.Traducere_VizualizareUtilizatori(limba_selectata);
                this.label15.Text = date["id"];
                this.label2.Text = date["nume"];
                this.label3.Text = date["utilizator"];
                this.label4.Text = date["parola"];
                this.label5.Text = date["rol"];
                this.cmbRolU.Items.Clear();
                this.cmbRolU.Items.Add(date["cmbRol_angajat"]);
                this.cmbRolU.Items.Add(date["cmbRol_admin"]);
               this.cmbRolU.Items.Add(date["cmbRol_manager"]); 
                this.label6.Text = date["filtrare_rol"];
                this.cmbFiltrareRol.Items.Clear();
                this.cmbFiltrareRol.Items.Add(date["cmbFiltrare_Angajat"]);
                this.cmbFiltrareRol.Items.Add(date["cmbFiltrare_Admin"]);
                this.cmbFiltrareRol.Items.Add(date["cmbFiltrare_Manager"]);
                this.btnLista.Text = date["afis_lista"];
                this.btnDeconectare.Text = date["deconectare"];
                this.btnAdaugaU.Text = date["adaugare_utilizator"];
                this.btnActualizare.Text = date["actualizare_utilizator"];
                this.btnStergere.Text = date["stergere_utilizator"];
                this.cmbFiltrareRol.Text = date["filtreaza"];
                this.dataGridView1.Columns[0].HeaderText = date["tabel_id"];
                this.dataGridView1.Columns[1].HeaderText = date["tabel_nume"];
                this.dataGridView1.Columns[2].HeaderText = date["tabel_user"];
                this.dataGridView1.Columns[3].HeaderText = date["tabel_parola"];
                this.dataGridView1.Columns[4].HeaderText = date["tabel_rol"];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void VizualizareUtilizatori_Load(object sender, EventArgs e)
        {

        }
    

    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VizualizareAdministrator_Load(object sender, EventArgs e)
        {

        }

        private void cmbRolU_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
