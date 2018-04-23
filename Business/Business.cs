using Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busy
{
    public class Business
    {
        public static List<Pessoa> lista = new List<Pessoa>();
        public List<Pessoa> Populate()
        {
            try
            {
                string caminho = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Infnet\AspNet\Azure\TP1\Data\DB.mdf;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(caminho))
                {
                    con.Open();
                    string query = "Select * from Pessoas";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Pessoa p = new Pessoa()
                        {
                            id = Convert.ToInt32(dr["Id"]),
                            nome = Convert.ToString(dr["nome"]),
                            sobrenome = Convert.ToString(dr["sobrenome"]),
                            email = Convert.ToString(dr["email"]),
                            data_nascimento = Convert.ToDateTime(dr["data_nascimento"])

                        };

                        lista.Add(p);
                    }
                    return lista;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
