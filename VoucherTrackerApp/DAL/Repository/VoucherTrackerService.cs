using VoucherTrackerApp.DAL.Interface;
using VoucherTrackerApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VoucherTrackerApp.DAL.Repository
{
    public class VoucherTrackerService : IVoucherTrackerInterface
    {
        private IVoucherTrackerRepository _repo;
        public VoucherTrackerService(IVoucherTrackerRepository repo)
        {
            this._repo = repo;
        }

        public int DeleteVoucher(int voucherId)
        {
            var res= _repo.DeleteVoucher(voucherId);
            return res;
        }

        public Voucher GetVoucherByID(int voucherId)
        {
            return _repo.GetVoucherByID(voucherId);
        }
        public void Save()
        {
            _repo.Save();
        }


        IEnumerable<Voucher> IVoucherTrackerInterface.GetVouchers()
        {
            return _repo.GetVouchers();
        }

        Voucher IVoucherTrackerInterface.InsertVoucher(Voucher voucher)
        {
            return _repo.InsertVoucher(voucher);
        }

        bool IVoucherTrackerInterface.UpdateVoucher(Voucher voucher)
        {
            return _repo.UpdateVoucher(voucher);
        }
    }
}