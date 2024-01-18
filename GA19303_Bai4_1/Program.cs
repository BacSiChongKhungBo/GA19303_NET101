using System.Text;

namespace GA19303_Bai4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            #region vòng for
            //vòng for: lặp lại với điểm bắt đầu, bước nhảy và
            //kết thúc khi điều kiện kết thúc là false
            int diem = 0;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"diem {diem} là điểm hợp lệ");
                diem++;
            }
            #endregion
            #region demo for và mảng
            int sl;
            Console.WriteLine("Xin mời nhập số lượng dt: ");
            sl = int.Parse(Console.ReadLine());
            // gán độ dài cho mảng
            int[] ram = new int[sl];
            for (int i = 0; i < sl; i++)
            {
                Console.WriteLine("Xin mời nhập ram cho dt " + (i+1));
                ram[i] = int.Parse(Console.ReadLine());
            }
            #endregion
        }
    }
}