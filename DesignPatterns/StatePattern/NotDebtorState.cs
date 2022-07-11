using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    public class NotDebtorState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            if (amount <= customerContext.Residue)
            {
                customerContext.Discount(amount);
                Console.WriteLine($"La compra ha sido permitida, su nuevo saldo es: {customerContext.Residue}");
                if (customerContext.Residue <= 0)
                    customerContext.SetState(new DebtorState());
            }
            else
            {
                Console.WriteLine($"No se puede realizar la compra ya que el costo es de: " +
                    $"{amount} y su saldo es: {customerContext.Residue}");
            }
        }
    }
}
