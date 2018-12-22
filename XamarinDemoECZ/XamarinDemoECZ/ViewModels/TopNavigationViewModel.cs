using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinDemoECZ.ViewModels {
    public class TopNavigationViewModel : BaseViewModel {
        string iconSettings = string.Empty;
        public string IconSettings {
            get { return iconSettings; }
            set { SetProperty(ref iconSettings, value); }
        }

        string iconProfile = string.Empty;
        public string IconProfile {
            get { return iconProfile; }
            set { SetProperty(ref iconProfile, value); }
        }

        string name = string.Empty;
        public string Name {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        public ICommand OpenSettingsCommand { get; private set; }

        public TopNavigationViewModel() {
            IconSettings = IconFont.Sun;
            IconProfile = IconFont.User;
            Name = "FC DMP";

            OpenSettingsCommand = new Command(OpenSettings);
        }

        void OpenSettings() {
            (App.Current.MainPage as Shell).GoToAsync("app:///newapp/settings");
        }
    }
}
