using Agrowio.Common.Persistence.Entities.BaseEntities;
using Agrowio.SensorDbWriteService.Entities.Abstract;
using Agrowio.SensorDbWriteService.Entities.Concrete;
using Agrowio.SensorDbWriteService.Infastructure.Abstract;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Infastructure.Concrete
{
    public class DbService<T>:IDbService<T> where T : BaseCollection
    {
        IMongoClient _client;
        IMongoDatabase _db;
        IMongoCollection<T> _collection;
        //public string CollectionName=String.Empty;
        
        public DbService(string _collectionName)
        {
            const string uri = "mongodb://localhost:27017";
            _client = new MongoClient(uri);
            _db = _client.GetDatabase("Agrowio");
            _collection = _db.GetCollection<T>(_collectionName);
        }

        public bool Add(T entity)
        {
            try
            {
                _collection.InsertOne(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
       

        public T GetById(ObjectId id)
        {
            try
            {
                return _collection.Find(p => p.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {

                return null;
            }

        }
        public List<T> GetAll()
        {
            try
            {
                return _collection.Find(_ => true).ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public T Update(T entity)
        {
            try
            {
                //var updateDef = Builders<T>.Update
                //    .Set("DeviceIdentity", entity.Metadata.DeviceIdentity)
                //    .Set("InputType", entity.Metadata.InputType);
                //_collection.UpdateOne(x => x.Id == entity.Id, updateDef);
                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Remove(ObjectId id)
        {
            try
            {
                _collection.DeleteOne(p => p.Id == id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
        {
            return (await _collection.FindAsync(predicate)).SingleOrDefault();
            
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            return (await _collection.FindAsync(predicate)).ToList();
        }

        //TODO Delete Single Async metotu Timeseries lerde throw atıyormuş kullanmayacağız ama şimdilik dursun
        public async Task<long> DeleteSingleAsync(Expression<Func<T, bool>> predicate)
        {
            return (await _collection.DeleteOneAsync(predicate)).DeletedCount;
           
        }

        public async Task<long> DeleteManyAsync(Expression<Func<T, bool>> predicate)
        {
            return (await _collection.DeleteManyAsync(predicate)).DeletedCount;
        }

        public async  Task<bool> AddSignleAsync(T entity)
        {

            try
            {
                await _collection.InsertOneAsync(entity);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
            

            
        }

        public async Task<bool> AddManyAsync(List<T> entities)
        {
            try
            {
                await _collection.InsertManyAsync(entities);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
