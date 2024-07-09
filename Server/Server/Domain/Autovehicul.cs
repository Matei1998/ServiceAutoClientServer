using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Domain
{
    public class Autovehicul
    {
        private string proprietar;
        private string marca;
        private string culoare;
        private string combustibil;

        public Autovehicul()
        {
            this.proprietar = ("");
            this.marca = "";
            this.culoare = "";
            this.combustibil = "";
        }
        public Autovehicul(string proprietar, string marca, string culoare, string combustibil)
        {
            this.proprietar = proprietar;
            this.marca = marca;
            this.culoare = culoare;
            this.combustibil = combustibil;

        }

        public Autovehicul(Autovehicul p)
        {
            this.proprietar = p.proprietar;
            this.marca = p.marca;
            this.culoare = p.culoare;
            this.combustibil = p.combustibil;
        }




        public string Proprietar { get => this.proprietar; set => this.proprietar = value; }
        public string Marca { get => this.marca; set => this.marca = value; }
        public string Culoare { get => culoare; set => culoare = value; }
        public string Combustibil { get => combustibil; set => combustibil = value; }


        public string AccesProprietar()
        {
            return this.proprietar;
        }
        public string AccesMarca()
        {
            return this.marca;
        }

        public string AccesCuloare()
        {
            return this.culoare;
        }

        public string AccesCombustibil()
        {
            return this.combustibil;
        }



        public override string ToString()
        {

            return this.proprietar + ";" + this.marca + ";" + this.culoare + ";" + this.combustibil.ToString();
        }
    }
}
