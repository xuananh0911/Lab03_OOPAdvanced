using System;

namespace Lab03_OOPAdvanced
{
    public interface IPayment
    {
        bool ThucHienThanhToan(decimal soTien);
    }

    public class ThanhToanTienMat : IPayment
    {
        public bool ThucHienThanhToan(decimal soTien)
        {
            Console.WriteLine($"Đã thanh toán {soTien:N0} VNĐ bằng tiền mặt.");
            return true;
        }
    }

    public class ChuyenKhoan : IPayment
    {
        public bool ThucHienThanhToan(decimal soTien)
        {
            Console.WriteLine($"Đã thanh toán {soTien:N0} VNĐ qua chuyển khoản ngân hàng.");
            return true;
        }
    }

    public class ViDienTu : IPayment
    {
        public bool ThucHienThanhToan(decimal soTien)
        {
            Console.WriteLine($"Đã thanh toán {soTien:N0} VNĐ qua Ví điện tử.");
            return true;
        }
    }
}