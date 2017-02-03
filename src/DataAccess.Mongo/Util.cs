using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Mongo
{
    public static class Util<T>
    {
        public static IMongoCollection<T> GetDatabase(string name)
        {
            var client = new MongoClient("mongodb://localhost:27017/");
            var database = client.GetDatabase("aspnet-core-identity-sample");
            var collectionName = database.GetCollection<T>(name);
            return collectionName;
        }
    }
}
