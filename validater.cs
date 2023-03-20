namespace CmdControl
{
    public class Validate
    {
        public static Commands Commandvalidater(string command)
        {
            try
            {
                CommandIndexer inputComand = new CommandIndexer();
                inputComand["view"] = new ReadFile();
                inputComand["clear"] = new ClearFile();
                inputComand["append"] = new InsertData();
                inputComand["delete"] = new DeleteFile();

                return inputComand[command];
            }
            catch 
            {
                throw new Exception("Invalid Command");
            }
            

        }
    }
}
