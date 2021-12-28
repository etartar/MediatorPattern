using MediatorPattern.Abstract.Scenario1;
using System;

namespace MediatorPattern.Concrete.Scenario1
{
    public class GraphicsCard : Unit
    {
        public GraphicsCard(IMotherboard motherboard) : base(motherboard)
        {
        }

        public void GiveVisual(string videoData)
        {
            string[] datas = videoData.Split(",");
            foreach (string data in datas)
                Console.WriteLine($"Incoming image : {data}");
        }
    }
}
