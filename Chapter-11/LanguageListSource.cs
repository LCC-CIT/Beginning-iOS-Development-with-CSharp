
using System;

using Foundation;
using UIKit;

namespace Presidents
{
	public class LanguageListSource : UITableViewSource
	{
		string[] languageNames = {"English", "French", "German", "Spanish"};
		string[] languageCodes = {"en", "fr", "de", "es"};

		readonly LanguageListController controller;

		public string[] LanguageNames {get{ return languageNames; }}
		public string[] LanguageCodes {get{ return languageCodes; }}

		public LanguageListSource (LanguageListController c)
		{
			controller = c;
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

//		public override string TitleForHeader (UITableView tableView, nint section)
//		{
//			return "Header";
//		}
//
//		public override string TitleForFooter (UITableView tableView, nint section)
//		{
//			return "Footer";
//		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (LanguageListCell.Key) as LanguageListCell;
			if (cell == null)
				cell = new LanguageListCell ();

			cell.TextLabel.Text = languageNames[indexPath.Row];
			// cell.DetailTextLabel.Text = "DetailsTextLabel";
			
			return cell;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			controller.DetailViewControllerRef.LanguageString = languageCodes[indexPath.Row];
		}
	}
}

