using MediatorPattern.Abstract.Scenario2;
using System;

namespace MediatorPattern.Concrete.Scenario2
{
    public class XCompany : Company
    {
        public XCompany(ITransport transport) : base(transport)
        {
        }

        public override void StartTransport()
        {
            Console.WriteLine("İzmir'den eşyalar yüklendi.");
            _transport.TransferTheProperty(this);
        }
    }
}
