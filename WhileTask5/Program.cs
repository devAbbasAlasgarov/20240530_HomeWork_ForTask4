using System.Diagnostics;
using System.Text;

namespace WhileTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string resultOfBloodTest = "NORMAL";
            decimal priceOfDoctor = 90;
            string professionOfDoctor="";
            string nameOfDoctor="";
            decimal positiveResult = 0;
            decimal negativeResult = 0;
            Boolean nextDoctor = true;
            string replyForNextDoctor;
            int numberOfDoctors = 1;

            nameAndProfession(nameOfDoctor, professionOfDoctor); 

            while (nextDoctor == true)
            {
                Console.WriteLine($"DR.{nameOfDoctor}, WHAT IS THE PRICE OF YOUR SERVICE?");
                priceOfDoctor += decimal.Parse(Console.ReadLine());

                Console.WriteLine("WHAT IS THE RESULT OF MY TEST? (Enter p for positive and n for negative)");
                resultOfBloodTest = Console.ReadLine();
                if(resultOfBloodTest =="p")
                {
                    positiveResult++;
                }
                else
                {
                    negativeResult++;
                }
                Console.WriteLine("DO I NEED TO SEE OTHER DOCTOR? (Enter y for yes and n for no)");
                replyForNextDoctor = Console.ReadLine();
                if(replyForNextDoctor=="y")
                {
                    nextDoctor = true;
                    nameAndProfession(nameOfDoctor, professionOfDoctor);
                }
                else
                {
                    nextDoctor= false;
                }
                
                numberOfDoctors++;
            };

            Console.WriteLine($"TOTAL NUMBER OF DOCTORS HAS GIVEN SERVICE: {numberOfDoctors}");
            Console.WriteLine($"TOTAL AMOUNT SPENT FOR SERVICES: {priceOfDoctor}");
            Console.WriteLine($"NUMBER OF POSITIVE RESULTS: {positiveResult}");
            Console.WriteLine($"NUMBER OF NEGATIVE RESULTS: {negativeResult}");
            if(positiveResult > negativeResult)
            {
                Console.WriteLine("CANDIDATE CAN PARTICIPATE IN EXAM!");
            }
            else
            {
                Console.WriteLine("REJECTI0N!");
            }
        }

        public static void nameAndProfession(string nameOfDoctor, string professionOfDoctor)
        {
            Console.WriteLine("WHAT IS DOCTOR'S NAME?");
            nameOfDoctor = Console.ReadLine();
            Console.WriteLine("WHAT IS DOCTOR'S PROFESSION?");
            professionOfDoctor = Console.ReadLine();
        }

        
    }
}
