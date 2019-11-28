using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace TaskAL
{
    public partial class PersonsViewCandTVC : UIViewController
    {

        public String data;
        
        public PersonsViewCandTVC (IntPtr handle) : base (handle)
        {

           
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        
            Console.WriteLine("view did load");
            List<string> itemData = new List<string>();

      
            mainListview.Source = new TableViewSource(itemData, this);

            //mainListview.ReloadData();

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
            // mainListview.ReloadData();
            // Release any cached data, images, etc that aren't in use.
        }


    
        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            var transferdata = segue.DestinationViewController as DetailPersonVC;
            if (transferdata != null)
            {
                transferdata.data = this.data;
            }
        }
    }
}