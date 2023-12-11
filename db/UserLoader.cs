using ExamenInterfaces.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenInterfaces.db
{
    internal class UserLoader
    {
        public UserList Users { get; set; }
        private DataConnector connector;
        public static UserLoader _instance = new UserLoader();

        private UserLoader() { 
            connector = new DataConnector();
            this.Users = new UserList();
        }
        public void LoadListFromDatabase()
        {
            using (MySqlConnection conn = connector.GetConnection())
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Usuario;";
                ReadQueryResult(cmd);
            }
        }

        private void ReadQueryResult(MySqlCommand cmd)
        {
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Users.AddUser(new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                }
            }
        }
    }
}
