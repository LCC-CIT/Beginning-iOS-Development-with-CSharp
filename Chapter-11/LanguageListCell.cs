
using System;

using Foundation;
using UIKit;

namespace Presidents
{
	public class LanguageListCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("LanguageListControllerCell");

		public LanguageListCell () : base (UITableViewCellStyle.Value1, Key)
		{
			// TODO: add subviews to the ContentView, set various colors, etc.
			TextLabel.Text = "TextLabel";
		}
	}
}

