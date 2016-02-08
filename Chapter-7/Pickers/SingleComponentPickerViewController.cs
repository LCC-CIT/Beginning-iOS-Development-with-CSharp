
using System;

using Foundation;
using UIKit;

namespace Pickers
{
	public partial class SingleComponentPickerViewController : UIViewController, IUIPickerViewDelegate, IUIPickerViewDataSource
	{

		private string[] characterNames	= {"Luke", "Leia", "Han", "Chewbecca", "Artoo", "Threepio", "Lando"};

		public SingleComponentPickerViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
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


		// Picker Data Source Methods

		 public  int GetComponentCount(UIPickerView pickerView)  {
			return 1;
		}

		public  int GetRowsInComponent(UIPickerView pickerView, System.nint component) {
			return characterNames.GetLength(0);
		}

		// Picker delegate methods
		/*
		 * func pickerView(pickerView: UIPickerView,
titleForRow row: Int,
forComponent component: Int) -> String! {
return characterNames[row]
} */
		
		public string titleForRow(int row) {
			return characterNames[row];
		}
	}
}

