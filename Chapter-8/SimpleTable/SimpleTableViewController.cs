using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SimpleTable
{

	public partial class SimpleTableViewController : UITableViewController  //, IUITableViewDelegate, IUITableViewDataSource
	{

		private string[] dwarves = {
			"Sleepy", "Sneezy", "Bashful", "Happy",
			"Doc", "Grumpy", "Dopey",
			"Thorin", "Dorin", "Nori", "Ori",
			"Balin", "Dwalin", "Fili", "Kili",
			"Oin", "Gloin", "Bifur", "Bofur",
			"Bombur"
		};

		// private string simpleTableIdentifier = "SimpleTableIdentifier";

		public SimpleTableViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			TableView.DataSource = new SimpleTableViewDataSource (dwarves);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
			
	}


	/********************* TableViewDataSource class *********************************/
	// Note: not a nested class, just in the same file and namespace 

	public class SimpleTableViewDataSource : UITableViewDataSource 
	{
		// there is NO database or storage of Tasks in this example, just an in-memory array
		string[] tableItems;
		string cellIdentifier = "dwarfcell"; // set in the Storyboard

		public SimpleTableViewDataSource (string[] items)
		{
			tableItems = items;
		}

		public override nint RowsInSection (UITableView tableView, nint section)
		{
			return tableItems.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			// in a Storyboard, Dequeue will ALWAYS return a cell,
			var cell = tableView.DequeueReusableCell (cellIdentifier);
			// now set the text 
			cell.TextLabel.Text = tableItems[indexPath.Row];

			// Add images to the cell
			cell.ImageView.Image = UIImage.FromFile("Images/star");
			cell.ImageView.HighlightedImage = UIImage.FromFile ("Images/star2");

			// Cell style should be set to "Subtitle" or "RightDetial" in the storyboard
			// Add detail information
			const int NUM_DISNEY_DWARVES = 7;
			if (cell.DetailTextLabel != null) {
				if (indexPath.Row < NUM_DISNEY_DWARVES) {
					cell.DetailTextLabel.Text = "Mr Disney";
				} else {
					cell.DetailTextLabel.Text = "Mr Tolkien";
				}
			}

			return cell;
		}

		public string GetItem(int id) {
			return tableItems[id];
		}
	}

}
