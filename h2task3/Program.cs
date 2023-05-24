namespace h2task3
{
    internal class Program
    {
        enum HTTPError 
        {
            BadRequest = 400,
            Unauthorised,
            PaymentRequired,
            Forbidden,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter error code");
            Console.WriteLine((HTTPError)Convert.ToInt32(Console.ReadLine()));
        }   
    }
}
