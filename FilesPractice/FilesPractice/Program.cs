//Purpose of this: look at my repos folder and print out all folders within 
// as well as all files within the folders.
Console.WriteLine("Files Practice!");

RecursiveFunction(@"C:\repos");

void RecursiveFunction(string foldername) {
   
    Console.WriteLine($"{foldername}");
    string[] folders = Directory.GetDirectories(foldername);
    foreach (string folder in folders)
    {
        RecursiveFunction(folder);
        string[] files = Directory.GetFiles(foldername);
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }
    }
}
