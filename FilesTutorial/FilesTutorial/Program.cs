using static System.Console;
//using static System.IO.Directory;

string fullFilename = @"C:\Users\max-s\Desktop\FilesTutorial.log";

List<string> log = new();

if (File.Exists(fullFilename))
{
    string[] lines = File.ReadAllLines(fullFilename);
    log.AddRange(lines);
}


WriteLog("*** Multiples of 3 ***");
for(int i = 0; i <= 100; i++)
{
    if(i % 3 == 0)
    {
        WriteLog($"i is {i}");
    }
}

File.WriteAllLines(fullFilename, log);

WriteLine("Done ...");


//Below is a method where you pass in the message you want logged.
void WriteLog(string message)
{
    string logmessage = $"{DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff")} {message}";
    log.Add(logmessage);
}

//WriteLine("Files Tutorial!");

//string foldername = @"C:\repos\cs10dotnet6";

//string[] files = Directory.GetFiles(foldername);
//string[] folders = Directory.GetDirectories(foldername);
//foreach(string folder in folders)
//{
//    WriteLine(folder);
//}

//foreach (string file in files)
//{
//    Console.WriteLine(file);
//}


//Delete(newfolder);

//CreateDirectory($"{newfolder}");

//Path.Combine(newfolder, "MyNewSubFolder");

//foreach(DriveInfo drive in DriveInfo.GetDrives())
//{
//    //if (drive.IsReady) { }
//    WriteLine($"{drive.Name} | {drive.DriveType} | {drive.DriveFormat} | {drive.TotalSize:N0} | {drive.AvailableFreeSpace:N0}");
//}