namespace MediatorPattern.Abstract.Scenario1
{
    public abstract class Unit
    {
        protected IMotherboard _motherboard;

        protected Unit(IMotherboard motherboard)
        {
            _motherboard = motherboard;
        }
    }
}
