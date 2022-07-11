using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatternsASPNET.Models.ViewModels;
using System;

namespace DesignPatternsASPNET.Strategies
{
    public class BeerWithoutBrandStrategy : IBeerSrategy
    {
        public void Add(FormBeerViewModel viewModel, IUnitOfWork unitOfWork)
        {
            var beer = new Beer()
            {
                Name = viewModel.Name,
                Style = viewModel.Style
            };

            var brand = new Brand()
            {
                Name = viewModel.OtherBrand,
                Id = Guid.NewGuid(),
            };

            beer.BrandId = brand.Id;

            unitOfWork.Brands.Add(brand);
            unitOfWork.Beers.Add(beer);
            unitOfWork.Save();
        }
    }
}
