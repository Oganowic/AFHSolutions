using System;
using System.Collections.Generic;
using System.Text;
using AFH.Entities.Concrete;

namespace AFH.Business.Abstract
{
    public interface ICityService
    {
        List<City> GetAll();
        void Add(City city);
        void Update(City city);
        void Delete(int cityID);
    }
}
