using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

using SupportFragment = Android.Support.V4.App.Fragment;
using Android.Views;
using System.Collections.Generic;
using Android.Support.Design.Widget;


namespace FragmentTest2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        BottomNavigationView bottomNavigation;

        private SupportFragment mCurrentFragment;
        private Fragmentfood mFragment1;
        private Fragmenttourist mFragment2;
        private Fragmenthistory mFragment3;
        private Stack<SupportFragment> mStackFragment;
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            bottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.bNV);
            bottomNavigation.NavigationItemSelected += (s, e) =>
            {
                Android.Support.V4.App.Fragment fragment = null;
                switch (e.Item.ItemId)
                {
                    case Resource.Id.Food:
                        fragment = new Fragmentfood();
                        break;
                    case Resource.Id.Tourist:
                        fragment = new Fragmenttourist();
                        break;
                    case Resource.Id.History:
                        fragment = new Fragmenthistory();
                        break;
                }
                SupportFragmentManager.BeginTransaction()
                .Replace(Resource.Id.fragmentConteiner, fragment)
                .Commit();

                return;
            };

            mFragment1 = new Fragmentfood();
            mFragment2 = new Fragmenttourist();
            mFragment3 = new Fragmenthistory();

            mStackFragment = new Stack<SupportFragment>();

            var trans = SupportFragmentManager.BeginTransaction();
            trans.Add(Resource.Id.fragmentConteiner, mFragment3, "Fragmenthistory");
            trans.Hide(mFragment3);
            trans.Add(Resource.Id.fragmentConteiner, mFragment2, "Fragmenttourist");
            trans.Hide(mFragment2);
            trans.Add(Resource.Id.fragmentConteiner, mFragment1, "Fragmentfood");
            trans.Commit();

            mCurrentFragment = mFragment1;

        }
    }
}
