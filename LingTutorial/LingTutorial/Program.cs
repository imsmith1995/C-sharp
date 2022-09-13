Console.WriteLine("Hello, World!");

int[] ints = new int[] {
    2472,   7071,   3332,   5745,   7982,
    9164,   3909,   4380,   4000,   7862,
    6058,   9429,   2425,   7746,   5152,
    4031,   3701,   8970,   8856,   3526,
    6431,   7059,   7470,   6268,   6122
};
int[] ints2 = new int[] { 8856, 9429, 7982 };

var intsFinal = from i in ints
                  join j in ints2
                    on i equals j
                  select j;

foreach(int n in intsFinal)
{
    Console.WriteLine(n);
}

var average = ints.Where(x => x % 2 != 0).Average();

var oddInts = from i in ints
              where i % 2 == 1
              select i;

//var Average = ints.Where(x => x % 2 != 0).Average();
//Console.WriteLine(Average);
