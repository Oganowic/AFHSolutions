using System;
using System.Collections.Generic;
using System.Text;
using AFH.Entities.Concrete;


namespace AFH.Business.Abstract
{
    public interface IDistrictService
    {
        List<District> GetAll();
        List<District> GetByCity(int cityID);
        void Add(District district);
        void Update(District district);
        void Delete(int districtID);
    }
}
