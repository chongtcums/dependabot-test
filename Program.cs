using System;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        var obj = new { Name = "SecurityTest" };
        string json = JsonConvert.SerializeObject(obj);
        Console.WriteLine(json);
    }
}
