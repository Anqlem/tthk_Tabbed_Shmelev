﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace tthk_Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class April : ContentPage
    {
        public April()
        {
            InitializeComponent();
            var lbl = new TapGestureRecognizer();
            lbl.Tapped += Lbl_Tapped;
            pyha1.GestureRecognizers.Add(lbl);
            var lbl2 = new TapGestureRecognizer();
            lbl2.Tapped += Lbl2_Tapped;
            pyha2.GestureRecognizers.Add(lbl2);
        }

        private void Lbl2_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Holiday", "This holiday will take place on April 12th", "OK");
        }

        private void Lbl_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Holiday", "This holiday will take place on April 10th", "OK");
        }
    }
}