using SoccerAnalyticModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerAnalyticsRepository.Interface
{
    public interface IPlayerRepository : IRepository<Player>
    {
        void Update(Player player);
    }
}
