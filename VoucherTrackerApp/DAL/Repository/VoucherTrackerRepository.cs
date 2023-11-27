using VoucherTrackerApp.DAL.Interface;
using VoucherTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace VoucherTrackerApp.DAL.Repository
{
    public class VoucherTrackerRepository : IVoucherTrackerRepository
    {
        private VoucherTrackerDbContext _context;
        public VoucherTrackerRepository(VoucherTrackerDbContext Context)
        {
            this._context = Context;
        }
        public IEnumerable<Voucher> GetVouchers()
        {
             return _context.Vouchers.ToList();
        }
        public Voucher GetVoucherByID(int id)
        {
            return _context.Vouchers.Find(id);
        }
        public Voucher InsertVoucher(Voucher voucher)
        {
            return _context.Vouchers.Add(voucher);
        }
        public int DeleteVoucher(int voucherID)
        {
            Voucher voucher = _context.Vouchers.Find(voucherID);
            var res= _context.Vouchers.Remove(voucher);
            return res.VoucherId;
        }
        public bool UpdateVoucher(Voucher voucher)
        {
            var res= _context.Entry(voucher).State = EntityState.Modified;
            return res.Equals("voucher");
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
