using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        //create a SweepstakesStackManager class that uses the Stack data structure as an underlying structure.
        
        Stack<Sweepstakes> sweepstakeStack = new Stack<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            //Adding item using Push
            
            sweepstakeStack.Push(sweepstakes);

        }
        public Sweepstakes GetSweepstakes()
        {
            //Retrieving Item using Pop
            Console.WriteLine("Remove Sweepstake from Stack");
            return sweepstakeStack.Pop();

            //This can also be used to clear a stack
            //stack.Clear();
            //Console.ReadKey();
        }
    }
}


