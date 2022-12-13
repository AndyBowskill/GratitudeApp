using GratitudeAppLibrary.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GratitudeAppLibrary.DataAccess
{
    internal class MongoGratitudeData
    {
        private readonly IDbConnection _db;
        private readonly IMongoCollection<GratitudeModel> _gratitude;

        public MongoGratitudeData(IDbConnection db)
        {
            _db = db;
            _gratitude = db.GratitudeCollection;
        }
    }
}
