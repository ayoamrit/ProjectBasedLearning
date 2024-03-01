namespace FolderMonitor
{
    public class Program
    {
        static FolderHandler.Folder _folder;
        static ReadHandler.Read _read;

       public static void Main(string[] args)
       {
            _folder = new FolderHandler.Folder();
            _read = new ReadHandler.Read();

            if (FolderHandler.Folder.IsEmpty)
            {
                Console.WriteLine("There are no folder paths found to monitor. Add Paths to get things going.....");
                
            }
       }

        private string? GetFilePath()
        {
            return Console.ReadLine();
        }
    }
}