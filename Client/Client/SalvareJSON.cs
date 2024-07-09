using Newtonsoft.Json;
using Server.Domain;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Client.Model
{
    public class SalvareJSON : Salvare
    {
        private static string FILENAME = "autovehicule_filtrate.json";

        public override void SalvareAutovehiculeFiltrate(List<Autovehicul> lista)
        {
            string path = getPath(FILENAME);
            string result = JsonConvert.SerializeObject(lista, Newtonsoft.Json.Formatting.Indented);

            using (var tw = new StreamWriter(path, false))
            {
                tw.WriteLine(result);
                tw.Close();
            }
        }
    }
}
