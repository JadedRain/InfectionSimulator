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
        public Person(int daysAlive, InfecStatus status)
        {
            DaysAlive = daysAlive;
            Status = status;
        }
        // The number of total created persons
        static int NumPeople { get; set; }
        // Tracks the number of days a person has been alive
        public int DaysAlive { get; }
        // Tracs the current status of a person
        public InfecStatus Status {get; }

        public abstract void ReturnHome();
        // How a person moves during the day
        public abstract void Move();

    }
}