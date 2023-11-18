using StepifyAppp.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace StepifyAppp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void Main(object sender, StartupEventArgs e)
        {
            //MainWindowView main = new();
            //main.ShowDialog();
            //LoginPageView login = new LoginPageView();
            //login.ShowDialog();
            //Register register= new Register();
            //register.ShowDialog();
            FirstWindow first = new FirstWindow();
            first.ShowDialog();
        }
    }
}
