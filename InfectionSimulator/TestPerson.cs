using System;
using InfectionSimulator.AbstractPerson;

namespace InfectionSimulator
{
    public class TestPerson : Person
    {
        public TestPerson(int daysAlive, InfecStatus status) : base (daysAlive, status) {}

        public override void ReturnHome()
        {

        }

        public override void Move()
        {

        }
    }
}