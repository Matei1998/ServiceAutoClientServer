using Server.Domain;
using System;
using System.Collections.Generic;
using System.IO;

namespace Client.Model
{
    public abstract class Salvare
    {
        public abstract void SalvareAutovehiculeFiltrate(List<Autovehicul> lista);

        protected string getPath(string fileName)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        }
    }
}
