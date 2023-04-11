using Agrowio.SensorDbWriteService.Entities.Concrete;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Infastructure.Abstract
{
    public interface IDbService<T>
    {
        public bool Add(T item);
        public bool Remove(Guid id);
        public T Update(T item);
        public T GetById(Guid id);
        public List<T> GetAll();


        //public T GetSingleAsync(Expression<Func<T, bool>> predicate);

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate);

        public Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate);

        public Task<long> DeleteSingleAsync(Expression<Func<T, bool>> predicate);

        public Task<long> DeleteManyAsync(Expression<Func<T, bool>> predicate);

        public Task<bool> AddSignleAsync(T entity);

        public Task<bool> AddManyAsync(List<T> entities);
        
    }
}
