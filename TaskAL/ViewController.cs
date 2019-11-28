using Foundation;
using System;
using UIKit;

namespace TaskAL
{
    public partial class ViewController : UIViewController 
    {

        public static string firstN;
        public static string lastN;
        public static string age;


        public ViewController(IntPtr handle) : base(handle)
        {


    }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void SaveBtn_TouchUpInside(UIButton sender)
        {
            firstN = FirstName.Text;
            lastN = LastName.Text;
            age = Age.Text;
          

            Sum.Text = "Förnamn: " + firstN + " Efternamn: " + lastN + " Ålder: "  + age ;

            PersonManager.personData.Add(Sum.Text);
        }
    }
}