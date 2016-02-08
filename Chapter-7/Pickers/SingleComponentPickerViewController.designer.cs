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
		UIButton selectButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIPickerView singlePicker { get; set; }

		[Action ("SelectButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void SelectButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (selectButton != null) {
				selectButton.Dispose ();
				selectButton = null;
			}
			if (singlePicker != null) {
				singlePicker.Dispose ();
				singlePicker = null;
			}
		}
	}
}
