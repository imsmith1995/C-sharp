// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello and welcome. I will be adding up your bowling scores.");

Console.WriteLine("Please, enter the score from your first bowling game: ");
string answer1 = Console.ReadLine();
int myScore1 = Convert.ToInt32(answer1);
Console.WriteLine($"The score from your first bowling game is {myScore1}");

Console.WriteLine("Enter the score from your second bowling game: ");
string answer2 = Console.ReadLine();
int myScore2 = Convert.ToInt32(answer2);
Console.WriteLine($"The score from your second bowling game is {myScore2}");

Console.WriteLine("Enter the score from your third bowling game: ");
string answer3 = Console.ReadLine();
int myScore3 = Convert.ToInt32(answer3);
Console.WriteLine($"The score from your third bowling game is {myScore3}");

int[] games = new int[] { myScore1, myScore2, myScore3 };
int seriesScore = games[1] + games[2] + games[0];
Console.WriteLine($"Score 1: {games[0],5}, Score 2: {games[1],5}, Score 3: {games[2],5}   Series Total:{seriesScore}");
Console.WriteLine($"The Series Total from your three bowling games is: {seriesScore};");

/*

Console.Write("Type a string and press ENTER: ");
string? response = Console.ReadLine();
Console.WriteLine($"You typed: {response}");

//An array of ints (scores)
int[] scores2 = new int[] { 100, 95, 97, 93, 100 };
Console.WriteLine($"{scores2[0],8}, {scores2[1],5}, {scores2[2],5}, {scores2[3],5}, {scores2[4],5}");

int[] scores = new int[5];
scores[0] = 100;
scores[1] = 95;
scores[2] = 97;
scores[3] = 100;
scores[4] = 7;
Console.WriteLine($"{scores[0],8}, {scores[1],5}, {scores[2],5}, {scores[3],5}, {scores[4],5}");


// An array of strings (names)
string[] names = { "Jack", "Sam", "James", "Ian", "Caleb", "Karl", "Josh", "Billy" };
Console.WriteLine($"{names[0]}, {names[1]}, {names[2]}, {names[3]}, {names[4]}, " +
    $"{names[5]}, {names[6]}, {names[7]}");


// An array simulating bowling game scores
int[] games =  new int[] { 145, 264, 244 };
int seriesScore = games[1] + games[2] + games[0];
Console.WriteLine($"{games[0],8}, {games[1],5}, {games[2],5}   Series Total:{seriesScore}");
*/
