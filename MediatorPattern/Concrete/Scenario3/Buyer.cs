using MediatorPattern.Abstract.Scenario3;
using System;

namespace MediatorPattern.Concrete.Scenario3
{
    public class Buyer : Person
    {
        public Buyer(ITransfer transfer) : base(transfer)
        {
        }

        public void PayForHousing(int price)
        {
            Console.WriteLine("Alıcı : Ödeme yapılmıştır.");
            _transfer.SendMoney(this, price);
        }
    }
}
