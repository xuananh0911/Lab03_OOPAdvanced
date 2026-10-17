using System;

namespace Lab03_OOPAdvanced
{
    public interface IMove
    {
        void DiChuyen();
        double TinhChiPhiVanhHanh();
    }

    public class XeMay : IMove
    {
        public void DiChuyen() => Console.WriteLine("Xe máy chạy bằng xăng trên đường bộ.");
        public double TinhChiPhiVanhHanh() => 1500; // VNĐ/km
    }

    public class OTo : IMove
    {
        public void DiChuyen() => Console.WriteLine("Ô tô chạy tốc độ cao trên cao tốc.");
        public double TinhChiPhiVanhHanh() => 3500;
    }

    public class XeDap : IMove
    {
        public void DiChuyen() => Console.WriteLine("Xe đạp di chuyển bằng sức người.");
        public double TinhChiPhiVanhHanh() => 0;
    }
}