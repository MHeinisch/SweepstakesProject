using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesStackManager : ISweepstakesManager
    {

        //member variables
        Stack<Sweepstakes> sweepstakesStack;



        //constructor
        public SweepstakesStackManager()
        {
            sweepstakesStack = new Stack<Sweepstakes>();
        }



        //functions
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes);
        }

        public Sweepstakes GetNextSweepstakesWinner()
        {
            return sweepstakesStack.Pop();
        }

    }
}
