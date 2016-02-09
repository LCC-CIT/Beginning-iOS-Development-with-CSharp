
using System;

using Foundation;
using UIKit;

namespace Pickers
{
	public partial class SingleComponentPickerViewController : UIViewController, IUIPickerViewDataSource
	{

		private static string[] characterNames	= {"Luke", "Leia", "Han", "Chewbecca", "Artoo", "Threepio", "Lando"};

		public SingleComponentPickerViewController (IntPtr handle) : base (handle)
		{
		}

		/*
		public SingleComponentPickerViewController() :base("SingleComponentPickerViewController", null)
		{
		}
		*/

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
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

		// Picker delegate methods - implementing IUIPickerViewDelegate
		// https://developer.xamarin.com/api/type/MonoTouch.UIKit.IUIPickerViewDelegate/
		// All the protocols in the original UIPickerViewDelegate are optional - so there isn't anything to implement
		// Instead, we'll create an instance of UIPickerViewDelegate and assign it to the picker's Delegate property
		class SinglePickerViewDelegate : UIPickerViewDelegate
		{
			public SinglePickerViewDelegate() {
				// Just so I can put a breakpoint here
			}

			public override string GetTitle (UIPickerView pickerView, nint row, nint component)
			{
				return  SingleComponentPickerViewController.characterNames[row];
			}
		}	
	}
}
