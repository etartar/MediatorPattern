using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Abstract.Scenario2
{
    public abstract class Company
    {
        protected ITransport _transport;

        protected Company(ITransport transport)
        {
            _transport = transport;
        }

        public abstract void StartTransport();
    }
}
