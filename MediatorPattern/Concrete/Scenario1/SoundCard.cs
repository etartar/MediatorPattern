using MediatorPattern.Abstract.Scenario1;
using System;

namespace MediatorPattern.Concrete.Scenario1
{
    public class SoundCard : Unit
    {
        public SoundCard(IMotherboard motherboard) : base(motherboard)
        {
        }

        public void GiveSound(string soundData)
        {
            string[] datas = soundData.Split(",");
            foreach (string data in datas)
                Console.WriteLine($"Incoming sound : {data}");
        }
    }
}
