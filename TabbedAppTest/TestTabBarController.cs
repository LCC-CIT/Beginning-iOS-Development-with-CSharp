using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TabbedAppTest
{
	partial class TestTabBarController : UITabBarController
	{

		public AppDelegate ThisApp {
			get { return (AppDelegate)UIApplication.SharedApplication.Delegate; }
		}

		public TestTabBarController (IntPtr handle) : base (handle)
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			ViewControllerSelected += (object sender, UITabBarSelectionEventArgs e) => 
			{
				var destination = e.ViewController;

				if (destination != null)
				{
					if(TabBar.SelectedItem.Title == "First")
					{
						ThisApp.Message = "First view selected";
						((FirstViewController)destination).ReadMessage();
					}
					else if(TabBar.SelectedItem.Title == "Second") 
					{
						((SecondViewController)destination).SetMessage("TabBarController says: 'Hello second view!'");
					}
				}
			};
		}
			
	}
}
