namespace GA19303_Bai5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hàm
            /*
             * Hàm: là 1 khối code riêng biệt
             * - Chỉ chạy khi được gọi
             * - hàm Main là hàm đặc biệt
             * - Hàm : 2 loại, có tham số và ko tham số
             * - Hàm được triển khai trong class
             * - không được code hàm trong hàm
             * - Hàm trong 1 class phải cùng kiểu thì mới
             * - gọi được nhau
             * 
             * Hàm có thể gọi từ 1 class khác tuy nhiên
             * phải khai báo và khởi tạo class đó
             */
            #endregion

            #region Access Modifier
            /*
             * public: có thể được truy cập bằng mọi hàm
             * private: không truy cập được từ class khác
             * protected: truy cập giới hạn
             * internal: chỉ truy cập trong class
             */
            #endregion
            InRaManHinh();
        }

        static void InRaManHinh()
        {
            Console.WriteLine("This is Function InRaManHinh");
        }
    }

}