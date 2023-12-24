﻿using QLBanBalo.Models;

namespace QLBanBalo.Repository
{
    public class LoaiSpRepository : ILoaiSpRepository
    {
        private readonly QLBanBaloContext _context;
        public LoaiSpRepository(QLBanBaloContext context)
        {
            _context = context;
        }

        public TLoaiSp Add(TLoaiSp loaisp)
        {
            _context.TLoaiSps.Add(loaisp);
            _context.SaveChanges();
            return loaisp;
        }

        public TLoaiSp Delete(string maloaisp)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TLoaiSp> GetAllLoaiSp()
        {
            return _context.TLoaiSps;
        }

        public TLoaiSp GetLoaiSp(string maloaisp)
        {
            return _context.TLoaiSps.Find(maloaisp);
        }

        public TLoaiSp Update(TLoaiSp loaisp)
        {
            _context.Update(loaisp);
            _context.SaveChanges();
            return loaisp;
        }
    }
}
