using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager:IFeatureDal
    {
        IFeatureDal _featuredal;

        public FeatureManager(IFeatureDal featuredal)
        {
            _featuredal = featuredal;
        }

        public void Delete(Feature t)
        {
            throw new NotImplementedException();
        }

        public Feature GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> GetList()
        {
            return _featuredal.GetList();
        }

        public void Insert(Feature t)
        {
            throw new NotImplementedException();
        }

        public void Update(Feature t)
        {
            throw new NotImplementedException();
        }
    }
}
