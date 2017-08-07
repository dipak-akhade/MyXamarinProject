using System;
using ZXing.Mobile;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Net;
using System.Threading;

namespace nWorksLeaveApp.Droid
{
	[Activity (Label="LeaveApp",  ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
//	[Activity(Label = "MyApp.Droid", Icon = "@drawable/icon", MainLauncher = true, Theme = "@style/MyTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			ActionBar.SetIcon (null);

			LoadApplication (new App ());

			MobileBarcodeScanner.Initialize (Application);

		}
	}
}

