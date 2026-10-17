using System;

namespace Lab03_OOPAdvanced
{
    public class TaiLieu
    {
        public string MaTL { get; set; } = string.Empty;
        public string TenTL { get; set; } = string.Empty;
        public virtual void HienThi() => Console.WriteLine($"Mã: {MaTL} - Tên: {TenTL}");
    }

    public class Sach : TaiLieu { public int SoTrang { get; set; } }
    public class TapChi : TaiLieu { public int SoPhatHanh { get; set; } }
    public class LuanVan : TaiLieu { public string ChuyenNganh { get; set; } = string.Empty; }
}