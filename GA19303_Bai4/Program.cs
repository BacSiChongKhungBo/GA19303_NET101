using System.Text;

namespace GA19303_Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            #region mảng
            // Mảng: tập hợp các số|chữ|đối tướng
            // có cùng kiểu dữ liệu
            int[] arr = { 2, 5, 7, 9, 1, 3, 8 };
            double[] arr2 = { 5.2, 1.4, 6.7, 55.6 };
            char[] arr3 = { 'a', 'd', '3', '6' };
            string[] arr4 = { "alo", "mưa", "gió" };
            //mảng có các thành phần gì????
            //index : vị trí 
            //giá trị: giá trị tại index bao nhiêu
            // trong mảng
            int[] siSoKhoi10 = { 40, 39, 41, 39, 45 };
            int index = 1;
            Console.WriteLine($"Lớp thứ {(index + 1)} có ss là");
            Console.WriteLine(siSoKhoi10[index]);
            #endregion
            #region in ra mảng ko dùng for
            //ở C: nhập số lượng trước
            //ở C#: hàm length => trả về độ dài của mảng
            //for(int i =0; i < độ dài mảng; i++)
            Console.WriteLine("--------------------");
            int i = 0;
            while (i < siSoKhoi10.Length) 
            {
                Console.WriteLine($"Lớp thứ {(i + 1)} có ss là");
                Console.WriteLine(siSoKhoi10[i]);
                i++;
            }
            //ngoài length, có thể sử dụng Count
            Console.WriteLine("--------------------");
            i = 0;
            while (i < siSoKhoi10.Count())
            {
                Console.WriteLine($"Lớp thứ {(i + 1)} có ss là");
                Console.WriteLine(siSoKhoi10[i]);
                i++;
            }
            #endregion
            #region Sắp Xếp mảng
            
            int[] sortedSiSoKhoi10;
            //tăng dần: OrderBy
            //sortedSiSoKhoi10 = siSoKhoi10.OrderBy(x => x).ToArray();
            //giảm dần: OrderByDescending
            sortedSiSoKhoi10 = siSoKhoi10.OrderByDescending(x => x).ToArray();
            Console.WriteLine("--------------------");
            i = 0;
            while (i < sortedSiSoKhoi10.Length)
            {
                Console.WriteLine($"Lớp thứ {(i + 1)} có ss là");
                Console.WriteLine(sortedSiSoKhoi10[i]);
                i++;
            }
            #endregion
        }
    }
}