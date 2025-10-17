using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerAnalyticModels
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Player> PlayerList { get; set; }
    }
}
