using NUnit.Framework;

namespace MarcosYPatrones.StrategyKata.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WalkMove()
        {
            IUnit viking = new Viking();

            viking.StartMoving();
            Assert.AreEqual(1, viking.Position);
            viking.StartMoving();
            Assert.AreEqual(2, viking.Position);
        }

        [Test]
        public void FlyMove()
        {
            IUnit viking = new Viking();
            viking.SetMoveBehavior(new Fly());

            viking.StartMoving();
            Assert.AreEqual(10, viking.Position);
            viking.StartMoving();
            Assert.AreEqual(20, viking.Position);
        }

        [Test]
        public void MixMove()
        {
            IUnit viking = new Viking();

            viking.StartMoving();
            Assert.AreEqual(1, viking.Position);

            viking.SetMoveBehavior(new Fly());
            viking.StartMoving();
            Assert.AreEqual(11, viking.Position);
        }
    }
}