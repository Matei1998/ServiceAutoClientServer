using Client.Model;
using Server.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Client
{
    public class ControlAutovehicule
    {
        private IVizualizareAutovehicule vizualizareAutovehicule;
        private IAutovehiculRepository persistentaAutovehicule;
        private DataTable autovehicule;
        private DataTable dataTable = new DataTable();

        public ControlAutovehicule(IVizualizareAutovehicule vizualizareAutovehicule)
        {
            this.vizualizareAutovehicule = vizualizareAutovehicule;
            this.vizualizareAutovehicule.SetareControl(this);
            this.autovehicule = new DataTable();
            this.creareLegatura();
        }

        private void creareLegatura()
        {
            ChannelFactory<IAutovehiculRepository> canalAutovehicul;
            NetTcpBinding tcp = new NetTcpBinding();
            tcp.OpenTimeout = new TimeSpan(0, 60, 0);
            tcp.SendTimeout = new TimeSpan(0, 60, 0);
            tcp.ReceiveTimeout = new TimeSpan(0, 60, 0);
            tcp.CloseTimeout = new TimeSpan(0, 60, 0);
            tcp.MaxReceivedMessageSize = System.Int32.MaxValue;
            tcp.Security.Mode = SecurityMode.Transport;
            tcp.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            tcp.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;
            string s = ConfigurationManager.ConnectionStrings["AdresaIP"].ConnectionString;
            canalAutovehicul = new ChannelFactory<IAutovehiculRepository>(tcp, "net.tcp://" + s + ":52002/Autovehicul");
            try
            {
                this.persistentaAutovehicule = canalAutovehicul.CreateChannel();
                this.creareListaAutovehicule();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void creareListaAutovehicule()
        {
            try
            {
                DataSet ds = this.persistentaAutovehicule.VizualizareAutovehicule();
                this.autovehicule = ds.Tables["vizualizareAutovehicule"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Vizualizare()
        {
            try
            {
                this.vizualizareAutovehicule.ReinitializareLista();
                foreach (DataRow dr in this.autovehicule.Rows)
                {
                    Autovehicul autovehicul = new Autovehicul(dr["Proprietar"].ToString(), dr["Marca"].ToString(), dr["Culoare"].ToString(), dr["Combustibil"].ToString());
                    this.vizualizareAutovehicule.AddAutovehicul(autovehicul);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Vizualizare(DataTable dataTable)
        {
            try
            {
                this.vizualizareAutovehicule.ReinitializareLista();
                foreach (DataRow dr in dataTable.Rows) // Iterăm prin fiecare rând din dataTable, nu din autovehicule
                {
                    Autovehicul autovehicul = new Autovehicul(dr["Proprietar"].ToString(), dr["Marca"].ToString(), dr["Culoare"].ToString(), dr["Combustibil"].ToString());
                    this.vizualizareAutovehicule.AddAutovehicul(autovehicul);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public bool AdaugareAutovehicul(Autovehicul autovehicul)
        {
            if (this.persistentaAutovehicule.AdaugareAutovehicul(autovehicul))
            {
                this.vizualizareAutovehicule.AddAutovehicul(autovehicul);
                this.creareListaAutovehicule();
                return true;
            }
            else
                return false;
        }

        public bool ActualizareAutovehicul(string proprietar, Autovehicul auto)
        {
            // Actualizăm baza de date
            if (this.persistentaAutovehicule.ActualizareAutovehicul(proprietar, auto))
            {
                // Reîncărcăm lista de autovehicule
                this.creareListaAutovehicule();

                // Actualizăm afișarea autovehiculelor în DataGridView
                this.Vizualizare();

                return true;
            }
            else
            {
                return false;
            }
        }







        public bool StergereAutovehicul(string proprietar)
        {
            if (this.persistentaAutovehicule.StergereAutovehicul(proprietar))
            {
                this.vizualizareAutovehicule.DeleteAutovehicul(proprietar);
                this.creareListaAutovehicule();
                return true;
            }
            else
                return false;
        }

        public void FiltrareAutovehicule(string criteriu_selectat, string cautare)
        { /*proprietar,marca,culoare */
            if (criteriu_selectat == "Owner" || criteriu_selectat == "Proprietario") criteriu_selectat = "Proprietar";
            if (criteriu_selectat == "Brand" || criteriu_selectat == "Marchio") criteriu_selectat = "Marca";
            if (criteriu_selectat == "Color" || criteriu_selectat == "Colore") criteriu_selectat = "Culoare";


            try
            {
                this.vizualizareAutovehicule.ReinitializareLista();
                foreach (DataRow dr in this.autovehicule.Rows)
                {
                    if (dr[criteriu_selectat].ToString() == cautare)
                    {
                        Autovehicul autovehicul = new Autovehicul(dr["Proprietar"].ToString(), dr["Marca"].ToString(), dr["Culoare"].ToString(), dr["Combustibil"].ToString());
                        this.vizualizareAutovehicule.AddAutovehicul(autovehicul);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public bool CautareAutovehicul(string proprietar)
        {
            bool gasit = false;
            int i = 0;
            while (!gasit && i < this.autovehicule.Rows.Count)
            {
                DataRow dr = this.autovehicule.Rows[i];
                if ((string)dr["Proprietar"] == proprietar)
                    gasit = true;
                else
                    i++;
            }
            return gasit;
        }

        public void SortareAutovehicule(string criteriu_sortare)
        {

            try
            {
                this.vizualizareAutovehicule.ReinitializareLista();
                if (criteriu_sortare == "Sortare_marca_crescator" || criteriu_sortare == "Ordina per marchio crescente" || criteriu_sortare == "Sort by brand ascending")
                {
                    autovehicule.DefaultView.Sort = "Marca";
                    dataTable = autovehicule.DefaultView.ToTable();

                }

                if (criteriu_sortare == "Sortare_marca_descrescator" || criteriu_sortare == "Ordina per marchio decrescente" || criteriu_sortare == "Sort by brand descending")
                {
                    autovehicule.DefaultView.Sort = "Marca desc";
                    dataTable = autovehicule.DefaultView.ToTable();

                }


                this.Vizualizare(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CautareDupaMarca(string marca)
        {
            try
            {
                this.vizualizareAutovehicule.ReinitializareLista();
                foreach (DataRow dr in this.autovehicule.Rows)
                {
                    if (dr["Marca"].ToString() == marca)
                    {
                        Autovehicul autovehicul = new Autovehicul(dr["Proprietar"].ToString(), dr["Marca"].ToString(), dr["Culoare"].ToString(), dr["Combustibil"].ToString());
                        this.vizualizareAutovehicule.AddAutovehicul(autovehicul);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SalvareAutovehiculeFiltrare(List<Autovehicul> lista)
        {

            SalvareCSV salvare_Csv = new SalvareCSV();
            SalvareJSON salvare_JSON = new SalvareJSON();

            salvare_Csv.SalvareAutovehiculeFiltrate(lista);
            salvare_JSON.SalvareAutovehiculeFiltrate(lista);


        }



        public void Statistica(string criteriu)
        {
            if (criteriu.Equals("Brand") || criteriu.Equals("Marchio")) criteriu = "Marca";
            if (criteriu.Equals("Color") || criteriu.Equals("Colore")) criteriu = "Culoare";
            if (criteriu.Equals("Fuel") || criteriu.Equals("Carburante")) criteriu = "Combustibil";
            {
                Dictionary<string, int> lista = new Dictionary<string, int>();
                foreach (DataRow dr in this.autovehicule.Rows)
                {
                    string cheie = dr[criteriu].ToString();
                    if (lista.ContainsKey(cheie))
                        lista[cheie]++;
                    else
                        lista[cheie] = 1;
                }
                this.vizualizareAutovehicule.Grafic(lista);

            }
        }
    }
}
