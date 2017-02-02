﻿using ThatCSharpGuy.UI.Views;
using Xamarin.Forms;

namespace ThatCSharpGuy.UI
{
    public class App : Application
    {
        public App()
        {
			MainPage = new VideoDetailPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
