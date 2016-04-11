using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Sweepstakes
    {

        //member variables
        string name;
        public List<Contestant> listOfContestants;
        int numberOfContestants;

        public int NumberOfContestants
        {
            get
            { return numberOfContestants; }
        }

        public string Name
        {
            get { return name; }
        }



        //constructor
        public Sweepstakes(string Name, List<Contestant> ListOfContestants)
        {
            name = Name;
            listOfContestants = ListOfContestants;
            numberOfContestants = listOfContestants.Count();
        }



        //functions

    }
}
