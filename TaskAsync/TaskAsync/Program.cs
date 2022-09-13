System.Diagnostics.Debug.WriteLine("Async Programming!");

Task t1 = new(WriteMultipleLines);

t1.Start();

System.Diagnostics.Debug.WriteLine("Done...");

t1.Wait();

System.Diagnostics.Debug.WriteLine("Finished...");

void WriteMultipleLines()
{
    System.Diagnostics.Debug.WriteLine("Print first line!");

    System.Diagnostics.Debug.WriteLine("Print second line!");

    System.Diagnostics.Debug.WriteLine("Print third line!");
}