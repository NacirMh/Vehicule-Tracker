using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimalateurVehicule.Infrastructure
{
    internal class ConnectionManager
    {
        private static ConnectionManager _instance;
        private MySqlConnection _con;
       
        private ConnectionManager(String connectionString)
        {
            _con = new MySqlConnection(connectionString);
            _con.Open();
        }

        public static ConnectionManager GetInstance(String connectionString)
        {
            if( _instance == null)
            {
                _instance = new ConnectionManager(connectionString);
    
            }

            return _instance;
        }

        public MySqlConnection GetConnection()
        {
            return _con;
        }

     
    }
}
