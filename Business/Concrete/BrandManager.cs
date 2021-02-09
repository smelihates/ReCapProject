using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
//
namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            if (brand.BrandName.Length>=2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("{0} markası başarıyla kaydedildi.",brand.BrandName);
            }
            else
            {
                Console.WriteLine("{0} markası en az iki karakter olmalı!",brand.BrandName);
            }
            
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int Id)
        {
            return _brandDal.Get(p => p.BrandId == Id);
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length >= 2)
            {
                _brandDal.Update(brand); 
                Console.WriteLine("{0} markası başarıyla kaydedildi.", brand.BrandName);
            }
            else
            {
                Console.WriteLine("{0} markası en az iki karakter olmalı!", brand.BrandName);

            }
            
        }
    }
}
