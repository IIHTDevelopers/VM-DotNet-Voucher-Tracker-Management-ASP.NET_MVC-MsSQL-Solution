
using VoucherTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherTrackerApp.DAL.Interface
{
    public interface IVoucherTrackerRepository
    {
        IEnumerable<Voucher> GetVouchers();
        Voucher GetVoucherByID(int voucherId);
        Voucher InsertVoucher(Voucher voucher);
        int DeleteVoucher(int voucherId);
        bool UpdateVoucher(Voucher voucher);
        void Save();
    }
}