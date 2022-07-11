using DesignPatterns.Models;
using System.Collections.Generic;

namespace DesignPatterns.Repository
{
    public interface IBeerRepository
    {
        public IEnumerable<Beer> Get();
        public Beer Get(int beerId);
        public void Add(Beer beer);
        public void Update(Beer beer);
        public void Delete(int beerId);

        public void SaveChanges();
    }
}
