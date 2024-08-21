using Reverse_Engineering.Data;

namespace Reverse_Engineering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var contxt in new AppDBContext().Speakers)
            {
                Console.WriteLine($"{contxt.FirstName} {contxt.LastName}");
            }
            Console.ReadKey();
        }
    }
}
