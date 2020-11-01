using PasswordToggle.Views;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace PasswordToggle.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string username;
        private string password;
        private bool hidePassword = true;

        public Command LoginCommand { get; }

        public Command TogglePasswordCommand { get; }

        public string Username
        {
            get => username;
            set => SetProperty(ref username, value);
        }

        public string Password 
        { 
            get => password; 
            set => SetProperty(ref password, value); 
        }

        public bool HidePassword
        {
            get => hidePassword;
            private set => SetProperty(ref hidePassword, value);
        }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            TogglePasswordCommand = new Command(OnTogglePasswordClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

        private void OnTogglePasswordClicked()
        {
            HidePassword = !HidePassword;
        }
    }
}
