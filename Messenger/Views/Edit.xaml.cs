﻿using System;
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

namespace Messenger.Views
{
    /// <summary>
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Page
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void BackBut_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SaveBut_Click(object sender, RoutedEventArgs e)
        {
            //TO-DO Сохранение изменений
        }
    }
}
