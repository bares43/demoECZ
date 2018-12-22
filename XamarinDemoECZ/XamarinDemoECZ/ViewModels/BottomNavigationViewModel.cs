using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinDemoECZ.ViewModels {
    public class BottomNavigationViewModel : BaseViewModel {

        string iconHome = string.Empty;
        public string IconHome {
            get { return iconHome; }
            set { SetProperty(ref iconHome, value); }
        }

        string iconTeam = string.Empty;
        public string IconTeam {
            get { return iconTeam; }
            set { SetProperty(ref iconTeam, value); }
        }

        string iconCalendar = string.Empty;
        public string IconCalendar {
            get { return iconCalendar; }
            set { SetProperty(ref iconCalendar, value); }
        }

        string iconMessages = string.Empty;
        public string IconMessages {
            get { return iconMessages; }
            set { SetProperty(ref iconMessages, value); }
        }

        string iconNotifications = string.Empty;
        public string IconNotifications {
            get { return iconNotifications; }
            set { SetProperty(ref iconNotifications, value); }
        }

        public ICommand OpenHomeCommand { get; private set; }

        public BottomNavigationViewModel() {
            IconCalendar = IconFont.CalendarAlt;
            IconMessages = IconFont.Comments;
            IconHome = IconFont.Building;
            IconNotifications = IconFont.Bookmark;
            IconTeam = IconFont.ListAlt;
            OpenHomeCommand = new Command(OpenHome);
        }

        void OpenHome() {
            (App.Current.MainPage as Shell).GoToAsync("app:///newapp/home");
        }
    }
}
