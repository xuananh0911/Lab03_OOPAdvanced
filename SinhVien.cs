using System;

namespace Lab03_OOPAdvanced
{
    public class SinhVien : Nguoi, IValidatable, IPrintable
    {
        public string MaSV { get; set; } = string.Empty;
        public double DiemTB { get; set; }

        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, double diemTB) : base(hoTen, ngaySinh)
        {
            MaSV = maSV;
            DiemTB = diemTB;
        }

        public override string MoTa()
        {
            return $"{base.MoTa()} - Mã: {MaSV} - Điểm TB: {DiemTB:N2}";
        }

        public bool IsValid(out string message)
        {
            if (string.IsNullOrWhiteSpace(MaSV)) { message = "Thiếu mã sinh viên"; return false; }
            if (DiemTB < 0 || DiemTB > 10) { message = "Điểm TB không hợp lệ"; return false; }
            message = "Dữ liệu hợp lệ";
            return true;
        }

        public string ToDisplayText()
        {
            return $"{MaSV} - {HoTen}";
        }
    }
}