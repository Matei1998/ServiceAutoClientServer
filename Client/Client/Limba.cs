using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Client
{
    public class Limba
    {
        private string limba;

        public Limba()
        {
            this.limba = "romana";
        }

        public Limba(string limba)
        {
            this.limba = limba;
        }

        public string AccesLimba()
        {
            return this.limba;
        }

        public void ActualizareLimba(string limba)
        {
            this.limba = limba;
        }

        public Dictionary<string, string> CautareInformatie(string limba)
        {
            try
            {
                Dictionary<string, string> date = new Dictionary<string, string>();
                XDocument xDoc = XDocument.Load(@"limba_autentificare.xml");
                List<XElement> xElemente = xDoc.Root.Elements(limba).ToList();
                foreach (XElement xElement in xElemente)
                {
                    date.Add("user", xElement.Element("user").Value);
                    date.Add("parola", xElement.Element("parola").Value);
                    date.Add("autentificare", xElement.Element("autentificare").Value);
                    date.Add("limba", xElement.Element("limba").Value);
                }
                return date;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public Dictionary<string, string> Traducere_VizualizareUtilizatori(string limba)
        {
            try
            {
                Dictionary<string, string> date = new Dictionary<string, string>();
                XDocument xDoc = XDocument.Load(@"limba_administrator.xml");
                List<XElement> xElemente = xDoc.Root.Elements(limba).ToList();
                foreach (XElement xElement in xElemente)
                {
                    date.Add("id", xElement.Element("id").Value);
                    date.Add("nume", xElement.Element("nume").Value);
                    date.Add("utilizator", xElement.Element("utilizator").Value);
                    date.Add("parola", xElement.Element("parola").Value);
                    date.Add("rol", xElement.Element("rol").Value);
                    date.Add("cmbRol_angajat", xElement.Element("cmbRol_angajat").Value);
                    date.Add("cmbRol_admin", xElement.Element("cmbRol_admin").Value);
                    date.Add("cmbRol_manager", xElement.Element("cmbRol_manager").Value);

                    date.Add("filtrare_rol", xElement.Element("filtrare_rol").Value);
                    date.Add("cmbFiltrare_Angajat", xElement.Element("cmbFiltrare_Angajat").Value);
                    date.Add("cmbFiltrare_Admin", xElement.Element("cmbFiltrare_Admin").Value);
                    date.Add("cmbFiltrare_Manager", xElement.Element("cmbFiltrare_Manager").Value);

                    date.Add("afis_lista", xElement.Element("afis_lista").Value);
                    date.Add("deconectare", xElement.Element("deconectare").Value);
                    date.Add("adaugare_utilizator", xElement.Element("adaugare_utilizator").Value);
                    date.Add("actualizare_utilizator", xElement.Element("actualizare_utilizator").Value);
                    date.Add("stergere_utilizator", xElement.Element("stergere_utilizator").Value);
                    date.Add("filtreaza", xElement.Element("filtreaza").Value);
                    date.Add("tabel_id", xElement.Element("tabel_id").Value);
                    date.Add("tabel_nume", xElement.Element("tabel_nume").Value);
                    date.Add("tabel_user", xElement.Element("tabel_user").Value);
                    date.Add("tabel_parola", xElement.Element("tabel_parola").Value);
                    date.Add("tabel_rol", xElement.Element("tabel_rol").Value);


                }
                return date;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public Dictionary<string, string> Traducere_VizualizareAutovehicule(string limba)
        {
            try
            {
                Dictionary<string, string> date = new Dictionary<string, string>();
                XDocument xDoc = XDocument.Load(@"limba_manager.xml");
                List<XElement> xElemente = xDoc.Root.Elements(limba).ToList();
                foreach (XElement xElement in xElemente)
                {
                   
                    date.Add("proprietar", xElement.Element("proprietar").Value);
                    date.Add("marca", xElement.Element("marca").Value);
                    date.Add("culoare", xElement.Element("culoare").Value);
                    date.Add("combustibil", xElement.Element("combustibil").Value);
                    date.Add("deconectare", xElement.Element("deconectare").Value);
                    date.Add("adaugare_autovehicul", xElement.Element("adaugare_autovehicul").Value);
                    date.Add("actualizare_autovehicul", xElement.Element("actualizare_autovehicul").Value);
                    date.Add("stergere_autovehicul", xElement.Element("stergere_autovehicul").Value);
                    date.Add("tabel_proprietar", xElement.Element("tabel_proprietar").Value);
                    date.Add("tabel_marca", xElement.Element("tabel_marca").Value);
                    date.Add("tabel_culoare", xElement.Element("tabel_culoare").Value);
                    date.Add("tabel_combustibil", xElement.Element("tabel_combustibil").Value);
                    date.Add("btnSalvareCsvJson", xElement.Element("btnSalvareCsvJson").Value);
                    date.Add("btnLista_Autovehicule", xElement.Element("btnLista_Autovehicule").Value);
                    date.Add("lbSortare", xElement.Element("lbSortare").Value);
                    date.Add("btnSortare", xElement.Element("btnSortare").Value);
                    date.Add("cmbSortare_Cres_Marca", xElement.Element("cmbSortare_Cres_Marca").Value);
                    date.Add("cmbSortare_Desc_Marca", xElement.Element("cmbSortare_Desc_Marca").Value);
                    date.Add("lbCautare_Marca", xElement.Element("lbCautare_Marca").Value);
                    date.Add("btnCauta", xElement.Element("btnCauta").Value);
                    date.Add("checkboxStatistica", xElement.Element("checkboxStatistica").Value);
                    date.Add("lbFiltre", xElement.Element("lbFiltre").Value);
                    date.Add("cmbFiltre_proprietar", xElement.Element("cmbFiltre_proprietar").Value);
                    date.Add("cmbFiltre_marca", xElement.Element("cmbFiltre_marca").Value);
                    date.Add("cmbFiltre_culoare", xElement.Element("cmbFiltre_culoare").Value);
                    date.Add("btnFiltrare", xElement.Element("btnFiltrare").Value);
                    date.Add("lbCriteriu", xElement.Element("lbCriteriu").Value);
                    date.Add("cmbStatistica_Marca", xElement.Element("cmbStatistica_Marca").Value);
                    date.Add("cmbStatistica_Culoare", xElement.Element("cmbStatistica_Culoare").Value);
                    date.Add("cmbStatistica_Combustibil", xElement.Element("cmbStatistica_Combustibil").Value);
                }
                return date;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public Dictionary<string, string> Traducere_VizualizareAutovehiculeAngajat(string limba)
        {
            try
            {
                Dictionary<string, string> date = new Dictionary<string, string>();
                XDocument xDoc = XDocument.Load(@"limba_angajat.xml");
                List<XElement> xElemente = xDoc.Root.Elements(limba).ToList();
                foreach (XElement xElement in xElemente)
                {
                    date.Add("proprietar", xElement.Element("proprietar").Value);
                    date.Add("marca", xElement.Element("marca").Value);
                    date.Add("culoare", xElement.Element("culoare").Value);
                    date.Add("combustibil", xElement.Element("combustibil").Value);
                    date.Add("deconectare", xElement.Element("deconectare").Value);
                    date.Add("adaugare_autovehicul", xElement.Element("adaugare_autovehicul").Value);
                    date.Add("actualizare_autovehicul", xElement.Element("actualizare_autovehicul").Value);
                    date.Add("stergere_autovehicul", xElement.Element("stergere_autovehicul").Value);
                    date.Add("tabel_proprietar", xElement.Element("tabel_proprietar").Value);
                    date.Add("tabel_marca", xElement.Element("tabel_marca").Value);
                    date.Add("tabel_culoare", xElement.Element("tabel_culoare").Value);
                    date.Add("tabel_combustibil", xElement.Element("tabel_combustibil").Value);
                    
                    date.Add("btnLista_Autovehicule", xElement.Element("btnLista_Autovehicule").Value);
                  
                  
                    date.Add("lbCautare_Marca", xElement.Element("lbCautare_Marca").Value);
                    date.Add("btnCauta", xElement.Element("btnCauta").Value);
                    
                    date.Add("lbFiltre", xElement.Element("lbFiltre").Value);
                    date.Add("cmbFiltre_proprietar", xElement.Element("cmbFiltre_proprietar").Value);
                    date.Add("cmbFiltre_marca", xElement.Element("cmbFiltre_marca").Value);
                    date.Add("cmbFiltre_culoare", xElement.Element("cmbFiltre_culoare").Value);
                    date.Add("btnFiltrare", xElement.Element("btnFiltrare").Value);
                  
                  
                }
                return date;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

    }
}