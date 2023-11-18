using StepifyAppp.Commands;
using StepifyAppp.Models;
using StepifyAppp.Services;
using StepifyAppp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StepifyAppp.ViewModels
{
    public class LoginPageViewModel:NotificationService
    {
        private ObservableCollection<User> users;
        public ObservableCollection<User> Users { get => users; set { users = value; OnPropertyChanged(); } }

        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set;}

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value;OnPropertyChanged(); }
        }


        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(); }
        }



        public LoginPageViewModel()
        {
            LoginCommand = new RelayCommand(login);
            RegisterCommand = new RelayCommand(register);
          LoadUsers();
           
        }

        public void login(object? parameter)
        {
            User Logined=null;
            if (Email== null || Password==null)
            {
                MessageBox.Show("Fields is empty!");
            }
           foreach (var user in Users)
            {
                if ((user.Email == Email)&&( user.Password == Password))
                {
                    Logined=user;
                    string data = JsonSerializer.Serialize(Logined, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText("../../../DataBase/LoginedUser.json", data);
                    Window w = new MainWindowView();
                    App.Current.MainWindow.Close();
                    App.Current.MainWindow = w;
                
                    w.ShowDialog();

                   
                
                }
                
            }
           if(Logined==null) { MessageBox.Show("Wrong password or email"); }
           
        }
     
  
        public void LoadUsers()
        {
            string existing = File.ReadAllText("../../../DataBase/Users.json");
            Users = JsonSerializer.Deserialize<ObservableCollection<User>>(existing);
        }

        public void register(object? parameter)
        {
            //Window w = new Register();
            //w.ShowDialog();

            Page p = parameter as Page;

            if (p != null)
            {
                p.NavigationService.Navigate(new Register());
            }


        }

    }
}
