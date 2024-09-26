using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poäng;
            poäng = 0;
            int dealer;
            dealer = 0;
           

                Console.WriteLine("vill du slå eller stanna");
            string answer;
            answer = "slå";
            answer = Console.ReadLine();
            string Answer;
            Answer = "stanna";
            while (answer == "slå")
            {
                Random rand = new Random();
                int x = rand.Next(1, 7);
                poäng += x;
                Console.WriteLine("dina poäng = " + poäng);
                Console.WriteLine(x);
                Console.WriteLine("vill du slå eller stanna");
                answer = Console.ReadLine();
               


            }
            if (Answer == "stanna")
            {
                Console.WriteLine("du har stannat");
                Console.WriteLine("dina poäng är = " + poäng);
              
            }
            while(dealer < 17)
            {
                Random rand = new Random();
                int x = rand.Next(1, 7);
                dealer += x;
                Console.WriteLine(" dealerns poäng = " + dealer);
                
            }
            if(dealer > 21)
            {
                Console.WriteLine("du vann");

            }
            if (poäng > 21)
            {
                Console.WriteLine("du förlorade");
            }



            
            

           


            




        }
    }
}
