using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public abstract class DBconexion
    {
        private readonly string connectionString;
        public DBconexion()
        {
            connectionString = "Server=DESKTOP-OSRUOIR\\SQLEXPRESS;DataBase= Agenda_electrónica; integrated security = true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
