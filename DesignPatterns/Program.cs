using DesignPatterns.DependencyInjection;

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
            var beer = new Beer("Colombia", "Babaria");
            var drinkWithBeer = new DrinkWithBeer(12, 43, beer);
            drinkWithBeer.Build();
            #endregion

        }
    }
}
