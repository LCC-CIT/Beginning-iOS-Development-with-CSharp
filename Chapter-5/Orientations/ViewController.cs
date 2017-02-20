using System;

using UIKit;

namespace Orientations
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		// comment this method out to see the orientations enabled in info.plist
		public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations ()
		{
			return UIInterfaceOrientationMask.Portrait; //| UIInterfaceOrientationMask.LandscapeLeft;
											// | UIInterfaceOrientationMask.LandscapeRight;
			// return base.GetSupportedInterfaceOrientations();
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

