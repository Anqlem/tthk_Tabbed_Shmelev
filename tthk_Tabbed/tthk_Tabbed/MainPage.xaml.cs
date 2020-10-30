using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tthk_Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            OpenActSheet();
        }

        private async void OpenActSheet()
        {
            string opt = await DisplayActionSheet("Which season open?", "Cancel", "","Winter", "Autumn", "Spring", "Summer");
            if (opt == "Autumn")
            {
                CurrentPage = Children[2];
            }
            else if(opt == "Winter")
            {
                CurrentPage = Children[0];
            }
            else if(opt == "Spring")
            {
                CurrentPage = Children[1];
            }
            else if(opt=="Summer")
            {
                CurrentPage = Children[3];
            }
        }
    }
}