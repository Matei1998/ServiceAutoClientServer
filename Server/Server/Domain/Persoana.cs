using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Domain
{
    public class Persoana
    {
        protected string nume;
        protected int legitimatie;

        public Persoana()
        {
            this.nume = "";
            this.legitimatie = 0;
        }

        public Persoana(int legitimatie, string nume)
        {
            this.nume = nume;
            this.legitimatie = legitimatie;
        }

        public Persoana(Persoana p)
        {
            this.nume = p.nume;
            this.legitimatie = p.legitimatie;
        }

        public string Nume { get => this.nume; set => this.nume = value; }
        public int Legitimatie { get => this.legitimatie; set => this.legitimatie = value; }

        public string AccesNume()
        {
            return this.nume;
        }

        public int AccesLegitimatie()
        {
            return this.legitimatie;
        }


        public override string ToString()
        {
            return this.legitimatie.ToString() + ";" + this.nume;
        }
    }
}
