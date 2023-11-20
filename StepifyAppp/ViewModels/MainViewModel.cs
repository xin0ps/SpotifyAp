using StepifyAppp.Commands;
using StepifyAppp.Models;
using StepifyAppp.Services;
using StepifyAppp.Views;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Windows;
using NAudio.Wave;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using System.Threading.Tasks;

namespace StepifyAppp.ViewModels
{
    public class MainViewModel : NotificationService
    {

        private string songname;

        public string Songname
        {
            get { return songname; }
            set { songname = value;OnPropertyChanged();  }
        }


        private int sliderValue;

        public int SliderValue
        {
            get { return sliderValue; }
            set { sliderValue = value; OnPropertyChanged(); }
        }

        private int nowtime;

        public int Nowtime
        {
            get { return nowtime; }
            set { nowtime = value; OnPropertyChanged(); }
        }

        private int alltime;

        public int Alltime
        {
            get { return alltime; }
            set { alltime = value; OnPropertyChanged(); }
        }

        private bool isPlaying;

        public bool IsPlaying
        {
            get { return isPlaying; }
            set { isPlaying = value; OnPropertyChanged(); }
        }

        private User user;
        public User User
        {
            get => user;
            set { user = value; OnPropertyChanged(); }
        }

        private ObservableCollection<User> users;
        public ObservableCollection<User> Users
        {
            get => users;
            set { users = value; OnPropertyChanged(); }
        }

        public ICommand SearchMusic { get; set; }
        public ICommand HomeCommand { get; set; }
        public ICommand Plus { get; set; }
        public ICommand PlayMusic { get; set; }

        private DispatcherTimer userUpdateTimer;
        private DispatcherTimer musicTimer;

        public MainViewModel()
        {
            SearchMusic = new RelayCommand(searchmusic);
            HomeCommand = new RelayCommand(home);
            Plus = new RelayCommand(plus);
            PlayMusic = new RelayCommand(playmusic);

            LoadUsers();
            LoadUser();

            // Timer'ı oluştur ve ayarla (örneğin, her 1 saniyede bir LoadUser'ı çağır)
            userUpdateTimer = new DispatcherTimer();
            userUpdateTimer.Interval = TimeSpan.FromSeconds(1);
            userUpdateTimer.Tick += UserUpdateTimer_Tick;

            // Timer'ı başlat
            userUpdateTimer.Start();

            musicTimer = new DispatcherTimer();
            musicTimer.Interval = TimeSpan.FromSeconds(1);
            musicTimer.Tick += MusicTimer_Tick;

            // Timer'ı başlat
            musicTimer.Start();
        }

        private void UserUpdateTimer_Tick(object sender, EventArgs e)
        {
            // Timer her tetiklendiğinde LoadUser'ı çağır
            LoadUser();
        }

        private void MusicTimer_Tick(object sender, EventArgs e)
        {
        if(isPlaying)
            {
                Nowtime += 1;
                SliderValue = Nowtime;
            }
        }

        public void plus(object? parameter)
        {
            var p = parameter as Page;
            if (p != null)
            {
                p.NavigationService.Navigate(new Addplaylist());
            }
        }

        public async void playmusic(object? parameter)

        {
            bool end = false;
            string musicPath = "../../../StaticFiles/Sting - Shape of My Heart Leon.mp3";
            Songname = "Sting - Shape of My Heart";
          
                try
                {
                    using (var player = new WaveOutEvent())
                    using (var reader = new Mp3FileReader(musicPath))
                    {

                        player.Init(reader);

                        Nowtime = (int)reader.CurrentTime.TotalSeconds;
                        Alltime = (int)reader.TotalTime.TotalSeconds;
                        IsPlaying = true;

                        // Müziği çal
                        player.Play();

                        // Belirli bir süre bekleyin (örneğin, 10 saniye)
                        await Task.Delay(reader.TotalTime);

                        
                        player.Stop();
                        IsPlaying = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}");
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
