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

namespace Listview
{
    public class HomeScreenAdapter : BaseAdapter<TableItem>
    {
        public List<TableItem> mItems;
        private Context mContext;
        public HomeScreenAdapter(Context context, List<TableItem> items)
        {
            mItems = items;
            mContext = context;
           
        }
        public override int Count
        {
            get { return mItems.Count; }
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override TableItem this[int position]
        {
            get { return mItems[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {

            View row = convertView;
            if (row == null)
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.CustomView, null, false);

            var item = mItems[position];

            TextView txtTootja = row.FindViewById<TextView>(Resource.Id.Tootja);
            TextView txtMudel = row.FindViewById<TextView>(Resource.Id.Mudel);
            TextView txtKilovatid = row.FindViewById<TextView>(Resource.Id.Kilovatid);
            ImageView pilt = row.FindViewById<ImageView>(Resource.Id.Image1);

            txtTootja.Text = mItems[position].Tootja;
            txtMudel.Text = mItems[position].Mudel;
            txtKilovatid.Text = mItems[position].Kilovatid;
            pilt.SetImageResource(mItems[position].AutoPilt);
            return row;
        }
    }
}