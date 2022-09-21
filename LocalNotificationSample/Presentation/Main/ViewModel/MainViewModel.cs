using System;
using System.Windows.Input;
using UIKit;
using UserNotifications;

namespace LocalNotificationSample.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
             
        }
        public void ScheduleNotification(string notificationBody)
        {
            var content = new UNMutableNotificationContent();
            content.Title = "Mahmoud Notification";
            content.Body = notificationBody;
            content.Sound = UNNotificationSound.Default;
            content.Badge = 1;

            var trigger = UNTimeIntervalNotificationTrigger.CreateTrigger(10, false);

            var requestID = "sampleRequest";
            var request = UNNotificationRequest.FromIdentifier(requestID, content, trigger);

            // schedule it
            UNUserNotificationCenter.Current.AddNotificationRequest(request, (error) =>
            {
                if (error != null)
                {
                    Console.WriteLine($"Error: {error.LocalizedDescription ?? ""}");
                }
                else
                {
                    Console.WriteLine("Added");
                }
            });
        }
    }
}
