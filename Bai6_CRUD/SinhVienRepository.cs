using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_CRUD
{
    internal class SinhVienRepository
    {
        #region khâu chuẩn bị
        //b1: khai báo đối tượng và DS đối tượng
        SinhVien sv;
        List<SinhVien> lst;
        //B2: tạo ctor và khởi tạo danh sách
        public SinhVienRepository()
        {
            lst = new List<SinhVien>();
        }
        #endregion

        #region Hàm thêm đối tượng
        public void ThemSinhVien()
        {
            //B1:Quan trọng: khởi tạo sinh viên trong này
            sv = new SinhVien();
            //B2: nhập thông tin sv
            Console.WriteLine("nhập mã");
            sv.Ma = Console.ReadLine();
            Console.WriteLine("nhập tên");
            sv.Ten = Console.ReadLine();
            Console.WriteLine("nhập tuổi");
            sv.Tuoi = int.Parse(Console.ReadLine());
            //B3: thêm vào danh sách
            lst.Add(sv);
            Console.WriteLine("Thêm thành công");
        }
        #endregion
        #region Hàm Xuất danh sách
        public void XuatDanhSach()
        {
            //b1: tạo foreach
            foreach (SinhVien sv in lst)
            {
                //B2: gọi hàm InThongTin
                sv.InThongTin();
            }
            //for (int i = 0; i < lst.Count; i++)
            //{
            //    lst[0].InThongTin();
            //}
        }
        #endregion

        #region Hàm Xóa 
        public void XoaSinhVienC1()
        {
            #region chuẩn bị
            SinhVien svCanXoa = new SinhVien();
            #endregion
            //B1: nhập mã cần xóa
            Console.WriteLine("Xin mời nhập mã cần xóa");
            string input = Console.ReadLine();
            //B2: Dùng linq xóa luôn
            svCanXoa = lst.Where(x => x.Ma == input).FirstOrDefault();
            //tìm trong danh sách: lst.where
            //với sinh viên là x: (x =>
            //và mã của sv x tương đương với mã nhập vào: x.Ma == input)
            //Nếu tìm được thì lấy thằng đầu, ko được thì null :FirstOrDefault(); 

            //B3: nếu ds có đối tượng, tiến hành xóa, ko thì báo lại
            if(svCanXoa != null)
            {
                lst.Remove(svCanXoa);
                Console.WriteLine("Xóa thành công");
            }
            else
            {
                Console.WriteLine("không tìm thấy");
            }
        }

        public void XoaSinhVienC2()
        {
            #region chuẩn bị
            SinhVien svCanXoa = new SinhVien();
            bool tontai = false;
            #endregion
            //B1: nhập mã cần xóa
            Console.WriteLine("Xin mời nhập mã cần xóa");
            string input = Console.ReadLine();
            //B2: chạy foreach
            foreach (SinhVien sv in lst)
            {
                //nếu mã sv trong danh sách trùng mã nhập
                if(sv.Ma == input)
                {
                    //sinh viên cần xóa có tồn tại
                    tontai = true;
                    //gán thông tin
                    svCanXoa = sv;
                    break;
                }
            }
            //B3: nếu sv tồn tại
            if( tontai )
            {
                lst.Remove(svCanXoa);
                Console.WriteLine("Xóa thành công");
            }
            else
            {
                Console.WriteLine("không tìm thấy");
            }
        }
        #endregion

        #region Hàm Sửa thông tin
        public void SuaThongTin()
        {
            //b1: nhập mã cần sửa
            bool timthay = false;
            Console.WriteLine("Xin mời nhập mã cần sửa");
            string input = Console.ReadLine();
            //B2: tạo foreach
            foreach (SinhVien sinhVien in lst)
            {
                if(sv.Ma == input)
                {
                    timthay = true;
                    Console.WriteLine("Xin mời nhập mã mới");
                    sv.Ma = Console.ReadLine();
                    Console.WriteLine("Xin mời nhập tên mới");
                    sv.Ten = Console.ReadLine();
                    Console.WriteLine("Xin mời nhập tuổi mới");
                    sv.Tuoi = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sửa thành công");
                    break;
                }
            }
            if(timthay == false)
            {
                Console.WriteLine("Không tìm thấy");
            }
        }
        #endregion

        #region Hàm sắp xếp tăng dần
        public void SortDanhSachASC()
        {
            List<SinhVien> newlst =  lst.OrderBy(sv => sv.Tuoi).ToList();
            foreach (SinhVien sv in newlst)
            {
                sv.InThongTin();
            }
            Console.WriteLine("Sắp xếp thành công");
        }
        #endregion
        #region Hàm sắp xếp giảm dần
        public void SortDanhSachDESC()
        {
            List<SinhVien> newlst = lst.OrderByDescending(sv => sv.Tuoi).ToList();
            foreach (SinhVien sv in newlst)
            {
                sv.InThongTin();
            }
            Console.WriteLine("Sắp xếp thành công");
        }
        #endregion

        #region Kế thừa
        public void KeThua()
        {
            List<SinhVienGA> lstSVGA;
            lstSVGA = new List<SinhVienGA>()
            {
                new SinhVienGA("1", "Văn A", 19, 10, 10),
                new SinhVienGA("2", "Văn B", 18, 7, 9),
                new SinhVienGA("3", "Văn C", 20, 8, 6),
                new SinhVienGA("4", "Văn D", 19, 4, 7),
            };
            foreach (var svienga in lstSVGA)
            {
                svienga.InThongTin();
            }
        }
        #endregion
    }
}
