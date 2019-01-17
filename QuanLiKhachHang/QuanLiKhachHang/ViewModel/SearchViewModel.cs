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

        private ObservableCollection<tblLichSuGiaoDich> _LichSuGiaoDich;
        public ObservableCollection<tblLichSuGiaoDich> LichSuGiaoDich { get => _LichSuGiaoDich; set { _LichSuGiaoDich = value; OnPropertyChanged(); } }

        private ObservableCollection<ListKHnew> _List;
        public ObservableCollection<ListKHnew> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<ListTenUD> _ListUD;
        public ObservableCollection<ListTenUD> ListUD { get => _ListUD; set { _ListUD = value; OnPropertyChanged(); } }


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

        private int _DiemTich;
        public int DiemTich{ get => _DiemTich; set { _DiemTich = value; OnPropertyChanged(); } }
    
        private int _DiemLuu;
        public int DiemLuu { get => _DiemLuu; set { _DiemLuu = value; OnPropertyChanged(); } }

        private string _TenNV;
        public string TenNV { get => _TenNV; set { _TenNV = value; OnPropertyChanged(); } }


        private int _MaGD;
        public int MaGD { get => _MaGD; set { _MaGD = value; OnPropertyChanged(); } }
        private int _MaGDSP;
        public int MaGDSP { get => _MaGDSP; set { _MaGDSP = value; OnPropertyChanged(); } }

        private int _MaNVGD;
        public int MaNVGD { get => _MaNVGD; set { _MaNVGD = value; OnPropertyChanged(); } }

        private DateTime _NgayGiaoDich;
        public DateTime NgayGiaoDich { get => _NgayGiaoDich; set { _NgayGiaoDich = value; OnPropertyChanged(); } }

        private int _TienThanhToan;
        public int TienThanhToan { get => _TienThanhToan; set { _TienThanhToan = value; OnPropertyChanged(); } }

        private int _TienGiam;
        public int TienGiam { get => _TienGiam; set { _TienGiam = value; OnPropertyChanged(); } }

        private ObservableCollection<ListGDnew> _ListGD;
        public ObservableCollection<ListGDnew> ListGD { get => _ListGD; set { _ListGD = value; OnPropertyChanged(); } }


        private int _DiemTru;
        public int DiemTru { get => _DiemTru; set { _DiemTru = value; OnPropertyChanged(); } }

        private int _SoLuong;
        public int SoLuong { get => _SoLuong; set { _SoLuong = value; OnPropertyChanged(); } }


        private int _Key;
        public int Key { get => _Key; set { _Key = value; OnPropertyChanged(); } }

        public ICommand Scommand { get; set; }
        
   
        void LoadDL()
        {
            var query = from g in DataProvider.Ins.DB.tblGiaoDich
                        where g.MaKH == Key
                        select new ListKHnew
                        {
                            MaGD = g.MaGD,
                            TenNV = g.tblNhanVien.HoTen,
                            TienThanhToan = g.TienThanhToan,
                            TienGiam = g.TienGiam,
                            DiemTich = g.DiemTich,
                            DiemTru = g.DiemTru,
                            NgayGiaoDich = g.NgayGiaoDich
                        };
            var sp = from s in DataProvider.Ins.DB.tblSanPhamGiaoDich
                     where s.tblGiaoDich.MaKH == Key 
                     select new ListGDnew
                     {
                         MaGDS = s.MaGD,
                         TenSPs = s.tblSanPham.TenSP,
                         SL = s.SoLuong
                     };
            var ud = from s in DataProvider.Ins.DB.tblCoUuDai
                     where s.MaKH == Key
                     select new ListTenUD
                     {
                         TUD  = s.tblUuDai.TenUD
                     };
            ListGD = new ObservableCollection<ListGDnew>(sp);
            ListUD = new ObservableCollection<ListTenUD>(ud);
            List = new ObservableCollection<ListKHnew>(query);
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
            var Tongtien = DataProvider.Ins.DB.tblLichSuGiaoDich.Where(z=>z.MaKH == Key).GroupBy(x => x.MaKH).Select(group => new
            {
                MaKH = group.Key,
                Tien = group.Sum(y=>y.TongTienGD)
            }).ToList();
                
              
                
                if (KhachHangList.Count() != 0)
                {
                    foreach(var i in KhachHangList)
                    {
                        HoTen = i.HoTen;
                        SDT = i.SDT;
                        NamSinh = i.NamSinh;
                        LoaiKH = i.LoaiKhachHang;
                        DiaChi = i.DiaChi;
                        MaKH = i.MaKH;
                        DiemTichLuy = i.DiemTichLuy;
                      
                    }
                    foreach(var i in Tongtien)
                    {
                        DiemLuu = i.Tien;
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu");
                }

            });

        }
    }

    public class ListTenUD
    {
        public string TUD { get; set; }
    }

    public class ListGDnew
    {
        public int MaGDS { get; set; }
        public string TenSPs { get; set; }
        public int SL { get; set; }
    }
}
