using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            VizualizareAutentificare vizualizareAutentificare = new VizualizareAutentificare();
            vizualizareAutentificare.Visible = false;
            ControlAutentificare control = new ControlAutentificare(vizualizareAutentificare);
            vizualizareAutentificare.ShowDialog();
        }
    }
}
