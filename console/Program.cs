using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;


public class Program
{
    static Dictionary<string, bool> dangerous_words = new Dictionary<string, bool>();


    public static void Main(string[] args)
    {
        //my_linq();
        foo();
        Console.WriteLine("done");
    }

    public static async void foo()
    {
        await FooAsync();
        //await FooAsync();
    }


    static async Task FooAsync()
    {
        string text = await File.ReadAllTextAsync("Program.cs");
        Console.WriteLine(text);
        //return s;

    }

    public static void my_linq()
    {
        string[] array = { "dog", "cat", "apple", "sun", "sky", "human", "tree", "violin", "shrimp", "water", "sand" };

        var result = from s in array where s.StartsWith("s") orderby s[1] select s;

        var result2 = array.Where(s => s.StartsWith("s")).OrderBy(s => s[1]).Select(s => s);

        foreach (string s2 in result2)
        {
            Console.WriteLine(s2);
        }
    }
}
