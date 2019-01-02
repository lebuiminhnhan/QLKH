﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLiKhachHang.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded = false;
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand CustomerCommand { get; set; }
        // mọi thứ xử lý sẽ nằm trong này
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                Isloaded = true;
                LoginForm loginWindow = new LoginForm();
                loginWindow.ShowDialog();
            }
              );

            CustomerCommand = new RelayCommand<object>((p) => { return true; }, (p) => { AddCustomer wd = new AddCustomer(); wd.ShowDialog(); });
        }

    }
}
