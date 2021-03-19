using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarAddError = "Eklenecek Araç Sistemde Mevcut";
        public static string CarNameInvalid = "Araç İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarListed = "Araçlar Listelendi";
        public static string CarUpdated="Araç Güncellendi";
        public static string CarDeleted="Araç Silindi";

        public static string BrandDeleted="Model Silindi";
        public static string BrandAdded="Model Eklendi";
        public static string BrandAddError = "Eklenecek Model Sistemde Mevcut";
        public static string BrandUpdated="Model Güncellendi";


        public static string ColorUpdated="Renk Güncellendi";
        public static string ColorDeleted="Renk Silindi";
        public static string ColorAdded="Renk Eklendi";
        public static string ColorAddError="Eklenecek Renk Sistemde Mevcut";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomerDeleted = "Müşteri Silindi";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UserDeleted = "Kullanıcı Silindi";

        public static string RentalAdded = "Araç Kiralama Başarılı";
        public static string RentalAddError = "Araç Kiralanmıştır";
        public static string RentalUpdated = "Kiralama İşlemi Güncellendi";
        public static string RentalDeleted = "Kiralama İşlemi Kaldırıldı";
        public static string RentalReturnDate = "Araç Teslim Alındı";
        public static string RentalReturnDateError = "Araç Daha Önce Teslim Alınmış";

        public static string CarImagesLimitExceeded = "Resim limiti aşıldığı için yeni resim eklenemedi";
        public static string CarImageCarIdNotEmpty = "Resim eklenirken araç ID' si boş bırakılamaz";
        public static string CarImageAdded = "Araç resmi eklendi";
        public static string CarImageDeleted = "Araç resmi silindi";
        public static string CarImageUpdated = "Araç resmi güncellendi";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string UserAlreadyExists= "Kullanıcı zaten mevcut";
        public static string SuccessfullLogin = "Giriş başarılı";
        public static string PasswordError = "Hatalı parola";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserRegistered = "Kayıt olundu";
    }
}
