// See https://aka.ms/new-console-template for more information


using System.Xml;

MAX.Console.Run("Ian");

Console.WriteLine("Hello, World!");

if (true)
{
    Console.WriteLine("The if statement is true!");
    Console.WriteLine("We want to execute this statement also if true.");
}

Console.WriteLine("This statement will always execute regardless of the if statement");

MAX.Student sam = new MAX.Student();
sam.Firstname = "Noah";
sam.Lastname = "Phence";
Console.WriteLine(sam.Firstname + " " + sam.Lastname);

MAX.Student caleb = new MAX.Student();
caleb.Firstname = "Caleb";
caleb.Lastname = "Phence";
Console.WriteLine(caleb.Fullname());

MAX.Major math = new MAX.Major();
math.Code = "MATH";
math.Description = "mathematics";
math.MinSAT = 1200;
Console.WriteLine(math.Code + " \t " + math.Description + " \t " + math.MinSAT);
math.Print();

MAX.Major bus = new MAX.Major();
bus.Code = "BUS";
bus.Description = "Business";
bus.MinSAT = 400;
bus.Print();

// variable

var i = 13.0m;
var j = 3;
var sum = i + j;
var diff = i - j;
var prod = i * j;
var div = i / (decimal)j;

Console.WriteLine($"{sum} | {diff} | {prod} | {div} ");


Person kim = new();

kim.Birthdate = new(2022, 08, 26);

class Person{
    public DateTime Birthdate;
}

