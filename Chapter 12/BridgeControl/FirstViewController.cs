using System;

using UIKit;
using Foundation;


namespace BridgeControl
{
	public partial class FirstViewController : UIViewController
	{
		public FirstViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			RefreshFields();
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

		private void RefreshFields()
		{
			var defaults = NSUserDefaults.StandardUserDefaults;

			officerLabel.Text = defaults.StringForKey (Constants.OFFICER_KEY);
			authorizationCodeLabel.Text = defaults.StringForKey (Constants.AUTHORIZATION_CODE_KEY);
			favoriteTeaLabel.Text = defaults.StringForKey (Constants.FAVORITE_TEA_KEY);
			rankLabel.Text = defaults.StringForKey (Constants.RANK_KEY);
			warpDriveLabel.Text = defaults.StringForKey (Constants.WARP_DRIVE_KEY);
			warpFactorLabel.Text = defaults.StringForKey (Constants.WARP_FACTOR_KEY);
			favoriteCaptainLabel.Text = defaults.StringForKey (Constants.FAVORITE_CAPTAIN_KEY);
			favoriteGadgetLabel.Text = defaults.StringForKey (Constants.FAVORITE_GADGET_KEY);
			favoriteAlienLabel.Text = defaults.StringForKey (Constants.FAVORITE_ALIEN_KEY);
		}
	}


}

