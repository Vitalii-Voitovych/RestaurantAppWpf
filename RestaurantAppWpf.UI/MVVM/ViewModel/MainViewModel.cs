﻿using RestaurantAppWpf.UI.Core;
using RestaurantAppWpf.UI.MVVM.View;

namespace RestaurantAppWpf.UI.MVVM.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private object currentView;
        public object CurrentView
        {
            get => currentView;
            set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }
        public HomeViewModel HomeVM { get; } = new HomeViewModel();
        public MenuViewModel MenuVM { get; } = new MenuViewModel();
        public SettingViewModel SettingVM { get; } = new SettingViewModel();
        public CartViewModel CartVM { get; set; } = new CartViewModel();
        public LoginViewModel LoginVM { get; set; } = new LoginViewModel();
        public RelayCommand HomeCommand { get; }
        public RelayCommand MenuCommand { get; }
        public RelayCommand SettingCommand { get; }
        public RelayCommand CartCommand { get; }

        public MainViewModel()
        {
            CurrentView = HomeVM;
            LoginView loginView = new LoginView();
            loginView.ShowDialog();
            HomeCommand = new RelayCommand(() => CurrentView = HomeVM);
            MenuCommand = new RelayCommand(() => CurrentView = MenuVM);
            SettingCommand = new RelayCommand(() =>  CurrentView = SettingVM);
            CartCommand = new RelayCommand(() => CurrentView = CartVM);
        }
    }
}
