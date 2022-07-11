using DesignPatterns.BuilderPattern;
using DesignPatterns.Models;
using DesignPatterns.Repository;
using DesignPatterns.StatePattern;
using DesignPatterns.StrategyPattern;
using DesignPatterns.UnitOfWorkPattern;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implement Singleton
            //var singleton = Singleton.Log.Instance;
            //singleton.WriteLog("Hola como va Singleton");
            //singleton.WriteLog("Singleton Fuck");
            //singleton.WriteLog("Yeahhh");

            //var a = Singleton.Log.Instance;
            //var b = Singleton.Log.Instance;

            //Console.WriteLine(a.Equals(b));
            #endregion

            #region Implement Factory Method
            //SaleFactory storeSaleFactory = new StoreSaleFactory(12);
            //SaleFactory internetSaleFactory = new InternetSaleFactory(5);

            //ISale sale1 = storeSaleFactory.GetSale();
            //sale1.Sell(10);

            //ISale sale2 = internetSaleFactory.GetSale();
            //sale2.Sell(20);
            #endregion

            #region Dependency Injection
            //var beer = new Beer("Colombia", "Babaria");
            //var drinkWithBeer = new DrinkWithBeer(12, 43, beer);
            //drinkWithBeer.Build();
            #endregion

            #region Entity Framework
            //using (var context = new DesignPatternsContext())
            //{
            //    var lst = context.Beers.ToList();
            //    foreach (var beer in lst)
            //    {
            //        Console.WriteLine(beer.Name);
            //    }
            //}
            #endregion

            #region Repository
            //using (var context = new DesignPatternsContext())
            //{
            //    var beerReporsitory = new BeerRepository(context);
            //    var beer = new Beer { Name = "Club Colombia", Style = "Malta" };

            //    beerReporsitory.Add(beer);
            //    beerReporsitory.SaveChanges();

            //    var beerFind = beerReporsitory.Get(2);

            //    var beers = beerReporsitory.Get();

            //    beer = new Beer { BeerId = 2, Name = "Eirninger", Style = "Refajo" };
            //    beerReporsitory.Update(beer);
            //    beerReporsitory.SaveChanges();

            //    beerReporsitory.Delete(3);
            //    beerReporsitory.SaveChanges();
            //}
            #endregion

            #region Repository Generic
            //using (var context = new DesignPatternsContext())
            //{
            //    var beerRepository = new Repository<Beer>(context);

            //    Console.WriteLine("********* Begin Beers **********");
            //    foreach (var beerDb in beerRepository.Get())
            //    {
            //        Console.WriteLine($"{beerDb.Id} - {beerDb.Name}");
            //    }
            //    Console.WriteLine("********* End Beers **********");

            //    Console.WriteLine(Environment.NewLine);
            //    Console.WriteLine(Environment.NewLine);
            //    Console.WriteLine(Environment.NewLine);

            //    var brandRepository = new Repository<Brand>(context);
            //    brandRepository.Add(new Brand { Name = " Tu puta madre" });
            //    brandRepository.SaveChanges();

            //    Console.WriteLine("********* Begin Brands **********");
            //    foreach (var brandDb in brandRepository.Get())
            //    {
            //        Console.WriteLine($"{brandDb.Id} - {brandDb.Name}");
            //    }
            //    Console.WriteLine("********* End Brands **********");
            //}
            #endregion

            #region Unit of Work
            //using (var context = new DesignPatternsContext())
            //{
            //    UnitOfWork unit = new UnitOfWork(context);

            //    var beerRepository = unit.Beers;
            //    var beer = new Beer
            //    {
            //        Name = "Pilsen",
            //        Style = "Morrocoya"
            //    };
            //    beerRepository.Add(beer);

            //    var brandRepository = unit.Brands;
            //    var brand = new Brand
            //    {
            //        Name = "Mercachochas"
            //    };
            //    brandRepository.Add(brand);

            //    unit.Save();
            //}
            #endregion

            #region Strategy
            //var strategy = new Context(new PdfStrategy());
            //strategy.Export();
            //strategy.Strategy = new PngStrategy();
            //strategy.Export();
            //strategy.Strategy = new HtmlStrategy();
            //strategy.Export();
            #endregion

            #region Builder
            //var preparedAlcoholDrink = new PreparedAlcoholicDrinkConcreteBuilder();
            //var barman = new BarmanDirector(preparedAlcoholDrink);
            //barman.PreparedMargarita();
            //var preparedDrink = preparedAlcoholDrink.GetPreparedDrink();
            //Console.WriteLine(preparedDrink.Result);
            #endregion

            #region State
            var customerContext = new CustomerContext();
            Console.WriteLine(customerContext.GetState());
            customerContext.Request(100);
            Console.WriteLine(customerContext.GetState());

            customerContext.Request(50);
            Console.WriteLine(customerContext.GetState());

            customerContext.Request(100);
            Console.WriteLine(customerContext.GetState());

            customerContext.Request(50);
            Console.WriteLine(customerContext.GetState());

            customerContext.Request(50);
            Console.WriteLine(customerContext.GetState());
            #endregion

        }
    }
}
