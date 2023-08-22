namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((MoonsOfYear)num);
        }
    }
}