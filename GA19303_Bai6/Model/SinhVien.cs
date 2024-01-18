using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA19303_Bai6.Model
{
    internal class SinhVien
    {
        //B1: Tạo thuộc tính cho đối tượng
        private string maSV;
        private string ten;
        private int tuoi;

        //B2: ctor + tab: khởi tạo constructor
        public SinhVien()
        {
            //đừng code gì trong này
        }

        //B3: tạo các trung gian để giao tiếp với
        // các class khác
        /*
         * 1. bôi đen thuộc tính được khai báo tại B1
         * 2. chuột phải/ crtl+. rồi chọn Quick options and refactoring
         * 3. Chọn generate constructor (hàm có tham số đầu vào)
         */
        public SinhVien(string maSV, string ten, int tuoi)
        {
            this.maSV = maSV;
            this.ten = ten;
            this.tuoi = tuoi;
        }

        //B4: tạo trung gian thuộc tính
        /*
         * 1. bôi đen thuộc tính được khai báo tại B1
         * 2. chuột phải/ crtl+. rồi chọn Quick options and refactoring
         * 3. Chọn Encapsolute fields (but still use fields)
         */

        public string MaSV { get => maSV; set => maSV = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        //B5: in ra màn hình 
        //Lưu ý: dùng biến không viết hoa chữ cái đầuD
        public string InThongTin()
        {
            return (maSV + " | " + ten + " | " + tuoi);
        }

        public void InThongTinVoid()
        {
            Console.WriteLine(maSV + " | " + ten + " | " + tuoi);
        }

    }
}
