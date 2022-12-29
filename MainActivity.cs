using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using AndroidX.Navigation.Fragment;
using AndroidX.Navigation;

namespace com.companyname.navigationdialogtest
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, NavController.IOnDestinationChangedListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            NavHostFragment navHostFragment = SupportFragmentManager.FindFragmentById(Resource.Id.nav_host) as NavHostFragment;
            NavController navController = navHostFragment.NavController;
            
            navController.AddOnDestinationChangedListener(this);
            
            //int[] topLevelDestinationIds = new int[] { Resource.Id.home_fragment};


        }

        public void OnDestinationChanged(NavController controller, NavDestination destination, Bundle arguments)
        {
            //throw new System.NotImplementedException();
        }
    }
}