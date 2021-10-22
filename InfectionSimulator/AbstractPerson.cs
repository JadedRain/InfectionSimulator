using System;
using InfectionSimulator.PersonInterface;

namespace InfectionSimulator.AbstractPerson
{
    // This enum represents the different possible status for a person to be in
    public enum InfecStatus
    {
        // Can be infected by the disease
        suseptible, 
        // Can transmit the disease
        infectious,
        // Recovered from the infection and can no longer be infected 
        recovered, 
        // Not able to get infected
        vaccinated 
    }

    // An abstract class that determines what each person should contain
    public abstract class Person : IPerson
    {
        // Tracks the number of days a person has been alive
        private int DaysAlive { get; set; }
        // Tracs the current status of a person
        private InfecStatus Status {get; set; }

        public abstract void ReturnHome();
        // How a person moves during the day
        public abstract void Move();

    }
}