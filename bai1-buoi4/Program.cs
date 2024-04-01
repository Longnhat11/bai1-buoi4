using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_buoi4
{
    public struct sach
    {
        public string Tieude;
        public string tacgia;
        public int namxuatban;
    }
    class Program
    {
        static List<sach> sachmoi = new List<sach>();
        static void themsach()
        {
            sach sachthem = new sach();
            Console.Write("Nhập tiêu đề sách: ");
            sachthem.Tieude = Console.ReadLine();
            Console.Write("Nhập tác giả: ");
            sachthem.tacgia = Console.ReadLine();
            Console.Write("Nhập năm xuất bản: ");
            string nhapvao = Console.ReadLine();
            int namra;
            bool ilaso = int.TryParse(nhapvao, out namra);
            while (ilaso == false)
            {
                Console.WriteLine("ban nhap khong phai so! xin moi nhap lai:");
                nhapvao = Console.ReadLine();
                ilaso = int.TryParse(nhapvao, out namra);
                if ((namra < -2147483648) && (namra > 2147483647) && (ilaso == true))
                {
                    Console.WriteLine("ban nhap so khong trong khoang int, xin moi nhap lai.");
                    ilaso = false;
                }
            }
            sachthem.namxuatban = namra;
            sachmoi.Add(sachthem);  
        }
        static void hienthisach()
        {
            foreach (sach sachhienthi in sachmoi)
            {
                Console.WriteLine($"Tiêu đề: {sachhienthi.Tieude}, Tác giả: {sachhienthi.tacgia}, Năm xuất bản: {sachhienthi.namxuatban}");
            }
        }
        static void timsach()
        {
            Console.Write("Nhập tiêu đề sách cần tìm: ");
            string tieudevao = Console.ReadLine();
            foreach ( var sachtim in sachmoi )
            {
                if (sachtim.Tieude == tieudevao) 
                { Console.WriteLine($"Tiêu đề: {sachtim.Tieude}, Tác giả: {sachtim.tacgia}, Năm xuất bản: {sachtim.namxuatban}"); }
                else
                {
                    Console.WriteLine("Không tìm thấy sách.");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Thêm sách mới");
            Console.WriteLine("2. Hiển thị danh sách sách");
            Console.WriteLine("3. Tìm kiếm sách theo tiêu đề");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập lựa chọn của bạn : ");
            string nhapvao = Console.ReadLine();
            int luachon;
            bool luachonlaso = int.TryParse(nhapvao, out luachon);
            while (luachonlaso == false)
            {
                Console.WriteLine("ban nhap khong phai so! xin moi nhap lai:");
                nhapvao = Console.ReadLine();
                luachonlaso = int.TryParse(nhapvao, out luachon);
                if ((luachon < -2147483648) && (luachon > 2147483647) && (luachonlaso == true))
                {
                    Console.WriteLine("ban nhap so khong trong khoang int, xin moi nhap lai.");
                    luachonlaso = false;
                }
            }
            switch (luachon)
            {
                case 1:
                    themsach();
                    break;
                case 2:
                    hienthisach();
                    break;
                case 3:
                    timsach();
                    break;
                case 4:
                    Console.WriteLine("thoát trương trình !");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
            Console.ReadKey();  
        }
    } 
}
