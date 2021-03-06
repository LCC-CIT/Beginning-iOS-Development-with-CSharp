﻿using Foundation;
using UIKit;

namespace Presidents
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate, IUISplitViewControllerDelegate
	{
		// class-level declarations

		public override UIWindow Window {
			get;
			set;
		}

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{ 
			// Assign the SplitViewController's DisplayModeButtonItem to the left button of the DetailViewController.
			var splitViewController = (UISplitViewController)Window.RootViewController;
			var navigationController = (UINavigationController)splitViewController.ViewControllers [1]; // The Detail ViewController is at index 1
			navigationController.TopViewController.NavigationItem.LeftBarButtonItem = splitViewController.DisplayModeButtonItem;

			// Set the SplitViewController's delegate to this AppDelegate so that the SplitViewController can call CollapseSecondViewController
			splitViewController.WeakDelegate = this;

			return true;
		}

		public override void OnResignActivation (UIApplication application)
		{
			// Invoked when the application is about to move from active to inactive state.
			// This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
			// or when the user quits the application and it begins the transition to the background state.
			// Games should use this method to pause the game.
		}

		public override void DidEnterBackground (UIApplication application)
		{
			// Use this method to release shared resources, save user data, invalidate timers and store the application state.
			// If your application supports background exection this method is called instead of WillTerminate when the user quits.
		}

		public override void WillEnterForeground (UIApplication application)
		{
			// Called as part of the transiton from background to active state.
			// Here you can undo many of the changes made on entering the background.
		}

		public override void OnActivated (UIApplication application)
		{
			// Restart any tasks that were paused (or not yet started) while the application was inactive. 
			// If the application was previously in the background, optionally refresh the user interface.
		}

		public override void WillTerminate (UIApplication application)
		{
			// Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
		}

		[Export ("splitViewController:collapseSecondaryViewController:ontoPrimaryViewController:")]
		public bool CollapseSecondViewController (UISplitViewController splitViewController, UIViewController secondaryViewController, UIViewController primaryViewController)
		{
			if (secondaryViewController.GetType () == typeof(UINavigationController) &&
			    ((UINavigationController)secondaryViewController).TopViewController.GetType () == typeof(DetailViewController) &&
			    ((DetailViewController)((UINavigationController)secondaryViewController).TopViewController).DetailItem == null) {
				// Return YES to indicate that we have handled the collapse by doing nothing; the secondary controller will be discarded.
				return true;
			}
			return false;
		}
	}
}


