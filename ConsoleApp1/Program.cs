using System;
using System.Threading.Tasks;

public class MyApp
{

    public static void Main(string[] args)
    {
        Method1();
        Console.WriteLine("Hello");
        Method2();
        Console.ReadLine();
    }

    public static async Task Method1()
    {
        Console.WriteLine("Hello1");
        await Task.Run(() =>
        {
            Task.Delay(5000).Wait();
            Console.WriteLine("Helloone");
        });

        Console.WriteLine("Hello2");
    }


    public static void Method2()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Method 2");
            // Do something
            Task.Delay(5000).Wait();
        }
    }
}
