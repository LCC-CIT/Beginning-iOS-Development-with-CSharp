
using System;

using Foundation;
using UIKit;

namespace Presidents
{
	public class LanguageListControllerSource : UITableViewSource
	{
		string[] languageNames = {"English", "French", "German", "Spanish"};
		string[] languageCodes = {"en", "fr", "de", "es"};

		public string[] LanguageNames {get{ return languageNames; }}
		public string[] LanguageCodes {get{ return languageCodes; }}

		public LanguageListControllerSource ()
		{
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			// We only have one section
			return 1;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return languageCodes.Length;
		}

		public override string TitleForHeader (UITableView tableView, nint section)
		{
			return "Header";
		}

		public override string TitleForFooter (UITableView tableView, nint section)
		{
			return "Footer";
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (LanguageListControllerCell.Key) as LanguageListControllerCell;
			if (cell == null)
				cell = new LanguageListControllerCell ();

			cell.TextLabel.Text = languageNames[indexPath.Row];
			cell.DetailTextLabel.Text = "DetailsTextLabel";
			
			return cell;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			//DetailViewControllerRef.LanguageString = tVSource.LanguageNames[indexPath.Row];

			base.RowSelected (tableView, indexPath);
		}
	}
}

