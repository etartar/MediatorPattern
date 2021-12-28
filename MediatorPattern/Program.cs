using MediatorPattern.Concrete.Scenario1;
using MediatorPattern.Concrete.Scenario2;
using MediatorPattern.Concrete.Scenario3;
using System;

namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ScenarioOne();
            //ScenarioTwo();
            ScenarioThree();
        }

        private static void ScenarioThree()
        {
            Transfer transfer = new Transfer();
            Buyer buyer = new Buyer(transfer);
            RealEstateAgent realEstateAgent = new RealEstateAgent(transfer);
            Seller seller = new Seller(transfer);

            transfer.Buyer = buyer;
            transfer.RealEstateAgent = realEstateAgent;
            transfer.Seller = seller;

            buyer.PayForHousing(200000);
            Console.WriteLine("***********");
            buyer.PayForHousing(100000);
        }

        private static void ScenarioTwo()
        {
            Transport transport = new Transport();
            XCompany xCompany = new XCompany(transport);
            YCompany yCompany = new YCompany(transport);
            ZCompany zCompany = new ZCompany(transport);

            transport.XCompany = xCompany;
            transport.YCompany = yCompany;
            transport.ZCompany = zCompany;

            xCompany.StartTransport();
        }

        private static void ScenarioOne()
        {
            Motherboard motherboard = new Motherboard();

            CdDriver cdDriver = new CdDriver(motherboard);
            Cpu cpu = new Cpu(motherboard);
            GraphicsCard graphicsCard = new GraphicsCard(motherboard);
            SoundCard soundCard = new SoundCard(motherboard);

            motherboard.CdDriver = cdDriver;
            motherboard.Cpu = cpu;
            motherboard.GraphicsCard = graphicsCard;
            motherboard.SoundCard = soundCard;

            cdDriver.ReadCd();
        }
    }
}
