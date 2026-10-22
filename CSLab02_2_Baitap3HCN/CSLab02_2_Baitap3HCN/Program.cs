using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab02_2_Baitap3HCN
{
    class HinhChuNhat
    {
        private double mChieuCao;
        private double mChieuRong;
        // Constructor ko tham số
        public HinhChuNhat()
        {
            mChieuCao = 0;
            mChieuRong = 0;
        }
        // Constructor có tham số
        public HinhChuNhat(double chieuCao, double chieuRong)
        {
            mChieuCao = chieuCao;
            mChieuRong = chieuRong;
        }
        public double ChieuCao
        {
            get { return mChieuCao; }
            set { mChieuCao = value; }
        }
        public double ChieuRong
        {
            get { return mChieuRong; }
            set { mChieuRong = value; }
        }
        //tính chu vi
        public double TinhChuVi()
        {
            return (mChieuCao + mChieuRong) * 2;
        }
        //tính diện tích
        public double TinhDienTich()
        {
            return mChieuCao * mChieuRong;
        }
        //kiểm tra hình vuông
        public bool KiemTraHinhVuong()
        {
            return mChieuCao == mChieuRong;
        }
        //xuất thông tin
        public void XuatThongTin()
        {
            Console.WriteLine($"Chieu dai: {mChieuCao}, Chieu rong: {mChieuRong}");
            Console.WriteLine($"Chu vi: {TinhChuVi()}");
            Console.WriteLine($"Dien tich: {TinhDienTich()}");
            Console.WriteLine($"La hinh vuong? {(KiemTraHinhVuong() ? "Phai" : "Khong")}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== KIEM TRA LOP HINH CHU NHAT ===");
            HinhChuNhat hcn1 = new HinhChuNhat(10, 5);
            Console.WriteLine("Thông tin Hinh chu nhat 1:");
            hcn1.XuatThongTin();

            Console.WriteLine();

            HinhChuNhat hcn2 = new HinhChuNhat();
            hcn2.ChieuCao = 6;
            hcn2.ChieuRong = 6;
            Console.WriteLine("Thông tin Hinh chu nhat 2:");
            hcn2.XuatThongTin();

            Console.ReadLine();
        }
    }
}
