using MaterialDesignThemes.Wpf;

using StepifyAppp.Commands;
using StepifyAppp.Models;
using StepifyAppp.Services;
using StepifyAppp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Xml.Linq;

namespace StepifyAppp.ViewModels
{



    public class RegisterViewModel : NotificationService
    {
        public static  bool apply = false;
        private string error;

        public string Error
        {
            get { return error; }
            set { error = value; OnPropertyChanged(); }
        }
     
        private User user;
       

        public User User
        {
            get { return user; }
            set { user = value; OnPropertyChanged(); }
        }

        public ICommand SaveCommand { get; set; }
        public ICommand CancelCommand { get; set; }


        public RegisterViewModel()
        {
            user = new User();
            
            SaveCommand = new RelayCommand(Save, CanSave);
            CancelCommand = new RelayCommand(CancelWindow);
      
        }



        public void Save(object? parameter)
        {
         
        
            var window = parameter as   Page;
            
            if (window != null)
            { int rand = Random.Shared.Next(999, 9999);
               
                SendEmail.sendverification(user.Email, rand.ToString());
                VerificationModel.random = rand.ToString();
                VerificationModel.registereduser= user;
                user = new User();
                window.NavigationService.Navigate(new Verification());
        
            }


        }


        public bool CanSave(object? parameter)
        {
            if (User.Name.Length < 2)
            {
                Error = "• Name  minimum 3 symbol";
                return false;
            }
            else
            {
                Error = "";
            }

            if (User.Surname.Length<2 )
            {
                Error = "• SurName  minimum 3 symbol";
                return false;
            }
            else
            {
                Error = "";
            }

            // E-posta adresi kontrolü
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            if (!Regex.IsMatch(User.Email, emailPattern))
            {
                Error = "• Email@gmail.com";
                return false;
            }
            else
            {
                Error = "";
            }

            // Parola kontrolü
            string passwordPattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*(),.?\"":{}|<>])[A-Za-z\d!@#$%^&*(),.?\"":{}|<>]{8,}$";



            if (!Regex.IsMatch(User.Password, passwordPattern))
            {
                Error = "• Password minimum 8 symbol";
                return false;
            }
            else
            {
                Error = "";
            }

            return true;
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
