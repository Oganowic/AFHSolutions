using System;
using System.Collections.Generic;
using System.Text;
using AFH.Entities.Concrete;
using AFH.DataAccess.Abstract;
using AFH.Business.Abstract;

namespace AFH.Business.Concrete
{
    public class CityManager : ICityService
    {
        private ICityDal _cityDal;
        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public List<City> GetAll()
        {
            return _cityDal.GetList();
        }
        public void Add(City city)
        {
            _cityDal.Add(city);
        }
        public void Update(City city)
        {
            _cityDal.Update(city);
        }
        public void Delete(int cityID)
        {
            _cityDal.Delete(new City { CityID = cityID });
        }
    }
}
