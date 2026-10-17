using System;

namespace Lab03_OOPAdvanced
{
    public abstract class NhanVien
    {
        public string HoTen { get; set; } = string.Empty;
        public abstract decimal TinhLuong();
    }

    public class NhanVienVanPhong : NhanVien
    {
        public decimal LuongCoDinh { get; set; }
        public override decimal TinhLuong() => LuongCoDinh;
    }

    public class NhanVienKinhDoanh : NhanVien
    {
        public decimal LuongCoBan { get; set; }
        public decimal DoanhSo { get; set; }
        public override decimal TinhLuong() => LuongCoBan + (DoanhSo * 0.1m);
    }

    public class GiangVien : NhanVien
    {
        public int SoTietDay { get; set; }
        public decimal DonGiaTiet { get; set; }
        public override decimal TinhLuong() => SoTietDay * DonGiaTiet;
    }
}