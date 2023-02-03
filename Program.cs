using Newtonsoft.Json;

Dictionary<string, int> points = new()
{
    { "James", 9001 },
    { "Jo", 3474 },
    { "Jess", 11926 }
};

string json = JsonConvert.SerializeObject(points, Formatting.Indented);

Console.WriteLine(json);