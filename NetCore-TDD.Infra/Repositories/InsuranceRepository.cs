using NetCore_TDD.Infra.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore_TDD.Infra.Repositories
{
    public class InsuranceRepository
    {
        private readonly DBContext _context;
        public InsuranceRepository(DBContext ctx)
        {
            this._context = ctx;
        }
        public Insurance Post(Insurance insurer)
        {
            _context.Insurance.Add(insurer);
            _context.SaveChanges();
            return insurer;
        }
    }
}
