// DiaChi.cs
public struct DiaChi
{
    public string SoNha { get; set; }
    public string TenDuong { get; set; }
    public string Quan { get; set; }
    public string ThanhPho { get; set; }

    public DiaChi(string soNha, string tenDuong, string quan, string thanhPho)
    {
        SoNha = soNha;
        TenDuong = tenDuong;
        Quan = quan;
        ThanhPho = thanhPho;
    }

    public override string ToString()
    {
        return $"{SoNha}, {TenDuong}, {Quan}, {ThanhPho}";
    }
}
