using System;

namespace hhh
{
    class First
    {
       private static void Main(string[] args)
        { //  var name="jonson";
        //     Console.WriteLine("Hello " + name);

        Console.WriteLine("What is your name? ");
        var name=Console.ReadLine();
        var date=DateTime.Now;
        Console.WriteLine($"Hello , {name}  on {date:d} at {date:t}");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey(true);

        }
    }
}
