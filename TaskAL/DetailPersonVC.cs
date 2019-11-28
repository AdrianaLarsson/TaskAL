using Foundation;
using System;
using UIKit;

namespace TaskAL
{
    public partial class DetailPersonVC : UIViewController

      
    {
        public ViewController viewController;

        public String data;

        public DetailPersonVC()
        {
        }

        public DetailPersonVC (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
           firstNTitle.Text = ViewController.firstN ;

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