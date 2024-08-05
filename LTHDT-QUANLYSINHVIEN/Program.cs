
// Program.cs
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        // Nhập thông tin sinh viên
        int soSinhVien = 0;
        Console.Write("Nhập số lượng sinh viên: ");
        if (int.TryParse(Console.ReadLine(), out soSinhVien) && soSinhVien > 0)
        {
            for (int i = 0; i < soSinhVien; i++)
            {
                Console.WriteLine($"\nNhập thông tin cho sinh viên thứ {i + 1}:");

                Console.Write("Họ tên: ");
                string hoTen = Console.ReadLine();

                Console.Write("Số nhà: ");
                string soNha = Console.ReadLine();

                Console.Write("Tên đường: ");
                string tenDuong = Console.ReadLine();

                Console.Write("Quận: ");
                string quan = Console.ReadLine();

                Console.Write("Thành phố: ");
                string thanhPho = Console.ReadLine();

                DiaChi diaChi = new DiaChi(soNha, tenDuong, quan, thanhPho);

                Console.Write("Mã sinh viên: ");
                string maSinhVien = Console.ReadLine();

                Console.Write("Số CMND: ");
                string soCMND = Console.ReadLine();

                Console.Write("Điểm trung bình: ");
                float diemTrungBinh;
                while (!float.TryParse(Console.ReadLine(), out diemTrungBinh) || diemTrungBinh < 0)
                {
                    Console.Write("Điểm trung bình không hợp lệ, vui lòng nhập lại: ");
                }

                SinhVien sinhVien = new SinhVien(hoTen, diaChi, maSinhVien, soCMND, diemTrungBinh);
                danhSachSinhVien.Add(sinhVien);
            }
        }
        else
        {
            Console.WriteLine("Số lượng sinh viên không hợp lệ.");
            return;
        }

        // Hiển thị thông tin sinh viên
        Console.WriteLine("\nDanh sách sinh viên:");
        foreach (var sv in danhSachSinhVien)
        {
            Console.WriteLine(sv);
        }

        // Sắp xếp danh sách sinh viên theo điểm trung bình
        danhSachSinhVien = danhSachSinhVien.OrderBy(sv => sv.DiemTrungBinh).ToList();

        // Hiển thị danh sách sinh viên đã sắp xếp
        Console.WriteLine("\nDanh sách sinh viên sau khi sắp xếp theo điểm trung bình:");
        foreach (var sv in danhSachSinhVien)
        {
            Console.WriteLine(sv);
        }
    }
}
