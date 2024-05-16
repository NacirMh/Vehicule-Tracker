using SimalateurVehicule.domain;

using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimalateurVehicule.Infrastructure
{
    internal class DaoVPosition : IDao
    {
        private MySqlConnection _con;
        private string _connectionString = "server=localhost;port=3306;user=root;database=vehiculeSimulator;Uid=root;";
        
        public DaoVPosition()
        {
            _con = ConnectionManager.GetInstance(_connectionString).GetConnection();
        }


        bool IDao.stock(DTOstock s)
        {
            string query = "insert into vehiculePosition (matricule , positionX , positionY , time) values (@matricule , @positionX , @positionY , @time)";
            MySqlCommand cmd = new MySqlCommand(query, _con);
            cmd.Parameters.AddWithValue("@matricule", s.Matricule);
            cmd.Parameters.AddWithValue("@positionX", s.X);
            cmd.Parameters.AddWithValue("@positionY", s.Y);
            cmd.Parameters.AddWithValue("@time", s.Time);
            int rows = cmd.ExecuteNonQuery();
            return rows > 0;
        }
        public List<DTOstock> retrieve(int id, DateTime date1, DateTime date2)
        {
            string query = "SELECT * FROM vehiculePosition WHERE matricule = @id AND time between @startDate AND @endDate";
            MySqlCommand cmd = new MySqlCommand(query, _con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@startDate", date1);
            cmd.Parameters.AddWithValue("@endDate", date2);

            List<DTOstock> vehiculePositions = new List<DTOstock>();

            DTOstock positionV = null;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                positionV = new DTOstock
                {
                    Matricule = (int)reader["matricule"],
                    X = (int)reader["positionX"],
                    Y = (int)reader["positionY"],
                    Time = Convert.ToDateTime(reader["time"])
                };
                vehiculePositions.Add(positionV);

            }


            return vehiculePositions;
        }
    }
}
