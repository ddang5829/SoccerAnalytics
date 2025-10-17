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
    public class PlayerRepository : Repository<Player>
    {
        private AppDbContext _db;
        public PlayerRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
