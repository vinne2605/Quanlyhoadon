using HuynhNhatVien_206.Model;
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

namespace HuynhNhatVien_206
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void hienthi()
        {
            csdl_thuephongContext db=new csdl_thuephongContext();
            dgPhong.ItemsSource = db.Phongs.Select(t=>new
            {
                Maphong=t.Maphong,
                Tinhtrang=t.Tinhtrang,
                Maloai=t.Maloai,
            }).ToList();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            csdl_thuephongContext db = new csdl_thuephongContext();
            cmdMaloai.ItemsSource = db.Loaiphongs.ToList();
            hienthi();
        }

        private void lenhThem_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            csdl_thuephongContext db = new csdl_thuephongContext();
            CPhong x = gridPhong.DataContext as CPhong;
            //Phong a = CPhong.chuyendoi(x);
            Phong a = new Phong
            {
                Maphong = x.Maphong,
                Tinhtrang = x.Tinhtrang,
                Maloai = cmdMaloai.SelectedValue.ToString(),
            };
            db.Phongs.Add(a);
            db.SaveChanges();
            hienthi();
        }

        private void lenhThem_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
