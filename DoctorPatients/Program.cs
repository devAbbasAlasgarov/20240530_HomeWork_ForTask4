using System.Text;
using System.Transactions;

namespace DoctorPatients
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Xəstə sayını daxil edin: ");
            int numberOfPatients = int.Parse(Console.ReadLine());
           
            EnterNumberOfPills(numberOfPatients);
         
        }
        public static void EnterNumberOfPills(int numberOfPatients)
        {
            int numberOfPills;
            int sumOfPills=0;
            for (int i = 1; i <= numberOfPatients; i++)
            {
                Console.Write($"Enter number of pills given to patient {i} : ");
                numberOfPills = int.Parse(Console.ReadLine());
                sumOfPills += numberOfPills;
            }
            float averageNumberOfPills =  (float)sumOfPills / numberOfPatients;
            Console.WriteLine($"Qəbul edilən xəstə sayı: {numberOfPatients}");
            Console.WriteLine($"Xəstələrə yazlılan toplam dərman sayı: {sumOfPills}");
            Console.WriteLine($"Xəstə başına düşən ortalama dərman sayı: {averageNumberOfPills}");
            Console.Read();
        }
    }

    


}
