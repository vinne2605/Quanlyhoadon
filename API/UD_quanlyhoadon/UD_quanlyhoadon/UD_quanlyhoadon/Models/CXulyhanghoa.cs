using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows;

namespace UD_quanlyhoadon.Models
{
    internal class CXulyhanghoa
    {
        public static List<CHanghoa> getDshanghoa()
        {
            try 
            {
                HttpClient hc = new HttpClient();
                string strUrl = @"https://localhost:7084/api/HangHoa";
                var con = hc.GetAsync(strUrl);
                con.Wait();
                if (con.Result.IsSuccessStatusCode == false)
                    return null;
                var kq=con.Result.Content.ReadFromJsonAsync<List<CHanghoa>>();
                kq.Wait();
                return kq.Result;   
            }
            catch (Exception) {
                return null;
            }
        }
        public static bool themHanghoa(CHanghoa x)
        {
            try
            {
                HttpClient hc = new HttpClient();
                string strUrl = @"https://localhost:7084/api/HangHoa";
                var con = hc.PostAsJsonAsync<CHanghoa>(strUrl, x);
                con.Wait();
                return con.Result.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool xoaHanghoa(string mahang)
        {
            try
            {
                HttpClient hc = new HttpClient();
                string strUrl = @"https://localhost:7084/api/HangHoa";
                var con = hc.DeleteAsync(strUrl);
                con.Wait();
                return con.Result.IsSuccessStatusCode;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool SuaHanghoa(CHanghoa x)
        {
            try
            {
                HttpClient hc = new HttpClient();
                string strUrl = @"https://localhost:7011/api/Hanghoa";
                var con = hc.PostAsJsonAsync<CHanghoa>(strUrl, x);
                con.Wait();
                return con.Result.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
