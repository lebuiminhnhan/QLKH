using QuanLiKhachHang.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Office.Interop.Excel;
namespace QuanLiKhachHang
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            app.WindowState = XlWindowState.xlMaximized;

            Workbook wb = app.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = wb.Worksheets[1];
           

            ws.Range["A1"].Value = "Mã Khách Hàng";
            ws.Range["B1"].Value = "Tên Khách Hàng";
            ws.Range["C1"].Value = "Giới Tính";
            ws.Range["D1"].Value = "Năm Sinh";
            ws.Range["E1"].Value = "Địa Chỉ";
            ws.Range["F1"].Value = "Số Điện Thoại";
            ws.Range["G1"].Value = "Email";
            ws.Range["H1"].Value = "CMND";
            ws.Range["I1"].Value = "Điểm Tích Lũy";
            ws.Range["J1"].Value = "Điểm Hiện Có";
            ws.Range["K1"].Value = "Loại Khách Hàng";
            int i = 2;
           
            foreach ( var item in DataProvider.Ins.DB.tblKhachHang.Where(x=>x.TrangThai != "Đã Xóa").ToList())
            {
                    ws.Range["A" +i].Value = item.MaKH;
                    ws.Range["B" + i].Value = item.HoTen;
                    ws.Range["C" + i].Value = item.GioiTinh;
                    ws.Range["D" + i].Value = item.NamSinh;
                    ws.Range["E" + i].Value = item.DiaChi;
                    ws.Range["F" + i].Value = item.SDT;
                    ws.Range["G" + i].Value = item.Email;
                    ws.Range["H" + i].Value = item.CMND;
                    ws.Range["I" + i].Value = item.DiemLuu;
                    ws.Range["J" + i].Value = item.DiemTichLuy;
                    ws.Range["K" + i].Value = item.LoaiKhachHang;
                    i++;
                if(i> DataProvider.Ins.DB.tblKhachHang.Where(x => x.TrangThai != "Đã Xóa").Count())
                {
                    break;
                }
                
            }
            Random n = new Random();
            int so = n.Next(9999);
            wb.SaveAs("D:\\ds"+so+".xlsx");
        }
    }
}
