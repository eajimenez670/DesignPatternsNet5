using DesignPatterns.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Repository
{
    public class BeerRepository : IBeerRepository
    {
        private readonly DesignPatternsContext _context;
        public BeerRepository(DesignPatternsContext context)
        {
            _context = context;
        }

        public void Add(Beer beer) => _context.Beers.Add(beer);


        public void Delete(int beerId) => _context.Beers.Remove(new Beer { Id = beerId });


        public IEnumerable<Beer> Get() => _context.Beers.ToList();


        public Beer Get(int beerId) => _context.Beers.Find(beerId);


        public void SaveChanges() => _context.SaveChanges();


        public void Update(Beer beer) => _context.Entry(beer).State = EntityState.Modified;

    }
}
