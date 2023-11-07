using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        Hashtable week = new Hashtable();

        week.Add("Monday","2");
        week.Add("Tuesday", "3");
        week.Add("Wednesday", "4");
        week.Add("Thursday", "5");
        week.Add("Friday", "6");
        week.Add("Saturday", "7");
        week.Add("Sunday", "8");

        foreach(var key in week.Keys)
        {
            Console.WriteLine(key + ":" + week[key]);
        }

        Console.WriteLine("\n");


        if (week.ContainsKey("Tuesday"))
            Console.WriteLine("see Tuesday");
        else
            Console.WriteLine("no see him");
    }
}