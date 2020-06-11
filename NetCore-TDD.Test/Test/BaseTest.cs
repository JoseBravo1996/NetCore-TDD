using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NetCore_TDD.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore_TDD.Test.Test
{
    public class BaseTest
    {
        protected DBContext _context;
        public BaseTest(DBContext _context = null)
        {
            this._context = _context ?? GetInMemoryDBContext();
        }
        protected DBContext GetInMemoryDBContext()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            var builder = new DbContextOptionsBuilder<DBContext>();
            var options = builder.UseInMemoryDatabase("test").UseInternalServiceProvider(serviceProvider).Options;

            DBContext dbContext = new DBContext(options);
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            return dbContext;
        }
    }
}
