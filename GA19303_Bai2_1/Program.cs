using System.Text;

namespace GA19303_Bai2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            #region Switch case
            int choice;
            Console.WriteLine("Menu");
            Console.WriteLine("1. gà rán");
            Console.WriteLine("2. ham bơ gơ");
            Console.WriteLine("3. khoai tây chiên");
            Console.WriteLine("Xin mời nhập lựa chọn");
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("bạn đã chọn gà rán");
                    break;
                case 2:
                    Console.WriteLine("Bạn đã chọn ham bơ gơ");
                    break;
                case 3:
                    Console.WriteLine("Bạn đã chọn khoai chiên");
                    break;
                default: // luôn phải có trong switch case
                    Console.WriteLine("không có trong menu");
                    break;
            }
            #endregion
            /*
             * While và do while
             * mảng và for
             * foreach
             * Hướng đối tượng:
             *      - thêm
             *      - sửa
             *      - xóa
             *      - update
             * delegate
             */
        }
    }
}