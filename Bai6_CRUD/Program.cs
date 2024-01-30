using System.Text;

namespace Bai6_CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            #region khâu chuẩn bị
            // khai báo và khởi tạo class quản lý 
            // đối tượng
            SinhVienRepository repos = new SinhVienRepository();
            // khai báo biến lựa chọn
            int luachon;
            #endregion
            //B1: tạo vòng lặp
            //lưu ý: chắc chắn vòng lặp sẽ lỗi
            //       tuy nhiên code đến khi nhập
            //       lựa chọn là sẽ hết
            do
            {
                //B2: code menu và nhập lựa chọn
                Console.WriteLine("1. Nhập");
                Console.WriteLine("2. Xuất");
                Console.WriteLine("3. Sửa");
                Console.WriteLine("4. Xóa");
                Console.WriteLine("5. Tìm theo mã");
                Console.WriteLine("6. XS tăng dần");
                Console.WriteLine("7. XS giảm dần");
                Console.WriteLine("9. Kế thừa");
                Console.WriteLine("8. Thoát");
                Console.WriteLine("Xin mời nhập lựa chọn");
                luachon = int.Parse(Console.ReadLine());
                //B3: switch case
                switch(luachon)
                {
                    case 1:
                        repos.ThemSinhVien();
                        break;
                    case 2:
                        repos.XuatDanhSach();
                        break;
                    case 3:
                        repos.SuaThongTin();
                        break;
                    case 4:
                        repos.XoaSinhVienC1();
                        break;
                    case 6:
                        Console.WriteLine("Bye");
                        break;
                    case 7:
                        repos.SortDanhSachASC();
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("ko có trong menu");
                        break;

                }
            } while (luachon != 8); //lựa chọn != thoát

        }
    }
}