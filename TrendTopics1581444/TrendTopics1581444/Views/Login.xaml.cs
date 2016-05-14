﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TrendTopics1581444.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            this.btnLogin.Clicked += async (sender, e) =>
            {
                await this.Navigation.PushAsync(new Home());
            };
        }
    }
}