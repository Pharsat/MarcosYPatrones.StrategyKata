namespace MarcosYPatrones.StrategyKata
{
    public interface IUnit
    {
        int Position { get; set; }

        void SetMoveBehavior(IMoveBehavior moveStrategy);

        void StartMoving();
    }
}