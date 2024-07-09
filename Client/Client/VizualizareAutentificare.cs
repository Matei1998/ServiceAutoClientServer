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
    public partial class VizualizareAutentificare : Form, IVizualizareAutentificare
    {
        private ControlAutentificare controlAutentificare;
        private Limba limba;
        private string limba_selectata = "romana";
        public VizualizareAutentificare()
        {
            InitializeComponent();
            this.limba = new Limba();

        }

        public string User
        {
            get
            {
                if (this.txtUserAutentificare.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus userul!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.txtUserAutentificare.Text;
            }

            set
            {
                this.txtUserAutentificare.Text = value;
            }
        }

        public string Parola
        {
            get
            {
                if (this.txtParolaAutentificare.Text.Length == 0)
                {
                    MessageBox.Show("Nu s-a introdus parola!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return this.txtParolaAutentificare.Text;
            }

            set
            {
                this.txtParolaAutentificare.Text = value;
            }
        }

        public void SetareControl(ControlAutentificare controlAutentificare)
        {
            this.controlAutentificare = controlAutentificare;
        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {


          if (this.User != null && this.Parola != null)
            {
                Utilizator utilizator = this.controlAutentificare.Logare(this.User, this.Parola);
                if (utilizator == null)
                    MessageBox.Show("Nu exista utilizator cu datele specificate!");
                else
                {

                    if (utilizator.Rol == "Administrator")
                    {
                        this.Hide();
                        VizualizareUtilizatori vizualizare = new VizualizareUtilizatori(limba_selectata);
                        vizualizare.Visible = false;
                        ControlUtilizatori control = new ControlUtilizatori(vizualizare);
                        vizualizare.ShowDialog();

                    }
                    else if(utilizator.Rol == "Manager")
                    {
                       this.Hide();
                        VizualizareAutovehicule vizualizare = new VizualizareAutovehicule(limba_selectata);
                        vizualizare.Visible = false;
                        ControlAutovehicule control = new ControlAutovehicule(vizualizare);
                        vizualizare.ShowDialog();
                    }else
                    {

                        this.Hide();
                        Form1 vizualizare = new Form1(limba_selectata);
                        vizualizare.Visible = false;
                        ControlAutovehicule control = new ControlAutovehicule(vizualizare);
                        vizualizare.ShowDialog();

                    }
                }

            }
        }

        private void Romana_Click(object sender, EventArgs e)
        {
            limba_selectata = "romana";
            try
            {
                Dictionary<string, string> date = this.limba.CautareInformatie("romana");
                this.label1.Text = date["user"];
                this.label2.Text = date["parola"];
                this.btnAutentificare.Text = date["autentificare"];
                this.label4.Text = date["limba"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Engleza_Click(object sender, EventArgs e)
        {
            limba_selectata = "engleza";
            try
            {
                Dictionary<string, string> date = this.limba.CautareInformatie("engleza");
                this.label1.Text = date["user"];
                this.label2.Text = date["parola"];
                this.btnAutentificare.Text = date["autentificare"];
                this.label4.Text = date["limba"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void Italiana_Click(object sender, EventArgs e)
        {
            limba_selectata = "italiana";
            try
            {
                Dictionary<string, string> date = this.limba.CautareInformatie("italiana");
                this.label1.Text = date["user"];
                this.label2.Text = date["parola"];
                this.btnAutentificare.Text = date["autentificare"];
                this.label4.Text = date["limba"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void VizualizareAutentificare_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
