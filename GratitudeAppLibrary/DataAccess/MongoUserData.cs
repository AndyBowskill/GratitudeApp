using GratitudeAppLibrary.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GratitudeAppLibrary.DataAccess
{
    internal class MongoUserData
    {
        private readonly IDbConnection _db;
        private readonly IMongoCollection<UserModel> _users;

        public MongoUserData(IDbConnection db)
        {
            _db = db;
            _users = db.UserCollection;
        }
    }
}
