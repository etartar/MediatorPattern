using MediatorPattern.Abstract.Scenario1;

namespace MediatorPattern.Concrete.Scenario1
{
    public class CdDriver : Unit
    {
        private string _cdData;

        public CdDriver(IMotherboard motherboard) : base(motherboard)
        {
        }

        public string CdData => _cdData;

        public void ReadCd()
        {
            _cdData = "image1,image2,image3*sound1,sound2,sound3";
            _motherboard.Change(this);
        }
    }
}
