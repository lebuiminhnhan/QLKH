using System;
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
using System.Windows.Shapes;

namespace QuanLiKhachHang
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }
        QLKHDataContext db = new QLKHDataContext();
        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
           
            MainWindow m = new MainWindow();
           
            try
            {
                if(db.tblTaiKhoans.Where(x=>x.TenDangNhap == usernamebox.Text && x.MatKhau == PasswordBox.Password).FirstOrDefault() != null)
                {
                   
                    m.ShowDialog();
                    loginform.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
            catch ( Exception)
            {
               
            }
        }

        private void BtnThoat_Click(object sender, RoutedEventArgs e)
        {
            loginform.Close();
        }
    }
}
