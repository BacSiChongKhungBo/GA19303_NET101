namespace GA19303_Bai3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region do while
            /* do
             * {
             *      thực hiện khối lệnh
             * } while(<điều kiện trả về true>);
             * 
             */
            int count1 = 11;
            do
            {
                Console.WriteLine("do while số " + count1);
                count1++;
            } while (count1 <= 10);
            int count2 = 11;
            while(count2 <= 10)
            {
                Console.WriteLine("while số " + count2);
                count2++;
            }
            #endregion

            #region khác nhau giữa while và do while
            /* WHILE:
             *  while sẽ kiểm trả điều kiện có trả
             *  về true hay không rồi mới quyết định
             *  có thực hiện khối lệnh trong nó hay ko
             * DO WHILE:
             *  bất chấp điều kiện là true hay false
             *  do while vẫn sẽ chạy ít nhất 1 lần
             *  sau đó mới kiểm tra điều kiện
             */
            #endregion

            #region dowhile áp dụng vào menu
            //khai báo lựa chọn
            // while cần gán giá trị
            // dowhile thì không nhất thiết phải gán giá trị
            int choice;
            do
            {
                Console.WriteLine("Game screen");
                Console.WriteLine("1. New Game");
                Console.WriteLine("2. Continue");
                Console.WriteLine("3. Setting");
                Console.WriteLine("0. Exit");
                //lựa chọn thoát == giá trị trả về true
                Console.WriteLine("xin mời nhập lựa chọn:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
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
            } while(choice != 0);
            #endregion
        }
    }
}