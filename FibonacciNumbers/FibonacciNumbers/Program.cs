using System.Diagnostics;
using System.Globalization;

string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
//var streamWriter = File.CreateText(Path.Combine(folderPath, "appTrace.log"));
//var traceWriter = new System.Diagnostics.TextWriterTraceListener(streamWriter);
//System.Diagnostics.Trace.Listeners.Add(traceWriter);

//System.Diagnostics.Trace.AutoFlush = true;

Console.WriteLine("Fibonacci!");

//Creating the Fibonacci Sequence
// 1, 1, 2, 3, 5, 8, 13, 21, ...
//start with 1, 1 and then the following number is the sum of the previous two entries.

int a = 1;
int b = 1;
int c = 0;

Console.WriteLine($"{a},");
Console.WriteLine($"{b},");

while (c < 100)
{
    c = Add(a, b);
    //Debug.WriteLine($"a = {a}, b = {b}, c = {c}");
    //Trace.TraceInformation($"a = {a}, b = {b}, c = {c}");
    Console.WriteLine($"{c},");

    a = b;
    b = c;
}

int Add(int a, int b)
{
    return a + b;
}

//Try to make it Fibonacci Sequence Recursively

int j = 1;
int k = 1;
Fib(1, 1);

void Fib(int j, int k)
{
    var c = j + k;
    if (c > 100) return;
    Console.WriteLine($"{c}, ");
    Fib(k, c);

}