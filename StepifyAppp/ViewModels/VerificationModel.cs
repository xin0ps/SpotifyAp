using StepifyAppp.Commands;
using StepifyAppp.Models;
using StepifyAppp.Services;
using StepifyAppp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
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


    public class VerificationModel : NotificationService
    {

        private ObservableCollection<User> users;
        public ObservableCollection<User> Users { get => users; set { users = value; OnPropertyChanged(); } }



        public static string random { get; set; }
        private string verify;
        public static User registereduser { get; set; }

        public string Verify
        {
            get { return verify; }
            set { verify = value; OnPropertyChanged(); }
        }


        public ICommand Apply { get; set; }
        public ICommand Cancel { get; set; }

        public VerificationModel()
        {
            Cancel = new RelayCommand(CancelWindow);
            Apply = new RelayCommand(apply);
            Users = new ObservableCollection<User>();
            LoadUsers();

        }

        public void apply(object? parameter)
        {
            var p = parameter as Page;
            if (random == verify)
            {
                if (p != null)
                {
                    MessageBox.Show("Register Succesfully");

                   
                        Users.Add(registereduser!);

                        string data = JsonSerializer.Serialize(Users, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText("../../../DataBase/Users.json", data);
                    
                    p.NavigationService.Navigate(new LoginPageView());

                }

            }
            else
            {
                MessageBox.Show("Wrong Verrification Code");
            }
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
        public void CancelWindow(object? parameter)
        {
            var p = parameter as Page;

            if (p != null)
            {
                p.NavigationService.GoBack();
            }
        }
    }
}
