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
        public Toast(string message, string folderPath)
        {
            var builder = new ToastContentBuilder()
            .AddArgument("meetingId", 9813)
            .AddText("Adaptive Tiles Meeting", hintMaxLines: 1)
            .AddText("Conf Room 2001 / Building 135")
            .AddText("10:00 AM - 10:30 AM");
        }
    }
}
