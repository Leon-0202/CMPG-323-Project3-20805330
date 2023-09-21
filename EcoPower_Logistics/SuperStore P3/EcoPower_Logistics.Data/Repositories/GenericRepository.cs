using EcoPower_Logistics.Data.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EcoPower_Logistics.Data.Repositories
{
    /** 
     * This repository is the only class that accesses the DbContext directly.
     * It provides implementation for the basic CRUD operations.
     * The specialized repository classes inherit from this repository class,
     * and indirectly access the DbContext through it.
     */ 
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly SuperStoreContext _context;

        public GenericRepository(SuperStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return _context.Set<T>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Add)} entity must not be null");
            }
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Update)} entity must not be null");
            }
            try
            {
                _context.Update(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated {ex.Message}");
            }
        }

        public void Remove(T entity)
        {
            try
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Handle the exception
                if (ex.InnerException is SqlException sqlException)
                {
                    if (sqlException.Number == 547) // Error number for foreign key constraint violation in SQL Server
                    {
                        throw new Exception($"This record is associated with other existing records and can thus not be removed: {ex.Message}");
                    }
                    else
                    {
                        // Handle other SQL exceptions or rethrow the exception
                        throw new Exception($"Could not remove entity: {ex.Message}");
                    }
                }
                else
                {
                    // Handle other types of DbUpdateException or rethrow the exception
                    throw new Exception($"Could not remove entity: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not remove entity: {ex.Message}");
            }
        }
    }
}
