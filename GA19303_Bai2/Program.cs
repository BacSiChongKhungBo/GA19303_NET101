using System.Text;

namespace GA19303_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region viết tiếng việt
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;
            #endregion

            #region If
            //<điều kiện trả về true>:
            int diem = 6;
            if (diem < 5) //trả về false => không in ra
            {
                Console.WriteLine("nôn 6 lít cho DVSV");
            }
            if (diem >= 5) // 6 > 5 => true => in ra màn hình
            {
                Console.WriteLine("đóng 1 củ 2 môn tiếp theo");
            }
            // if ( <điều kiện trả về true> )
            // {
            //      Thực hiện câu lệnh trong khối if
            //      khi điều kiện thỏa mãn
            // }
            #endregion

            #region if else
            // if ( <điều kiện trả về true> )
            // {
            //      Thực hiện câu lệnh trong khối if
            //      khi điều kiện thỏa mãn
            // }
            // else
            // {
            //      Thực hiện câu lệnh trong khối else
            //      khi điều kiện ở if là false
            // }
            int soDuTK = 50000;
            int soTienRut;
            Console.WriteLine("Xin moi nhap so tien can rut: ");
            soTienRut = int.Parse(Console.ReadLine());
            if (soTienRut > soDuTK)
            {
                Console.WriteLine("Không đủ số dư");
            }
            else
            {
                Console.WriteLine("Rút thành công");
                Console.WriteLine("số dư còn lại: " + (soDuTK - soTienRut));
            }
            #endregion

            #region if else if
            // if ( <điều kiện 1 trả về true> )
            // {
            //      Thực hiện câu lệnh trong khối if
            //      khi điều kiện 1 thỏa mãn
            // }
            // else if ( <điều kiện 2 trả về true> )
            // {
            //      Thực hiện câu lệnh trong khối if
            //      khi điều kiện 2 thỏa mãn
            // }
            // ....
            // else if ( <điều kiện n trả về true> )
            // {
            //      Thực hiện câu lệnh trong khối if
            //      khi điều kiện n thỏa mãn
            // }
            // else
            // {
            //      Thực hiện câu lệnh trong khối else
            //      khi điều kiện ở tất cả các if là false
            // }
            Console.WriteLine("Xin mời nhập giá trị xúc xắc");
            float xs = float.Parse(Console.ReadLine());
            if (xs < 9)
            {
                Console.WriteLine("Xỉu");
            }
            else if (xs > 9) 
            {
                Console.WriteLine("Tài");
            }
            else
            {
                Console.WriteLine("x14");
            }
            #endregion

            #region Lưu ý khi code if else
            /*
             * 1. Luôn bắt đầu = if và kết thúc = else
             * 2. Không lồng quá 3 khối if vào nhau
             * 3. Để ý kiểu dữ liệu của biến khi xác định ĐK
             */
            #endregion

            /*
             * gây sát thương lên người chơi dựa trên
             * đạn găm vào bộ phận nào trên cơ thể
             * với giả định:
             * Ak 47:
             * đầu : 135 máu
             * tay : 39 máu
             * ngực : 48 máu
             * chân : 26 máu
             */
            #region gây sát thương
            // đánh dấu số trên các bộ phận cơ thể
            int dau = 1;
            int tay = 2;
            int nguc = 3;
            int target; //tượng trưng cho đạn găm vào đâu
            int hp_enemy = 100;
            Console.WriteLine("nhập vị trí muốn găm đạn: ");
            target = int.Parse(Console.ReadLine());
            // xác định vị trí mà đạn găm thông qua if else
            if (target == dau) 
            {
                hp_enemy = hp_enemy - 135;
            }
            else if (target == tay)
            {
                hp_enemy = hp_enemy - 39;
            }
            else if (target == nguc)
            {
                hp_enemy = hp_enemy - 48;
            }
            else
            {
                hp_enemy = hp_enemy - 26;
            }
            //Xác nhận kết quả của lần bắn
            if(hp_enemy <= 0) 
            {
                Console.WriteLine($"kẻ địch chết hp còn lại: {hp_enemy}");
            }
            else
            {
                Console.WriteLine($"kẻ địch sống hp còn lại: {hp_enemy}");
            }
            #endregion
        }
    }
}