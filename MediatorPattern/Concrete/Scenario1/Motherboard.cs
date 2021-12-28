using MediatorPattern.Abstract.Scenario1;

namespace MediatorPattern.Concrete.Scenario1
{
    public class Motherboard : IMotherboard
    {
        private CdDriver _cdDriver;
        private Cpu _cpu;
        private GraphicsCard _graphicsCard;
        private SoundCard _soundCard;

        public CdDriver CdDriver { set { _cdDriver = value; } }
        public Cpu Cpu { set { _cpu = value; } }
        public GraphicsCard GraphicsCard { set { _graphicsCard = value; } }
        public SoundCard SoundCard { set { _soundCard = value; } }

        public void Change(Unit unit)
        {
            if (unit is CdDriver)
            {
                _cpu.ProcessData(_cdDriver.CdData);
            }
            else if (unit is Cpu)
            {
                _graphicsCard.GiveVisual(_cpu.VideoData);
                _soundCard.GiveSound(_cpu.SoundData);
            }
        }
    }
}
