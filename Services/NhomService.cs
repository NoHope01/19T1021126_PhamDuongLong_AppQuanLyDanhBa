using QLDB.Model;
using QLDB.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDB.Services
{
     class NhomService
    {
        public static List<NhomViewModel> GetDanhSachNhom()
        {

            var db = new Model1();
            var rs = db.Nhoms.Select(e => new NhomViewModel
            {

                IDNhom = (int)e.ID,
                TenNhom = e.TenNhom,


            }).ToList();
            return rs;
        }
    }
}
