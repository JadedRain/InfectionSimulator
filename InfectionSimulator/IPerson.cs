using System;

namespace  InfectionSimulator.PersonInterface
{
    public interface IPerson
    {
        // A methond that is used to return a person back home after a day is over
        void ReturnHome();
        // A method that is used to have a person move throughout the enviroment during the day
        void Move();
    }
}