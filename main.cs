using System;
using System.Reflection;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{
    public static async Task Main()
    {
        HttpClient client = new HttpClient();
        string response = await client.GetStringAsync("https://api.adviceslip.com/advice");

        // Console.WriteLine(jsonAsDictionary);
        Console.WriteLine("");
        JsonNode infoNode = JsonNode.Parse(response)!;
        // Console.WriteLine(forecastNode);
        JsonNode slipNode = infoNode!["slip"]!;
        // Console.WriteLine(windNode);
        JsonNode adviceNode = slipNode!["advice"]!;

        var advice = adviceNode;
        Console.WriteLine("Your advice for the day is... " + advice + "");
    }
}