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
using UD_quanlyhoadon.Models;

namespace UD_quanlyhoadon.UI
{
    /// <summary>
    /// Interaction logic for WindowHanghoa.xaml
    /// </summary>
    public partial class WindowHanghoa : Window
    {
        public WindowHanghoa()
        {
            InitializeComponent();
        }
        private void hienthi()
        {
            List<CHanghoa> ds =  CXulyhanghoa.getDshanghoa();
            if (ds == null)
                MessageBox.Show("LOI KET NOI");
            else dgHanghoa.ItemsSource = ds;

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            hienthi();
        }

        private void dgHanghoa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gridHanghoa.DataContext = dgHanghoa.SelectedItem;

        }

        private void lenhThem_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CHanghoa x=gridHanghoa.DataContext as CHanghoa;
            bool ok = CXulyhanghoa.themHanghoa(x);
            if (ok == false)
                MessageBox.Show("Loi khi them!");
            else hienthi();
        }

        private void lenhThem_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void lenhXoa_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CHanghoa x = gridHanghoa.DataContext as CHanghoa;
            bool ok = CXulyhanghoa.xoaHanghoa(x.Mahang);
            if (ok == false)
                MessageBox.Show("Lỗi khi xóa !");
            else
                hienthi();
        }

        private void lenhXoa_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void lenhSua_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CHanghoa x = gridHanghoa.DataContext as CHanghoa;
            bool ok = CXulyhanghoa.SuaHanghoa(x);
            if (ok == false)
                MessageBox.Show("Lỗi khi sua !");
            else
                hienthi();
        }

        private void lenhSua_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute=true;
        }
    }
}
