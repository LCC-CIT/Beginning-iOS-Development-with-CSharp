
using System;

using Foundation;
using UIKit;

namespace Pickers
{
	public partial class DatePickerViewController : UIViewController
	{
		public DatePickerViewController (IntPtr handle) : base (handle)
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
			
			// Perform any additional setup after loading the view, typically from a nib.
			var date = new NSDate();
			datePicker.Date  = date;

			base.ViewDidLoad ();
		}
			

		partial void selectButton_TouchUpInside (UIButton sender)
		{
			var date = datePicker.Date;
			var msg = String.Format("The date and time you selected is {0}", date);


			var  alert = UIAlertController.Create(
				title: "Date and Time Selected",
				message: msg,
				preferredStyle: UIAlertControllerStyle.Alert);

			var action = UIAlertAction.Create(
				title: "That's so true!",
				style: UIAlertActionStyle.Default,
				handler: null);

			alert.AddAction(action);
			this.PresentViewController(alert, true, null);		
		}
	}
}

