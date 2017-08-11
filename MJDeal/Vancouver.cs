using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Support.V7.Widget;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MJDeal
{
    [Activity(Label = "Vancouver")]
    public class Vancouver : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            var tab = this.ActionBar.NewTab();
            tab.SetText(tabText);
            tab.SetIcon(Resource.Drawable.ic_tab_white);

        }
    }
}