using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Tesis.Model
{
    public class DataAccess
    {
        string connST2 = ConfigurationManager.AppSettings["defaultConnection"].ToString();

        public List<Person> GetPersonas()
        {
            List<Person> result = new List<Person>();
            using (SqlConnection conn = new SqlConnection(connST2))
            {

                SqlCommand com = new SqlCommand("exec dbo.SelPersona", conn);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for(int i=0; i < dt.Rows.Count; i++)
                {
                    Person person = new Person();
                    DataRow dr = dt.Rows[i];
                    person.Id = Convert.ToInt32(dr["Id"].ToString());
                    person.Name = dr["Nombre"].ToString();
                    person.Age = Convert.ToInt32(dr["Edad"].ToString());
                    person.Email = dr["Email"].ToString();
                    result.Add(person);
                }
                return result;
            }
        }

        public DataTable GetPersonasPorBuscador(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connST2))
            {
                string command = String.Format("exec dbo.buscarPersonas '{0}'", nombre);
                //conn.Open();
                SqlCommand com = new SqlCommand(command, conn);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }

        }


        public void UpdatePersonas(int id, string nombre, int edad, string correo)
        {
            using (SqlConnection conn = new SqlConnection(connST2))
            {
                //placeholder
                string command = String.Format("exec dbo.UdpPersona '{0}','{1}', '{2}', '{3}'", id,
                                                                                                nombre,
                                                                                                edad,
                                                                                                correo);
                conn.Open();
                SqlCommand com2 = new SqlCommand(command, conn);
                com2.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void CreatePersona(string nombre, int edad, string correo)
        {
            using (SqlConnection conn = new SqlConnection(connST2))
            {
                string command = String.Format("exec dbo.InsPersona '{0}','{1}', '{2}'",
                                                                                               nombre,
                                                                                               edad,
                                                                                               correo);
                conn.Open();
                SqlCommand com2 = new SqlCommand(command, conn);
                com2.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void DeletePersonas(int id)
        {
            using (SqlConnection conn = new SqlConnection(connST2))
            {
                string command = String.Format("exec dbo.DelPersona '{0}'", id);
                conn.Open();
                SqlCommand com2 = new SqlCommand(command, conn);
                com2.ExecuteNonQuery();
                conn.Close();
            }

        }

    }

}
