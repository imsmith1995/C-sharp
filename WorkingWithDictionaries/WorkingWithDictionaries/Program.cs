Console.WriteLine("Working With Dictionaries");

WorkingWithDictionaries();

static void Output(string title, IEnumerable<string> collection)
{
    Console.WriteLine(title);
    foreach (string item in collection)
    {
        Console.WriteLine($"  {item}");
    }
}

static void WorkingWithDictionaries()
{
    Dictionary<string, string> keywords = new();

    //add using named parameters
    keywords.Add(key: "int", value: "32-bit integer data type");

    //add using positional parameters
    keywords.Add("long", "64-bit integer data type");
    keywords.Add("float", "Single precision floating point number");

    Output("Dictionary keys:", keywords.Keys);
    Output("Dictionary values:", keywords.Values);

    Console.WriteLine("Keywords and their definitions");
    foreach (KeyValuePair<string, string> item in keywords)
    {
        Console.WriteLine($"  {item.Key}: {item.Value}");
    }
    //Lookup a value using a key
    string key = "long";
    Console.WriteLine($"The definition of {key} is {keywords[key]}");
}
