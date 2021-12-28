using MediatorPattern.Abstract.Scenario3;

namespace MediatorPattern.Concrete.Scenario3
{
    public class Transfer : ITransfer
    {
        Buyer _buyer;
        RealEstateAgent _realEstateAgent;
        Seller _seller;

        public Buyer Buyer { set { _buyer = value; } }

        public RealEstateAgent RealEstateAgent { set { _realEstateAgent = value; } }

        public Seller Seller { set { _seller = value; } }

        public void SendMoney(Person person, int price)
        {
            if (person is Buyer && price > 100000)
            {
                _seller.GetMoney(price);
            }
            else if (person is Buyer && price <= 100000)
            {
                _realEstateAgent.GetCommission(price * 10 / 100);
                _seller.GetMoney(price);
            }
            else if (person is Seller && price > 100000)
            {
                _realEstateAgent.GetCommission(price * 3 / 100);
            }
        }
    }
}
