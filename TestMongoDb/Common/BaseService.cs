using MongoDB.Driver;
using TestMongoDb.Entities;
using TestMongoDb.Models;

namespace TestMongoDb.Common
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IMongoCollection<TEntity> _collection;
        public BaseService(MongoSettings settings , IMongoClient client)
        {
            var dataBase = client.GetDatabase(settings.DatabaseName);
            _collection = dataBase.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public void Delete(Guid id)
        {
            _collection.DeleteOne(f => f.Id == id);
        }

        public List<TEntity> GetAll()
        {
            return _collection.Find(t => true).ToList();
        }

        public TEntity GetById(Guid id)
        {
            return _collection.Find(f => f.Id == id).FirstOrDefault();
        }

        public void Insert(TEntity entity)
        {
            _collection.InsertOne( entity);
        }

        public void Update(TEntity entity)
        {
            _collection.ReplaceOne( f => f.Id == entity.Id, entity);
        }
    }
}
