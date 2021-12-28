using MediatorPattern.Abstract.Scenario2;
using System;

namespace MediatorPattern.Concrete.Scenario2
{
    public class Transport : ITransport
    {
        XCompany _xCompany;
        YCompany _yCompany;
        ZCompany _zCompany;

        public XCompany XCompany { set => _xCompany = value; }
        
        public YCompany YCompany { set => _yCompany = value; }

        public ZCompany ZCompany { set => _zCompany = value; }

        public void TransferTheProperty(Company company)
        {
            if (company is XCompany)
            {
                Console.WriteLine("Eşyalar Ankara'da tekrar nakledilmek üzere indirildi.");
                _yCompany.StartTransport();
            }
            else if (company is YCompany)
            {
                Console.WriteLine("Eşyalar Bursa'da tekrar nakledilmek üzere indirildi.");
                _zCompany.StartTransport();
            }
            else
            {
                Console.WriteLine("Eşyalar İstanbul'a vardı.");
            }
        }
    }
}
