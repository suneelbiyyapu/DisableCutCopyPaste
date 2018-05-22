using DisableCutCopyPaste;
using DisableCutCopyPaste.iOS;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using ObjCRuntime;
using Foundation;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace DisableCutCopyPaste.iOS
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (Control != null)
            {
                // Write your logic if requires.
            }
        }

        // Following method is for hiding Menu control options (Cut, Copy, Paste ... etc).
        public override bool CanPerform(Selector action, NSObject withSender)
        {
            NSOperationQueue.MainQueue.AddOperation(() =>
            {
                UIMenuController.SharedMenuController.SetMenuVisible(false, false);
            });

            return base.CanPerform(action, withSender);
        }
    }
}
