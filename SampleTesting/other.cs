using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SampleTesting
{
    [Activity(Label = "other")]
    public class other : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.OtherPage);
//            string email = Intent.GetStringExtra("email" ?? "Not Rec");
//            string pass = Intent.GetStringExtra("password" ?? "Not Rec");
//
//            TextView texte = FindViewById<TextView>(Resource.Id.textEmail);
//            TextView textp = FindViewById<TextView>(Resource.Id.textPassword);
            Button goback = FindViewById<Button>(Resource.Id.btnGoBack);


//            texte.Text = email;
//            textp.Text = pass;

            goback.Click += delegate { this.Finish(); };



        }
    }
}