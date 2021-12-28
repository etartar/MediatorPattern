using MediatorPattern.Abstract.Scenario2;
using System;

namespace MediatorPattern.Concrete.Scenario2
{
    public class ZCompany : Company
    {
        public ZCompany(ITransport transport) : base(transport)
        {
        }

        public override void StartTransport()
        {
            Console.WriteLine("Bursa'dan eşyalar yüklendi.");
            _transport.TransferTheProperty(this);
        }
    }
}
