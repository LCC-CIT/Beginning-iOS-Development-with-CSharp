
using System;

using Foundation;
using UIKit;

namespace ViewSwitcher
{
	public partial class SwitchingViewController : UIViewController
	{
		private BlueViewController blueViewController;
		private YellowViewController yellowViewController;

		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public SwitchingViewController ()
			: base (UserInterfaceIdiomIsPhone ? "SwitchingViewController_iPhone" : "SwitchingViewController_iPad", null)
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

//		partial void SwitchViews(UIBarButtonItem sender)   // Not sure about this
//		{
//		}
	}
}

