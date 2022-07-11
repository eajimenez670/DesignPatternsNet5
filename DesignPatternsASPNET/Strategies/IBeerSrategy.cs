using DesignPatterns.Repository;
using DesignPatternsASPNET.Models.ViewModels;

namespace DesignPatternsASPNET.Strategies
{
    public interface IBeerSrategy
    {
        public void Add(FormBeerViewModel viewModel, IUnitOfWork unitOfWork);
    }
}
