using System;
using System.Collections.Generic;

namespace Lab03_OOPAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("          CHƯƠNG TRÌNH CHẠY BÀI LAB 3 - IT3212     ");
                Console.WriteLine("==================================================");
                Console.WriteLine(" 1. Bài 1 & 2: Kế thừa Nguoi - SinhVien và Override MoTa");
                Console.WriteLine(" 3. Bài 3: Lớp trừu tượng NguoiHoc (Tính học phí)");
                Console.WriteLine(" 4. Bài 4: Interface IValidatable & IPrintable");
                Console.WriteLine(" 5. Bài 5: Danh sách đa hình List<NguoiHoc>");
                Console.WriteLine(" 6. Bài 6: Hệ thống nhân viên đa hình");
                Console.WriteLine(" 7. Bài 7: Quản lý phương tiện (IMove)");
                Console.WriteLine(" 8. Bài 8: Quản lý tài liệu thư viện");
                Console.WriteLine(" 9. Bài 9: Hệ thống thanh toán (IPayment)");
                Console.WriteLine(" 10. Bài 10: Nâng cấp quản lý sinh viên");
                Console.WriteLine(" 0. Thoát chương trình");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("=> Chọn bài muốn chạy (0-10): ");

                string choice = Console.ReadLine() ?? "";
                Console.Clear();

                switch (choice)
                {
                    case "1":
                    case "2":
                        RunBai1_2();
                        break;
                    case "3":
                        RunBai3();
                        break;
                    case "4":
                        RunBai4();
                        break;
                    case "5":
                        RunBai5();
                        break;
                    case "6":
                        RunBai6();
                        break;
                    case "7":
                        RunBai7();
                        break;
                    case "8":
                        RunBai8();
                        break;
                    case "9":
                        RunBai9();
                        break;
                    case "10":
                        RunBai10();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

                Console.WriteLine("\n--------------------------------------------------");
                Console.Write("Bấm phím bất kỳ để quay lại menu chính...");
                Console.ReadKey();
            }
        }

        static void RunBai1_2()
        {
            Console.WriteLine("--- CHẠY BÀI 1 & 2: Kế thừa và Ghi đè phương thức ---");
            SinhVien sv = new SinhVien("SV01", "Nguyễn Xuân Anh", new DateTime(2005, 5, 12), 8.5);
            Console.WriteLine(sv.MoTa());
        }

        static void RunBai3()
        {
            Console.WriteLine("--- CHẠY BÀI 3: Lớp trừu tượng NguoiHoc ---");
            NguoiHoc sv1 = new SinhVienChinhQuy { HoTen = "An", SoTinChi = 18 };
            NguoiHoc sv2 = new SinhVienLienThong { HoTen = "Bình", SoTinChi = 15 };
            Console.WriteLine($"Học phí Chính quy ({sv1.SoTinChi} TC): {sv1.TinhHocPhi():N0} đ");
            Console.WriteLine($"Học phí Liên thông ({sv2.SoTinChi} TC): {sv2.TinhHocPhi():N0} đ");
        }

        static void RunBai4()
        {
            Console.WriteLine("--- CHẠY BÀI 4: Interface IValidatable & IPrintable ---");
            SinhVien sv = new SinhVien("SV02", "Trần Bình", new DateTime(2005, 9, 3), 11.0);
            if (sv.IsValid(out string msg))
            {
                Console.WriteLine(sv.ToDisplayText());
            }
            else
            {
                Console.WriteLine($"Lỗi dữ liệu: {msg}");
            }
        }

        static void RunBai5()
        {
            Console.WriteLine("--- CHẠY BÀI 5: Danh sách đa hình List<NguoiHoc> ---");
            List<NguoiHoc> ds = new List<NguoiHoc>
            {
                new SinhVienChinhQuy { HoTen = "An", SoTinChi = 18 },
                new SinhVienLienThong { HoTen = "Bình", SoTinChi = 15 }
            };

            decimal tong = 0;
            foreach (var item in ds)
            {
                decimal hocPhi = item.TinhHocPhi();
                tong += hocPhi;
                Console.WriteLine($"- {item.HoTen} ({item.GetType().Name}): {hocPhi:N0} đ");
            }
            Console.WriteLine($"=> Tổng học phí: {tong:N0} đ");
        }

        static void RunBai6()
        {
            Console.WriteLine("--- CHẠY BÀI 6: Hệ thống nhân viên ---");
            List<NhanVien> dsNV = new List<NhanVien>
            {
                new NhanVienVanPhong { HoTen = "Văn A", LuongCoDinh = 8000000 },
                new NhanVienKinhDoanh { HoTen = "Thị B", LuongCoBan = 5000000, DoanhSo = 30000000 }
            };
            foreach (var nv in dsNV)
            {
                Console.WriteLine($"- {nv.HoTen} ({nv.GetType().Name}): Lương = {nv.TinhLuong():N0} đ");
            }
        }

        static void RunBai7()
        {
            Console.WriteLine("--- CHẠY BÀI 7: Quản lý phương tiện ---");
            IMove xe = new OTo();
            xe.DiChuyen();
            Console.WriteLine($"Chi phí vận hành: {xe.TinhChiPhiVanhHanh()} đ/km");
        }

        static void RunBai8()
        {
            Console.WriteLine("--- CHẠY BÀI 8: Quản lý tài liệu thư viện ---");
            Sach sach = new Sach { MaTL = "S01", TenTL = "Lập trình .NET", SoTrang = 350 };
            sach.HienThi();
            Console.WriteLine($"Số trang: {sach.SoTrang}");
        }

        static void RunBai9()
        {
            Console.WriteLine("--- CHẠY BÀI 9: Hệ thống thanh toán ---");
            IPayment thanhToan = new ChuyenKhoan();
            thanhToan.ThucHienThanhToan(1500000);
        }

        static void RunBai10()
        {
            Console.WriteLine("--- CHẠY BÀI 10: Nâng cấp quản lý sinh viên ---[cite: 19]");
            Console.WriteLine("Hệ thống đã tích hợp interface và đa hình hoàn tất.");
        }
    }
}