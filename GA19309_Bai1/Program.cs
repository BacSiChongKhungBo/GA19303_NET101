using System.Text;

namespace GA19303_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, GA19303!");
            // cw + tab: Console.WriteLine();
            Console.WriteLine("cw tab");

            // nhập tên tuổi, điểm tb của học sinh
            // được gì: in ra màn hình
            //          gọi biến
            //          in ra màn hình kèm biến

            //biến
            int tuoi;
            float diemTB;
            //Tên: sử dụng string
            string ten;

            //in ra và nhập = tiếng việt
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Xin mời nhập tên:");
            ten = Console.ReadLine(); //nhập giá trị cho biến
            Console.WriteLine("Xin mời nhập tuổi:");
            // <kiểu dữ liệu>.Parse() : đổi sang kiểu dữ liệu mong muốn
            tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Xin mời nhập ĐiểmTB:");
            diemTB = float.Parse(Console.ReadLine());

            // in ra màn hình kèm biến
            Console.WriteLine("Tên: " + ten);
            Console.WriteLine("Tuổi: " + tuoi);
            Console.WriteLine("Điểm TB: " + diemTB);
            // in 1 dòng nhiều biến
            //C1:
            Console.WriteLine("Tên: " + ten + " Tuổi: " + tuoi + " Điểm TB: " + diemTB);
            //C2:
            Console.WriteLine($"Tên: {ten} Tuổi: {tuoi} DiemTB: {diemTB}");

        }
    }
}