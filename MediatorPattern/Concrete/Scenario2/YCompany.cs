using MediatorPattern.Abstract.Scenario2;
using System;

namespace MediatorPattern.Concrete.Scenario2
{
    public class YCompany : Company
    {
        public YCompany(ITransport transport) : base(transport)
        {
        }

        public override void StartTransport()
        {
            Console.WriteLine("Ankara'dan eşyalar yüklendi.");
            _transport.TransferTheProperty(this);
        }
    }
}
