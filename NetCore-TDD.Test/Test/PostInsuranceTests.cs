using NetCore_TDD.Infra.Models;
using NetCore_TDD.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NetCore_TDD.Test.Test
{
    public class PostInsuranceTests: BaseTest
    {
        #region Theory
        #endregion

        #region Fact
        //[Fact]
        //public void Fact_PostInsurance_NoClassNoRepository()
        //{
        //    // EXAMPLE
        //    var insurer = new Insurance(1,"Santader", 1, true);

        //    // REPOSITORY
        //    _context.Insurance.Add(insurer);
        //    _context.SaveChanges();

        //    // ASSERT
        //    Assert.Equal(1, insurer.Id);

        //}

        //[Fact]
        //public void Fact_PostInsurance_NoRepository()
        //{
        //    // EXAMPLE
        //    var insurer = new Insurance(1,"Santader", 1, true);

        //    // REPOSITORY
        //    _context.Insurance.Add(insurer);
        //    _context.SaveChanges();

        //    // ASSERT
        //    Assert.Equal(1, insurer.Id);
        //}


        [Fact]
        public void Fact_PostInsurance()
        {
            // EXAMPLE
            var insurer = new Insurance(1, "Santader", 1, true);

            // REPOSITORY
            _context.Insurance.Add(insurer);
            _context.SaveChanges();

            // ASSERT
            Assert.Equal(1, insurer.Id);
        }

        [Fact]
        public void Fact_PostUser()
        {
            // EXAMPLE
            var insurer = new Insurance(1, "Santader", 1, true);

            // REPOSITORY
            insurer = new InsuranceRepository(_context).Post(insurer);

            // ASSERT
            Assert.Equal(1, insurer.Id);
        }


        #endregion

    }
}
