using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace TaskAL
{
    public partial class PersonsViewCandTVC : UIViewController
    {
       
        
        public PersonsViewCandTVC (IntPtr handle) : base (handle)
        {

           
        }

       

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Console.WriteLine("view did load");
            List<string> itemData = new List<string>()
         {
        ViewController.age,
        ViewController.firstN,
        ViewController.lastN,
        
        };
            mainListview.Source = new TableViewSource(itemData);
            mainListview.ReloadData();
            
            //Sum2.Text = ViewController.age;
        }


        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            mainListview.ReloadData();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            mainListview.ReloadData();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}