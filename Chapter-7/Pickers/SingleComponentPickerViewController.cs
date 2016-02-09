using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Pickers
{
	partial class SingleComponentPickerViewController : UIViewController, IUIPickerViewDataSource
	{
		private static string[] characterNames	= {"Luke", "Leia", "Han", "Chewbecca", "Artoo", "Threepio", "Lando"};

		public SingleComponentPickerViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			singlePicker.DataSource = this;
			singlePicker.Delegate = new SinglePickerViewDelegate();
			base.ViewDidLoad ();
		}

		partial void SelectButton_TouchUpInside (UIButton sender)
		{
			var row = singlePicker.SelectedRowInComponent(0);
			var selected = characterNames[row];
			var title = string.Format("You selected {0}", selected);

			var alert = UIAlertController.Create(title, "Thank you for choosing", UIAlertControllerStyle.Alert);
			var action = UIAlertAction.Create("You're welcome", UIAlertActionStyle.Default, null);
			alert.AddAction(action);
			PresentViewController(alert, true, null);

		}

		// Picker Data Source Methods - implementing IUIPickerViewDataSource

		public  nint GetComponentCount(UIPickerView pickerView)  {
			return 1;
		}

		public  nint GetRowsInComponent(UIPickerView pickerView, nint component) {
			return characterNames.GetLength(0);
		}

		// Picker Delegate class (nested class)
		class SinglePickerViewDelegate : UIPickerViewDelegate
		{
			public override string GetTitle (UIPickerView pickerView, nint row, nint component)
			{
				return  SingleComponentPickerViewController.characterNames[row];
			}
		}	
	}
}
