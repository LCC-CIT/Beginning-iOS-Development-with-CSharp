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

namespace ControlFun2016
{
    [Register ("ControlFunViewController")]
    partial class ControlFunViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl choiceSegmentedControl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton doSomethingButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch leftSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField nameField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField numberField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider numberSlider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch rightSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel sliderLabel { get; set; }

        [Action ("choiceSegmentedControl_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void choiceSegmentedControl_ValueChanged (UIKit.UISegmentedControl sender);

        [Action ("doSomethingButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void doSomethingButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("OnTapGestureRecognized:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnTapGestureRecognized (UIKit.UITapGestureRecognizer sender);

        [Action ("sliderLabel_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void sliderLabel_ValueChanged (UIKit.UISlider sender);

        [Action ("Switch_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Switch_ValueChanged (UIKit.UISwitch sender);

        [Action ("TextFieldDoneEditing:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TextFieldDoneEditing (UIKit.UITextField sender);

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