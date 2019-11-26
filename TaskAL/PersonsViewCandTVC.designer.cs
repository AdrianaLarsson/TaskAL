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
    [Register ("PersonsViewCandTVC")]
    partial class PersonsViewCandTVC
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView mainListview { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (mainListview != null) {
                mainListview.Dispose ();
                mainListview = null;
            }
        }
    }
}