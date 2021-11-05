using DesignPatterns.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DesignPatternsContext _contex;
        private readonly IRepository<Beer> _beers;
        private readonly IRepository<Brand> _brands;
        public IRepository<Beer> Beers
        {
            get
            {
                return _beers == null ?
                    new Repository<Beer>(_contex) :
                    _beers;
            }
        }

        public IRepository<Brand> Brands
        {
            get
            {
                return _brands == null ?
                  new Repository<Brand>(_contex) :
                  _brands;
            }
        }

        public UnitOfWork(DesignPatternsContext context)
        {
            _contex = context;
        }

        public void Save()
        {
            _contex.SaveChanges();
        }
    }
}
