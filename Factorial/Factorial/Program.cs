Console.WriteLine("Factorial!");
//Recursive Functions
//Calculate 6 factorial (6!)

int target = 6;
int product = Factorial(target);

int Factorial(int nbr)
{
    if (nbr == 1)
    {
        return 1;
    }
    return nbr * Factorial(nbr - 1)
        ;
}


// Factorial via a For Loop
int FactorialLoop(int nbr)
{
    int product = 1;

    for (int idx = 1; idx <= target; idx++)
    {
        product = product * idx;
    }
    return product;
}
    Console.WriteLine($"{target}! is:  {product}");



