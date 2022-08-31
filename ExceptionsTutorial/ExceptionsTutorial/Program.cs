/*
 * The following is a bit of code on exceptions
 * for more information on exceptions, 
 * see pages 120-124 of the book.
*/
internal class Program{

    private static void Main(string[] args) { 
    Method1();
    }
    private static void Method1() {
        Method2();
    }

    private static void Method2() {
        Method3();
    }
    private static void Method3() {
        int n = 0;
        int d = 0;
        try
        {
            int x = n / d;
        } catch(DivideByZeroException)
        {
            Console.WriteLine("We attempted to divide by zero");
        }
        catch (Exception)
        {
            Console.WriteLine("An exception occured!");
        }
        Console.WriteLine("End of Method3!");
    }
}