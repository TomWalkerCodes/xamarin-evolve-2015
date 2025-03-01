﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using Xamarin.Forms;
using SQLite.Net.Platform.WindowsPhone8;

namespace People.WinPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();


            string dbPath = FileAccessHelper.GetLocalFilePath("people.db3");
            Content = People.App.GetMainPage(new SQLitePlatformWP8(), dbPath).ConvertPageToUIElement(this);
        }
    }
}
