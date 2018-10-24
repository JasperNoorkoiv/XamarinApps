﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WeatherApp
{
    public class CustomAdapter : BaseAdapter<Core.Weather>
    {
        List<Core.Weather> weathers;
        Activity context;

        public CustomAdapter(Activity context, List<Core.Weather> items) : base()
        {
            this.context = context;
            this.weathers = items;
        }

        public override Core.Weather this[int position]
        {
            get { return weathers[position]; }
        }

        public override int Count { get { return weathers.Count; } }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.CustomRow, null);
            }
            //DateTime date = Convert.ToDateTime(weathers[position].Date);
            //string day = date.ToString("dddd").Substring(0, 3) + " " + date.ToString("HH:mm");
            //view.FindViewById<TextView>(Resource.Id.SDate).Text = day;
            //view.FindViewById<TextView>(Resource.Id.STemp).Text = weathers[position].Temperature;
            view.FindViewById<ImageView>(Resource.Id.Layout1Image).SetImageResource(Resource.Drawable._01d);

            return view;
        }
    }
}