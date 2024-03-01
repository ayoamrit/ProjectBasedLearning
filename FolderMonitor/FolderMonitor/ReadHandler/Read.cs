using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderMonitor.ReadHandler
{
    public class Read
    {
        private const string _filePath = "ReaderContent.txt";

        public Read()
        {
            bool fileExistenceFlag = CheckFileExistence();

            if (!fileExistenceFlag)
            {
                CreateNewFile();
            }
            else
            {
                try
                {
                    ReadData();

                }catch(ExceptionHandler.ReaderException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }

        private bool CheckFileExistence()
        {
            return File.Exists(_filePath);
        }

        private void CreateNewFile()
        {
            File.Create(_filePath);
        }

        private void ReadData()
        {
            try
            {
                using (StreamReader reader = new StreamReader(_filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        FolderHandler.Folder.List.Add(line);
                    }
                }

            }catch(Exception)
            {
                throw new ExceptionHandler.ReaderException("An error occurred while reading data from the file");
            }

        }
    }
}
