using System;
using System.Collections.Generic;
using System.Text;
using AFH.Core.DataAccess.EntityFramework;
using AFH.DataAccess.Abstract;
using AFH.Entities.Concrete;

namespace AFH.DataAccess.Concrete.EntityFramework
{
    public class EfDistrictDal:EfEntityRepositoryBase<District,AFHContext>, IDistrictDal
    {
    }
}
