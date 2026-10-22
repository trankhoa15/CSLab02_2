using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab02_2_Baitap2
{
    struct HangHoa{
        public int MaHH;
        public string TenHH;
        public int SoLuong;
        public double DonGia;

        // Constructor
        public HangHoa(int ma, string ten, int soLuong, double donGia){
            MaHH = ma;
            TenHH = ten;
            SoLuong = soLuong;
            DonGia = donGia;
        }
        public double ThanhTien(){
            return SoLuong * DonGia;
        }

        public override string ToString(){
            return string.Format("{0} - {1} - {2} cai x {3:N0} đ = {4:N0} đ",
                MaHH, TenHH, SoLuong, DonGia, ThanhTien());
        }
    }
    internal class Program
    {
        static void ThemMatHang(List<HangHoa> ds, HangHoa hh)
        {
            ds.Add(hh);
        }

        static bool TimMatHang(List<HangHoa> ds, int maHH)
        {
            foreach (var item in ds)
            {
                if (item.MaHH == maHH) return true;
            }
            return false;
        }

        static void XuatDanhSach(List<HangHoa> ds)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("Danh sach trong.");
                return;
            }
            Console.WriteLine("\n--- DANH SACH MAT HANG ---");
            foreach (var hh in ds)
            {
                Console.WriteLine(hh);
            }
            Console.WriteLine("---------------------------\n");
        }

        static void XoaMatHang(List<HangHoa> ds, int maHH)
        {
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaHH == maHH)
                {
                    ds.RemoveAt(i);
                    Console.WriteLine($"Da xoa mat hang co ma {maHH}");
                    return;
                }
            }
        }
        static void Main(string[] args)
        {
            List<HangHoa> danhSach = new List<HangHoa>();
            string tiepTuc = "y";
            Console.WriteLine("=== NHAP DANH SACH MAT HANG ===");
            while (tiepTuc.ToLower() == "y"){
                Console.Write("Nhap Ma HH: ");
                int ma = int.Parse(Console.ReadLine());

                Console.Write("Nhap Ten HH: ");
                string ten = Console.ReadLine();

                Console.Write("Nhap So Luong: ");
                int sl = int.Parse(Console.ReadLine());

                Console.Write("Nhap Don Gia: ");
                double gia = double.Parse(Console.ReadLine());

                HangHoa hh = new HangHoa(ma, ten, sl, gia);
                ThemMatHang(danhSach, hh);

                Console.Write("Co tiep tuc nhap khong? (y/n): ");
                tiepTuc = Console.ReadLine();
                Console.WriteLine();
            }
            XuatDanhSach(danhSach);
            Console.Write("Nhap Ma HH can tim va xoa: ");
            int maCanXoa = int.Parse(Console.ReadLine());

            if (TimMatHang(danhSach, maCanXoa)){
                Console.WriteLine($"Tim thay mat hang ma {maCanXoa}!");
                XoaMatHang(danhSach, maCanXoa);
                Console.WriteLine("\nDanh sach sau khi xoa:");
                XuatDanhSach(danhSach);
            }
            else{
                Console.WriteLine($"Khong tim thay mat hang co ma {maCanXoa}.");
            }
            Console.ReadLine();
        }
    }
}
