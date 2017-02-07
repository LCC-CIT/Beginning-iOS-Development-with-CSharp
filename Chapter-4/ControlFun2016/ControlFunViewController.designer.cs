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

namespace ControlFun
{
	[Register ("ControlFunViewController")]
	partial class ControlFunViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl choiceSegmentedControl { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton doSomethingButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch leftSwitch { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField nameField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField numberField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISlider numberSlider { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch rightSwitch { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel sliderLabel { get; set; }

		[Action ("choiceSegmentedControl_ValueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void choiceSegmentedControl_ValueChanged (UISegmentedControl sender);

		[Action ("doSomethingButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void doSomethingButton_TouchUpInside (UIButton sender);

		[Action ("sliderLabel_ValueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void sliderLabel_ValueChanged (UISlider sender);

		[Action ("Switch_ValueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void Switch_ValueChanged (UISwitch sender);

		void ReleaseDesignerOutlets ()
		{
			if (choiceSegmentedControl != null) {
				choiceSegmentedControl.Dispose ();
				choiceSegmentedControl = null;
			}
			if (doSomethingButton != null) {
				doSomethingButton.Dispose ();
				doSomethingButton = null;
			}
			if (leftSwitch != null) {
				leftSwitch.Dispose ();
				leftSwitch = null;
			}
			if (nameField != null) {
				nameField.Dispose ();
				nameField = null;
			}
			if (numberField != null) {
				numberField.Dispose ();
				numberField = null;
			}
			if (numberSlider != null) {
				numberSlider.Dispose ();
				numberSlider = null;
			}
			if (rightSwitch != null) {
				rightSwitch.Dispose ();
				rightSwitch = null;
			}
			if (sliderLabel != null) {
				sliderLabel.Dispose ();
				sliderLabel = null;
			}
		}
	}
}
