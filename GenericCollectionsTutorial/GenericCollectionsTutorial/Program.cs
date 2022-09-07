using GenericCollectionsTutorial;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

Console.WriteLine("Generic Collections!");




/*
 * The RPN Calculator
 * 
 * "2 3 * 1 +" evalutates to 7 | "2 * 3 + 1 = 7" 
 * 6 6 * 5 6 * + 27 - evaluates to 39  |   "6^2 + 5*6 - 27"
 */
/*
int a = 0;
int b = 0;

Stack<int> stack = new ();
string eval = "6 6 * 5 6 * + 27 -";

string[] parts = eval.Split(" ");
foreach(string part in parts)
{
    switch (part)
    {
        case "+":
            //add
            a = stack.Pop();
            b = stack.Pop();
            stack.Push(a + b);
            break;
        case "-":
            //subtract
            a = stack.Pop();
            b = stack.Pop();
            stack.Push(b - a);
            break;
        case "*":
            //multiply
            a = stack.Pop();
            b = stack.Pop();
            stack.Push(a * b);
            break;
        case "/":
            //divide
            a = stack.Pop();
            b = stack.Pop();
            stack.Push(b / a);
            break;
        default:
            // convert to number
            // and push
            int nbr = Convert.ToInt32 (part);
            stack.Push (nbr);
            break;


    }
}

Console.WriteLine($" = {stack.Pop()}");
*/

/*
Stack<int> stack = new();

int anInt = GetUserInput();
stack.Push(anInt);

while (true)
{
    anInt = GetUserInput();
    stack.Push(anInt);
    if (anInt == 0) break;
    var a = stack.Pop();
    var b = stack.Pop();
    stack.Push(a + b);
    Console.WriteLine($"{a + b}");
}

Console.WriteLine("Done...");



int GetUserInput()
{
    Console.Write("Enter an integer: ");
    string ans = Console.ReadLine();
    return Convert.ToInt32(ans);
}


string[] names = new string[] { "John", "James", "Dakota", "Adam", "Mathew", "Cannon" };

Dictionary<string, int> dictionary = new Dictionary<string, int>();

foreach(string name in names)
{
    string ch = name.Substring(0, 1).ToUpper();
    if(!dictionary.ContainsKey(ch))
    {
        dictionary.Add(ch, 0);
    }
    dictionary[ch]++;
}

*/


/*
List<int> ints = new();


for (int idx = 1; idx < 1000; idx += 13)
{
    ints.Add(idx);
}

Console.WriteLine($"The List has {ints.Count} items.");

Console.WriteLine($"The fifth item in the List is {ints[4]}");

int sum = 0;
foreach (int idx in ints)
    sum += idx;

ints.ForEach(idx => sum += idx);

Console.WriteLine($"{sum}");

List<string> cities = new();

cities.Add ("London");
cities.Add("Paries");
cities.Add("London");
cities.Add("Santiago");
cities.Add("Sydney");

cities.Sort();

cities.ForEach(city =>  Console.WriteLine($"{city}, "));

Dictionary<string, string> states = new();
states.Add("OH", "Ohio");
states.Add("KY", "Kentucky");
states.Add("IN", "Indiana");

string state = states["KY"];

var x = states.Keys.ToList();

foreach (var key in states.Keys.ToList())
{
    var value = states[key];
}

Dictionary<int, Student> students = new();
students.Add(10, new Student { Id = 10, Name = "Noah Phence", SAT = 1200 });
students.Add(20, new Student { Id = 20, Name = "Graham Krakr", SAT = 1000 });
students.Add(30, new Student { Id = 30, Name = "Leo Lemon", SAT = 1150 });

Student noah = students[10];
Student grah = students[20];
*/