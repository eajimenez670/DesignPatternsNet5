using DesignPatterns.Repository;
using DesignPatternsASPNET.Models.ViewModels;

namespace DesignPatternsASPNET.Strategies
{
    public class BeerContext
    {
        private IBeerSrategy _beerSrategy;

        public IBeerSrategy Strategy
        {
            set
            {
                _beerSrategy = value;
            }
        }

        public BeerContext(IBeerSrategy beerSrategy)
        {
            _beerSrategy = beerSrategy;
        }

        public void Add(FormBeerViewModel viewModel, IUnitOfWork unitOfWork)
        {
            _beerSrategy.Add(viewModel, unitOfWork);
        }
    }
}
