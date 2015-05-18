using System;
using System.Collections.Generic;

using UIKit;
using Foundation;

namespace Presidents
{
	public partial class DetailViewController : UIViewController
	{
		public object DetailItem { get; set; }

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

				// Display the Wkikpedia URL for the selected president
				detailDescriptionLabel.Text = presDict["url"];

				// Display the Wikipedia article
				var url = new NSUrl (presDict["url"]);
				var request = new NSUrlRequest (url);
				detailWebView.LoadRequest (request);
			}

		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			ConfigureView ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


