using SoccerAnalyticModels;
using SoccerAnalyticsDataAccess.Data;
using SoccerAnalyticsRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerAnalyticsRepository.ClassImplementation
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        private AppDbContext _db;
        public PlayerRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Player player)
        {
            _db.Players.Update(player);
        }
    }
}
