using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Domain
{
    public class Utilizator : Persoana
    {
        private string cont;
        private string parola;
        private string rol;

        public Utilizator() : base()
        {
            this.cont = "";
            this.parola = "";
            this.rol = "";
        }

        public Utilizator(int legitimatie, string nume, string cont, string parola, string rol)
              : base(legitimatie, nume)
        {
            this.cont = cont;
            this.parola = parola;
            this.rol = rol;
        }

        public Utilizator(Utilizator u)
        {
            this.nume = u.nume; //in plus
            this.legitimatie = u.legitimatie;
            this.cont = u.cont;
            this.parola = u.parola;
            this.rol = u.rol;
        }

        public string Cont { get => this.cont; set => this.cont = value; }
        public string Parola { get => this.parola; set => this.parola = value; }
        public string Rol { get => rol; set => rol = value; }


        public string AccesRol()
        {
            return this.rol;
        }

        public string AccesCont()
        {
            return this.cont;
        }

        public string AccesParola()
        {
            return this.parola;
        }



        public override string ToString()
        {
            string s = base.ToString();
            s += ";" + this.cont + ";" + this.parola + ";" + this.rol;
            return s;
        }
    }
}
