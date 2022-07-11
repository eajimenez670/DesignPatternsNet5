using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatternsASPNET.Models.ViewModels;
using System;

namespace DesignPatternsASPNET.Strategies
{
    public class BeerWithBrandStrategy : IBeerSrategy
    {
        public void Add(FormBeerViewModel viewModel, IUnitOfWork unitOfWork)
        {
            var beer = new Beer()
            {
                Name = viewModel.Name,
                Style = viewModel.Style,
                BrandId = (Guid)viewModel.BrandId
            };

            unitOfWork.Beers.Add(beer);
            unitOfWork.Save();
        }
    }
}
