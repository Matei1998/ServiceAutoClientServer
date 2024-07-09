using Server.Domain;

namespace Client
{
    public interface IVizualizareUtilizatori
    {

        


        void SetareControl(ControlUtilizatori controlUtilizatori);

        void AdaugareUtilizator(Utilizator utilizator);

        void ReinitializareLista();

        void StergereUtilizator(int rand);
    }
}
