using Learn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Time
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Employee emp1 = new PermanentEmployee("267543", "Tom", 5000);
            Employee emp2 = new ContractEmployee("953456", "Ketty", 30);
            Console.WriteLine("Are you logging in ?, Please respond in Y for Yes and N for No");
            var YesONo = Convert.ToString(Console.ReadLine());
            if (YesONo == "Y")
            {
                Console.Write("Check in Date and Time is : ");
                DateTime now = DateTime.Now;
                Console.WriteLine(now + "  " + now.DayOfWeek);
                Console.ReadLine();
                Console.WriteLine("What is the user Code? ");
                var EmpN = Convert.ToString(Console.ReadLine());
                if (EmpN== "emp2")
                {
                    Console.WriteLine(emp2);
                    Console.ReadLine();
                }
                if (EmpN == "emp1")
                {
                    Console.WriteLine(emp1);
                }
               else
                {
                    Console.WriteLine("Please enter Empl;oyee Number");
                }
               
                
            }
            else
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}

