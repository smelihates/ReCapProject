using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Data;
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
            Console.WriteLine("----------------");
            Console.WriteLine("Arabalar     : 1");
            Console.WriteLine("Markalar     : 2");
            Console.WriteLine("Renkler      : 3");
            Console.WriteLine("Kullanıcılar : 4");
            Console.WriteLine("Müşteriler   : 5");
            Console.WriteLine("Kiralama     : 6");

            Console.WriteLine("Seçiminizi yapınız");
            AMenu = Int32.Parse(Console.ReadLine());

            Console.Clear();
        AltMenu:
            Console.WriteLine("-----------");
            if (AMenu == 1)
            {
                Console.WriteLine("Araba işlemleri");
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
                Console.WriteLine("Renk işlemleri");
                Console.WriteLine("Listele  : 1");
                Console.WriteLine("Bul      : 2");
                Console.WriteLine("Ekle     : 3");
                Console.WriteLine("Güncelle : 4");
                Console.WriteLine("Sil      : 5");
                Console.WriteLine("Ana Menu : 0");
            }
            else if (AMenu == 4)
            {
                Console.WriteLine("Kullanıcı işlemleri");
                Console.WriteLine("Listele  : 1");
                Console.WriteLine("Bul      : 2");
                Console.WriteLine("Ekle     : 3");
                Console.WriteLine("Güncelle : 4");
                Console.WriteLine("Sil      : 5");
                Console.WriteLine("Ana Menu : 0");
            }
            else if (AMenu == 5)
            {
                Console.WriteLine("Müşteri işlemleri");
                Console.WriteLine("Listele  : 1");
                Console.WriteLine("Bul      : 2");
                Console.WriteLine("Ekle     : 3");
                Console.WriteLine("Güncelle : 4");
                Console.WriteLine("Sil      : 5");
                Console.WriteLine("Ana Menu : 0");
            }
            else if (AMenu == 6)
            {
                Console.WriteLine("Kiralama işlemleri");
                Console.WriteLine("Araç Kiralama          : 1");
                Console.WriteLine("Araç Teslim Alma       : 2");
                Console.WriteLine("Kiradaki Araçlar       : 3");
                //Console.WriteLine("Müsait Araçlar         : 4");
                Console.WriteLine("Tüm Kayıtlar           : 4");
                Console.WriteLine("Ana Menu               : 0");
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

                case 4:
                    switch (AltMenu)
                    {
                        case 0:
                            goto AnaMenu;
                        case 1:
                            KullanicilariListele();
                            break;
                        case 2:
                            KullaniciBul();
                            break;
                        case 3:
                            KullaniciEkle();
                            break;
                        case 4:
                            KullaniciGuncelle();
                            break;
                        case 5:
                            KullaniciSil();
                            break;
                    }
                    goto AltMenu;
                case 5:
                    switch (AltMenu)
                    {
                        case 0:
                            goto AnaMenu;
                        case 1:
                            MusterileriListele();
                            break;
                        case 2:
                            MusteriBul();
                            break;
                        case 3:
                            MusteriEkle();
                            break;
                        case 4:
                            MusteriGuncelle();
                            break;
                        case 5:
                            MusteriSil();
                            break;
                    }
                    goto AltMenu;
                case 6:
                    switch (AltMenu)
                    {
                        case 0:
                            goto AnaMenu;
                        case 1:
                            AracKirala();
                            break;
                        case 2:
                            AracTeslimAl();
                            break;
                        case 3:
                            KiradakiAraclar();
                            break;
                        //case 4:
                        //    //MusaitAraclar();
                        //    break;
                        case 4:
                            TumKayitlar();
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



        private static void KiradakiAraclar()
        {
            Console.WriteLine("Kiralık Araçlar Listesi-------------------------------------------------------------------------------------------------------------");

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentedCars();
            foreach (var rental in result.Data)
            {
                Console.WriteLine("CustomerId :{0,-2}   CarId:{1,-10}   RentDate:{2,-10}    ReturnDate:{3,-10}", rental.CustomerId, rental.CarId, rental.RentDate, rental.ReturnDate);
            }


            Console.WriteLine(result.Message);

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }

        private static void TumKayitlar()
        {
            Console.WriteLine("Kiralık Araçlar Listesi-------------------------------------------------------------------------------------------------------------");

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetAll();

            foreach (var rental in result.Data)
            {
                Console.WriteLine("CustomerId :{0,-2}   CarId:{1,-10}   RentDate:{2,-10}    ReturnDate:{3,-10}", rental.CustomerId, rental.CarId, rental.RentDate, rental.ReturnDate);
            }

            Console.WriteLine(result.Message);

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");


        }

        private static void AracTeslimAl()
        {

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental();

            Console.WriteLine("Teslim Alınacak Aracın  CarId'sini giriniz");
            int i = Int32.Parse(Console.ReadLine());
            rental.CarId = i;

            var result = rentalManager.Update(rental);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }

        private static void AracKirala()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental();


            Console.WriteLine("Kiralanacak Araç Id'sini giriniz");
            rental.CarId = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Kiralayacak Müşteri Id'sini giriniz");
            rental.CustomerId = Int32.Parse(Console.ReadLine());

            rental.RentDate = DateTime.Now;

            var result = rentalManager.Add(rental);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }

        private static void MusterileriListele()
        {
            Console.WriteLine("Müşteri Listesi-------------------------------------------------------------------------------------------------------------");

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.GetAll();

            foreach (var customer in result.Data)
            {
                Console.WriteLine("CustomerId :{0,-2}   Company Name:{1,-10}   UserId:{2,-10}", customer.CustomerId, customer.CompanyName, customer.UserId);
            }

            Console.WriteLine(result.Message);

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }
        private static void MusteriBul()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer();

            Console.WriteLine("CustomerId giriniz");
            int i = Int32.Parse(Console.ReadLine());

            var result = customerManager.GetById(i);

            customer = result.Data;
            Console.WriteLine("CustomerId :{0,-2}   Company Name:{1,-10}   UserId:{2,-10}", customer.CustomerId, customer.CompanyName, customer.UserId);
            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }
        private static void MusteriEkle()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer();

            Console.WriteLine("UserId giriniz");
            customer.UserId = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Müşteri Adı giriniz");
            customer.CompanyName = Console.ReadLine();

            var result = customerManager.Add(customer);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }
        private static void MusteriGuncelle()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer();
            Customer customer1 = new Customer();

            Console.WriteLine("Güncellenecek CustomerId'yi giriniz");
            int i = Int32.Parse(Console.ReadLine());

            customer = customerManager.GetById(i).Data;
            Console.WriteLine("CustomerId :{0,-2}   Company Name:{1,-10}   UserId:{2,-10}", customer.CustomerId, customer.CompanyName, customer.UserId);

            customer1.CustomerId = i;

            Console.WriteLine("UserId giriniz");
            customer1.UserId = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Müşteri Adı giriniz");
            customer1.CompanyName = Console.ReadLine();

            var result = customerManager.Update(customer1);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }
        private static void MusteriSil()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer();

            Console.WriteLine("Silinecek CustomerId'yi giriniz");
            int i = Int32.Parse(Console.ReadLine());

            customer = customerManager.GetById(i).Data;

            var result = customerManager.Delete(customer);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }

        private static void KullanicilariListele()
        {
            Console.WriteLine("Kullanici Listesi-------------------------------------------------------------------------------------------------------------");

            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.GetAll();

            foreach (var user in result.Data)
            {
                Console.WriteLine("Id: {0,-2}   Name :{1,-20}   EMail:{2,-10}", user.Id, user.FirstName + " " + user.LastName, user.Email);
            }

            Console.WriteLine(result.Message);

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }
        private static void KullaniciBul()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user = new User();

            Console.WriteLine("User Id giriniz");
            int i = Int32.Parse(Console.ReadLine());

            var result = userManager.GetById(i);

            user = result.Data;
            Console.WriteLine("Id: {0,-2}   Name :{1,-20}   EMail:{2,-10}", user.Id, user.FirstName + " " + user.LastName, user.Email);
            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }
        private static void KullaniciEkle()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user = new User();

            Console.WriteLine("Kullanıcı Adı giriniz");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("Kullanıcı Soyadı giriniz");
            user.LastName = Console.ReadLine();

            Console.WriteLine("Kullanıcı Email'i giriniz");
            user.Email = Console.ReadLine();

            user.Password = "12df12er";

            var result = userManager.Add(user);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }
        private static void KullaniciGuncelle()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user = new User();
            User user1 = new User();

            Console.WriteLine("Güncellenecek Kullanıcı Id'sini giriniz");
            int i = Int32.Parse(Console.ReadLine());

            user = userManager.GetById(i).Data;
            Console.WriteLine("Id: {0,-2}   Name :{1,-20}   EMail:{2,-10}", user.Id, user.FirstName + " " + user.LastName, user.Email);

            Console.WriteLine("Kullanıcı Adı giriniz");
            user1.FirstName = Console.ReadLine();

            Console.WriteLine("Kullanıcı Soyadı giriniz");
            user1.LastName = Console.ReadLine();

            Console.WriteLine("Kullanıcı Email'i giriniz");
            user1.Email = Console.ReadLine();

            user1.Password = "12df12er";

            var result = userManager.Update(user1);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }
        private static void KullaniciSil()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user = new User();

            Console.WriteLine("Silinecek Kullanıcı Id'sini giriniz");
            int i = Int32.Parse(Console.ReadLine());

            user = userManager.GetById(i).Data;

            var result = userManager.Delete(user);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }

        private static void AracListele()
        {
            Console.WriteLine("Araç Listesi-------------------------------------------------------------------------------------------------------------");

            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();

            foreach (var car in result.Data)
            {
                Console.WriteLine("Id: {0,-2}   Marka:{1,-2}   Renk:{2,-2}   Model Yılı: {3,-5}  Fiyatı: {4,-5:0}TL   Açıklama: {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine(result.Message);

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }
        private static void MarkaListele()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var item in brandManager.GetAll().Data)
            {
                Console.WriteLine("Id: {0,-2}   Marka:{1,-2}", item.BrandId, item.BrandName);
            }

            Console.WriteLine("Listelemek için Marka Id giriniz");
            int i = Int32.Parse(Console.ReadLine());

            var result = carManager.GetCarsByBrandId(i);

            foreach (var car in result.Data)
            {
                Console.WriteLine("Id: {0,-2}   Marka:{1,-2}   Renk:{2,-2}   Model Yılı: {3,-5}  Fiyatı: {4,-5:0}TL   Açıklama: {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }
            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }
        private static void AracBul()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car();

            Console.WriteLine("Araç Id giriniz");
            int i = Int32.Parse(Console.ReadLine());

            var result = carManager.GetById(i);

            car = result.Data;
            Console.WriteLine("Id: {0,-2}   Marka:{1,-2}   Renk:{2,-2}   Model Yılı: {3,-5}  Fiyatı: {4,-5:0}TL   Açıklama: {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }
        private static void AracEkle()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Car car = new Car();

            foreach (var item in brandManager.GetAll().Data)
            {
                Console.WriteLine("Id: {0,-2}   Marka:{1,-2}", item.BrandId, item.BrandName);
            }
            Console.WriteLine("Marka Id giriniz");
            car.BrandId = Int32.Parse(Console.ReadLine());

            foreach (var item in colorManager.GetAll().Data)
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

            var result = carManager.Add(car);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }
        private static void AracGuncelle()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Car car = new Car();

            Console.WriteLine("Güncellenecek Aracın Id'sini giriniz");
            int i = Int32.Parse(Console.ReadLine());

            car = carManager.GetById(i).Data;
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

            var result = carManager.Update(car);

            car = carManager.GetById(i).Data;
            Console.WriteLine("Id: {0,-2}   Marka:{1,-2}   Renk:{2,-2}   Model Yılı: {3,-5}  Fiyatı: {4,-5:0}TL   Açıklama: {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }
        private static void AracSil()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car();
            Console.WriteLine("Silinecek Aracın Id'sini giriniz");
            int i = Int32.Parse(Console.ReadLine());
            car = carManager.GetById(i).Data;

            var result = carManager.Delete(car);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }
        private static void AracDetayListele()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            foreach (var car in result.Data)
            {
                Console.WriteLine("Id: {0,-2} Marka:{1,-10} Renk:{2,-10} Fiyat:{3,-5:0}TL", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            }

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }

        private static void MarkalariListele()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetAll();

            foreach (var item in result.Data)
            {
                Console.WriteLine("Id: {0,-2}   Marka:{1,-2}", item.BrandId, item.BrandName);

            }
            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }
        private static void MarkaBul()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();

            Console.WriteLine("Marka Id giriniz");
            int i = Int32.Parse(Console.ReadLine());

            var result = brandManager.GetById(i);

            brand = result.Data;
            Console.WriteLine("Id: {0,-2}   Marka:{1,-2}", brand.BrandId, brand.BrandName);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }
        private static void MarkaEkle()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();

            Console.WriteLine("Marka Adı giriniz");
            brand.BrandName = Console.ReadLine();

            var result = brandManager.Add(brand);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }
        private static void MarkaGuncelle()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();

            Console.WriteLine("Güncellenecek Markanın Id'sini giriniz");
            int i = Int32.Parse(Console.ReadLine());

            brand = brandManager.GetById(i).Data;
            Console.WriteLine("Id: {0,-2}   Marka:{1,-2}", brand.BrandId, brand.BrandName);

            Console.WriteLine("Marka adını giriniz");
            brand.BrandName = Console.ReadLine();

            var result = brandManager.Update(brand);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }
        private static void MarkaSil()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();

            Console.WriteLine("Silinecek Markanın Id'sini giriniz");
            int i = Int32.Parse(Console.ReadLine());

            brand = brandManager.GetById(i).Data;

            var result = brandManager.Delete(brand);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }

        private static void RenkleriListele()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();

            foreach (var item in result.Data)
            {
                Console.WriteLine("Id: {0,-2}   Renk:{1,-2}", item.ColorId, item.ColorName);
            }

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }
        private static void RenkBul()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color();
            int i;

            Console.WriteLine("Renk Id'sini giriniz.");
            i = Int32.Parse(Console.ReadLine());

            var result = colorManager.GetById(i);
            color = result.Data;

            Console.WriteLine("Id: {0,-2}   Renk:{1,-2}", color.ColorId, color.ColorName);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }
        private static void RenkEkle()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color();

            Console.WriteLine("Renk adı giriniz.");

            color.ColorName = Console.ReadLine();

            var result = colorManager.Add(color);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }
        private static void RenkGuncelle()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color();
            int i;

            Console.WriteLine("Güncellenecek Renk Id'sini giriniz.");
            i = Int32.Parse(Console.ReadLine());


            color = colorManager.GetById(i).Data;
            Console.WriteLine("Id: {0,-2}   Renk:{1,-2}", color.ColorId, color.ColorName);

            Console.WriteLine("Renk adı giriniz");
            color.ColorName = Console.ReadLine();

            var result = colorManager.Update(color);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }
        private static void RenkSil()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color();
            int i;

            Console.WriteLine("Silinecek Renk Id'sini giriniz.");
            i = Int32.Parse(Console.ReadLine());
            color = colorManager.GetById(i).Data;

            var result = colorManager.Delete(color);

            Console.WriteLine(result.Message);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
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
