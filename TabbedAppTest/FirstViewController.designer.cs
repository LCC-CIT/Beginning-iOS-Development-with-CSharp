// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TabbedAppTest
{
	[Register ("FirstViewController")]
	partial class FirstViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel messageLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (messageLabel != null) {
				messageLabel.Dispose ();
				messageLabel = null;
			}
		}
	}
}
