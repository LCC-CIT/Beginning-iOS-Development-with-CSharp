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

namespace ButtonFun
{
	[Register ("ButtonFunViewController")]
	partial class ButtonFunViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton bottomButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton leftButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton rightButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel statusLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton topButton { get; set; }

		[Action ("topButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void topButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (bottomButton != null) {
				bottomButton.Dispose ();
				bottomButton = null;
			}
			if (leftButton != null) {
				leftButton.Dispose ();
				leftButton = null;
			}
			if (rightButton != null) {
				rightButton.Dispose ();
				rightButton = null;
			}
			if (statusLabel != null) {
				statusLabel.Dispose ();
				statusLabel = null;
			}
			if (topButton != null) {
				topButton.Dispose ();
				topButton = null;
			}
		}
	}
}
