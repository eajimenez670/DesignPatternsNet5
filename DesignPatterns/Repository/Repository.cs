using DesignPatterns.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase, new()
    {
        private readonly DesignPatternsContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DesignPatternsContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(int id)
        {
            _dbSet.Remove(new TEntity() { Id = id });
        }

        public IEnumerable<TEntity> Get()
        {
            return _dbSet.ToList();
        }

        public TEntity Get(int id)
        {
            return _dbSet.Find(id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
