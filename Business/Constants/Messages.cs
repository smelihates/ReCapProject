using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string BrandAdded = "Marka sisteme eklendi";
        public static string BrandNameInvalid = "Ürün ismi en az 2 karakter olmalıdır!";
        public static string BrandDeleted = "Marka sistemden silindi!";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandsListed = "Markalar listelendi";

        public static string ColorAdded = "Renk sisteme eklendi";
        public static string ColorDeleted = "Renk sistemden silindi!";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorsListed = "Renkler listelendi";

        public static string CarAdded = "Araba sisteme eklendi";
        public static string CarDeleted = "Araba sistemden silindi!";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarDailyPriceInvalid = "Araba günlük fiyatı 0 dan büyük olmalıdır!";

        public static string UserAdded = "Kullanıcı sisteme eklendi";
        public static string UserDeleted = "Kullanıcı sistemden silindi'";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UsersListed = "Kullanıcılar listelendi";

        public static string CustomerAdded = "Müşteri sisteme eklendi";
        public static string CustomerDeleted = "Müşteri sistemden silindi'";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomersListed = "Müşteriler listelendi";

        public static string RentalAdded = "Kiralama işlemi başlatıldı";
        public static string RentalFinished = "Kiralama işlemi bitirildi";
        public static string RentalDeleted = "Kiralama sistemden silindi'";
        public static string RentalUpdated = "Kiralama güncellendi";
        public static string RentalsListed = "Kiralamalar listelendi";

        public static string RentalReturnError = "Araç kiralama için uygun değil! Başka Araç seçin.";

        public static string CarImageAdded = "Araç resmi eklendi.";
        public static string CarImageDeleted = "Araç resmi silindi";
        public static string CarImagesListed = "Araç resimleri listelendi";
        public static string CarImageUpdated = "Araç resmi güncellendi";
        public static string MaxCarImagesExceeded = "Maksimum araç resim sayısı aşıldı!";
    }
}
