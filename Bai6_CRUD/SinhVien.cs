using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_CRUD
{
    internal class SinhVien
    {
        //b1: khai báo biến
        private string ma;
        private string ten;
        private int tuoi;

        //b2: ctor tab
        public SinhVien()
        {
            
        }

        //b3: tạo ctor có tham số
        public SinhVien(string ma, string ten, int tuoi)
        {
            this.ma = ma;
            this.ten = ten;
            this.tuoi = tuoi;
        }

        //b4: tạo các hàm trung gian để tương tác với class khác
        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        //Inthongtin
        public void InThongTin()
        {
            Console.WriteLine($"{ma} | {ten} | {tuoi}");
        }
    }
}
