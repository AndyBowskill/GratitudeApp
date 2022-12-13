using GratitudeAppLibrary.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GratitudeAppLibrary.DataAccess
{
    internal class DbConnection : IDbConnection
    {
        private readonly IConfiguration _configuration;
        private readonly IMongoDatabase _db;
        private string _connectionId = "MongoDB";
        public string DbName { get; set; }
        public MongoClient Client { get; set; }
        public string GratitudeCollectionName { get; set; } = "gratitudes";
        public string UserCollectionName { get; set; } = "users";
        public IMongoCollection<GratitudeModel> GratitudeCollection { get; set; }
        public IMongoCollection<UserModel> UserCollection { get; set; }
    }
}
