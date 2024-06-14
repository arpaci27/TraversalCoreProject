using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        IGuideDal _iGuideDal;

        public GuideManager(IGuideDal iGuideDal)
        {
            _iGuideDal = iGuideDal;
        }

        public void TAdd(Guide t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Guide t)
        {
            throw new NotImplementedException();
        }

        public Guide TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Guide> TGetList()
        {
            return _iGuideDal.GetList();
        }

        public void TUpdate(Guide t)
        {
            throw new NotImplementedException();
        }
    }
}
