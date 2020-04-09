using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        //create a SweepstakesQueueManager class that uses the Queue data structure as an underlying structure.
        
        Queue<Sweepstakes> sweepstakeQueue = new Queue<Sweepstakes>();

        public Sweepstakes GetSweepstakes()
        {
            //Retrieving item using Dequeue
            Console.WriteLine("Remove Sweepstake from Queue");
            return sweepstakeQueue.Dequeue();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            //Adding item using Enqueue
            
            sweepstakeQueue.Enqueue(sweepstakes);
        }

    }
}
