
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

		/*
		public SwitchingViewController ()
			: base (UserInterfaceIdiomIsPhone ? "SwitchingViewController_iPhone" : "SwitchingViewController_iPad", null)
		{
		}
		*/

		public SwitchingViewController (IntPtr handle) : base (handle)
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

			// Create a BlueViewController object from the current storyboard
			blueViewController = Storyboard.InstantiateViewController ("Blue") as BlueViewController;
			blueViewController.View.Frame = View.Frame;

		}


		partial void SwitchViews (UIBarButtonItem sender)
		{
			// Create the new view controller, if it doesn't exist 
			if(yellowViewController == null)
			{
				yellowViewController = Storyboard.InstantiateViewController("Yellow") as YellowViewController;
			}
			else if(blueViewController == null)
			{
				blueViewController = Storyboard.InstantiateViewController("Blue") as BlueViewController;
			}

			// Switch view controllers
			if(blueViewController != null && blueViewController.View.Superview != null)
			{
				yellowViewController.View.Frame = View.Frame;
				SwitchViewController(blueViewController, yellowViewController);
			}
			else
			{
				blueViewController.View.Frame = View.Frame;
				SwitchViewController(yellowViewController, blueViewController);
			}
		}

		private void SwitchViewController(UIViewController fromVC, UIViewController toVC)
		{
			if (fromVC != null) 
			{
				fromVC.WillMoveToParentViewController (null);
				fromVC.View.RemoveFromSuperview ();
				fromVC.RemoveFromParentViewController ();
			}

			if (toVC != null) 
			{
				this.AddChildViewController (toVC);
				this.View.InsertSubview (toVC.View, atIndex: 0);
				toVC.DidMoveToParentViewController (this);
			}
		}

	}
}

