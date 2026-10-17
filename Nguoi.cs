using System;

namespace Lab03_OOPAdvanced
{
    public class Nguoi
    {
        public string HoTen { get; set; } = string.Empty;
        public DateTime NgaySinh { get; set; }

        public Nguoi(string hoTen, DateTime ngaySinh)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }

        public virtual string MoTa()
        {
            return $"{HoTen} - {NgaySinh:dd/MM/yyyy}";
        }
    }
}