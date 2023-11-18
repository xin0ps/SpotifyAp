
using StepifyAppp.Api;
using StepifyAppp.Models;
using StepifyAppp.Services;
using StepifyAppp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace StepifyAppp.ViewModels
{
    public class LibraryPageViewModel:NotificationService
    {

        private User user;

        public User User { get => user; set { user = value; OnPropertyChanged(); } }

        public LibraryPageViewModel()
        {
            LoadUser();
        }

        public void LoadUser()
        {
            string existing = File.ReadAllText("../../../DataBase/LoginedUser.json");
            User = JsonSerializer.Deserialize<User>(existing);
        }

        public void WriteUser()
        {
            string data = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("../../../DataBase/LoginedUser.json", data);
        }
    }
}

    
