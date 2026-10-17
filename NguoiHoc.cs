using System;

namespace Lab03_OOPAdvanced
{
    // Bài 3: Lớp trừu tượng NguoiHoc
    public abstract class NguoiHoc
    {
        public string HoTen { get; set; } = string.Empty;
        public int SoTinChi { get; set; }
        public abstract decimal TinhHocPhi();
    }

    public class SinhVienChinhQuy : NguoiHoc
    {
        public override decimal TinhHocPhi()
        {
            return SoTinChi * 450000m;
        }
    }

    public class SinhVienLienThong : NguoiHoc
    {
        public override decimal TinhHocPhi()
        {
            return SoTinChi * 520000m;
        }
    }
}