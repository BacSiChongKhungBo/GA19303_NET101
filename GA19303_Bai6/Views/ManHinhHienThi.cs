using GA19303_Bai6.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA19303_Bai6.Views
{
    internal class ManHinhHienThi
    {
        //khai báo
        SinhVienRepositories _repos;
        //ctor + tab
        public ManHinhHienThi()
        {
            //khởi tạo
            _repos = new SinhVienRepositories();
        }
        public void HienThiMenu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            int choice;
            do 
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. xuất danh sách sinh viên");
                Console.WriteLine("3. Xóa sinh viên theo mã");
                Console.WriteLine("4. Sửa sinh viên theo mã");
                Console.WriteLine("5.");
                Console.WriteLine("6.");
                Console.WriteLine("7. Thoát");
                Console.WriteLine("Xin mời nhập lựa chọn: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        _repos.ThemSinhVien();
                        break;
                    case 2:
                        _repos.XuatDanhSach();
                        break;
                    case 3:
                        _repos.XoaSinhVien();
                        break;
                    case 7:
                        Console.WriteLine("tạm biệt");
                        break;
                }
            } while (choice != 7);
        }
    }
}
