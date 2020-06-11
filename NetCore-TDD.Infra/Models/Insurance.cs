using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore_TDD.Infra.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdProvince { get; set; }
        public bool IsActive { get; set; }

        public Insurance()
        {

        }

        public Insurance(int Id, string Name, int IdProvince, bool IsActive)
        {
            this.Id = Id;
            this.Name = Name;
            this.IdProvince = IdProvince;
            this.IsActive = IsActive;
        }

    }
}
