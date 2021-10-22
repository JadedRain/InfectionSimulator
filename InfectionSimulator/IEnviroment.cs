using System;

namespace InfectionSimulator.EnviromentInterface
{
    // This interface will describe what an environment should be able to do
    public interface IEnviroment
    {
        // Determines how the day starts
        void DayStart();
        // Determines how the day ends
        void DayEnd();
        // Creates values for the max amount of people at each location
        void MaxPeopleAtLocation();
    }
}