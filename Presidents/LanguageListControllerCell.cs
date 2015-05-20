
using System;

using Foundation;
using UIKit;

namespace Presidents
{
	public class LanguageListControllerCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("LanguageListControllerCell");

		public LanguageListControllerCell () : base (UITableViewCellStyle.Value1, Key)
		{
			// TODO: add subviews to the ContentView, set various colors, etc.
			TextLabel.Text = "TextLabel";
		}
	}
}

