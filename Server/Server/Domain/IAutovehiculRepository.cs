using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.Domain
{
    [ServiceContract]

    public interface IAutovehiculRepository
    {
        [OperationContract]
        bool AdaugareAutovehicul(Autovehicul autovehicul);

        [OperationContract]
        bool StergereAutovehicul(string proprietar);

        [OperationContract]
        bool ActualizareAutovehicul(string proprietar, Autovehicul autovehicul);

        [OperationContract]
        DataSet VizualizareAutovehicule();

        

    }
}
