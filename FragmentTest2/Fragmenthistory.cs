using Android.Support.V4.App;
using Android.OS;
using Android.Views;

namespace FragmentTest2
{
    public class Fragmenthistory : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.historyFragment, container, false);
            return view;
        }
    }
}