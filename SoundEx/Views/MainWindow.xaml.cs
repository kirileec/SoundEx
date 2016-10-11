﻿using Prism.Events;
using SoundEx.Infrastructure.Events;
using SoundEx.Log;
using System.Windows;

namespace SoundEx.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IEventAggregator eventAggregator)
        {
            InitializeComponent();
            
        }
    }
}
