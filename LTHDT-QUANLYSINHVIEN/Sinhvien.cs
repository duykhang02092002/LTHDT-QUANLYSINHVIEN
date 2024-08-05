// SinhVien.cs
using System;

public class SinhVien
{
    public string HoTen { get; set; }
    public DiaChi DiaChi { get; set; }
    public string MaSinhVien { get; set; }
    public string SoCMND { get; set; }
    public float DiemTrungBinh { get; set; }

    public SinhVien(string hoTen, DiaChi diaChi, string maSinhVien, string soCMND, float diemTrungBinh)
    {
        HoTen = hoTen;
        DiaChi = diaChi;
        MaSinhVien = maSinhVien;
        SoCMND = soCMND;
        DiemTrungBinh = diemTrungBinh;
    }

    public override string ToString()
    {
        return $"Họ tên: {HoTen}, Địa chỉ: {DiaChi}, Mã sinh viên: {MaSinhVien}, Số CMND: {SoCMND}, Điểm trung bình: {DiemTrungBinh}";
    }
}
