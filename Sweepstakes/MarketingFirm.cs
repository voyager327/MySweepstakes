using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    //create a MarketingFirm class with functionality to create a sweepstakes.

    class MarketingFirm
    {
        public ISweepstakesManager manager;

        //Method Injection is applied on this method
        public void Marketingfirm(ISweepstakesManager manager)
        {
            //Factory Pattern will be applied here to have the option on which manager type will used
            //this.manager = manager;

            string managerType = UserInterface.ChooseManager();
            if (managerType == "Stack")
            {
                manager = new SweepstakesStackManager();
            }
            else if (managerType == "Queue")
            {
                manager = new SweepstakesQueueManager();
            }
            else
            {
                return;
            }

        }   //Method Injection is applied on this method
        public void CreateSweepstake()
        {
            Sweepstakes newSweepstake = new Sweepstakes();
            manager.InsertSweepstakes(newSweepstake);
        }



          



    }
}
