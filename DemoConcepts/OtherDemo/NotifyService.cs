using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DemoConcepts.OtherDemo
{
    public class NotifyService
    {

        public void ScheduledNotifications()
        {
            //            int x = int.Parse(NewEventYear.SelectedItem.ToString());
            //            int y = int.Parse(NewEventMonth.SelectedItem.ToString());
            //            int z = int.Parse(NewEventDate.SelectedItem.ToString());
            //            int a = int.Parse(NewEventHour.SelectedItem.ToString());
            //            int b = int.Parse(NewEventMinutes.SelectedItem.ToString());

            //            DateTime EventDate = new DateTime(x, y, z, a, b, 0)
            //TimeSpan NotTime = EventDate.Subtract(DateTime.Now);
            //            DateTime dueTime = DateTime.Now.Add(NotTime);

            //            ScheduledToastNotification scheduledToast = new ScheduledToastNotification(toastXml, dueTime);
            //            ToastNotificationManager.CreateToastNotifier().AddToSchedule(scheduledToast);
        }
        public static void CreateToastr()
        {
            //// Get a toast XML template
            //XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText04);

            //// Fill in the text elements
            //XmlNodeList stringElements = toastXml.GetElementsByTagName("text");
            //for (int i = 0; i < stringElements.Length; i++)
            //{
            //    stringElements[i].AppendChild(toastXml.CreateTextNode("Line " + i));
            //}

            //// Specify the absolute path to an image
            //String imagePath = "file:///" + Path.GetFullPath("toastImageAndText.png");
            //XmlNodeList imageElements = toastXml.GetElementsByTagName("image");

            //ToastNotification toast = new ToastNotification(toastXml);

        }
        public static void CreateWatcherService()
        {
            // Create a new FileSystemWatcher and set its properties.
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = "D:\\Bhavik\\WatcherFolder";
            /* Watch for changes in LastAccess and LastWrite times, and
               the renaming of files or directories. */
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only watch text files.
            watcher.Filter = "*.txt";

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // Begin watching.
            watcher.EnableRaisingEvents = true;

            // Wait for the user to quit the program.
            Console.WriteLine("Press \'q\' to quit the sample.");
        }

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            // Specify what is done when a file is renamed.
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
            // throw new NotImplementedException();
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            // Specify what is done when a file is changed, created, or deleted.
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
        }
    }
}
