using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderMonitor.FileHandler
{
    public class Read : FPath
    {
        
        //Constructor for the Read class
        public Read()
        {

            //Check if the file exists
            bool fileExistenceFlag = CheckFileExistence();

            //If the file does not exist, create a new one
            if (!fileExistenceFlag)
            {
                CreateNewFile();
            }
            else
            {
                try
                {
                    //Read data from the existing file
                    ReadData();

                }
                catch (ExceptionHandler.ReaderException ex)
                {
                    //If an exception occurs during reading, catch and handle it
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);  //Exit the program
                }
            }
        }

        //Method to check if the file exists
        private bool CheckFileExistence()
        {
            return File.Exists(_filePath);
        }

        //Method to create a new file if it does not exist
        private void CreateNewFile()
        {
            File.CreateText(_filePath);
        }

        //Method to read data from the file
        private void ReadData()
        {
            try
            {
                //using statement ensures that the StreamReader is properly disposed after use
                using (StreamReader reader = new StreamReader(_filePath))
                {
                    string line;

                    //Read each line from the file until the end
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Add each line to a list in another class named FolderHandler
                        FolderHandler.Folder.List.Add(line);
                    }
                }

            }
            catch (Exception)
            {

                //If an exception occurs during reading, throw a custom exception
                throw new ExceptionHandler.ReaderException("An error occurred while reading data from the file");
            }

        }
    }
}
