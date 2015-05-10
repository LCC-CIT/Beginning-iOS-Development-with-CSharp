using System;
using UIKit;

namespace SimpleTable
{
	public partial class ViewController : UITableView
	{

		private string[] dwarves = {
			"Sleepy", "Sneezy", "Bashful", "Happy",
			"Doc", "Grumpy", "Dopey",
			"Thorin", "Dorin", "Nori", "Ori",
			"Balin", "Dwalin", "Fili", "Kili",
			"Oin", "Gloin", "Bifur", "Bofur",
			"Bombur"
		};

		private string simpleTableIdentifier = "SimpleTableIdentifier";

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			source  Source = new RootTableSource(chores.ToArray ());

		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			Source = new SimpleTableViewDataSource (dwarves);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}

	public class SimpleTableViewDataSource : UITableViewSource 
	{
		// there is NO database or storage of Tasks in this example, just an in-memory array
		string[] tableItems;
		string cellIdentifier = "taskcell"; // set in the Storyboard

		public SimpleTableViewDataSource (string[] items)
		{
			tableItems = items;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			// in a Storyboard, Dequeue will ALWAYS return a cell,
			var cell = tableView.DequeueReusableCell (cellIdentifier);
			// now set the properties as normal
			cell.TextLabel.Text = tableItems[indexPath.Row].Name;
			if (tableItems[indexPath.Row].Done)
				cell.Accessory = UITableViewCellAccessory.Checkmark;
			else
				cell.Accessory = UITableViewCellAccessory.None;
			return cell;
		}

	

		public string GetItem(int id) {
			return tableItems[id];
		}
	}

}

