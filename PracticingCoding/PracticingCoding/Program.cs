
Console.WriteLine("Power Multiplier x^y.");

var running = "yes";

do {
var x = UserEnterAndConvert("Please type the base number and press [ENTER]: ");
var y = UserEnterAndConvert($"What Power do you want to multiply {x} by?: ");

    int answer = 1;
    for (int idx = y; idx > 0; idx--)
    {
        answer *= x;
    }

    Console.WriteLine($"{x}^{y} is {answer}");
    Console.WriteLine("Do you want to conitue? yes/no: ");
    running = Console.ReadLine();
    while (running != "yes" || running != "no")
    {
        if (running == "yes")
            break;
         if (running == "no")
            break;
        Console.WriteLine("Not a valid response...");
        Console.WriteLine("Type yes or no and press [ENTER]");
       running = Console.ReadLine();
    }


} while (running != "no");


int UserEnterAndConvert(string message)
{
    bool flag = true;
    int convertednbr = 0;
    while (flag)
    {
        Console.WriteLine($"{message}");
        var enterednbr = Console.ReadLine();
        try
        {
            convertednbr = Convert.ToInt32(enterednbr);
            flag = false;
        }
        catch (Exception)
        {
            Console.WriteLine($"Not a valid response. Only enter numbers");
            flag = true;
        }
    }
    return convertednbr;
}

