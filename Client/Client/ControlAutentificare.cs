using Server;
using Server.Domain;
using Server.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public class ControlAutentificare
    {

        private IVizualizareAutentificare vizualizareAutentificare;
        private IUtilizatorRepository persistentaUtilizator;

        public ControlAutentificare(IVizualizareAutentificare vizualizareAutentificare)
        {
            this.vizualizareAutentificare = vizualizareAutentificare;
            this.vizualizareAutentificare.SetareControl(this);

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
            tcp.MaxReceivedMessageSize = System.Int32.MaxValue;
            tcp.Security.Mode = SecurityMode.Transport;
            tcp.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            tcp.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;
            string s = ConfigurationManager.ConnectionStrings["AdresaIP"].ConnectionString;
            canalUtilizator = new ChannelFactory<IUtilizatorRepository>(tcp, "net.tcp://" + s + ":52001/Utilizator");
            try
            {
                this.persistentaUtilizator = canalUtilizator.CreateChannel();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public Utilizator Logare(string user, string parola)
        {
            return this.persistentaUtilizator.Logare(user, parola);


        }





    }
}

