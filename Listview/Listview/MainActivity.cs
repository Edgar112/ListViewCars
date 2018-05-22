using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Collections.Generic;

namespace Listview
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private List<TableItem> mItems;
        private ListView mListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);
            mListView = FindViewById<ListView>(Resource.Id.listView1);

            mItems = new List<TableItem>();

            mItems.Add(new TableItem()
            {
                AutoPilt = Resource.Drawable.car1, // 1
                Tootja = "BMW",
                Mudel = "DDAe2",
                Kilovatid = "223kw"
            });
            mItems.Add(new TableItem()
            {
                AutoPilt = Resource.Drawable.car2, // 2
                Tootja = "BMW",
                Mudel = "Gaed",
                Kilovatid = "228kw"
            });
            mItems.Add(new TableItem()
            {
                AutoPilt = Resource.Drawable.car3, // 3
                Tootja = "BMW",
                Mudel = "GAWfg23",
                Kilovatid = "148kw"
            });
            mItems.Add(new TableItem()
            {
                AutoPilt = Resource.Drawable.car4, // 4
                Tootja = "BMW",
                Mudel = "11sWfg23",
                Kilovatid = "151kw"
            });
            mItems.Add(new TableItem() //5
            {
                AutoPilt = Resource.Drawable.car5, 
                Tootja = "BMW",
                Mudel = "11qq2g23",
                Kilovatid = "199kw"
            });
            mItems.Add(new TableItem()
            {
                AutoPilt = Resource.Drawable.car6,
                Tootja = "BMW",
                Mudel = "1JFaEE3",
                Kilovatid = "151kw"
            });
            mItems.Add(new TableItem()
            {
                AutoPilt = Resource.Drawable.car7,
                Tootja = "Nissan",
                Mudel = "Micbuss",
                Kilovatid = "151kw"
            });
            mItems.Add(new TableItem()
            {
                AutoPilt = Resource.Drawable.car8,
                Tootja = "Nissan",
                Mudel = "MicBus2020",
                Kilovatid = "1200kw"
            });
            mItems.Add(new TableItem()
            {
                AutoPilt = Resource.Drawable.car9,
                Tootja = "Nissan",
                Mudel = "LowKBuss",
                Kilovatid = "11kw"
            });
            mItems.Add(new TableItem()
            {
                AutoPilt = Resource.Drawable.car10,
                Tootja = "Nissan",
                Mudel = "UltraJapanMX-3",
                Kilovatid = "90kw"
            });
            HomeScreenAdapter adapter = new HomeScreenAdapter(this, mItems);
            mListView.Adapter = adapter;
        }
    } 
}

