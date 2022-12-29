using Android.OS;
using Android.Views;
using Google.Android.Material.BottomSheet;

namespace com.companyname.navigationdialogtest.dialogs
{
    public class BottomDialog : BottomSheetDialogFragment
    {
        public BottomDialog() { }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            return inflater.Inflate(Resource.Layout.generic_dialog_scrollable, container, false);
        }
    }
}