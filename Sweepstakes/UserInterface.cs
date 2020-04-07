using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
         
        public static int ContestantNumber = 0; 
        public static string FirstName()
        {
            Console.WriteLine("Enter your first name.");
            return Console.ReadLine();
        }
           
        public static string LastName()
        {
            Console.WriteLine("Enter your last name.");
            return Console.ReadLine();
        }

        public static string EmailAdd()
        {
            Console.WriteLine("Enter your Email Add.");
            return Console.ReadLine();
        }
        public static int RegistrationNumber()
        {
            ContestantNumber = +1;
            Console.WriteLine("Your registration number is " + ContestantNumber);
            return ContestantNumber;
        }


       
            
        
    }

}
    
              
    

