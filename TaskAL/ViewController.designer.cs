// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TaskAL
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Age { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CreateDatabse { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField FirstName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField LastName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDBName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton RetriveBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SaveBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Sum { get; set; }

        [Action ("CreateDatabse_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CreateDatabse_TouchUpInside (UIKit.UIButton sender);

        [Action ("RetriveBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void RetriveBtn_TouchUpInside (UIKit.UIButton sender);

        [Action ("SaveBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SaveBtn_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Age != null) {
                Age.Dispose ();
                Age = null;
            }

            if (CreateDatabse != null) {
                CreateDatabse.Dispose ();
                CreateDatabse = null;
            }

            if (FirstName != null) {
                FirstName.Dispose ();
                FirstName = null;
            }

            if (LastName != null) {
                LastName.Dispose ();
                LastName = null;
            }

            if (lblDBName != null) {
                lblDBName.Dispose ();
                lblDBName = null;
            }

            if (RetriveBtn != null) {
                RetriveBtn.Dispose ();
                RetriveBtn = null;
            }

            if (SaveBtn != null) {
                SaveBtn.Dispose ();
                SaveBtn = null;
            }

            if (Sum != null) {
                Sum.Dispose ();
                Sum = null;
            }
        }
    }
}