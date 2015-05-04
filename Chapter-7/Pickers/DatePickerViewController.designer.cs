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
	[Register ("DatePickerViewController")]
	partial class DatePickerViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIDatePicker DatePicker { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton selectButton { get; set; }

		[Action ("selectButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void selectButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (DatePicker != null) {
				DatePicker.Dispose ();
				DatePicker = null;
			}
			if (selectButton != null) {
				selectButton.Dispose ();
				selectButton = null;
			}
		}
	}
}
