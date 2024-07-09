using Server.Domain;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Client.Model
{
    public class SalvareCSV : Salvare
    {
        private static string FILENAME = "autovehicule_filtrate.csv";

        public override void SalvareAutovehiculeFiltrate(List<Autovehicul> lista)
        {
            string path = getPath(FILENAME);
            StringBuilder csvContent = new StringBuilder();

            bool header = false;
            if (File.Exists(path))
                File.Delete(path);

            foreach (Autovehicul autovehicul in lista)
            {
                string proprietar = autovehicul.Proprietar;
                string marca = autovehicul.Marca;
                string culoare = autovehicul.Culoare;
                string combustibil = autovehicul.Combustibil;

                string csv;
                string[] autovehiculCsv = { proprietar, marca, culoare,combustibil };

                if (!header)
                {
                    csvContent.AppendLine("proprietar,marca,culoare,combustibil");
                    header = true;
                }

                csv = string.Join(",", autovehiculCsv);
                csvContent.AppendLine(csv);
            }

            File.AppendAllText(path, csvContent.ToString());
        }
    }
}
