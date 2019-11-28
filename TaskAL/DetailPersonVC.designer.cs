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
    [Register ("DetailPersonVC")]
    partial class DetailPersonVC
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton backBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView detail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel firstNTitle { get; set; }

        [Action ("BackBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BackBtn_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (backBtn != null) {
                backBtn.Dispose ();
                backBtn = null;
            }

            if (detail != null) {
                detail.Dispose ();
                detail = null;
            }

            if (firstNTitle != null) {
                firstNTitle.Dispose ();
                firstNTitle = null;
            }
        }
    }
}