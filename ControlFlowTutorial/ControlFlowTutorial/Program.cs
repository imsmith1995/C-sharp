
int bigInt = int.MaxValue;
Console.WriteLine(bigInt);
bigInt++;
Console.WriteLine(bigInt);



//string strNumber = "$2345A";

//int anInt = 0;

//bool CanConvert = int.TryParse(strNumber, out anInt);

//if (!CanConvert)
//{
//    Console.WriteLine("The string could not be converted!"); 
//}
//else
//{
//    Console.WriteLine($"The converted value is {anInt}");
//    }




//string strNumber = "2345";
//int nbr = Convert.ToInt32(strNumber);
//string anotherString = nbr.ToString();
//var aVariable = 123.ToString();



//Fizz, Buzz, and Fizz-buzz

// check number 1 to 50
/* if div. by 3 then print Fizz,
 * if div. by 5 then print Buzz,
 * if div. by 3 & 5 then print Fizz-buzz,
 * if not div. by 3 or 5 then print the number
*/    

//for (int idx = 1; idx <= 100; idx++)
//{
//    if (idx % 3 == 0 && idx % 5 != 0)
//    {
//        Console.Write("Fizz, ");
//    }
//    else if (idx % 5 == 0 && idx % 3 != 0)
//    {
//        Console.Write("Buzz, ");
//    }

//    else if (idx % 3 == 0 && idx % 5 == 0)
//    {
//        Console.Write("Fizz-buzz, ");
//    }

//    else
//        Console.Write($"{idx},  ");
//}

//foreach loop
//int[] NewScores = { 130, 460, 975, 169, 134,
//                    413, 436, 241, 598, 811,
//                    589, 726, 933, 906, 326,
//                    966, 861, 679, 797, 362,
//                    885, 551, 277, 997, 841 };
//int sum = 0;

////Sum if evenly divisible by 3
//foreach (int number in NewScores)
//{   if (number % 3 != 0)
//    { continue; }
//    sum += number;
//}
//Console.WriteLine($"the sum of numbers is: {sum}");


//add 1 to 100 if divi by 5 or 7
//int sum = 0;

//    for(int idx = 100; idx > 0; idx--)
//{
//    if (idx % 5 == 0  || idx % 7 == 0)
//    {
//        sum += idx;
//    }

//}
   
//    Console.WriteLine($"The sum of numbers 1 to 100 that are div. by 7 and 5 are: {sum}");

// for() loops

//int i = 1000000;
//int sum = 0;

//for (int i = 1000000; i > 0; i--) {
//    if (i % 2 == 0)
//    { continue; }
//    sum += i;
//}

//do{
//    sum += i;
//    i--;
//} while (i > 0);

//int i = 100;
//int sum = 0;
//while(i > 0) {
//    sum += i;
//    i--;
//}
//Console.WriteLine($"Sum of number 1 to 100 is {sum}");


//var stateCode = "OH";
//var city = "Cincinnati";
//string salesperson = string.Empty;

//salesperson = stateCode switch
//{
//    "OH" => "Karl",
//    "KY" => "Sam",
//    "IN" => "Ian",
//      _  => "Greg"
//};

//switch (stateCode)
//{
//    case "OH":
//        Console.WriteLine("Ohio");
//        break;
//    case "KY":
//        Console.WriteLine("Kentucky");
//        break;
//    case "IN":
//        Console.WriteLine("Indiana");
//        break;
//    default:
//        Console.WriteLine("It is not a tristate state");
//        break;
//}

//if (state == "OH")
//{
//    Console.WriteLine("State is Ohio");
//    if(city == "Cincinnati")
//    {
//        Console.WriteLine("City is Cincinnati");
//    } else if (city == "Columbus")
//    {
//        Console.WriteLine("City is Columbus");
//    } else
//    {
//        Console.WriteLine("City is Cleveland");
//    }
//} else if (state == "KY")
//{
//    Console.WriteLine("State is Kentucky");
//} else
//{
//    Console.WriteLine("State is not Ohio or Kentucky");
//}



//===================================================



//var boolean = true;

//if (boolean == true)
//{
//    Console.WriteLine("Boolean is true!");
//}
//else
//{
//    Console.WriteLine("Boolean is false!");
//}