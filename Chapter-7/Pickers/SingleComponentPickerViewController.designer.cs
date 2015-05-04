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

namespace Pickers
{
	[Register ("SingleComponentPickerViewController")]
	partial class SingleComponentPickerViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton testButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel testLabel { get; set; }

		[Action ("testButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void testButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (testButton != null) {
				testButton.Dispose ();
				testButton = null;
			}
			if (testLabel != null) {
				testLabel.Dispose ();
				testLabel = null;
			}
		}
	}
}
