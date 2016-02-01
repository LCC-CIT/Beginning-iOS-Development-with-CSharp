using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ViewSwitcher
{
	partial class YellowViewController : UIViewController
	{
		public YellowViewController (IntPtr handle) : base (handle)
		{
		}

		partial void YellowButton_TouchUpInside (UIButton sender)
		{
			var alert = UIAlertController.Create(title: "Yellow View Button Pressed", 
				message: "You pressed the button on the yellow view", preferredStyle: UIAlertControllerStyle.Alert);
			var action = UIAlertAction.Create(title: "I sure did", style: UIAlertActionStyle.Default, handler: null);
			alert.AddAction(action);
			PresentViewController(alert, animated: true, completionHandler: null);		}

	}
}
