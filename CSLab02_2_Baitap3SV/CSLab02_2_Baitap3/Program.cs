using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab02_2_Baitap3SV
{
    class SinhVien
    {
        public int MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public int Tuoi
        {
            get {return DateTime.Now.Year - NgaySinh.Year;}
        }

        // Constructor ko tham số
        public SinhVien() { }
        // Constructor có tham số
        public SinhVien(int maSV, string hoTen, DateTime ngaySinh, string diaChi, string dienThoai)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            DienThoai = dienThoai;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} sinh {2}, {3} tuoi, SDT: {4}, ĐC: {5}.",
                MaSV, HoTen, NgaySinh.ToString("dd/MM/yyyy"), Tuoi, DienThoai, DiaChi);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> dssv = new List<SinhVien>();

            // Khởi tạo sử dụng Object Initializer
            dssv.Add(new SinhVien
            {
                MaSV = 1,
                HoTen = "Tran Van Teo",
                DienThoai = "0909789567",
                DiaChi = "123 Truong Dinh",
                NgaySinh = new DateTime(2000, 11, 28)
            });

            // Khởi tạo bằng constructor có tham số
            dssv.Add(new SinhVien(2, "Tran Van Quang", new DateTime(1999, 11, 28), "123 Truong Cong Dinh", "0909567789"));

            Console.WriteLine("=== DANH SACH SINH VIEN ===");
            foreach (SinhVien sv in dssv)
            {
                Console.WriteLine(sv);
            }

            Console.ReadLine();
        }
    }
}
