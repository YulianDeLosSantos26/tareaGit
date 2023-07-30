using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad.cache;


namespace CapaDatos
{
    public class CD_Login:DBconexion
    {
        public bool Login(string username, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection= connection;
                    command.CommandText= "select *from Login Where Username= @username and Password =@password";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader= command.ExecuteReader();
                    if (reader.HasRows)
                    {
                       
                        return true;
                    }
                    else
                        return false;   

                }
            }
        }
        



    }
}
