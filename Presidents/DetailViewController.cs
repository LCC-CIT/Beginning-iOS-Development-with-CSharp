using System;
using System.Collections.Generic;

using UIKit;
using Foundation;

namespace Presidents
{
	public partial class DetailViewController : UIViewController
	{
		UIBarButtonItem languageButton = null;
		UIPopoverController languagePopoverController = null;
		string languageString = "";

		public object DetailItem { get; set; }    // TODO: change the type from object to what it's supposed to be

		public string LanguageString 
		{ 
			get{ return languageString; }
			set
			{ 
				ConfigureView ();
				if (languagePopoverController != null) 
				{
					languagePopoverController.Dismiss (true);
					languagePopoverController = null;
				}
				languageString = value; 
			}
		}

		public DetailViewController (IntPtr handle) : base (handle)
		{
		}

		public void SetDetailItem (object newDetailItem)
		{
			if (DetailItem != newDetailItem) {
				DetailItem = newDetailItem;
				
				// Update the view
				ConfigureView ();
			}
		}
			

		void ConfigureView ()
		{
			// Update the user interface for the detail item
			if (IsViewLoaded && DetailItem != null) {
				var presDict = DetailItem as Dictionary<string, string>;

				// Display the president's name
				Title = presDict ["name"]; 

				// Modify the URL for the selected language
				var urlString = ModifyUrlForlanguage(presDict["url"], LanguageString);

				// Display the Wkikpedia URL for the selected president
				detailDescriptionLabel.Text = urlString;

				// Display the Wikipedia article
				var url = new NSUrl(urlString);
				var request = new NSUrlRequest (url);
				detailWebView.LoadRequest (request);
			}

		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			if(UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad)
			{
				languageButton = new UIBarButtonItem ("Choose Language", UIBarButtonItemStyle.Plain, this, ToggleLanguagePopover);
				NavigationItem.RightBarButtonItem = languageButton;
			}

			ConfigureView ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		private EventHandler ToggleLanguagPopover( object sender, EventArgs e)
		{
		}

		private string ModifyUrlForlanguage(string url, string languageCode)
		{
			return url.Remove(7, 2).Insert(7, languageCode);
		}
	}
}


