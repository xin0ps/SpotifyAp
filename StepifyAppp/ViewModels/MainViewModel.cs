using StepifyAppp.Commands;
using StepifyAppp.Models;
using StepifyAppp.Services;
using StepifyAppp.Views;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace StepifyAppp.ViewModels
{
    public class MainViewModel : NotificationService
    {
        private User user;
        public User User { get => user; set { user = value; OnPropertyChanged(); } }

        private ObservableCollection<User> users;
        public ObservableCollection<User> Users { get => users; set { users = value; OnPropertyChanged(); } }

        public ICommand SearchMusic { get; set; }
        public ICommand HomeCommand { get; set; }
        public ICommand Plus { get; set; }

        private DispatcherTimer userUpdateTimer;

        public MainViewModel()
        {
            SearchMusic = new RelayCommand(searchmusic);
            HomeCommand = new RelayCommand(home);
            Plus = new RelayCommand(plus);

            LoadUsers();
            LoadUser();

            // Timer'ı oluştur ve ayarla (örneğin, her 1 saniyede bir LoadUser'ı çağır)
            userUpdateTimer = new DispatcherTimer();
            userUpdateTimer.Interval = TimeSpan.FromSeconds(1);
            userUpdateTimer.Tick += UserUpdateTimer_Tick;

            // Timer'ı başlat
            userUpdateTimer.Start();
        }

        private void UserUpdateTimer_Tick(object sender, EventArgs e)
        {
            // Timer her tetiklendiğinde LoadUser'ı çağır
            LoadUser();
        }

        public void plus(object? parameter)
        {
            var p = parameter as Page;
            if (p != null)
            {
                p.NavigationService.Navigate(new Addplaylist());
            }
        }

        public void LoadUsers()
        {
            string existing = File.ReadAllText("../../../DataBase/Users.json");
            Users = JsonSerializer.Deserialize<ObservableCollection<User>>(existing);
        }

        public void LoadUser()
        {
            string existing = File.ReadAllText("../../../DataBase/LoginedUser.json");
            User = JsonSerializer.Deserialize<User>(existing);
        }

        public void home(object? parameter)
        {
            Page p = parameter as Page;
            if (p != null)
            {
                p.NavigationService.Navigate(new LibraryPageView());
            }
        }

        public void searchmusic(object? parameter)
        {
            Page p = parameter as Page;
            if (p != null)
            {
                p.NavigationService.Navigate(new SearchPageView());
            }
        }
    }
}
