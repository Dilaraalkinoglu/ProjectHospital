HASTANE YÖNETİM SİSTEMİ    
  
Proje Hakkında:     
Hastane Yönetim Sistemi, bir hastane içerisindeki hasta, doktor ve sekreter işlemlerinin yönetilmesini sağlamak amacıyla geliştirilmiş bir C# Windows Forms uygulamasıdır. Proje sayesinde hastalar randevu alabilir, doktorlar hasta bilgilerini görüntüleyebilir ve sekreterler yönetim işlemlerini gerçekleştirebilirler.
  
Özellikler:     
✅ Hasta kayıt, giriş ve randevu alma  
![Ekran görüntüsü 2025-04-28 134200](https://github.com/user-attachments/assets/fcd3c156-470b-41a2-8822-ec2e4b3de8b0)  
![Ekran görüntüsü 2025-04-28 135935](https://github.com/user-attachments/assets/6455b70a-97bc-439d-afca-d84b9bb195a3)  




✅ Doktor kayıt, giriş ve randevu takip    
![Ekran görüntüsü 2025-04-28 140153](https://github.com/user-attachments/assets/264bd0f3-d8af-4634-8506-7b07502eb040)  
![Ekran görüntüsü 2025-04-28 135958](https://github.com/user-attachments/assets/6551847b-df6b-48a6-91a2-696c9088fc60)  
![Ekran görüntüsü 2025-04-28 140007](https://github.com/user-attachments/assets/96f098f6-7be5-4577-9d70-9cc0e59ee88b)  





✅ Sekreter paneli ile:    
![Ekran görüntüsü 2025-04-28 140038](https://github.com/user-attachments/assets/87c20951-f5bb-4783-9f26-89109805df2e)


  -Randevu oluşturma    
     ![Ekran görüntüsü 2025-04-28 140051](https://github.com/user-attachments/assets/e84abbf0-e9b6-4d2a-a130-6666879de187)  
     ![Ekran görüntüsü 2025-04-28 140119](https://github.com/user-attachments/assets/167804ba-f478-48ec-9028-12117c81e8c7)


     

  -Branş ve doktor yönetimi    
     ![Ekran görüntüsü 2025-04-28 140100](https://github.com/user-attachments/assets/c6260052-74e8-4420-9c8c-80a83a9dabc3)  
     ![Ekran görüntüsü 2025-04-28 140109](https://github.com/user-attachments/assets/a76e7960-05c3-4160-92d2-248a201a482a)



  -Duyuru yapma    
     ![Ekran görüntüsü 2025-04-28 140136](https://github.com/user-attachments/assets/a8a72ebe-0ce9-49a9-930f-c904fed9ef5a)


✅ SQL Server veritabanı bağlantısı  

✅ Gelişmiş kullanıcı doğrulama  

✅ Hızlı erişim panelleri  

✅ Modern ve kullanımı kolay arayüzler    

Kullanılar Teknolojiler:   
Programlama Dili: C# (.NET 9.0)  

Platform: Windows Forms  

Veritabanı: Microsoft SQL Server  

Geliştirme Ortamı: Visual Studio 2022+  

Kurulum Adımları:  
1. Bu projeyi kendi bilgisayarınıza klonlayın:  

        git clone https://github.com/kullaniciadi/Proje_Hastane.git  
2. Visual Studio ile projeyi açın.  

3. NuGet paketlerini yükleyin.  

4. SQL Server üzerinde gerekli veritabanını ve tabloları oluşturun.  

5. App.config dosyasındaki bağlantı cümlesini kendi sunucunuza göre düzenleyin.  

6. Projeyi çalıştırın.

Veritabanı Yapılandırması:  
Veritabanı tabloları şunlardır:  

-Hastalar  

-Doktorlar  

-Branşlar  

-Randevular  

-Duyurular  

Veritabanı script dosyası proje içerisinde ayrıca sağlanabilir.  

Kullanıcı Rolleri:  
Hasta->	Randevu alma, aktif randevularını görüntüleme, kişisel bilgilerini düzenleme  
Doktor->	Randevu listesi görüntüleme, hastanın şikayet bilgilerini görme, kişisel bilgileri güncelleme  
Sekreter->	Randevu oluşturma, doktor ve branş listesi yönetme, duyuru yayımlama  

Katkı Sağlama:  
-Forklayın (Fork tuşuna basın)  

-Yeni bir dal açın (git checkout -b feature/yenilik)  

-Değişikliklerinizi commit edin (git commit -m 'Yeni özellik ekledim')  

-Dalınıza push yapın (git push origin feature/yenilik)  

-Pull Request açın    

İletişim:  
Proje ile ilgili her türlü görüş, öneri ve hata bildirimleri için:  
dilaraalkinoglu80@gmail.com








