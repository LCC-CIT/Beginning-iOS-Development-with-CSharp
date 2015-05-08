using System;

using UIKit;

namespace SimpleTable
{
	public partial class ViewController : UIViewController, IUITableViewDataSource, IUITableViewDelegate
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
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

