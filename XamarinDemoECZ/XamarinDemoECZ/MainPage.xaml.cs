using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinDemoECZ.Views;

namespace XamarinDemoECZ {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();

            Shell.SetNavBarIsVisible(this, false);
        }
    }
}
