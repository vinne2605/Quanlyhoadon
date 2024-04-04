namespace webapi_hoadon.Models
{
    public class CHanghoa
    {
        public string Mahang { get; set; } = null!;
        public string? Tenhang { get; set; }
        public string? Dvt { get; set; }
        public double? Dongia { get; set; }
        public static CHanghoa chuyendoi(Hanghoa x)
        {
            if (x == null) return null;
            return new CHanghoa
            {
                Mahang = x.Mahang,
                Tenhang = x.Tenhang,
                Dvt = x.Dvt,
                Dongia = x.Dongia,
            };
        }
        public static Hanghoa chuyendoi(CHanghoa x)
        {
            if (x == null) return null;
            return new Hanghoa
            {
                Mahang = x.Mahang,
                Tenhang = x.Tenhang,
                Dvt = x.Dvt,
                Dongia = x.Dongia,
            };
        }
    }
}
