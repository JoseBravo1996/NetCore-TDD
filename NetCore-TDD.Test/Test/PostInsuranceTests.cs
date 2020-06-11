using NetCore_TDD.Infra.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NetCore_TDD.Test.Test
{
    public class PostInsuranceTests
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
        //    ins.Insurance.Add(insurer);
        //    ins.SaveChanges();

        //    // ASSERT
        //    Assert.Equal(1, insurer.Id);

        //}

        [Fact]
        public void Fact_PostInsurance_NoRepository()
        {
            // EXAMPLE
            var insurer = new Insurance(1,"Santader", 1, true);

            // REPOSITORY
            ins.Insurance.Add(insurer);
            ins.SaveChanges();

            // ASSERT
            Assert.Equal(1, insurer.Id);
        }

#endregion
    
}
}
