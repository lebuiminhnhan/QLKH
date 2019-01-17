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
    public class GiaoDichViewModel : BaseViewModel
    {
        private ObservableCollection<ListKHnew> _List;
        public ObservableCollection<ListKHnew> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<tblSanPhamGiaoDich> _ListGD;
        public ObservableCollection<tblSanPhamGiaoDich> ListGD { get => _ListGD; set { _ListGD = value; OnPropertyChanged(); } }

        private ObservableCollection<tblNhanVien> _ListNV;
        public ObservableCollection<tblNhanVien> ListNV { get { return _ListNV; } set { _ListNV = value; OnPropertyChanged(); } }

        private tblNhanVien _SNV;
        public tblNhanVien SNV { get { return _SNV; } set { _SNV = value; OnPropertyChanged(); } }

        private ObservableCollection<tblKhachHang> _ListKH;
        public ObservableCollection<tblKhachHang> ListKH { get => _ListKH; set { _ListKH = value; OnPropertyChanged(); } }


        private ListKHnew _SelectedItem;
        public ListKHnew SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    MaGD = SelectedItem.MaGD;

                    NgayGiaoDich = SelectedItem.NgayGiaoDich;
                    DiemTichLuy = SelectedItem.DiemTich;
                    MaKH = SelectedItem.MaKH;
                    MaNVGD = SelectedItem.MaNV;
                    TienThanhToan = SelectedItem.TienThanhToan;
                    TienGiam = SelectedItem.TienGiam;
                    DiemTru = SelectedItem.DiemTru;
                }
            }
        }

        private tblSanPhamGiaoDich _SelectedItemSP;
        public tblSanPhamGiaoDich SelectedItemSP
        {
            get => _SelectedItemSP;
            set
            {
                _SelectedItemSP = value;
                OnPropertyChanged();
                if (SelectedItemSP != null)
                {
                    MaGDSP = SelectedItemSP.MaGD;

                    MaSP = SelectedItemSP.MaSP;

                    SoLuong = SelectedItemSP.SoLuong;
                }
            }
        }

        private int _MaSP;
        public int MaSP { get => _MaSP; set { _MaSP = value; OnPropertyChanged(); } }


        private int _MaKH;
        public int MaKH { get => _MaKH; set { _MaKH = value; OnPropertyChanged(); } }

        private string _TenKH;
        public string TenKH { get => _TenKH; set { _TenKH = value; OnPropertyChanged(); } }

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


        private int _DiemTichLuy;
        public int DiemTichLuy { get => _DiemTichLuy; set { _DiemTichLuy = value; OnPropertyChanged(); } }

        private int _DiemTru;
        public int DiemTru { get => _DiemTru; set { _DiemTru = value; OnPropertyChanged(); } }

        private int _SoLuong;
        public int SoLuong { get => _SoLuong; set { _SoLuong = value; OnPropertyChanged(); } }


        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public ICommand AddCommandSP { get; set; }
        public ICommand EditCommandSP { get; set; }
        public ICommand DeleteCommandSP { get; set; }
       

        private List<String> _property;
        public List<String> Property
        {
            get => new List<string>() { "Nam", "Nữ" };
            set
            {
                _property = value;
                OnPropertyChanged();
            }

        }

    
        public void LoadDL()
        {
            var query = from g in DataProvider.Ins.DB.tblGiaoDich
                        where g.TrangThai != "Đã Xóa"
                        select new ListKHnew
                        {
                            MaGD = g.MaGD,
                            TenKH = g.tblKhachHang.HoTen,
                            TenNV = g.tblNhanVien.HoTen,
                            TienThanhToan = g.TienThanhToan,
                            TienGiam = g.TienGiam,
                            DiemTich = g.DiemTich,
                            DiemTru = g.DiemTru,
                            NgayGiaoDich= g.NgayGiaoDich
                        };

            
            List = new ObservableCollection<ListKHnew>(query);
            ListNV = new ObservableCollection<tblNhanVien>(DataProvider.Ins.DB.tblNhanVien.OrderByDescending(x => x.MaNV));
            ListGD = new ObservableCollection<tblSanPhamGiaoDich>(DataProvider.Ins.DB.tblSanPhamGiaoDich.OrderByDescending(x=>x.MaGD));
        }
        public GiaoDichViewModel()
        {

            LoadDL();

            AddCommandSP = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(MaGD.ToString()))
                    return false;

                var displayList = DataProvider.Ins.DB.tblSanPhamGiaoDich.Where(x => x.MaGD == MaGD);
                if (displayList == null || displayList.Count() != 0)
                    return true;

                return true;

            }, (p) =>
            {
                var sp = new tblSanPhamGiaoDich();
                sp.MaGD = MaGD;
                sp.MaSP = MaSP;
                sp.SoLuong = SoLuong;

                DataProvider.Ins.DB.tblSanPhamGiaoDich.Add(sp);
                DataProvider.Ins.DB.SaveChanges();
                LoadDL();
                MessageBox.Show("Thêm sản phẩm vào giao dịch thành công!");
            });

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(MaGD.ToString()))
                    return false;

                var displayList = DataProvider.Ins.DB.tblGiaoDich.Where(x => x.MaGD == MaGD);
                if (displayList == null || displayList.Count() != 0)
                    return false;

                return true;

            }, (p) =>
            {
                var giaodich = new tblGiaoDich();
                giaodich.MaGD = MaGD;
                giaodich.MaKH = MaKH;
                giaodich.MaNV = MaNVGD;
                giaodich.TienThanhToan = TienThanhToan;
                giaodich.TienGiam = TienGiam;
                giaodich.DiemTich = DiemTichLuy;
                giaodich.DiemTru = DiemTru;
                giaodich.TrangThai = "Hoạt Động";
                giaodich.NgayGiaoDich = NgayGiaoDich;
               
                DataProvider.Ins.DB.tblGiaoDich.Add(giaodich);

                try
                {
                    DataProvider.Ins.DB.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }


                
                var lsgiaodich = new tblLichSuGiaoDich();
                lsgiaodich.MaGD = MaGD;
                lsgiaodich.MaKH = MaKH;
                lsgiaodich.TongTienGD = TienThanhToan;
                DataProvider.Ins.DB.tblLichSuGiaoDich.Add(lsgiaodich);

                var capnhat = DataProvider.Ins.DB.tblKhachHang.Where(x => x.MaKH == MaKH).SingleOrDefault();
                capnhat.DiemTichLuy = capnhat.DiemTichLuy - DiemTru;
                capnhat.DiemLuu = capnhat.DiemLuu + DiemTichLuy;
                capnhat.DiemTichLuy = capnhat.DiemTichLuy + DiemTichLuy;
                var uu = new tblCoUuDai();

                if(capnhat.DiemLuu >= 500)
                {
                    capnhat.LoaiKhachHang = "Premium";
                    uu.MaKH = MaKH;
                    uu.MaGD = MaGD;
                    uu.MaUD = 1;
                    DataProvider.Ins.DB.tblCoUuDai.Add(uu);
                    DataProvider.Ins.DB.SaveChanges();
                }
                if(capnhat.DiemLuu >= 300 && capnhat.DiemLuu<500)
                {
                    capnhat.LoaiKhachHang = "VIP";
                    uu.MaKH = MaKH;
                    uu.MaGD = MaGD;
                    uu.MaUD = 4;
                    DataProvider.Ins.DB.tblCoUuDai.Add(uu);
                    DataProvider.Ins.DB.SaveChanges();
                }
                if (capnhat.DiemLuu > 100 && capnhat.DiemLuu <300)
                {
                    capnhat.LoaiKhachHang = "Thân Thiết";
                    uu.MaKH = MaKH;
                    uu.MaGD = MaGD;
                    uu.MaUD = 3;
                    DataProvider.Ins.DB.tblCoUuDai.Add(uu);
                    DataProvider.Ins.DB.SaveChanges();
                }
                if(sn(capnhat.NamSinh,NgayGiaoDich)==true)
                {
                    uu.MaKH = MaKH;
                    uu.MaGD = MaGD;
                    uu.MaUD = 2;
                    DataProvider.Ins.DB.tblCoUuDai.Add(uu);
                    DataProvider.Ins.DB.SaveChanges();
                }
                DataProvider.Ins.DB.SaveChanges();
                LoadDL();
                MessageBox.Show("Thêm giao dịch thành công!");
                SelectedItem = null;
                TienThanhToan = 0;
                MaNVGD = 0;
                MaGD = 0;
                MaKH = 0;
                TienGiam = 0;
                DiemTru = 0;
                DiemTichLuy = 0;
                NgayGiaoDich = DateTime.Now;
            });


            EditCommandSP = new RelayCommand<object>((p) =>
            {
                if (SelectedItemSP == null)
                    return false;

                var displayList = DataProvider.Ins.DB.tblSanPhamGiaoDich.Where(x => x.MaGD == MaGDSP);
                if (displayList == null || displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var sp = DataProvider.Ins.DB.tblSanPhamGiaoDich.Where(x => x.MaGD == SelectedItemSP.MaGD).SingleOrDefault();
                sp.MaGD = SelectedItem.MaGD;
                sp.MaSP = MaSP;
                sp.SoLuong = SoLuong;

              
                DataProvider.Ins.DB.SaveChanges();
                SelectedItemSP.MaGD = MaGDSP;
                SelectedItemSP.MaSP = MaSP;
                SelectedItemSP.SoLuong = SoLuong;

                LoadDL();
                MessageBox.Show("Sửa sản phẩm vào giao dịch thành công!");
                SelectedItem = null;
                MaGD = 0;
                MaSP = 0;
                SoLuong = 0;
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.tblGiaoDich.Where(x => x.MaGD == MaGD);
                if (displayList == null || displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var giaodich = DataProvider.Ins.DB.tblSanPhamGiaoDich.Where(x => x.MaGD == SelectedItem.MaGD).SingleOrDefault();
                var sp = new tblSanPhamGiaoDich();
                sp.MaGD = giaodich.MaGD;
                sp.MaSP = 

                DataProvider.Ins.DB.SaveChanges();
                SelectedItem.MaGD = MaGD;
                
                
                LoadDL();
                MessageBox.Show("Sửa giao dịch thành công!");
                SelectedItem = null;
                TienThanhToan = 0;
                MaNVGD = 0;
                MaGD = 0;
                MaKH = 0;
                TienGiam = 0;
                DiemTru = 0;
                DiemTichLuy = 0;
                NgayGiaoDich = DateTime.Now;
            });

            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.tblGiaoDich.Where(x => x.MaGD == MaGD);
                if (displayList == null || displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var giaodich = DataProvider.Ins.DB.tblGiaoDich.Where(x => x.MaGD == SelectedItem.MaGD).SingleOrDefault();
                giaodich.TrangThai = "Đã Xóa";

                DataProvider.Ins.DB.SaveChanges();
                SelectedItem.MaGD = MaGD;
                SelectedItem.MaKH = MaKH;
                SelectedItem.MaNV = MaNVGD;
                SelectedItem.TienGiam = TienGiam;
                SelectedItem.TienThanhToan = TienThanhToan;
                SelectedItem.DiemTich = DiemTichLuy;
                SelectedItem.DiemTru = DiemTru;
                SelectedItem.NgayGiaoDich = NgayGiaoDich;

                LoadDL();
                MessageBox.Show("Xóa giao dịch thành công!");
                SelectedItem = null;
                TienThanhToan = 0;
                MaNVGD = 0;
                MaGD = 0;
                MaKH = 0;
                TienGiam = 0;
                DiemTru = 0;
                DiemTichLuy = 0;
                NgayGiaoDich = DateTime.Now;
            });
        }
        public bool sn(DateTime n1, DateTime n2)
        {
            if (n1.Day == n2.Day && n1.Month == n2.Month)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
    public class ListKHnew
    {
        public int MaGD { get; set; }
        public string TenKH { get; set; }
        public string TenNV { get; set; }
        public int TienThanhToan { get; set; }
        public int TienGiam { get; set; }
        public int DiemTich { get; set; }
        public int MaKH { get; set; }
        public int MaNV { get; set; }
        public int DiemTru { get; set; }
        public DateTime NgayGiaoDich { get; set; }
    }
}
