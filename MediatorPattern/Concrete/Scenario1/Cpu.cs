using MediatorPattern.Abstract.Scenario1;

namespace MediatorPattern.Concrete.Scenario1
{
    public class Cpu : Unit
    {
        private string _videoData, _soundData;

        public Cpu(IMotherboard motherboard) : base(motherboard)
        {
        }

        public string VideoData => _videoData;

        public string SoundData => _soundData;

        public void ProcessData(string cdData)
        {
            string[] array = cdData.Split("*");
            _videoData = array[0];
            _soundData = array[1];
            _motherboard.Change(this);
        }
    }
}
