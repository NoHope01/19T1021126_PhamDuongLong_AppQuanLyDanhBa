using QLDB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDB.ViewModel
{
    // Class naỳ khai báo các giá trị có trong SQL 
    public enum KetQua
    {
        Loi, ThanhCong
    }
    public class NguoiViewModel
    {
        public int ID { get; set; }
        public string TenGoi { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int? IDNhom { get; set; }



    }
}
