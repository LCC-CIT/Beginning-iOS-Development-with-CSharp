using System;

using Foundation;
using UIKit;
using CoreGraphics;

namespace Presidents
{
	public class LanguageListControllerController : UITableViewController
	{
		// iOS has the potential for "retain cycles"
		// Mono's garbage collector might solve this though - don't know
		// WeakReference wRef = new WeakReference();   // We might not need this
		DetailViewController detailViewController;
		LanguageListControllerSource tVSource = new LanguageListControllerSource ();


		public LanguageListControllerController () : base (UITableViewStyle.Grouped)
		{
			// Get a weak reference - again, we might not need this
			//detailViewController = wRef.Target as DetailViewController;
		}


		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			// Register the TableView's data source
			TableView.Source = tVSource;

			ClearsSelectionOnViewWillAppear = false;
			PreferredContentSize = new CGSize((nfloat)320, (nfloat)tVSource.LanguageCodes.Length * 44);
			TableView.RegisterClassForCellReuse (typeof(UITableViewCell), "Cell");

			base.ViewDidLoad ();
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			detailViewController.LanguageString = tVSource.LanguageNames[indexPath.Row];

			base.RowSelected (tableView, indexPath);
		}
	}
}

