﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPower_Logistics.Data.Data;

namespace EcoPower_Logistics.Data.Repositories
{
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
            catch (Exception ex)
            {
                throw new Exception($"Could not remove entity: {ex.Message}");
            }
        }
    }
}
