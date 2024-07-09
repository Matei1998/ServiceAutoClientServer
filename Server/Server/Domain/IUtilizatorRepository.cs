using Server.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [ServiceContract]
    public interface IUtilizatorRepository
    {
        [OperationContract]
        bool AdaugareUtilizator(Utilizator ut);

        [OperationContract]
        bool ActualizareUtilizator(int id_utilizator, Utilizator ut);

        [OperationContract]
        bool StergereUtilizator(int id_utilizator);

        [OperationContract]
        DataSet VizualizareUtilizatori();

        [OperationContract]
        Utilizator Logare(string user, string parola);
    }
}
