using NetCore_TDD.Infra.Models;
using NetCore_TDD.Infra.Repositories;
using NetCore_TDD.Infra.Validations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NetCore_TDD.Test.Test
{
    public class PostInsuranceTests: BaseTest
    {
        #region Theory

/*        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("La Caja Seguros, 'Desea aprende TDD o lo que esta en la caja?' LA CAJA CAJA")]
        public void Theory_PostInsurer_Name_NoValidation(string Name)
        {
            var insurer = new Insurance
            {
                Name = Name
            };
            Assert.Null(insurer.Name);
            Assert.Empty(insurer.Name);
            Assert.True(insurer.Name.Length > 1);

        }*/

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("La Caja Seguros, 'Desea aprende TDD o lo que esta en la caja?' LA CAJA CAJA")]
        public void Theory_PostInsurer_Name_Validation(string Name)
        {
            var insurer = new Insurance
            {
                Name = Name
            };

            var val = new PostInsuranceValidator().Validate(insurer);
            Assert.False(val.IsValid);
        }

        #endregion

        #region Fact
        //[Fact]
        //public void Fact_PostInsurance_NoClassNoRepository()
        //{
        //    var insurer = new Insurance(1,"Santader", 1, true);

        //    _context.Insurance.Add(insurer);
        //    _context.SaveChanges();

        //    Assert.Equal(1, insurer.Id);

        //}

        //[Fact]
        //public void Fact_PostInsurance_NoRepository()
        //{
        //    var insurer = new Insurance(1,"Santader", 1, true);

        //    _context.Insurance.Add(insurer);
        //    _context.SaveChanges();

        //    Assert.Equal(1, insurer.Id);
        //}


/*        [Fact]
        public void Fact_PostInsurance()
        {
            var insurer = new Insurance(1, "Santader", 1, true);

            _context.Insurance.Add(insurer);
            _context.SaveChanges();

            Assert.Equal(1, insurer.Id);
        }*/


        //Repository
        [Fact]
        public void Fact_PostInsurance()
        {
            var insurer = new Insurance(1, "Santader", 1, true);

            
            insurer = new InsuranceRepository(_context).Post(insurer);

            Assert.Equal(1, insurer.Id);
        }


        #endregion

    }
}
