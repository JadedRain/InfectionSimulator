using System;
using System.Collections.Generic;
using InfectionSimulator.AbstractPerson;
using InfectionSimulator.EnviromentInterface;

namespace InfectionSimulator.AbstractEnviroment
{
    // This enum is the possible locations that can be in an enviroment
    public enum Location 
    {
        Home,
        Work,
        Store,
        Park,
        Resturaunt
    }
    // This class represents what each enviroment should contain
    public abstract class Enviroment : IEnviroment
    {
        // The number of total created enviroments
        static int NumEnviroments { get; set; }
        // A list of current people in the enviromenment
        private List<Person> CurrentPeople { get; set; }
        // A list of locations the enviroment contains
        private List<Location> PossibleLocations { get; set; }


        // Triggers events that start at the begining of the day
        public abstract void DayStart();
        // Triggers behaviors after the day is over in the simulation
        public abstract void DayEnd();
        // Determines how many people can be at a given location
        public abstract void MaxPeopleAtLocation();
    }
}