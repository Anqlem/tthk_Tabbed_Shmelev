﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tthk_Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class December : ContentPage
    {
        public December()
        {
            InitializeComponent();
            var lbl = new TapGestureRecognizer();
            lbl.Tapped += Lbl_Tapped;
            pyha1.GestureRecognizers.Add(lbl);
            var lbl2 = new TapGestureRecognizer();
            lbl2.Tapped += Lbl2_Tapped;
            pyha2.GestureRecognizers.Add(lbl2);
            var lbl3 = new TapGestureRecognizer();
            lbl3.Tapped += Lbl3_Tapped;
            pyha3.GestureRecognizers.Add(lbl3);
        }
        private void Lbl3_Tapped(object sender, EventArgs e)
        {
           DisplayAlert("Holiday", "This holiday will take place on December 26th", "OK");
           
        }

        private void Lbl2_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Holiday", "This holiday will take place on December 25th", "OK");
        }

        private void Lbl_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Holiday", "This holiday will take place on December 24th", "OK");
        }
    }
}