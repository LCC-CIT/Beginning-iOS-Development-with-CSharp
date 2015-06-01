// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BridgeControl
{
	[Register ("SecondViewController")]
	partial class SecondViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch engineSwitch { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton resetButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton settingsButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISlider warpFactorSlider { get; set; }

		[Action ("engineSwitch_ValueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void engineSwitch_ValueChanged (UISwitch sender);

		[Action ("resetButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void resetButton_TouchUpInside (UIButton sender);

		[Action ("settingsButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void settingsButton_TouchUpInside (UIButton sender);

		[Action ("warpFactorSlider_ValueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void warpFactorSlider_ValueChanged (UISlider sender);

		void ReleaseDesignerOutlets ()
		{
			if (engineSwitch != null) {
				engineSwitch.Dispose ();
				engineSwitch = null;
			}
			if (resetButton != null) {
				resetButton.Dispose ();
				resetButton = null;
			}
			if (settingsButton != null) {
				settingsButton.Dispose ();
				settingsButton = null;
			}
			if (warpFactorSlider != null) {
				warpFactorSlider.Dispose ();
				warpFactorSlider = null;
			}
		}
	}
}
