using QuanLiKhachHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLiKhachHang.ViewModel
{
   public class LoginViewModel : BaseViewModel
    {
       
            public bool IsLogin { get; set; }
            private string _UserName;
            public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
            private string _Password;
            public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }

            
            public ICommand LoginCommand { get; set; }
            public ICommand PasswordChangedCommand { get; set; }
            // mọi thứ xử lý sẽ nằm trong này
            public LoginViewModel()
            {
                IsLogin = false;
                Password = "";
                UserName = "";
                LoginCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { Login(p); });
               
                PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });
            }

            void Login(Window p)
            {
                if (p == null)
                return;


            //IsLogin = true;

            //     p.Close();

            /*
             admin
             admin
            
            staff
            staff
             */


            int accCount = DataProvider.Ins.DB.tblTaiKhoan.Where(x => x.TenDangNhap == UserName && x.MatKhau == Password).Count();

            if (accCount > 0)
            {
                IsLogin = true;

                p.Close();
            }
            else
            {
                IsLogin = false;
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

       

        

    }
}
