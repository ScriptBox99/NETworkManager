﻿using NETworkManager.ViewModels;
using System.Windows.Controls;

namespace NETworkManager.Views
{
    public partial class SNMPHostView : UserControl
    {
        SNMPHostViewModel viewModel = new SNMPHostViewModel();

        public SNMPHostView()
        {
            InitializeComponent();
            DataContext = viewModel;
        }               
    }
}