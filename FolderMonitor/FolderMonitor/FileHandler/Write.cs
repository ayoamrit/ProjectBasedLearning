using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderMonitor.FileHandler
{
    public class Write : FPath
    {
        public void SaveContent()
        {
            using(StreamWriter streamWriter = new StreamWriter(_filePath))
            {
                foreach(var folderPath in FolderHandler.Folder.List)
                {
                    streamWriter.WriteLine(folderPath);
                }
            }
        }

    }
}
