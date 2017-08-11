using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;

namespace MJDeal
{
    [Activity(Label = "MJDeal", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
       
    {
        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Android.Net.Uri uri = Android.Net.Uri.Parse("Resource.Drawable.Wildlife");

            VideoView videoView = FindViewById<VideoView>(Resource.Drawable.Wildlife);
            videoView.SetVideoURI(uri);
            videoView.Start(); 
           
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button CityMenu = FindViewById<Button>(Resource.Id.CityMenu);
            


            CityMenu.Click += (s, arg) => {
                PopupMenu menu = new PopupMenu(this, CityMenu);
                menu.Inflate(Resource.Menu.CityMenuPopUp);
               
                menu.MenuItemClick += (s1, arg1) => {

                    Console.WriteLine(arg1);
                   
                    Console.WriteLine("{0} selected", arg1.Item.TitleFormatted);
        
``                      switch (arg1.Item.TitleFormatted.ToString())  {
             case "Vancouver":
                           var intent = new Intent(this, typeof(Vancouver));
                           StartActivity(intent);
                           break;
             case "More":
                            var intent1 = new Intent(this, typeof(More));
                            StartActivity(intent1);
                            break;
             default:
                 break;
         } 
                };

                menu.DismissEvent += (s2, arg2) => {
                    Console.WriteLine("menu dismissed");
                };
                menu.Show();
            };
           
            
           
        }
        }
        }
    


