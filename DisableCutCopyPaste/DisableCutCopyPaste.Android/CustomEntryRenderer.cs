using Android.Content;
using Android.Views;
using DisableCutCopyPaste;
using DisableCutCopyPaste.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace DisableCutCopyPaste.Droid
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.CustomSelectionActionModeCallback = new Callback();
            }
        }
    }

    // Following class is for hiding Menu control options (Cut, Copy, Paste ... etc).
    internal class Callback : Java.Lang.Object, ActionMode.ICallback
    {

        public bool OnActionItemClicked(ActionMode mode, IMenuItem item)
        {
            return false;
        }

        public bool OnCreateActionMode(ActionMode mode, IMenu menu)
        {
            return false;
        }

        public void OnDestroyActionMode(ActionMode mode)
        {

        }

        public bool OnPrepareActionMode(ActionMode mode, IMenu menu)
        {
            return false;
        }
    }
}