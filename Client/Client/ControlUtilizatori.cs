using Server.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.ServiceModel;
using System.Windows.Forms;
using Server;

namespace Client
{
    public class ControlUtilizatori
    {
        private IVizualizareUtilizatori vizualizareUtilizatori;
        private IUtilizatorRepository persistentaUtilizatori;
        private DataTable utilizatori;

        public ControlUtilizatori(IVizualizareUtilizatori vizualizareUtilizatori)
        {
            this.vizualizareUtilizatori = vizualizareUtilizatori;
            this.vizualizareUtilizatori.SetareControl(this);
            this.utilizatori = new DataTable();
            this.creareLegatura();
        }

        private void creareLegatura()
        {
            ChannelFactory<IUtilizatorRepository> canalUtilizator;
            NetTcpBinding tcp = new NetTcpBinding();
            tcp.OpenTimeout = new TimeSpan(0, 60, 0);
            tcp.SendTimeout = new TimeSpan(0, 60, 0);
            tcp.ReceiveTimeout = new TimeSpan(0, 60, 0);
            tcp.CloseTimeout = new TimeSpan(0, 60, 0);
            tcp.MaxReceivedMessageSize = int.MaxValue;
            tcp.Security.Mode = SecurityMode.Transport;
            tcp.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            tcp.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;
            string s = ConfigurationManager.ConnectionStrings["AdresaIP"].ConnectionString;
            canalUtilizator = new ChannelFactory<IUtilizatorRepository>(tcp, "net.tcp://" + s + ":52001/Utilizator");
            try
            {
                this.persistentaUtilizatori = canalUtilizator.CreateChannel();
                this.creareListaUtilizatori();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void creareListaUtilizatori()
        {
            try
            {
                DataSet ds = this.persistentaUtilizatori.VizualizareUtilizatori();
                this.utilizatori = ds.Tables["vizualizareUt"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public bool CautareUtilizator(int id_utilizator)
        {
            bool gasit = false;
            int i = 0;
            while (!gasit && i < this.utilizatori.Rows.Count)
            {
                DataRow dr = this.utilizatori.Rows[i];
                if ((int)dr["Legitimatie"] == id_utilizator)
                    gasit = true;
                else
                    i++;
            }
            return gasit;
        }

        public bool CautareUtilizator(int rand, int id_utilizator)
        {
            DataRow id_selectat = this.utilizatori.Rows[rand];
            int id = (int)id_selectat["Legitimatie"];
            bool gasit = false;
            int i = 0;
            while (!gasit && i < this.utilizatori.Rows.Count)
            {
                DataRow dr = this.utilizatori.Rows[i];
                if ((int)dr["Legitimatie"] == id_utilizator && id != id_utilizator)
                    gasit = true;
                else
                    i++;
            }
            return gasit;
        }

        public bool AdaugareUtilizator(Utilizator ut)
        {
            if (this.persistentaUtilizatori.AdaugareUtilizator(ut))
            {
                this.vizualizareUtilizatori.AdaugareUtilizator(ut);
                this.creareListaUtilizatori();
                return true;
            }
            else
                return false;
        }

        public bool ActualizareUtilizator(int rand, Utilizator ut)
        {
            DataRow id_utilizator = this.utilizatori.Rows[rand];
            if (this.persistentaUtilizatori.ActualizareUtilizator((int)id_utilizator["Legitimatie"], ut))
            {
                this.vizualizareUtilizatori.ReinitializareLista();
                this.creareListaUtilizatori();
                this.Vizualizare();
                return true;
            }
            else
                return false;
        }

        public bool StergereUtilizator(int rand)
        {
            DataRow dr = this.utilizatori.Rows[rand];
            if (this.persistentaUtilizatori.StergereUtilizator((int)dr["Legitimatie"]))
            {
                this.vizualizareUtilizatori.StergereUtilizator(rand);
                this.creareListaUtilizatori();
                return true;
            }
            else
                return false;
        }

        public void Vizualizare()
        {
            try
            {
                this.vizualizareUtilizatori.ReinitializareLista();
                foreach (DataRow dr in this.utilizatori.Rows)
                {
                    Utilizator utilizator = new Utilizator((int)dr["Legitimatie"], dr["Nume"].ToString(), dr["Cont"].ToString(), dr["Parola"].ToString(), dr["Rol"].ToString());
                    this.vizualizareUtilizatori.AdaugareUtilizator(utilizator);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FiltrareUtilizatori(string criteriu_filtrare)
        {
            try
            {
                this.vizualizareUtilizatori.ReinitializareLista();
                foreach (DataRow dr in this.utilizatori.Rows)
                {
                    if (dr["Rol"].ToString() == criteriu_filtrare)
                    {
                        Utilizator utilizator = new Utilizator((int)dr["Legitimatie"], dr["Nume"].ToString(), dr["Cont"].ToString(), dr["Parola"].ToString(), dr["Rol"].ToString());
                        this.vizualizareUtilizatori.AdaugareUtilizator(utilizator);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
