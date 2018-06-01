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

            Button signUp = FindViewById<Button>(Resource.Id.newuser);
            signUp.Click += SignUpButton;

        }

        public void MakeText(string text)
        {
            Toast.MakeText(ApplicationContext, text, ToastLength.Long).Show();
        }

        public void SignUpButton(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.register);
        }

        public void BackButton(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.register);
        }
        public void HomePage(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.activity_main);
        }
        //public void MenuPage(object sender, EventArgs e)
        //{
        //    SetContentView(Resource.Layout.game_selection);
        //}
        //public void TTTHomePage(object sender, EventArgs e)
        //{
        //    SetContentView(Resource.Layout.tictactoe_home);
        //}
        //public void TTTGamePage(object sender, EventArgs e)
        //{
        //    SetContentView(Resource.Layout.tictactoe_game);
        //}

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
            catch (Exception)
            {
                Toast.MakeText(ApplicationContext, "Something went wrong", ToastLength.Long).Show();
            }
        }
    }
}

