using File = System.IO.File;

namespace CmdControl
{
    public abstract class Commands
    {
        public string Path { get; set; }
        public abstract void PerformCommand();
    }
    public class ReadFile : Commands
    {
        public override void PerformCommand()
        {
            string[] lines = File.ReadAllLines(this.Path);
            if(lines.Length > 0)
            {
                foreach (string line in lines)
                    Console.WriteLine(line);
            }
            else
            {
                Console.WriteLine("File is empty.");
            }
            

        }
    }

    public class ClearFile : Commands
    {
        public override void PerformCommand()
        {
            FileStream fileStream = File.Open(this.Path, FileMode.Open);
            fileStream.SetLength(0);
            fileStream.Close();

        }
    }

    public class InsertData : Commands
    {
        public override void PerformCommand()
        {
            Console.WriteLine("Enter the data to be appended");
            var value = Console.ReadLine();
            FileStream fileStream = File.Open(this.Path, FileMode.Append, FileAccess.Write);
            using (StreamWriter streamWriter = new StreamWriter(fileStream))
            {
                streamWriter.WriteLine(value);
            }
            fileStream.Close();
        }
    }

    public class DeleteFile : Commands
    {
        public override void PerformCommand()
        {
            try
            {
                File.Delete(this.Path);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
