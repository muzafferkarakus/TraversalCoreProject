﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class Feature2Manager : IFeature2Service
    {
        IFeature2Dal _feature2Dal;

        public Feature2Manager(IFeature2Dal feature2Dal)
        {
            _feature2Dal = feature2Dal;
        }

        public List<Feature2> GetList()
        {
            return _feature2Dal.GetList();
        }

        public void TAdd(Feature2 t)
        {
            _feature2Dal.Insert(t);
        }

        public void TDelete(Feature2 t)
        {
            _feature2Dal.Delete(t);
        }

        public Feature2 TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature2 t)
        {
            _feature2Dal.Update(t);
        }
    }
}
