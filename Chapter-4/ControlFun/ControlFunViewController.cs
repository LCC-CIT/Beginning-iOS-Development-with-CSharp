using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace ControlFun
{
	public partial class ControlFunViewController : UIViewController
	{
		public ControlFunViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			nameField.EditingDidEndOnExit += (sender, e) => {
				((UITextField)sender).ResignFirstResponder();
			};

			((UIControl)View).TouchDown += (sender, e) => {
				nameField.ResignFirstResponder();
				numberField.ResignFirstResponder();
			};

		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}


		partial void sliderLabel_ValueChanged (UISlider sender)
		{
			int progress = (int)sender.Value;
			sliderLabel.Text = progress.ToString();
		}

		partial void Switch_ValueChanged (UISwitch sender)
		{
			var setting = sender.On;
			leftSwitch.SetState(setting, true);
			rightSwitch.SetState(setting, true);
		}

		partial void doSomethingButton_TouchUpInside (UIButton sender)
		{
			var controller = UIAlertController.Create("Are You Sure?", null, UIAlertControllerStyle.ActionSheet);

			var yesAction = UIAlertAction.Create("Yes, I'm sure!", UIAlertActionStyle.Destructive, 
				(action) => 
				{ string msg = this.nameField.Text == ""
					? "You can breath easy, everything went OK."
					: "You can breath easy " + this.nameField.Text + " everything went OK.";
			
				var cancelAction = UIAlertAction.Create("Phew!", UIAlertActionStyle.Cancel, null);

				var controller2 = UIAlertController.Create("Something Was Done", msg, UIAlertControllerStyle.Alert);
				controller2.AddAction(cancelAction);
				this.PresentViewController(controller2, true, null);
				});
			
			var noAction = UIAlertAction.Create("No way!", UIAlertActionStyle.Cancel, null);
			controller.AddAction(noAction);
			controller.AddAction(yesAction);

			var ppc = controller.PopoverPresentationController;
			if(ppc != null)
			{
				ppc.SourceView = sender;
				ppc.SourceRect = sender.Bounds;
			} 

			PresentViewController(controller, true, null);
		}

		partial void choiceSegmentedControl_ValueChanged (UISegmentedControl sender)
		{
			if (sender.SelectedSegment == 0)	// Switches selected
			{
				leftSwitch.Hidden = false;
				rightSwitch.Hidden = false;
				doSomethingButton.Hidden = true;
			}
			else
			{
				leftSwitch.Hidden = true;			// Button selected
				rightSwitch.Hidden = true;
				doSomethingButton.Hidden = false;
			}

		}

		#endregion
	}
}

