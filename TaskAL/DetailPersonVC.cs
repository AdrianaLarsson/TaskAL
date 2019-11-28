using Foundation;
using System;
using UIKit;

namespace TaskAL
{
    public partial class DetailPersonVC : UIViewController

      
    {
        public ViewController viewController;

      
        public string firstNP = ViewController.firstN;
        public string lastNP = ViewController.lastN;
        public string ageP = ViewController.age;
        public string selectedR = TableViewSource.SelectedRow;



        public DetailPersonVC()
        {
        }

        public DetailPersonVC (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
           
            base.ViewDidLoad();
            firstNTitle.Text = selectedR + firstNP + " " + " Efternamn: " + lastNP + " Ålder: " + ageP; 
                //+ "Förnamn: " + firstNP + " Efternamn: " + lastNP + " Ålder: " + ageP;

          
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void BackBtn_TouchUpInside(UIButton sender)
        {

            this.DismissViewController(true, null);
        }

    }
}