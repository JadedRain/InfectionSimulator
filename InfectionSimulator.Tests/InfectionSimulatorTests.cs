using NUnit.Framework;
using InfectionSimulator;
using InfectionSimulator.AbstractPerson;
using InfectionSimulator.AbstractEnviroment;

namespace InfectionSimulator.Tests
{
    public class Tests
    {
        TestPerson _person;
        [SetUp]
        public void Setup()
        {
            _person = new TestPerson(0, InfecStatus.suseptible);
        }

        [Test]
        public void TestPerson()
        {
            Assert.IsTrue(_person.DaysAlive == 0);
            Assert.IsTrue(_person.Status == InfecStatus.suseptible);
            Assert.IsFalse(_person.Status == InfecStatus.infectious);
        }
    }
}