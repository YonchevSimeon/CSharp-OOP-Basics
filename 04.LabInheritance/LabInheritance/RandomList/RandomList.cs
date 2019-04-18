using System;
using System.Collections.Generic;
public class RandomList : List<string>
{
    
    public string RandomString()
    {
        Random random = new Random();
        string result = null;
        if(this.Count > 0)
        {
            int randomElement = random.Next(0, this.Count - 1);
            result = this[randomElement];
            this.RemoveAt(randomElement);
        }
        return result;
    }

}
