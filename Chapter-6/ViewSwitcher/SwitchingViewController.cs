
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
			blueViewController.View.Frame = View.Frame; // Set the current frame to the Blue view
			// The SwitchingViewController's Frame gets passed back and forth 
			// between the Blue and Yellow View's frames. The Frame determines where the view get's
			// displayed on the screen.
		}


		partial void SwitchViews (UIBarButtonItem sender)
		{
			// Create the new view controller, only if it doesn't already exist 
			if(yellowViewController == null)
			{
				yellowViewController = Storyboard.InstantiateViewController("Yellow") as YellowViewController;
			}
			else if(blueViewController == null)
			{
				blueViewController = Storyboard.InstantiateViewController("Blue") as BlueViewController;
			}

			UIView.BeginAnimations("View Flip");
			UIView.SetAnimationDuration(0.4);
			UIView.SetAnimationCurve(UIViewAnimationCurve.EaseInOut);

			// Switch frames, then switch view controllers
			if(blueViewController != null && blueViewController.View.Superview != null)
			{
				UIView.SetAnimationTransition(UIViewAnimationTransition.FlipFromRight, forView: View, cache:true);
				yellowViewController.View.Frame = View.Frame;
				SwitchViewController(blueViewController, yellowViewController);
			}
			else
			{
				UIView.SetAnimationTransition(UIViewAnimationTransition.FlipFromLeft, forView: View, cache: true);
				blueViewController.View.Frame = View.Frame;
				SwitchViewController(yellowViewController, blueViewController);
			}
			UIView.CommitAnimations();
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

