using System;

using UIKit;

namespace Pickers
{
	public partial class ViewController : UITabBarController
	{
		/*
		UIViewController tab1, tab2, tab3;

		public ViewController ()
		{
			tab1 = new DatePickerViewController();
			//tab1.Title = "Green";
			//tab1.View.BackgroundColor = UIColor.Green;

			tab2 = new SingleComponentPickerViewController();
			//tab2.Title = "Orange";
			//tab2.View.BackgroundColor = UIColor.Orange;

			tab3 = new DoubleComponentPickerViewController();
			//tab3.Title = "Red";
			//tab3.View.BackgroundColor = UIColor.Red;

			var tabs = new UIViewController[] {
				tab1, tab2, tab3
			};

			ViewControllers = tabs;
		}
		*/

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

