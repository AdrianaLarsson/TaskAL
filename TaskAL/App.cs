using System;
using UIKit;
using SQLite;
using System.IO;
using Xamarin.Forms;

namespace TaskAL
{
    public partial class App : Application
    {
        static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                }
                return database;
            }
        }

        //    public App()
        //    {
        //        InitializeComponent();

        //        ViewController = new ViewController();
        //    }

        //    protected override void OnStart()
        //    {
        //        // Handle when your app starts
        //    }

        //    protected override void OnSleep()
        //    {
        //        // Handle when your app sleeps
        //    }

        //    protected override void OnResume()
        //    {
        //        // Handle when your app resumes
        //    }
        //}
    }
}
