﻿using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

namespace DevDaysTasks.Droid
{
	[Activity (Label = "Tasks", 
		Icon = "@drawable/icon", 
		MainLauncher = true, 
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsAppCompatActivity
    {
		protected override void OnCreate (Bundle bundle)
		{
            FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;

            base.OnCreate (bundle);

			Forms.Init (this, bundle);
			Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
            
			LoadApplication (new App ());
		}
	}
}

