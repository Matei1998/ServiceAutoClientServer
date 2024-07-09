using Server.Domain;
using Server.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conectare la baza de date serviceauto ...");
            NetTcpBinding tcp = new NetTcpBinding();
            tcp.OpenTimeout = new TimeSpan(0, 60, 0);
            tcp.SendTimeout = new TimeSpan(0, 60, 0);
            tcp.ReceiveTimeout = new TimeSpan(0, 60, 0);
            tcp.CloseTimeout = new TimeSpan(0, 60, 0);
            tcp.MaxReceivedMessageSize = System.Int32.MaxValue;
            tcp.ReaderQuotas.MaxArrayLength = System.Int32.MaxValue;
            string s = ConfigurationManager.ConnectionStrings["AdresaIP"].ConnectionString;
            tcp.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            tcp.Security.Message.ClientCredentialType = MessageCredentialType.Certificate;
            try
            {
                UtilizatorRepository utilizator = new UtilizatorRepository();
                ServiceHost gazda = new ServiceHost(utilizator);
                gazda.AddServiceEndpoint(typeof(IUtilizatorRepository), tcp, "net.tcp://" + s + ":52001/Utilizator");
                gazda.Open();


                AutovehiculRepository auto = new AutovehiculRepository();
                ServiceHost gazda2 = new ServiceHost(auto);
                gazda2.AddServiceEndpoint(typeof(IAutovehiculRepository), tcp, "net.tcp://" + s + ":52002/Autovehicul");
                gazda2.Open();


                Console.WriteLine("Conectare realizata.");
                utilizator.VizualizareUtilizatori();
                auto.VizualizareAutovehicule();

                Console.ReadLine();
                gazda.Close();
                gazda2.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Nu s-a realizat conectarea la baza de date. " + ex.ToString());
                Console.ReadLine();
            }
        }
    }
}
