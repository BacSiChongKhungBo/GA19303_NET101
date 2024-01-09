using System.Text;

namespace GA19303_Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            #region While
            // while: trong khi
            // while (<điều kiện trả về true>)
            // {
            //      thực hiện khối lệnh
            //      khi điều kiện trả về true
            // }
            int count = 5;
            while (count <= 10)
            {
                Console.WriteLine("số: " + count);
                count++;
                Console.WriteLine("số sau ++: " + count);
                Console.WriteLine("điều kiện trả về " + (count <= 10));
            }
            #endregion

            #region demo while
            // tạo 1 biến lựa chọn có sẵn giá trị
            // giá trị gán khác với giá trị trả về true
            int choice = -1;
            // đặt lựa chọn thoát = 0
            while (choice != 0)
            {
                Console.WriteLine("Game screen");
                Console.WriteLine("1. New Game");
                Console.WriteLine("2. Continue");
                Console.WriteLine("3. Setting");
                Console.WriteLine("0. Exit");
                //lựa chọn thoát == giá trị trả về true
                Console.WriteLine("xin mời nhập lựa chọn:");
                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("bạn chọn new game");
                        break;
                    case 2:
                        Console.WriteLine("bạn chọn Continue");
                        break;
                    case 3:
                        Console.WriteLine("bạn chọn Setting");
                        break;
                    case 0:
                        Console.WriteLine("bạn chọn Exit");
                        break;
                    default:
                        Console.WriteLine("không có lựa chọn trong menu");
                        break;
                }
            }
            #endregion
            // ôn tập Lab
            // tạo 1 menu,
            // trong menu có các chức năng:
            // 1.nhập họ tên, địa chỉ, mã sv
            // 2. nhập số dư, số tiền đóng
        }
    }
}