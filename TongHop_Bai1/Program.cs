using System.Data.SqlTypes;
using System.Text;

namespace TongHop_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region viết tiếng việt
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;
            #endregion
            #region Biến và kiểu dữ liệu
            string ten; // dùng cho tên, địa chỉ, công việc,...
            int tuoi; // dùng cho những thứ là số nguyên
            float diemTB; // dùng cho những thứ là số thực
            double soDuTK; // dùng cho những thứ là số thực
            bool sex; // bool thể hiện true false => giới tính, trạng thái
            
            //------------- một số biến khác 
            decimal soTP;
            DateTime dateTime; //Thoi gian
            #endregion
            #region Yêu cầu nhập và Nhập dữ liệu cho biến
            Console.WriteLine("Xin mời nhập tên:");
            ten = Console.ReadLine();
            Console.WriteLine("Xin mời nhập tuổi:");
            tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Xin mời nhập ĐiểmTB:");
            diemTB = float.Parse(Console.ReadLine());
            #endregion
            #region Xuất ra màn hình kèm dữ liệu
            // in ra màn hình kèm biến
            Console.WriteLine("Tên: " + ten);
            Console.WriteLine("Tuổi: " + tuoi);
            Console.WriteLine("Điểm TB: " + diemTB);
            // in 1 dòng nhiều biến
            //C1:
            Console.WriteLine("Tên: " + ten + " Tuổi: " + tuoi + " Điểm TB: " + diemTB);
            //C2:
            Console.WriteLine($"Tên: {ten} Tuổi: {tuoi} DiemTB: {diemTB}");
            #endregion
        }
    }
}