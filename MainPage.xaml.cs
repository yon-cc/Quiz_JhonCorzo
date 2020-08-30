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

namespace QuizJhonCorzo
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public class Classes
        {
            public string classes { get; set; }
        }
        public MainPage()
        {
            InitializeComponent();

            List<Classes> ListClasses = new List<Classes>();

            ListClasses.Add(new Classes { classes = "Mage" });
            ListClasses.Add(new Classes { classes = "Warrior" });
            ListClasses.Add(new Classes { classes = "Hunter" });
            ListClasses.Add(new Classes { classes = "Monk" });

            classesCombobx.ItemsSource = ListClasses;

        }

      
    }
}