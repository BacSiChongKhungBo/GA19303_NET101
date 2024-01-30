using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_CRUD
{
    // : <class đối tượng>
    // giúp cho class hiện tại trở thành 
    // cha con với class được kế thừa
    //SinhVienGA : con - SinhVien: cha
    internal class SinhVienGA : SinhVien
    {
        //tạo thuộc tính riêng cho SinhVienGA
        private double diemUnity;
        private double diemCSharp;

        public SinhVienGA()
        {
            
        }

        public SinhVienGA(string ma, string ten, int tuoi, double diemUnity, double diemCSharp) : base(ma,ten,tuoi)
        {
            this.diemUnity = diemUnity;
            this.diemCSharp = diemCSharp;
        }

        public double DiemUnity { get => diemUnity; set => diemUnity = value; }
        public double DiemCSharp { get => diemCSharp; set => diemCSharp = value; }

        public void InThongTin()
        {
            //kế thừa in thông tin của bên SinhVien
            base.InThongTin();
            //sau đó sẽ nhập bổ sung các thuộc tính svien ko có
            Console.WriteLine($"{diemUnity} | {diemCSharp}");
        }
    }
}
