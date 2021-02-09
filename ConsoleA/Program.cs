using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
//

namespace ConsoleUI
{
    class Program
    {
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        ColorManager colorManager = new ColorManager(new EfColorDal());
        CarManager carManager = new CarManager(new EfCarDal());

        static void Main(string[] args)
        {


            int AMenu = 0;
            int AltMenu = 0;

        AnaMenu:
            Console.Clear();
            Console.WriteLine("-----------");
            Console.WriteLine("Araba : 1");
            Console.WriteLine("Marka : 2");
            Console.WriteLine("Renk  : 3");
            Console.WriteLine("Seçiminizi yapınız");
            AMenu = Int32.Parse(Console.ReadLine());

            Console.Clear();
        AltMenu:
            Console.WriteLine("-----------");
            if (AMenu == 1)
            {
                Console.WriteLine("Araç ile ilgili işlemler");
                Console.WriteLine("Listele          : 1");
                Console.WriteLine("Marka Listele    : 2");
                Console.WriteLine("Araç Bul         : 3");
                Console.WriteLine("Araç Ekle        : 4");
                Console.WriteLine("Araç güncelle    : 5");
                Console.WriteLine("Araç Sil         : 6");
                Console.WriteLine("Araç Detay Liste : 7");
                Console.WriteLine("Ana Menu         : 0");
                
            }
            else if (AMenu == 2)
            {
                Console.WriteLine("Marka ile ilgili işlemler");
                Console.WriteLine("Listele  : 1");
                Console.WriteLine("Bul      : 2");
                Console.WriteLine("Ekle     : 3");
                Console.WriteLine("Güncelle : 4");
                Console.WriteLine("Sil      : 5");
                Console.WriteLine("Ana Menu : 0");
            }
            else if (AMenu == 3)
            {
                Console.WriteLine("Renk ile ilgili işlemler");
                Console.WriteLine("Listele  : 1");
                Console.WriteLine("Bul      : 2");
                Console.WriteLine("Ekle     : 3");
                Console.WriteLine("Güncelle : 4");
                Console.WriteLine("Sil      : 5");
                Console.WriteLine("Ana Menu : 0");
            }

            AltMenu = Int32.Parse(Console.ReadLine());

            switch (AMenu)
            {
                case 1:
                    switch (AltMenu)
                    {
                        case 0:
                            goto AnaMenu;
                        case 1:
                            AracListele();
                            break;
                        case 2:
                            MarkaListele();
                            break;
                        case 3:
                            AracBul();
                            break;
                        case 4:
                            AracEkle();
                            break;
                        case 5:
                            AracGuncelle();
                            break;
                        case 6:
                            AracSil();
                            break;
                        case 7:
                            AracDetayListele();
                            break;
                    }
                    goto AltMenu;

                case 2:
                    switch (AltMenu)
                    {
                        case 0:
                            goto AnaMenu;
                        case 1:
                            MarkalariListele();
                            break;
                        case 2:
                            MarkaBul();
                            break;
                        case 3:
                            MarkaEkle();
                            break;
                        case 4:
                            MarkaGuncelle();
                            break;
                        case 5:
                            MarkaSil();
                            break;
                    }
                    goto AltMenu;

                case 3:
                    switch (AltMenu)
                    {
                        case 0:
                            goto AnaMenu;
                        case 1:
                            RenkleriListele();
                            break;
                        case 2:
                            RenkBul();
                            break;
                        case 3:
                            RenkEkle();
                            break;
                        case 4:
                            RenkGuncelle();
                            break;
                        case 5:
                            RenkSil();
                            break;
                    }
                    goto AltMenu;

            }



            Console.WriteLine(AMenu + "-" + AltMenu);
            Console.ReadKey();
            goto AnaMenu;

            //TestEntityF();

            //TestInMemory();

        }

        private static void AracListele()
        {

            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("Araç Listesi-------------------------------------------------------------------------------------------------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id: {0,-2}   Marka:{1,-2}   Renk:{2,-2}   Model Yılı: {3,-5}  Fiyatı: {4,-5:0}TL   Açıklama: {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }

        private static void MarkaListele()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine("Id: {0,-2}   Marka:{1,-2}", item.BrandId, item.BrandName);
            }
            Console.WriteLine("Listelemek için Marka Id giriniz");
            int i = Int32.Parse(Console.ReadLine());

            foreach (var car in carManager.GetCarsByBrandId(i))
            {
                Console.WriteLine("Id: {0,-2}   Marka:{1,-2}   Renk:{2,-2}   Model Yılı: {3,-5}  Fiyatı: {4,-5:0}TL   Açıklama: {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }

        private static void AracBul()
        {

            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car();

            Console.WriteLine("Araç Id giriniz");
            int i = Int32.Parse(Console.ReadLine());

            car = carManager.GetById(i);
            Console.WriteLine("Id: {0,-2}   Marka:{1,-2}   Renk:{2,-2}   Model Yılı: {3,-5}  Fiyatı: {4,-5:0}TL   Açıklama: {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);

        }

        private static void AracEkle()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Car car = new Car();


            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine("Id: {0,-2}   Marka:{1,-2}", item.BrandId, item.BrandName);
            }
            Console.WriteLine("Marka Id giriniz");
            car.BrandId = Int32.Parse(Console.ReadLine());

            foreach (var item in colorManager.GetAll())
            {
                Console.WriteLine("Id: {0,-2}   Renk:{1,-2}", item.ColorId, item.ColorName);
            }
            Console.WriteLine("Renk Id giriniz");
            car.ColorId = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Model yılı giriniz");
            car.ModelYear = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Fiyat bilgisi giriniz");
            car.DailyPrice = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Açıklama giriniz");
            car.Description = Console.ReadLine();

            carManager.Add(car);

            Console.WriteLine("Araç bilgileri eklendi!");

        }

        private static void AracGuncelle()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Car car = new Car();

            Console.WriteLine("Güncellenecek Aracın Id'sini giriniz");
            int i = Int32.Parse(Console.ReadLine());

            car = carManager.GetById(i);
            Console.WriteLine("Id: {0,-2}   Marka:{1,-2}   Renk:{2,-2}   Model Yılı: {3,-5}  Fiyatı: {4,-5:0}TL   Açıklama: {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);

            Console.WriteLine("Marka Id giriniz.");
            car.BrandId = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Renk Id giriniz.");
            car.ColorId = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Model yılı giriniz.");
            car.ModelYear = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Fiyat bilgisi giriniz.");
            car.DailyPrice = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Açıklama giriniz.");
            car.Description = Console.ReadLine();

            carManager.Update(car);

            Console.WriteLine("Araç bilgileri aşağıdaki şekilde güncellendi.");
            car = carManager.GetById(i);
            Console.WriteLine("Id: {0,-2}   Marka:{1,-2}   Renk:{2,-2}   Model Yılı: {3,-5}  Fiyatı: {4,-5:0}TL   Açıklama: {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);

        }

        private static void AracSil()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car();
            Console.WriteLine("Silinecek Aracın Id'sini giriniz");
            int i = Int32.Parse(Console.ReadLine());
            car = carManager.GetById(i);
            carManager.Delete(car);
            Console.WriteLine("Araç bilgileri silindi!");

        }

        private static void AracDetayListele()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Id: {0,-2} Marka:{1,-10} Renk:{2,-10} Fiyat:{3,-5:0}TL", car.CarName,car.BrandName,car.ColorName,car.DailyPrice );

            }
        }
        private static void MarkalariListele()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine("Id: {0,-2}   Marka:{1,-2}", item.BrandId, item.BrandName);

            }
        }

        private static void MarkaBul()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();

            Console.WriteLine("Marka Id giriniz");
            int i = Int32.Parse(Console.ReadLine());

            brand = brandManager.GetById(i);
            Console.WriteLine("Id: {0,-2}   Marka:{1,-2}", brand.BrandId, brand.BrandName);


        }

        private static void MarkaEkle()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();
            Console.WriteLine("Marka Adı giriniz");
            brand.BrandName = Console.ReadLine();
            brandManager.Add(brand);

            Console.WriteLine("Marka bilgisi eklendi.");

        }

        private static void MarkaGuncelle()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();

            Console.WriteLine("Güncellenecek Markanın Id'sini giriniz");
            int i = Int32.Parse(Console.ReadLine());

            brand = brandManager.GetById(i);
            Console.WriteLine("Id: {0,-2}   Marka:{1,-2}", brand.BrandId, brand.BrandName);

            Console.WriteLine("Marka adını giriniz");
            brand.BrandName = Console.ReadLine();
            brandManager.Update(brand);

        }

        private static void MarkaSil()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();

            Console.WriteLine("Silinecek Markanın Id'sini giriniz");
            int i = Int32.Parse(Console.ReadLine());
            brand = brandManager.GetById(i);
            brandManager.Delete(brand);
            Console.WriteLine("Marka bilgisi silindi.");


        }

        private static void RenkleriListele()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var item in colorManager.GetAll())
            {
                Console.WriteLine("Id: {0,-2}   Renk:{1,-2}", item.ColorId, item.ColorName);

            }
        }

        private static void RenkBul()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color();
            int i;

            Console.WriteLine("Renk Id'sini giriniz.");
            i = Int32.Parse(Console.ReadLine());

            color = colorManager.GetById(i);
            Console.WriteLine("Id: {0,-2}   Renk:{1,-2}", color.ColorId, color.ColorName);

        }

        private static void RenkEkle()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color();
    
            Console.WriteLine("Renk adı giriniz.");

            color.ColorName = Console.ReadLine();
            colorManager.Add(color);
            Console.WriteLine("Renk bilgisi girildi.");
        }

        private static void RenkGuncelle()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color();
            int i;

            Console.WriteLine("Güncellenecek Renk Id'sini giriniz.");
            i = Int32.Parse(Console.ReadLine());
            
            color = colorManager.GetById(i);
            Console.WriteLine("Id: {0,-2}   Renk:{1,-2}", color.ColorId, color.ColorName);

            Console.WriteLine("Renk adı giriniz");
            color.ColorName = Console.ReadLine();
            colorManager.Update(color);
            Console.WriteLine("Renk bilgisi güncellendi");


        }

        private static void RenkSil()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color();
            int i;

            Console.WriteLine("Silinecek Renk Id'sini giriniz.");
            i = Int32.Parse(Console.ReadLine());
            color = colorManager.GetById(i);

            colorManager.Delete(color);
            Console.WriteLine("Renk bilgisi silindi!");


        }

        //private static void TestEntityF()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    CarManager carManager = new CarManager(new EfCarDal());

        //    Console.WriteLine("No:4-Ford marka arabalar");

        //    foreach (var car in carManager.GetCarsByBrandId(4))
        //    {
        //        Console.WriteLine("Id: {0,-2}   Marka:{1,-10}   Renk:{2,-10}   Model Yılı: {3,-5}  Fiyatı: {4,-8}TL   Açıklama: {5}", car.Id, brandManager.GetById(car.BrandId).BrandName, colorManager.GetById(car.ColorId).ColorName, car.ModelYear, car.DailyPrice, car.Description);

        //    }
        //    Console.WriteLine("-------------------------------------------------------------------------------------------------------------");


        //    Console.WriteLine("No:2-Gri renkli arabalar");
        //    foreach (var car in carManager.GetCarsByColorId(2))
        //    {
        //        Console.WriteLine("Id: {0,-2}   Marka:{1,-10}   Renk:{2,-10}   Model Yılı: {3,-5}  Fiyatı: {4,-8}TL   Açıklama: {5}", car.Id, brandManager.GetById(car.BrandId).BrandName, colorManager.GetById(car.ColorId).ColorName, car.ModelYear, car.DailyPrice, car.Description);
        //    }
        //    Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        //    carManager.Add(new Car { Id = 7, BrandId = 2, ColorId = 2, DailyPrice = 0, ModelYear = 2020, Description = "i3-3 Kapı-Elektrik" });
        //    brandManager.Add(new Brand { BrandId = 12, BrandName = "H" });
        //}

        //private static void TestInMemory()
        //{
        //    BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
        //    ColorManager colorManager = new ColorManager(new InMemoryColorDal());
        //    CarManager carManager = new CarManager(new InMemoryCarDal());

        //    Console.WriteLine("");
        //    Console.WriteLine("Mevcut arabaları listeleme");

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine("Id: {0,-2}   Marka:{1,-10}   Renk:{2,-10}   Model Yılı: {3,-5}  Fiyatı: {4,-8}TL   Açıklama: {5}", car.Id, brandManager.GetByBrandId(car.BrandId).BrandName, colorManager.GetByColorId(car.ColorId).ColorName, car.ModelYear, car.DailyPrice, car.Description);
        //    }
        //    Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        //    Car car1 = new Car
        //    {
        //        Id = 6,
        //        BrandId = 2,
        //        ColorId = 2,
        //        DailyPrice = 200000,
        //        ModelYear = 2015,
        //        Description = "Sedan"
        //    };

        //    carManager.Add(car1);

        //    Console.WriteLine("");
        //    Console.WriteLine("Araba ekleme sonrası listeleme");

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine("Id: {0,-2}   Marka:{1,-10}   Renk:{2,-10}   Model Yılı: {3,-5}  Fiyatı: {4,-8}TL   Açıklama: {5}", car.Id, brandManager.GetByBrandId(car.BrandId).BrandName, colorManager.GetByColorId(car.ColorId).ColorName, car.ModelYear, car.DailyPrice, car.Description);
        //    }
        //    Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        //    car1.BrandId = 1;
        //    carManager.Update(car1);

        //    Console.WriteLine("");
        //    Console.WriteLine("Araba güncelleme sonrası listeleme");

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine("Id: {0,-2}   Marka:{1,-10}   Renk:{2,-10}   Model Yılı: {3,-5}  Fiyatı: {4,-8}TL   Açıklama: {5}", car.Id, brandManager.GetByBrandId(car.BrandId).BrandName, colorManager.GetByColorId(car.ColorId).ColorName, car.ModelYear, car.DailyPrice, car.Description);
        //    }
        //    Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        //    carManager.Delete(car1);
        //    Console.WriteLine("");
        //    Console.WriteLine("Araba silme sonrası listeleme");

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine("Id: {0,-2}   Marka:{1,-10}   Renk:{2,-10}   Model Yılı: {3,-5}  Fiyatı: {4,-8}TL   Açıklama: {5}", car.Id, brandManager.GetByBrandId(car.BrandId).BrandName, colorManager.GetByColorId(car.ColorId).ColorName, car.ModelYear, car.DailyPrice, car.Description);
        //    }
        //    Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        //}
    }
}
