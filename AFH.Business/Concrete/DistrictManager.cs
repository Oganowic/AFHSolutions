using System;
using System.Collections.Generic;
using System.Text;
using AFH.Business.Abstract;
using AFH.Entities.Concrete;
using AFH.DataAccess.Abstract;

namespace AFH.Business.Concrete
{
    public class DistrictManager : IDistrictService
    {
        private IDistrictDal _districtDal;
        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public List<District> GetAll()
        {
            return _districtDal.GetList();
        }
        public List<District> GetByCity(int cityID)
        {
            return _districtDal.GetList(p => p.CityID == cityID || cityID == 0);
        }
        public void Add(District district)
        {
            _districtDal.Add(district);
        }
        public void Update(District district)
        {
            _districtDal.Update(district);
        }
        public void Delete(int districtID)
        {
            _districtDal.Delete(new District { DistrictID = districtID });
        }
    }
}
