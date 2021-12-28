using MediatorPattern.Abstract.Scenario3;
using System;

namespace MediatorPattern.Concrete.Scenario3
{
    public class Seller : Person
    {
        public Seller(ITransfer transfer) : base(transfer)
        {
        }

        public void GetMoney(int price)
        {
            Console.WriteLine($"Satıcı : {price} TL kadar konut bedeli alınmıştır.");
            _transfer.SendMoney(this, price);
        }
    }
}
