using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace ButtonFun
{
	public partial class ButtonFunViewController : UIViewController
	{
		public ButtonFunViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			leftButton.TouchUpInside += ButtonPressed;
			rightButton.TouchUpInside += ButtonPressed;
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}
			
		partial void topButton_TouchUpInside (UIButton sender)
		{
			ButtonPressed(sender, null);
		}

		private void ButtonPressed (object sender, EventArgs args)
		{
			string title = ((UIButton)sender).CurrentTitle;
			statusLabel.Text = title + " button pressed";
		}

		#endregion
	}
}

