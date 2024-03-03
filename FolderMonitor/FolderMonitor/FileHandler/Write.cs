using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderMonitor.FileHandler
{
    public class Write : FPath
    {
        //Method to save content to a file
        public void SaveContent()
        {
            try
            {
                //use StreamWriter to write to the specified file path
                using (StreamWriter streamWriter = new StreamWriter(_filePath))
                {
                    //Loop through each folder path in the list of FolderHandler.Folder.List
                    foreach (var folderPath in FolderHandler.Folder.List)
                    {
                        //Write each folder path to the file
                        streamWriter.WriteLine(folderPath);
                    }
                }
            }
            //Catch any exception that may occur during file writing
            catch(Exception ex)
            {
                throw new ExceptionHandler.WriterException($"Error occurred while saving data: {ex.Message}");
            }

        }

    }
}
