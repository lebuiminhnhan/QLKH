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
    public class SearchViewModel : BaseViewModel
    {
        private ObservableCollection<tblKhachHang> _KhachHangList;
        public ObservableCollection<tblKhachHang> KhachHangList { get => _KhachHangList; set { _KhachHangList = value; OnPropertyChanged(); } }

    
        private string _HoTen;
        public string HoTen { get => _HoTen; set { _HoTen = value; OnPropertyChanged(); } }

        private string _CMND;
        public string CMND { get => _CMND; set { _CMND = value; OnPropertyChanged(); } }

        private DateTime _NamSinh;
        public DateTime NamSinh { get => _NamSinh; set { _NamSinh = value; OnPropertyChanged(); } }

        private string _GioiTinh;
        public string GioiTinh { get => _GioiTinh; set { _GioiTinh = value; OnPropertyChanged(); } }

        private string _SDT;
        public string SDT { get => _SDT; set { _SDT = value; OnPropertyChanged(); } }

        private string _Email;
        public string Email { get => _Email; set { _Email = value; OnPropertyChanged(); } }

        private string _DiaChi;
        public string DiaChi { get => _DiaChi; set { _DiaChi = value; OnPropertyChanged(); } }

        private string _LoaiKH;
        public string LoaiKH { get => _LoaiKH; set { _LoaiKH = value; OnPropertyChanged(); } }

        private int _MaKH;
        public int MaKH { get => _MaKH; set { _MaKH = value; OnPropertyChanged(); } }

        private int _DiemTichLuy;
        public int DiemTichLuy { get => _DiemTichLuy; set { _DiemTichLuy = value; OnPropertyChanged(); } }

        private int _DiemLuu;
        public int DiemLuu { get => _DiemLuu; set { _DiemLuu = value; OnPropertyChanged(); } }

        private int _Key;
        public int Key { get => _Key; set { _Key = value; OnPropertyChanged(); } }

        public ICommand Scommand { get; set; }
        
   
        void LoadDL()
        {
            KhachHangList = new ObservableCollection<tblKhachHang>(DataProvider.Ins.DB.tblKhachHang.Where(x => x.MaKH == Key));
        }
        
        public SearchViewModel()
        {
          
          

           

            Scommand = new RelayCommand<object>((p) =>
            {
                
                return true;

            }, (p) =>
            {
                LoadDL();
                if (KhachHangList.Count() != 0)
                {
                    foreach(var i in KhachHangList)
                    {
                        MessageBox.Show("Có dữ liệu : "+i.HoTen+"");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu");
                }

            });

        }
    }
}
