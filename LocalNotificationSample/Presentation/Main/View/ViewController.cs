using Foundation;
using LocalNotificationSample.ViewModel;
using System;
using System.Threading.Tasks;
using UIKit;
using UserNotifications;

namespace LocalNotificationSample
{
    public partial class ViewController : UIViewController
    {
        private MainViewModel ViewModel => new MainViewModel();
        public ViewController(IntPtr handle) : base(handle)
        {
        }
        partial void SendNotification(UIButton sender)
        {
            
            if (string.IsNullOrEmpty(notificationContent.Text))
            {
                var alert = UIAlertController.Create("Error", "Please write notification body to show", UIAlertControllerStyle.Alert);
                ShowViewController(alert, this);
                Task.Delay(3000);
                DismissViewController(true, null);
                return;
            }
            ViewModel.ScheduleNotification(notificationContent.Text);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
