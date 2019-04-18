using System.Collections.Generic;
using System.Linq;

public class Smartphone : IPhone, IWWW
{
    //private List<string> phoneNumbers;
    //private List<string> sites;

    //public Smartphone(List<string> phoneNumbers, List<string> sites)
    //{
    //    this.PhoneNumbers = phoneNumbers;
    //    this.Sites = sites;
    //}

    //public List<string> PhoneNumbers
    //{
    //    get { return this.phoneNumbers; }
    //    set { this.phoneNumbers = value; }
    //}

    //public List<string> Sites
    //{
    //    get { return this.sites; }
    //    set { this.sites = value; }
    //}

    public string Calling(string phoneNumber)
    {
        if (!phoneNumber.Any(c => char.IsDigit(c)))
            return "Invalid number!";
        return $"Calling... {phoneNumber}";
    }

    public string Browsing(string site)
    {
        if (site.Any(c => char.IsDigit(c)))
            return "Invalid URL!";
        return $"Browsing: {site}!";
    }

}
