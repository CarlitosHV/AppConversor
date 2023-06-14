﻿using Conversor.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MenuPrincipal();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
