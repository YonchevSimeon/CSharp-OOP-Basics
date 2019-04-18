namespace Telephony
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();
            Smartphone sp = new Smartphone();
            foreach (string number in phoneNumbers)
            {
                Console.WriteLine(sp.Calling(number));

            }
            foreach (string site in sites)
            {
                Console.WriteLine(sp.Browsing(site));
            }
        }
    }
}
