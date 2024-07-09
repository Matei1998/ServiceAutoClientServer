using Server.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;

namespace Server.Repositories
{

    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false, InstanceContextMode = InstanceContextMode.Single)]

    internal class AutovehiculRepository : IAutovehiculRepository
    {

        public AutovehiculRepository()
        {

        }


        private string connectionString = ConfigurationManager.ConnectionStrings["ServiceAuto"].ConnectionString;

        public bool AdaugareAutovehicul(Autovehicul autovehicul)


        {

            bool rezultat = true;
            SqlConnection conexiune = null;

            try
            {
                string s = ConfigurationManager.ConnectionStrings["ServiceAuto"].ConnectionString;
                conexiune = new SqlConnection(s);
                if (conexiune.State == ConnectionState.Closed)
                    conexiune.Open();
                else
                {
                    conexiune.Close();
                    conexiune.Open();

                }

                SqlCommand adaugare = new SqlCommand("insert into autovehicul values('" + autovehicul.Proprietar + "','" + autovehicul.Marca + "','" + autovehicul.Culoare + "','" + autovehicul.Combustibil + "')", conexiune);
                if (adaugare.ExecuteNonQuery() == 0)
                    rezultat = false;
                conexiune.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la adăugarea autovehiculului: " + ex.Message);
                return false;
            }
            return rezultat;
        }

        public bool ActualizareAutovehicul(string proprietar, Autovehicul autovehicul)
        {
            bool rezultat = true;
            SqlConnection conexiune = null;

            try
            {
                string s = ConfigurationManager.ConnectionStrings["ServiceAuto"].ConnectionString;
                conexiune = new SqlConnection(s);
                if (conexiune.State == ConnectionState.Closed)
                    conexiune.Open();
                else
                {
                    conexiune.Close();
                    conexiune.Open();

                }

                SqlCommand actualizare = new SqlCommand("update autovehicul set marca = '" + autovehicul.Marca + "', culoare = '" + autovehicul.Culoare + "', combustibil = '" + autovehicul.Combustibil + "' where proprietar = '" + autovehicul.Proprietar + "'", conexiune);
                if (actualizare.ExecuteNonQuery() == 0)
                    rezultat = false;
                conexiune.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la actualizarea autovehiculului: " + ex.Message);
                return false;
            }
            return rezultat;
        }

        public bool StergereAutovehicul(string proprietar)
        {
            bool rezultat = true;
            SqlConnection conexiune = null;
            try
            {
                string s = ConfigurationManager.ConnectionStrings["ServiceAuto"].ConnectionString;
                conexiune = new SqlConnection(s);
                if (conexiune.State == ConnectionState.Closed)
                    conexiune.Open();
                else
                {
                    conexiune.Close();
                    conexiune.Open();
                }
                SqlCommand stergere = new SqlCommand("delete from autovehicul where proprietar = '" + proprietar + "'", conexiune);
                if (stergere.ExecuteNonQuery() == 0)
                    rezultat = false;
                conexiune.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                rezultat = false;
            }
            return rezultat;
        }

        public DataSet VizualizareAutovehicule()
        {
            SqlConnection conexiune = null;
            try
            {
                string s = ConfigurationManager.ConnectionStrings["ServiceAuto"].ConnectionString;
                conexiune = new SqlConnection(s);
                if (conexiune.State == ConnectionState.Closed)
                    conexiune.Open();
                else
                {
                    conexiune.Close();
                    conexiune.Open();
                }
               SqlCommand vizualizare = new SqlCommand("Select * from Autovehicul order by proprietar", conexiune);
                SqlDataAdapter dateCitite = new SqlDataAdapter(vizualizare);
                DataSet ds = new DataSet();
                dateCitite.Fill(ds, "vizualizareAutovehicule");
                conexiune.Close();
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
