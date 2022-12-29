using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AndroidX.Navigation;
using com.companyname.navigationdialogtest.dialogs;

namespace com.companyname.navigationdialogtest.fragments
{
    public class HomeFragment : Fragment
    {
        public HomeFragment() { }
        

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.fragment_home, container, false);
            Button navigateActionButton = view.FindViewById<Button>(Resource.Id.navigate_action_button);
            
            navigateActionButton.Click += NavigateActionButton_Click;
            return view;
        }

        private void NavigateActionButton_Click(object sender, System.EventArgs e)
        {
            NavController navController = Navigation.FindNavController(Activity, Resource.Id.nav_host);
            navController.Navigate(Resource.Id.action_home_to_bottom_sheet);

            //ShowSubscriptionInfoDialog();
        }

        private void ShowSubscriptionInfoDialog(/*string title, string explanation*/)
        {
            string tag = "SubscriptionInfoDialogFragment";
            FragmentManager fm = Activity.SupportFragmentManager;
            if (fm != null && !fm.IsDestroyed)
            {
                Fragment fragment = fm.FindFragmentByTag(tag);
                if (fragment == null)
                {
                    //BasicDialogFragment.NewInstance(title, explanation).Show(fm, tag);
                    BottomDialog dialog = new BottomDialog();
                    dialog.Show(fm, tag);
                }
            }
        }
    }
}