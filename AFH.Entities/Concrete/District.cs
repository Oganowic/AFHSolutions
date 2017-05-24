using System;
using System.Collections.Generic;
using System.Text;
using AFH.Core.Entities;

namespace AFH.Entities.Concrete
{
    public class District : IEntity
    {
        public int DistrictID { get; set; }
        public int CityID { get; set; }
        public string DistrictName { get; set; }
    }

}
