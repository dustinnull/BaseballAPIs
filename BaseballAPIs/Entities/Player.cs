using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseballAPIs.Entities
{
    public class Player
    {
        public int PID { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public string Position { get; set; }

        public int TID { get; set; }

    }
}

    