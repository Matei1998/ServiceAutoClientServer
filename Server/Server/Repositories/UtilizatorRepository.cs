using Server.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false, InstanceContextMode = InstanceContextMode.Single)]

    internal class UtilizatorRepository : IUtilizatorRepository
    {
        public UtilizatorRepository()
        {

        }

        public bool AdaugareUtilizator(Utilizator ut)
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
                SqlCommand adaugare = new SqlCommand("insert into Utilizator values('" + ut.Legitimatie + "','" + ut.Nume + "','" + ut.Cont + "','" + ut.Parola + "','" + ut.Rol + "')", conexiune);
                if (adaugare.ExecuteNonQuery() == 0)
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

        public bool ActualizareUtilizator(int id_utilizator, Utilizator ut)
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
                SqlCommand actualizare = new SqlCommand("update Utilizator set Legitimatie = '" + ut.Legitimatie + "', Nume = '" + ut.Nume + "', Cont = '" + ut.Cont + "', Parola = '" + ut.Parola + "', Rol = '" + ut.Rol + "' where Legitimatie = '" + id_utilizator + "'", conexiune);
                if (actualizare.ExecuteNonQuery() == 0)
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

        public bool StergereUtilizator(int id_utilizator)
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
               SqlCommand stergere = new SqlCommand("delete from Utilizator where Legitimatie = '" + id_utilizator + "'", conexiune);
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

        public DataSet VizualizareUtilizatori()
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
                SqlCommand vizualizare = new SqlCommand("Select * from Utilizator sort order by Legitimatie", conexiune);
                SqlDataAdapter dateCitite = new SqlDataAdapter(vizualizare);
                DataSet ds = new DataSet();
                dateCitite.Fill(ds, "vizualizareUt");
                conexiune.Close();
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Utilizator Logare(string user, string parola)
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
                SqlCommand vizualizare = new SqlCommand("Select * from Utilizator where Cont ='" + user + "' and Parola ='" + parola + "'", conexiune);
                SqlDataAdapter dateCitite = new SqlDataAdapter(vizualizare);
                DataSet ds = new DataSet();
                dateCitite.Fill(ds, "vizualizareUt");
                conexiune.Close();


                if (ds.Tables[0].Rows.Count != 0)
                {
                    int legitimatie = Convert.ToInt32(ds.Tables[0].Rows[0]["Legitimatie"].ToString());
                    string nume = ds.Tables[0].Rows[0]["Nume"].ToString();
                    string cont = ds.Tables[0].Rows[0]["Cont"].ToString();
                    string parola_utilizator = ds.Tables[0].Rows[0]["Parola"].ToString();
                    string rol = ds.Tables[0].Rows[0]["Rol"].ToString();
                    Utilizator utilizator = new Utilizator(legitimatie, nume, cont, parola_utilizator, rol);
                    return utilizator;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
