using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUI
{
    public partial class Login : ContentPage
    {
        private Entry usernameEntry;
        private Entry passwordEntry;
        private Button loginButton;

        public Login()
        {
            // Create the UI elements
            usernameEntry = new Entry
            {
                Placeholder = "Username"
            };
            passwordEntry = new Entry
            {
                Placeholder = "Password",
                IsPassword = true
            };
            loginButton = new Button
            {
                Padding = 10,
                Text = "Login",
                BackgroundColor = Color.FromRgb(0x23, 0xA0, 0xA9),
                TextColor = Color.FromRgb(255, 255, 255)
            };

            // Add the UI elements to the page
            StackLayout stackLayout = new StackLayout
            {
                Padding = new Thickness(10),
                Background = new SolidColorBrush(Color.FromRgb(0x27, 0x3E, 0x47)),
                Children = { usernameEntry, passwordEntry, loginButton }
            };
            Content = stackLayout;

            // Handle the login button click event
            loginButton.Clicked += LoginButton_Clicked;
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;
            // check if the input is valid and handle the login request
        }
    }

}
