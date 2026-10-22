using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab02_2_Baitap3SP
{
    class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public double Gia { get; set; }
        public SanPham() { }
        public SanPham(string ma, string ten, double gia)
        {
            MaSP = ma;
            TenSP = ten;
            Gia = gia;
        }
        //tính thuế
        public double TinhThueVAT()
        {
            return Gia * 0.1;
        }
        public void Nhap()
        {
            Console.Write("Nhap ma san pham: ");
            MaSP = Console.ReadLine();

            Console.Write("Nhap ten san pham: ");
            TenSP = Console.ReadLine();

            Console.Write("Nhap gia san pham: ");
            Gia = double.Parse(Console.ReadLine());
        }
        //xuất thông tin
        public void Xuat()
        {
            Console.WriteLine($"Ma SP: {MaSP} | Ten SP: {TenSP} | Gia: {Gia:N0} đ | Thue VAT: {TinhThueVAT():N0} đ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== NHAP THONG TIN 2 SAN PHAM ===");

            // Tạo đối tượng sản phẩm 1
            Console.WriteLine("\n[Nhap San Pham 1]");
            SanPham sp1 = new SanPham();
            sp1.Nhap();

            // Tạo đối tượng sản phẩm 2
            Console.WriteLine("\n[Nhap San Pham 2]");
            SanPham sp2 = new SanPham();
            sp2.Nhap();

            // Gọi phương thức xuất
            Console.WriteLine("\n=== THONG TIN CAC SAN PHAM VUA NHAP ===");
            sp1.Xuat();
            sp2.Xuat();

            Console.ReadLine();
        }
    }
}
