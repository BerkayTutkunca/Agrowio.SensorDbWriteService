using Agrowio.SensorDbWriteService.Infastructure.Abstract;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Infastructure.Concrete
{
    //BU GEREKSİZ Sileceğiz
    public class BaseRepository<T> : IDbService<T>
    {
        public bool Add(T item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddManyAsync(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddSignleAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<long> DeleteManyAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<long> DeleteSingleAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T GetById(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Remove(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public T Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
