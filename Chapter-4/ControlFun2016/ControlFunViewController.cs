using System;

using UIKit;

namespace ControlFun2016
{
	public partial class ControlFunViewController : UIViewController
	{
		protected ControlFunViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}
				public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		// Close the on-screen keyboard by tapping the Done button
		partial void TextFieldDoneEditing(UITextField sender)
		{
			sender.ResignFirstResponder();
		}

		// Close the on-screen keyboard by tapping outside the Text Field
		partial void OnTapGestureRecognized(UITapGestureRecognizer sender)
		{
			nameField.ResignFirstResponder();
			numberField.ResignFirstResponder();
		}

		partial void numberSlider_ValueChanged(UISlider sender)
		{
			int progress = (int)sender.Value;
			sliderLabel.Text = progress.ToString();
		}

		partial void Switch_ValueChanged(UISwitch sender)
		{
			var setting = sender.On;
			leftSwitch.SetState(setting, true);
			rightSwitch.SetState(setting, true);
		}

		partial void doSomethingButton_TouchUpInside(UIButton sender)
		{
			var controller = UIAlertController.Create("Are You Sure?", null, UIAlertControllerStyle.ActionSheet);

			var yesAction = UIAlertAction.Create("Yes, I'm sure!", UIAlertActionStyle.Destructive,
				(action) =>
				{
					string msg = this.nameField.Text == ""
					  ? "You can breath easy, everything went OK."
					  : "You can breath easy " + this.nameField.Text + " everything went OK.";

					// Controller within a controller
					var cancelAction = UIAlertAction.Create("Phew!", UIAlertActionStyle.Cancel, null);

					var controller2 = UIAlertController.Create("Something Was Done", msg, UIAlertControllerStyle.Alert);
					controller2.AddAction(cancelAction);
					this.PresentViewController(controller2, true, null);
				});

			var noAction = UIAlertAction.Create("No way!", UIAlertActionStyle.Cancel, null);
			controller.AddAction(noAction);
			controller.AddAction(yesAction);

			var ppc = controller.PopoverPresentationController;
			if (ppc != null)
			{
				ppc.SourceView = sender;
				ppc.SourceRect = sender.Bounds;
			}

			PresentViewController(controller, true, null);
		}

		partial void choiceSegmentedControl_ValueChanged(UISegmentedControl sender)
		{
			if (sender.SelectedSegment == 0)    // Switches selected
			{
				leftSwitch.Hidden = false;
				rightSwitch.Hidden = false;
				doSomethingButton.Hidden = true;
			}
			else
			{
				leftSwitch.Hidden = true;           // Button selected
				rightSwitch.Hidden = true;
				doSomethingButton.Hidden = false;
			}

		}

	}
}

