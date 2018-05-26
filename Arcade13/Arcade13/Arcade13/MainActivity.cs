using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

using System.Data.SqlClient;
using System;

namespace Arcade13
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            Button signIn = FindViewById<Button>(Resource.Id.SignIn);

            signIn.Click += Connect;
        }

        public void MakeText(string text)
        {
            Toast.MakeText(ApplicationContext, text, ToastLength.Long).Show();
        }

        public void Connect(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("SERVER=den1.mssql3.gear.host;DATABASE=arcade13;UID=arcade13;PWD=Rx7dWupmQ~~6;");
            //SqlDataReader sdr;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("insert into test_table (firstColumn, secondColumn) values (0, 1)"/*Insert query here*/, cnn);

                MakeText($"{cmd.ExecuteNonQuery()}");

                //sdr = cmd.ExecuteReader();
                //while(sdr.Read())
                //{

                //}
                cmd.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                Toast.MakeText(ApplicationContext, "Something went wrong", ToastLength.Long).Show();
            }
        }
    }
}

