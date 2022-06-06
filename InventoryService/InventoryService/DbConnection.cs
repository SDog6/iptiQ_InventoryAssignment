using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService
{
    public class DbConnection
    {
        protected static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Daenir\Documents\GitStuff\iptiQ_InventoryAssignment\InventoryService\InventoryService\Database1.mdf;Integrated Security=True");


        public DbConnection()
        {}
    }
}
