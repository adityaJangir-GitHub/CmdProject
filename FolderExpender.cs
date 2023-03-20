namespace CmdControl
{
    public class FolderExpender
    {
        public static void FolderStructer(string path, string space = " ")
        {

            var directories = Directory.GetDirectories(path);

            foreach (var directory in directories)
            {
                printFileDirectoryName(directory, space);
                fileStructer(path, space);

                var updatedPath = Path.Combine(path, Path.GetFileName(directory));
                var updatedSpace = space + "    ";
                if (Directory.Exists(updatedPath))
                {
                    FolderStructer(updatedPath, updatedSpace);   
                }
            }
        }
        private static void fileStructer(string path, string space)
        {
            var subDirextories = Directory.GetFiles(path);
            foreach (var subDirectory in subDirextories)
            {
                printFileDirectoryName(subDirectory, space);
            }
        }

        private static void printFileDirectoryName(string path, string space)
        {
            if (Path.HasExtension(path))
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(space + "|__" + Path.GetFileName(path));
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(space + "|__" + Path.GetFileName(path));
                Console.ResetColor();
            }

        }
    }
}
