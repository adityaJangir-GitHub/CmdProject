// See https://aka.ms/new-console-template for more information
using CmdControl;

var path = args.Length != 0 ? args[0] : null;

if (File.Exists(path) && Path.HasExtension(path))
{
    DisplayCommandList();
    var operation = Console.ReadLine().ToLower();
    Executor.Execute(operation, path);
}
else if (Directory.Exists(path) && !Path.HasExtension(path))
{
    FolderExpender.FolderStructer(path);
    Console.Write("Enter the full file path:");
    var extendedPath = Console.ReadLine();
    path = Path.Combine(path, extendedPath);

    DisplayCommandList();
    var operation = Console.ReadLine().ToLower();

    Executor.Execute(operation, path);

}
else
{
    Console.WriteLine("Invalid path");
}

void DisplayCommandList()
{
    // we can loop Commandvalidater for options list showing
    Console.WriteLine("following operation's can be perform, please choose from the list below ");
    Console.WriteLine("To view the data enter view");
    Console.WriteLine("To clear the data enter clear");
    Console.WriteLine("To append the data enter append");
    Console.WriteLine("To delete the file enter delete");
    Console.WriteLine("To create a new file enter create");
}



