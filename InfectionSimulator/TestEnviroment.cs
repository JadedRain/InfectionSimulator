using System;
using System.Collections.Generic;
using InfectionSimulator.AbstractEnviroment;
using InfectionSimulator.AbstractPerson;


namespace infectionSimulator
{
    public class TestEnviroment : Enviroment
    {
        public TestEnviroment(List<Person> people, Location[] locations) : base (people, locations){}
        public override void DayStart()
        {
            throw new NotImplementedException();
        }
        public override void DayEnd()
        {
            throw new NotImplementedException();
        }
        public override void MaxPeopleAtLocation()
        {
            throw new NotImplementedException();
        }
    }
}