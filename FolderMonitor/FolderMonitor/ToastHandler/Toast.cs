using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;

namespace FolderMonitor.ToastHandler
{
    public class Toast
    {
        //Constructor for the Toast class
        public Toast(string heading, string message, string folderPath)
        {
            //Create a new toast notification using ToastContentBuilder from Microsoft.Toolkit.Uwp.Notifications
            new ToastContentBuilder()
            .AddText($"{heading}", hintMaxLines: 1)  //Heading text
            .AddText($"Directory Path: {folderPath}")  //Directory path
            .AddText($"{message}")  //Message text
            .Show();  //Display the toast notification
        }
    }
}
