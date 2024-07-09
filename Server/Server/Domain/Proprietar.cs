using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Domain
{
    public class Proprietar
    {
        public string nume;

        public Proprietar()
        {
            this.nume = "";

        }

        public Proprietar(string nume)
        {
            this.nume = nume;

        }

        public Proprietar(Proprietar p)
        {
            this.nume = p.nume;

        }

        public string AccesNume()
        {
            return this.nume;
        }

        public void ActualizareNume(string nume)
        {
            this.nume = nume;
        }
        public override string ToString()
        {
            return this.nume.ToString();
        }

    }
}
