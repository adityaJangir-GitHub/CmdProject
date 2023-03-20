namespace CmdControl
{
    public class Executor
    {
        public static void Execute(string command, string path)
        {

            Commands commands = Validate.Commandvalidater(command);
            commands.Path = path;
            commands.PerformCommand();
        }
    }
}
