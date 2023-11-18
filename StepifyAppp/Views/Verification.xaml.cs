﻿using StepifyAppp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StepifyAppp.Views
{
    /// <summary>
    /// Interaction logic for Verification.xaml
    /// </summary>
    public partial class Verification : Page
    {
        public Verification()
        {
            InitializeComponent();
            DataContext = new VerificationModel();
        }
    }
}
