using Server.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public interface IVizualizareAutovehiculeAngajat
    {
        string Proprietar { get; set; }
        string Marca { get; set; }
        string Culoare { get; set; }
        string Combustibil { get; set; }

        void SetareControl(ControlAutovehicule controlAutovehicule);

        void AddAutovehicul(Autovehicul autovehicul);

        void UpdateAutovehicul(string proprietar, Autovehicul autovehicul);

        void DeleteAutovehicul(string proprietar);

      

        void ReinitializareLista();
    }
}
