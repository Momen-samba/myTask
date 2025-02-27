namespace myTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largeCarpet;
            int smallCarpet;
            int cost;
            double tax;
            double totalEstimate;

            Console.Write("Number of small carpets: ");
            smallCarpet = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of large carpets: ");
            largeCarpet = Convert.ToInt32(Console.ReadLine());

            cost = 25 * smallCarpet + 35 * largeCarpet;

            Console.WriteLine("price per small room: $25");
            Console.WriteLine("price per large room: $35");
            Console.WriteLine($"Cost: ${cost}");
            Console.WriteLine("Tax: $6.6");
            tax = cost * 0.06;

            totalEstimate = cost + tax;
            Console.WriteLine("=======================");
            Console.WriteLine($"Total Estimate: {totalEstimate}");
            Console.WriteLine("This estimate is valid for 30 days");



        }
    }
}
