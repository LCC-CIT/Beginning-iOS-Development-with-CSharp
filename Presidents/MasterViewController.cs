using System;
using System.Collections.Generic;

using UIKit;
using Foundation;
using CoreGraphics;

namespace Presidents
{
	public partial class MasterViewController : UITableViewController
	{
		DataSource dataSource;

		public DetailViewController DetailViewController { get; set; }

		public MasterViewController (IntPtr handle) : base (handle)
		{
			Title = NSBundle.MainBundle.LocalizedString ("Master", "Master");

			if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad) {
				PreferredContentSize = new CGSize (320f, 600f);
				ClearsSelectionOnViewWillAppear = false;
			}
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.
			NavigationItem.LeftBarButtonItem = EditButtonItem;

//			var addButton = new UIBarButtonItem (UIBarButtonSystemItem.Add, AddNewItem);
//			addButton.AccessibilityLabel = "addButton";
//			NavigationItem.RightBarButtonItem = addButton;

			DetailViewController = (DetailViewController)((UINavigationController)SplitViewController.ViewControllers [1]).TopViewController;

			TableView.Source = dataSource = new DataSource (this);

			// Load the presidents!
			string path = NSBundle.MainBundle.PathForResource ("PresidentList", "plist");
			var presidentInfo = new NSDictionary (path);  // parses the plist
			var presDictArray = (NSArray)presidentInfo["presidents"]; // returns an array of NSDictionary objects

			// We need to convert the array of NSDictionary objects to
			// a C# List<Dictionary>
			// We are going to fill the List in the datasource with Dictionary objects
			// containing names and wikipedia urls for the presidents

			NSDictionary p;
			for (nuint i = 0; i < presDictArray.Count; i++) 
			{
				p = presDictArray.GetItem<NSDictionary>(i);
				var presDict = new Dictionary<string,string> ();
				presDict ["name"] = p ["name"].ToString();
				presDict ["url"] = p ["url"].ToString();
				dataSource.Presidents.Add (presDict);
			}
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "showDetail") {

				var indexPath = TableView.IndexPathForSelectedRow;
				var item = dataSource.Presidents [indexPath.Row];
				var controller = (DetailViewController)((UINavigationController)segue.DestinationViewController).TopViewController;
				controller.SetDetailItem (item);
				controller.NavigationItem.LeftBarButtonItem = SplitViewController.DisplayModeButtonItem;
				controller.NavigationItem.LeftItemsSupplementBackButton = true;
			}
		}

		//
		// **********************  Data Source ************************
		//

		class DataSource : UITableViewSource
		{
			static readonly NSString CellIdentifier = new NSString ("Cell");
			//readonly List<object> objects = new List<object> ();
			List<Dictionary<string, string>> presidents = new List<Dictionary<string, string>>();
			readonly MasterViewController controller;

			public DataSource (MasterViewController controller)
			{
				this.controller = controller;
			}

			public IList<Dictionary<string, string>> Presidents {
				get { return presidents; }
			}

			// Customize the number of sections in the table view.
			public override nint NumberOfSections (UITableView tableView)
			{
				return 1;
			}

			public override nint RowsInSection (UITableView tableview, nint section)
			{
				return presidents.Count;
			}

			// Customize the appearance of table view cells.
			public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
			{
				var cell = tableView.DequeueReusableCell (CellIdentifier, indexPath);

				cell.TextLabel.Text = presidents [indexPath.Row]["name"];

				return cell;
			}

			public override bool CanEditRow (UITableView tableView, NSIndexPath indexPath)
			{
				// Return false if you do not want the specified item to be editable.
				return false;
			}

			public override void CommitEditingStyle (UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
			{
				/*
				if (editingStyle == UITableViewCellEditingStyle.Delete) {
					// Delete the row from the data source.
					presidents.RemoveAt (indexPath.Row);
					controller.TableView.DeleteRows (new [] { indexPath }, UITableViewRowAnimation.Fade);
				} else if (editingStyle == UITableViewCellEditingStyle.Insert) {
					// Create a new instance of the appropriate class, insert it into the array, and add a new row to the table view.
				}
				*/
			}

			public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
			{
				if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad)
					controller.DetailViewController.SetDetailItem (presidents [indexPath.Row]);
			}
		}
	}
}


