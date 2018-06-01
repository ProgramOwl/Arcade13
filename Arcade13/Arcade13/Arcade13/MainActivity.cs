﻿using Android.App;
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
            InitializeHomePage();
        }

#region InitializePages
        public void InitializeHomePage()
        {
            SetContentView(Resource.Layout.activity_main);

            Button signIn = FindViewById<Button>(Resource.Id.SignIn);
            signIn.Click += Connect;

            Button signUp = FindViewById<Button>(Resource.Id.newuser);
            signUp.Click += CallRegisterPage;
        }
        public void InitializeRegistrationPage()
        {
            SetContentView(Resource.Layout.register);
            ImageButton backTohome = FindViewById<ImageButton>(Resource.Id.backarrow);
            backTohome.Click += CallHomePage;
        }
        public void InitializeGameSelectionPage()
        {
            SetContentView(Resource.Layout.game_selection);
            //Button gameSelected = FindViewById<Button>(Resource.Id.gameSelected);
            //gameSelected.Click += CallTTTHomePage;
        }
        public void InitializeTTTHomePage()
        {
            SetContentView(Resource.Layout.tictactoe_home);
            //Button backButton = FindViewById<Button>)(Resource.Id.backButton); 
            //backButton.Click += CallGameSelectionPage;
            //Button playButton = FindViewById<Button>)(Resource.Id.playButton); 
            //playButton.Click += CallTTTGamePage;
        }
        public void InitializeTTTGamePage()
        {
            SetContentView(Resource.Layout.tictactoe_game);
            //Button backButton = FindViewById<Button>)(Resource.Id.backButton); 
            //backButton.Click += CallTTTHomePage;
        }
#endregion
        
#region CallPages
        public void CallRegisterPage(object sender, EventArgs e)
        {
            InitializeRegistrationPage();
        }
        public void CallHomePage(object sender, EventArgs e)
        {
            InitializeHomePage();
        }
        public void CallGameSelectionPage(object sender, EventArgs e)
        {
            InitializeGameSelectionPage();
        }
        public void CallTTTHomePage(object sender, EventArgs e)
        {
            InitializeTTTHomePage();
        }
        public void CallTTTGamePage(object sender, EventArgs e)
        {
            InitializeTTTGamePage();
        }
        #endregion

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
            catch (Exception)
            {
                Toast.MakeText(ApplicationContext, "Something went wrong", ToastLength.Long).Show();
            }
        }
    }
}

