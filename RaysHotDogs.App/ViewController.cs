using DocumentFormat.OpenXml.Vml.Spreadsheet;
using Foundation;
using System;
using UIKit;

namespace RaysHotDogs.App
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            //CancelButton.TouchUpInside += (object sender, EventArgs e) =>
            //{
            //    UIAlertView cancelConfirm = new UIAlertView("Ray's Hot Dogs", "Do you really want to cancel?", null, "OK", null);
            //    cancelConfirm.Show();
            //};
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void OrderButton_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }

        partial void UIButton885_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }

        partial void OrderButton_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }
    }
}