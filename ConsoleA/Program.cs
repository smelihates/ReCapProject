using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleA
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
            ColorManager colorManager = new ColorManager(new InMemoryColorDal());
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("");
            Console.WriteLine("Mevcut arabaları listeleme");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id: {0,-2}   Marka:{1,-10}   Renk:{2,-10}   Model Yılı: {3,-5}  Fiyatı: {4,-8}TL   Açıklama: {5}", car.Id, brandManager.GetByBrandId(car.BrandId).BrandName, colorManager.GetByColorId(car.ColorId).ColorName, car.ModelYear, car.DailyPrice, car.Description);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            Car car1= new Car
            {
                Id = 6,
                BrandId = 2,
                ColorId = 2,
                DailyPrice = 200000,
                ModelYear = 2015,
                Description = "Sedan"
            };

            carManager.Add(car1);

            Console.WriteLine("");
            Console.WriteLine("Araba ekleme sonrası listeleme");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id: {0,-2}   Marka:{1,-10}   Renk:{2,-10}   Model Yılı: {3,-5}  Fiyatı: {4,-8}TL   Açıklama: {5}", car.Id, brandManager.GetByBrandId(car.BrandId).BrandName, colorManager.GetByColorId(car.ColorId).ColorName, car.ModelYear, car.DailyPrice, car.Description);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            car1.BrandId = 1;
            carManager.Update(car1);

            Console.WriteLine("");
            Console.WriteLine("Araba güncelleme sonrası listeleme");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id: {0,-2}   Marka:{1,-10}   Renk:{2,-10}   Model Yılı: {3,-5}  Fiyatı: {4,-8}TL   Açıklama: {5}", car.Id, brandManager.GetByBrandId(car.BrandId).BrandName, colorManager.GetByColorId(car.ColorId).ColorName, car.ModelYear, car.DailyPrice, car.Description);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            carManager.Delete(car1);
            Console.WriteLine("");
            Console.WriteLine("Araba silme sonrası listeleme");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id: {0,-2}   Marka:{1,-10}   Renk:{2,-10}   Model Yılı: {3,-5}  Fiyatı: {4,-8}TL   Açıklama: {5}", car.Id, brandManager.GetByBrandId(car.BrandId).BrandName, colorManager.GetByColorId(car.ColorId).ColorName, car.ModelYear, car.DailyPrice, car.Description);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }
    }
}
