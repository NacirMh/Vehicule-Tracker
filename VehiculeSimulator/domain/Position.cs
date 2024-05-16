using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimalateurVehicule.domain
{
    internal class Position
    {
        private int id;
        private int x;
        private int y;
        private DateTime timestamp;

        Random random = new Random();

        public int Id { get => id; set => id = value; }
        public int X { get => random.Next(10,100); }
        public int Y { get => random.Next(10, 100); }
        public DateTime Timestamp { get => DateTime.Now; }
    }
}
