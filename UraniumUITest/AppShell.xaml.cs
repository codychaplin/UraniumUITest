﻿namespace UraniumUITest
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("HomePage", typeof(HomePage));
            Routing.RegisterRoute("TestPage", typeof(TestPage));
        }
    }
}
