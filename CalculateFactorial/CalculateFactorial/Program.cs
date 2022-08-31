// See https://aka.ms/new-console-template for more information

//int sum = 1;

//for (int k = 7; k > 0; k--)
//{
//    sum = sum * k;
//}


//Console.WriteLine($"The factorial of 7 is {sum}.");

Console.WriteLine("Calcalate Factorial");
int again = -1;
do
{
    int factorialNumber = GetIntFromUser("Enter Factorial to calculate");
    int factorial = 1;

    for (var idx = 1; idx <= factorialNumber; idx++)
    {
        factorial *= idx;
    }

    Console.WriteLine($"{factorialNumber}! is {factorial}");

    again = GetIntFromUser("Enter 0 to quit");
} while (again != 0);

int GetIntFromUser(string message)
{
    Console.Write($"{message}:  ");
    string response = Console.ReadLine();
    int resp = Convert.ToInt32(response);
    return resp;
}
