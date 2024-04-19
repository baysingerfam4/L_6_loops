using System.ComponentModel.Design;

namespace L_6_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //For Loop
            //Declared our vaiable
            //int count = 0;

            //{
                //while (count) ;

           // }
            for(int i =5; i < 10; i++ )
            {
                Console.WriteLine(i);
            }
       
            
            Console.Write("Please enter a whole number:");
            int number;
            bool isValid = false;

            while (!isValid)
            {
                string userRespose = Console.ReadLine();
                if (int.TryParse(userRespose, out number)) ;
                {
                    isValid = true;
                }

                {
                    Console.WriteLine("Please Enter a valid whole number");
                }

               // Console.WriteLine("Hello, World!");
               // int count = 0;
                //while (count <= 10)
                //{
                  //  Console.WriteLine(count);
               // }

                //Console.WriteLine("This is after our while loop");
                //{

               // }
            }
        }
    }
}
