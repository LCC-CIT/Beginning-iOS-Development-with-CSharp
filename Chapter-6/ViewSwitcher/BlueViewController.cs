
using System;

using Foundation;
using UIKit;

namespace ViewSwitcher
{
	public partial class BlueViewController : UIViewController
	{
		/*
		public BlueViewController () : base ("BlueViewController", null)
		{
		} */

		public BlueViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void BlueButton_TouchUpInside (UIButton sender)
		{
			var alert = UIAlertController.Create(title: "Blue View Button Pressed", 
				message: "You pressed the button ont he blue view", preferredStyle: UIAlertControllerStyle.Alert);
			var action = UIAlertAction.Create(title: "Yup, I did", style: UIAlertActionStyle.Default, handler: null);
			alert.AddAction(action);
			PresentViewController(alert, animated: true, completionHandler: null);
		}
	}
}

