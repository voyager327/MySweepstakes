using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        private string name;
        public Random random;
        public string winningNumber;
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {

            }
        }
        
        // Method Application
        public void SweepStakes(string name)
        {
            this.name = name;
        }
        public void RegisterContestants(Contestant contestant)
        {
            contestant.RegistrationNumber = contestants.Count;
            contestants.Add(contestant.RegistrationNumber, contestant);
 
        }
        public Contestant PickWinner()
        {
            Random random = new Random();
            int winningNumnber = random.Next(0, contestants.Count);
            Contestant contestantWinner = contestants[winningNumnber];
            return contestantWinner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("ContestantNumber: " + contestant.RegistrationNumber);
        }

      

        
        

        

 
    }
            
}
