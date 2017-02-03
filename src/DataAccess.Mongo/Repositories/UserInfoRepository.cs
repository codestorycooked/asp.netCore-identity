using DataAccess.Mongo.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Mongo.Repositories
{
    public class UserInfoRepository : IBaseInterface<Users>
    {
        private readonly IMongoCollection<Users> dbContext;
        public UserInfoRepository()
        {
            string collectionname = typeof(Users).Name.ToLower();
            dbContext = Util<Users>.GetDatabase(collectionname);
        }
        public void DeleteByID(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> GetAll()
        {
            return dbContext.Find<Users>(null, null).ToEnumerable();
        }

        public Users GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(Users data)
        {
            throw new NotImplementedException();
        }

        public void Put(Users data)
        {
            throw new NotImplementedException();
        }
    }
}
