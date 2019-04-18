using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

public class DateModifier
{
    public static int CalculateDifference (string firstDate, string secondDate)
    {
        DateTime first = DateTime.Parse(firstDate);
        DateTime second = DateTime.Parse(secondDate);
        TimeSpan difference = first - second;
        return Math.Abs(difference.Days);
    }
}
