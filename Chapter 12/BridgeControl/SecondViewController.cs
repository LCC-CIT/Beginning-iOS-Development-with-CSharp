using System;

using UIKit;
using Foundation;

namespace BridgeControl
{
	public partial class SecondViewController : UIViewController
	{
		public SecondViewController (IntPtr handle) : base (handle)
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

		partial void warpFactorSlider_ValueChanged (UISlider sender)
		{
			var defaults = NSUserDefaults.StandardUserDefaults;
			defaults.SetFloat(warpFactorSlider.Value, Constants.WARP_FACTOR_KEY);
			defaults.Synchronize();		
		}

		partial void settingsButton_TouchUpInside (UIButton sender)
		{
			UIApplication.SharedApplication.OpenUrl(new NSUrl(UIApplication.OpenSettingsUrlString));
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			RefreshFields ();
		}
		
		partial void engineSwitch_ValueChanged (UISwitch sender)
		{
			var defaults = NSUserDefaults.StandardUserDefaults;
			defaults.SetBool (engineSwitch.On, Constants.WARP_DRIVE_KEY);
			defaults.Synchronize();
		}

		private void RefreshFields()
		{
			var defaults = NSUserDefaults.StandardUserDefaults;
			engineSwitch.On = defaults.BoolForKey (Constants.WARP_DRIVE_KEY);
			warpFactorSlider.Value = defaults.FloatForKey (Constants.WARP_FACTOR_KEY);
			defaults.Synchronize();
		}

		partial void resetButton_TouchUpInside (UIButton sender)
		{
			var defaults = NSUserDefaults.StandardUserDefaults;
			defaults.SetNilValueForKey((NSString)Constants.WARP_DRIVE_KEY);
			defaults.SetNilValueForKey((NSString)Constants.WARP_FACTOR_KEY);
			defaults.SetNilValueForKey((NSString)Constants.FAVORITE_ALIEN_KEY);
			defaults.
		}
	}
}

