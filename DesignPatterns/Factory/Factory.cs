using System;

namespace DesignPatterns.Factory
{
    // Creator
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }

    // Concrete Creator
    public class StoreSaleFactory : SaleFactory
    {
        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }

        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }

    public class InternetSaleFactory : SaleFactory
    {
        private decimal _discount;

        public InternetSaleFactory(decimal discount)
        {
            _discount = discount;
        }

        public override ISale GetSale()
        {
            return new InternetSale(_discount);
        }
    }

    // Concrete Product
    public class StoreSale : ISale
    {
        private decimal _extra;

        public StoreSale(decimal extra)
        {
            _extra = extra;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"Vendido producto en TIENDA con un total de más comisión {total + _extra}");
        }
    }

    public class InternetSale : ISale
    {
        private decimal _discount;

        public InternetSale(decimal discount)
        {
            _discount = discount;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"Vendido producto en INTERNET con un total de menos descuento {total - _discount}");
        }
    }

    // Product
    public interface ISale
    {
        public void Sell(decimal total);
    }
}
