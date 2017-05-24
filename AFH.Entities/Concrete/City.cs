using System;
using System.Collections.Generic;
using System.Text;
using AFH.Core.Entities;

namespace AFH.Entities.Concrete
{
    public class City : IEntity
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public string CityCode { get; set; }

    }
}
