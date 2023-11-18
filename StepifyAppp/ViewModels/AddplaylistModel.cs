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
    public class AddplaylistModel:NotificationService
    {
        private User user;

        public User User { get => user; set { user = value; OnPropertyChanged(); } }


        private ObservableCollection<User> users;
        public ObservableCollection<User> Users { get => users; set { users = value; OnPropertyChanged(); } }



        private string name;

        public string Name
        {
            get { return name; }
            set { name = value;OnPropertyChanged(); }
        }


      public  ICommand Add { get; set; }

        
        public AddplaylistModel()
            
        {
            Add = new RelayCommand(add);
            

            LoadUser();
            LoadUsers();
        }

        public void Writedata()
        {
            string data = JsonSerializer.Serialize(Users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("../../../DataBase/Users.json", data);

        }
        public void LoadUsers()
        {
            string existing = File.ReadAllText("../../../DataBase/Users.json");
            Users = JsonSerializer.Deserialize<ObservableCollection<User>>(existing);
        }

        public void WriteUser()
        {
            string data = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("../../../DataBase/LoginedUser.json", data);
        }
        public void add(object? parameter)
        {
            LoadUsers();
            LoadUser();
            var p = parameter as Page;


            
                   
            foreach (var item in Users)
            {
                if (item.Email == user.Email)
                {
                    item.Libraries.Add(new Library(name));
                    Writedata();
                    string data = JsonSerializer.Serialize(item, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText("../../../DataBase/LoginedUser.json", data);
                }
            }

                
            

            p.NavigationService.Navigate(new LibraryPageView());

        }
        public void LoadUser()
        {
            string existing = File.ReadAllText("../../../DataBase/LoginedUser.json");
            User = JsonSerializer.Deserialize<User>(existing);
        }


    }
}
