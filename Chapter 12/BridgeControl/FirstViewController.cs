using System;
using UIKit;
using Foundation;


namespace BridgeControl
{
	public partial class FirstViewController : UIViewController
	{

		NSObject observer = null;

		public FirstViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			// Update the values shown in view 1 from the StandardUserDefaults
			RefreshFields ();

			// Subscribe to the applicationWillEnterForeground notification
			var app = UIApplication.SharedApplication;
			// NSNotificationCenter.DefaultCenter.AddObserver (this, UIApplication.WillEnterForegroundNotification, "ApplicationWillEnterForeground", app);
			// NSNotificationCenter.DefaultCenter.AddObserver (UIApplication.WillEnterForegroundNotification, ApplicationWillEnterForeground);
			observer = NSNotificationCenter.DefaultCenter.AddObserver (aName: UIApplication.WillEnterForegroundNotification, notify: ApplicationWillEnterForeground, fromObject: app);
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

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			NSNotificationCenter.DefaultCenter.RemoveObserver (observer);
		}

		private void RefreshFields()
		{
			NSUserDefaults defaults = NSUserDefaults.StandardUserDefaults;

			officerLabel.Text = defaults.StringForKey (Constants.OFFICER_KEY);
			authorizationCodeLabel.Text = defaults.StringForKey (Constants.AUTHORIZATION_CODE_KEY);
			favoriteTeaLabel.Text = defaults.StringForKey (Constants.FAVORITE_TEA_KEY);
			rankLabel.Text = defaults.StringForKey (Constants.RANK_KEY);
			warpDriveLabel.Text = defaults.BoolForKey (Constants.WARP_DRIVE_KEY) ? "Engaged" : "Disabled";
			warpFactorLabel.Text = defaults.StringForKey (Constants.WARP_FACTOR_KEY);
			favoriteCaptainLabel.Text = defaults.StringForKey (Constants.FAVORITE_CAPTAIN_KEY);
			favoriteGadgetLabel.Text = defaults.StringForKey (Constants.FAVORITE_GADGET_KEY);
			favoriteAlienLabel.Text = defaults.StringForKey (Constants.FAVORITE_ALIEN_KEY);
		}


		// We will subscribe to the applicationWillEnterForeground notification
		// so that this method is called when that notification occurs
		private void ApplicationWillEnterForeground(NSNotification notification)
		{
			var defaults = NSUserDefaults.StandardUserDefaults;
			defaults.Synchronize();
			RefreshFields();			
		}
	}


}

