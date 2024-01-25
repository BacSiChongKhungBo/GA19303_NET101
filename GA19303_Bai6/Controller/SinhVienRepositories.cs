using GA19303_Bai6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA19303_Bai6.Controller
{
    internal class SinhVienRepositories
    {
        #region 3 bước quan trọng nhất
        //B1: bước quan trọng nhất
        //khai báo class đối tượng
        SinhVien sv;
        //khai báo danh sách đối tượng
        List<SinhVien> sinhViens;
        //B2: tạo ctor cho class SinhVienRepositories
        // ctor + tab
        public SinhVienRepositories()
        {
            //B3: khởi tạo danh sách đối tượng
            sinhViens = new List<SinhVien>();
        }
        #endregion

        #region Thêm đối tượng vào danh sách
        public void ThemSinhVien()
        {
            //Siêu quan trọng
            sv = new SinhVien();
            //B1: xin mời nhập thông tin
            Console.WriteLine("Xin mời nhập mã");
            sv.MaSV = Console.ReadLine();
            Console.WriteLine("Xin mời nhập tên");
            sv.Ten = Console.ReadLine();
            Console.WriteLine("Xin mời nhập tuổi");
            sv.Tuoi = Convert.ToInt32(Console.ReadLine());
            //B2: Thêm vào danh sách
            sinhViens.Add(sv);
            Console.WriteLine("Thêm thành công");
        }
        #endregion
        #region Xuất danh sách đối tượng
        public void XuatDanhSach()
        {
            //B1: tạo 1 vòng lặp foreach
            //dịch: với mỗi một đối tượng trong danh sách
            foreach (var s in sinhViens)
            {
                //in đối tượng đó ra màn hình
                s.InThongTinVoid();
            }
        }
        #endregion
        #region Xóa 1 đối tượng ra khỏi danh sách
        public void XoaSinhVien()
        {
            //b3: tạo cờ : nếu tìm thấy thì đổi sang true
            bool isExist = false;
            //b3: tạo 1 sinh viên để chứa
            SinhVien svCanXoa = new SinhVien(); 
            //b1: cần nhập mã
            Console.WriteLine("Xin mời nhập mã sv cần xóa: ");
            string input = Console.ReadLine();
            //b2: tìm trong danh sách = foreach
            foreach (var s in sinhViens)
            {
                //b4: tìm xem trung hay không
                if(input.Equals(s.MaSV)) //equals tương đương ==
                {
                    //gán thông tin của s vào svCanXoa
                    svCanXoa = s;
                    // đổi trạng thái cờ isExist = true
                    isExist = true;
                    //thoát khỏi vòng lặp ngay lập tức
                    break;
                }
            }
            //B5: tổng kết
            if(isExist) //tìm thấy svien cần xóa
            {
                //tiến hành xóa
                Console.WriteLine("TÌm thấy");
                sinhViens.Remove(svCanXoa);
                Console.WriteLine("Xóa thành công");
            }
            else
            {
                Console.WriteLine("Không tìm thấy");
            }
        }
        #endregion
        #region Sửa Sinh Viên
        #endregion
        #region Tìm kiếm Sinh Viên theo mã
        #endregion
        #region Tìm kiếm Sinh Viên theo tuổi
        #endregion
    }
}
