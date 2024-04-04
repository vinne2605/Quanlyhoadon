using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuynhNhatVien_206.Model
{
    class CPhong
    {
        public string Maphong { get; set; }
        public int? Tinhtrang { get; set; }
        public string Maloai { get; set; }
        public static Phong chuyendoi(CPhong x)
        {
            if (x == null) return null;
            return new Phong
            {
                Maphong = x.Maphong,
                Tinhtrang = x.Tinhtrang,
                Maloai = x.Maloai,
            };
        }
        public static CPhong chuyendoi(Phong x)
        {
            if (x == null) return null;
            return new CPhong
            {
                Maphong = x.Maphong,
                Tinhtrang = x.Tinhtrang,
                Maloai = x.Maloai,
            };
        }
    }
}
