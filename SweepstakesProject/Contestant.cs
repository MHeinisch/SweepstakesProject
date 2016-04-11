using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Contestant
    {

        //member variables
        string name;
        int age;

        public string Name
        {
            get { return name; }
        }



        //constructor
        public Contestant(string Name, int Age)
        {
            name = Name;
            age = Age;
        }



        //functions
        public void RegisterContestant (Contestant contestant, Sweepstakes sweepstakes)
        {
            sweepstakes.listOfContestants.Add(contestant);
        }

        public string PickWinner(Sweepstakes sweepstakes)
        {
            Random rnd = new Random();
            int winningContestant = rnd.Next(0, sweepstakes.NumberOfContestants);
            return "The winner of " + sweepstakes.Name + " is " + sweepstakes.listOfContestants[winningContestant].Name + "!";
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant {1} is {2} years old.", name, age);
        }

    }
}
