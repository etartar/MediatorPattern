using MediatorPattern.Abstract.Scenario3;
using System;

namespace MediatorPattern.Concrete.Scenario3
{
    public class RealEstateAgent : Person
    {
        public RealEstateAgent(ITransfer transfer) : base(transfer)
        {
        }

        public void GetCommission(int price)
        {
            Console.WriteLine($"Emlakçı : {price} TL kadar komisyon alınmıştır");
        }
    }
}
