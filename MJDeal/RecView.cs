using System;

using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;

namespace MJDeal
{
    class RecView : RecyclerView.Adapter
    {
        public event EventHandler<RecViewClickEventArgs> ItemClick;
        public event EventHandler<RecViewClickEventArgs> ItemLongClick;
        string[] items;

        public RecView(string[] data)
        {
            items = data;
        }

        // Create new views (invoked by the layout manager)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            //Setup your layout here
            View itemView = null;
            //var id = Resource.Layout.__YOUR_ITEM_HERE;
            //itemView = LayoutInflater.From(parent.Context).
            //       Inflate(id, parent, false);

            var vh = new RecViewViewHolder(itemView, OnClick, OnLongClick);
            return vh;
        }

        // Replace the contents of a view (invoked by the layout manager)
        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            var item = items[position];

            // Replace the contents of the view with that element
            var holder = viewHolder as RecViewViewHolder;
            //holder.TextView.Text = items[position];
        }

        public override int ItemCount => items.Length;

        void OnClick(RecViewClickEventArgs args) => ItemClick?.Invoke(this, args);
        void OnLongClick(RecViewClickEventArgs args) => ItemLongClick?.Invoke(this, args);

    }

    public class RecViewViewHolder : RecyclerView.ViewHolder
    {
        //public TextView TextView { get; set; }


        public RecViewViewHolder(View itemView, Action<RecViewClickEventArgs> clickListener,
                            Action<RecViewClickEventArgs> longClickListener) : base(itemView)
        {
            //TextView = v;
            itemView.Click += (sender, e) => clickListener(new RecViewClickEventArgs { View = itemView, Position = AdapterPosition });
            itemView.LongClick += (sender, e) => longClickListener(new RecViewClickEventArgs { View = itemView, Position = AdapterPosition });
        }
    }

    public class RecViewClickEventArgs : EventArgs
    {
        public View View { get; set; }
        public int Position { get; set; }
    }
}