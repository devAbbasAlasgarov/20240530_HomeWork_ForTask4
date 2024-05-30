using System.Text;

namespace DoctorPatients
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int numberOfPills = 0;
            int sumOfPills = 0;
            Console.WriteLine("Xəstə sayını daxil edin: ");
            int numberOfPatients = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberOfPatients; i++)
            {
                Console.Write($"Enter number of pills given to patient {i} : ");
                numberOfPills = int.Parse(Console.ReadLine());
                sumOfPills += numberOfPills;
            }
            Console.WriteLine($"Qəbul edilən xəstə sayı: {numberOfPatients}");
            Console.WriteLine($"Xəstələrə yazlılan toplam dərman sayı: {sumOfPills}");
            Console.WriteLine($"Xəstə başına düşən ortalama dərman sayı: {sumOfPills/numberOfPatients}");
        }
    }
}
