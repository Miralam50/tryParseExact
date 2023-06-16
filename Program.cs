using System;
using System.Globalization;

public class Program
{
    public static bool CustomTryParseExact(string input, string format, out DateTime result)
    {
        result = DateTime.MinValue;

        CultureInfo provider = CultureInfo.InvariantCulture;
        DateTimeStyles styles = DateTimeStyles.None;

        if (DateTime.TryParseExact(input, format, provider, styles, out result))
        {
            return true;
        }

        return false;
    }

    public static void Main(string[] args)
    {
        string input = "03-05-2023";
        string format = "dd-MM-yyyy";
        DateTime result;

        if (CustomTryParseExact(input, format, out result))
        {
            Console.WriteLine("Successful: " + result);
        }
        else
        {
            Console.WriteLine("Unsuccessful");
        }
    }
}