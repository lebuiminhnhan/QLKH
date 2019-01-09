using QuanLiKhachHang.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLiKhachHang.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<tblKhachHang> _KhachHangList;
        public ObservableCollection<tblKhachHang> KhachHangList { get => _KhachHangList; set { _KhachHangList = value; OnPropertyChanged(); } }

        private int _Tam;
        public int Tam { get => _Tam; set { _Tam = value; OnPropertyChanged(); } }

        private int _SLGD;
        public int SLGD { get => _SLGD; set { _SLGD = value; OnPropertyChanged(); } }

        private int _TongThu;
        public int TongThu { get => _TongThu; set { _TongThu = value; OnPropertyChanged(); } }

        public bool Isloaded = false;
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand Refresh { get; set; }
        public ICommand CustomerCommand { get; set; }
        public ICommand GiaoDichCommand { get; set; }
        // mọi thứ xử lý sẽ nằm trong này
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                Isloaded = true;
                if (p == null)
                    return;
                p.Hide();
                LoginForm loginWindow = new LoginForm();
                loginWindow.ShowDialog();
               
                if (loginWindow.DataContext == null)
                    return;
                var loginVM = loginWindow.DataContext as LoginViewModel;

                if (loginVM.IsLogin)
                {
                    p.Show();
                    LoadDL();
                    
                }
                else
                {
                    p.Close();
                }
            }
              );

            CustomerCommand = new RelayCommand<object>((p) => { return true; }, (p) => { AddCustomer wd = new AddCustomer(); wd.ShowDialog(); });
            GiaoDichCommand = new RelayCommand<object>((p) => { return true; }, (p) => { GiaoDichWindow wd = new GiaoDichWindow(); wd.ShowDialog(); });
            Refresh = new RelayCommand<object>((p) => { return true; }, (p) => { LoadDL(); });

            // MessageBox.Show(DataProvider.Ins.DB.tblKhachHang.Select(x => x.HoTen).First());
        }
       
        public void LoadDL()
        {
           
            KhachHangList = new ObservableCollection<tblKhachHang>(DataProvider.Ins.DB.tblKhachHang.OrderByDescending(x=>x.MaKH).Where(x => x.TrangThai != "Đã Xóa"));
            SLGD = DataProvider.Ins.DB.tblGiaoDich.Count();
            Tam = KhachHangList.Count();
            TongThu = DataProvider.Ins.DB.tblGiaoDich.Sum(x => x.TienThanhToan);
        }
            

    }
}
