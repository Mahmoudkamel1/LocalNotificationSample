// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace LocalNotificationSample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UITextField notificationContent { get; set; }

		[Action ("SendNotification:")]
		partial void SendNotification (UIKit.UIButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (notificationContent != null) {
				notificationContent.Dispose ();
				notificationContent = null;
			}
		}
	}
}
