using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Telecom;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace SampleTesting
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


//            EditText email = FindViewById<EditText>(Resource.Id.userName);
//            EditText pass = FindViewById<EditText>(Resource.Id.password);           
            Button loginButton = FindViewById<Button>(Resource.Id.login);

            loginButton.Click += (sender, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(other));
                //                nextActivity.PutExtra("email", email.Text);
                //                nextActivity.PutExtra("password", pass.Text);   

                StartActivity(nextActivity);
            };


        }
    }
}