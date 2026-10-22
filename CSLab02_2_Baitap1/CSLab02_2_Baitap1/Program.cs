using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab02_2_Baitap1
{
    internal class Program
    {
        static void XuatMang(List<string> M)
        {
            string chuoi = string.Join(", ", M);
            Console.WriteLine(chuoi);
        }
        static void Main(string[] args)
        {
            List<string> mang = new List<string>();
            string tmp;

            // 1. Nhập các tên hàng hóa, dừng lại khi nhập "STOP"
            Console.WriteLine("=== NHAP DANH SACH HANG HOA (Nhap 'STOP' de dung) ===");
            while (true){
                Console.Write("Chuoi nhap: ");
                tmp = Console.ReadLine().Trim();
                if (tmp.ToUpper() == "STOP"){
                    break;
                }
                mang.Add(tmp);
                Console.WriteLine("Count = {0}, Capacity = {1}", mang.Count, mang.Capacity);
            }

            // 2. Xuất danh sách hàng hóa
            Console.WriteLine("\n--- DANH SACH HANG HOA VUA NHAP ---");
            XuatMang(mang);

            // 3. Tìm kiếm hàng hóa theo tên
            Console.WriteLine("\n--- TIM KIEM HANG HOA ---");
            Console.Write("Nhap ten hang hoa can tim: ");
            tmp = Console.ReadLine().Trim();

            bool timThay = mang.Contains(tmp);
            Console.WriteLine($"Ket qua tim kiem (Trả ve bool): {timThay}");

            if (timThay)
            {
                Console.WriteLine("Tim thay '{0}' tai vi tri index: {1}", tmp, mang.IndexOf(tmp));

                // 4. Xóa hàng hóa
                mang.Remove(tmp);
                Console.WriteLine("Da xoa hàng hoa '{0}'. Danh sach sau khi xoa:", tmp);
                XuatMang(mang);
            }

            // 5. Thêm hàng hóa vào vị trí index bất kỳ
            Console.WriteLine("\n--- THEM HANG HOA VAI VI TRI BAT KY ---");
            Console.Write("Nhap ten hang hoa moi: ");
            string tenMoi = Console.ReadLine().Trim();
            Console.Write($"Nhap vi tri index muon chen (0 den {mang.Count}): ");
            int index;
            if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= mang.Count){
                mang.Insert(index, tenMoi);
                Console.WriteLine("Danh sach sau khi chen:");
                XuatMang(mang);
            }
            else{
                Console.WriteLine("Vi tri index khong hop le!");
            }
            Console.ReadLine();
        }
    }
}
