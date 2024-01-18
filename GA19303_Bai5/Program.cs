namespace GA19303_Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class 
            // Class là gì: lớp
            // lớp là tập hợp các sinh viên tạo thành
            // sinh viên: hàm
            // tạo mới 1 class
            Demo1 demo1 = new Demo1(); // CỰC KÌ QUAN TRỌNG
            demo1.InRaManHinh();
            Demo2 demo2 = new Demo2();
            demo2.InRaManHinh();
            demo2.InRaManHinh1();
            #endregion     
        }
    }
}