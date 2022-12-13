using GratitudeAppLibrary.Models;
using MongoDB.Driver;

namespace GratitudeAppLibrary.DataAccess
{
    internal interface IDbConnection
    {
        MongoClient Client { get; set; }
        string DbName { get; set; }
        string GratitudeCollectionName { get; set; }
        string UserCollectionName { get; set; }
        IMongoCollection<GratitudeModel> GratitudeCollection { get; set; }
        IMongoCollection<UserModel> UserCollection { get; set; }
    }
}