using QLDB.Model;
using QLDB.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDB.Services
{
    public class NguoiService
    {
        public static List<NguoiViewModel> GetDanhSachLienLac()
        {
            var db = new Model1();
            var rs = db.Nguois.Select(e => new NguoiViewModel
            {
                ID = e.ID,
                TenGoi = e.TenGoi,
                Email = e.Email,
                PhoneNumber = e.PhoneNumber,
                IDNhom = (int)e.IDNhom,
                Address = e.Address,

            }).ToList();

            return rs;

        }

        public static List<NguoiViewModel> GetDanhSachLienLacTheoID(NhomViewModel nhom)
        {
            var db = new Model1();
            var rs = db.Nguois.Where(e => e.IDNhom == nhom.IDNhom).Select(e => new NguoiViewModel
            {
                ID = e.ID,
                TenGoi = e.TenGoi,
                Email = e.Email,
                PhoneNumber = e.PhoneNumber,
                IDNhom = (int)e.IDNhom,
                Address = e.Address,
            }).ToList();
            return rs;
        }

    }
}
