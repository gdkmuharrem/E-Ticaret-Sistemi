E-Ticaret Sistemi

Merhabalar,
Bu projede asıl dikkat çekilmesi gereken nokta Presentation yani C# ile form uygulaması değildir. Bu projedeki asıl amaç veritabanı SQL işlemleridir.
Şöyle ki projemizi Veri Tabanı Yönetim Sistemleri için tasarladık. Veri tabanı kısmında çalışmalarımızı beğendiğimiz için sunum kısmına biraz fazla odaklandık.
SQL kısmını da SQL isimli dosyadan ulaşabilirsiniz. Aynı Veritabanını geri yüklemeye dair bazı notlar aldım dilerseniz projenin birebir aynısını bilgisayarınızda çalıştırmak için :

  1-İlk olarak VeritabaniBackup.bak dosyasını indirin ve bilgisayarınızın masaüstü veya bir dosyasına değil de direkt olarak Bilgisayarımı açıp Diskinize aktarın. Örnek uzantı =>  C:\VeritabaniBackup.bak  mesela.
  2-SQL server management studio açın ve Connect tuşuna basıp Server'a bağlanın
  3-Sol taraftan "databases" klasöründen OnlineAlısveris veritabanına sağ tıklayıp "delete" deyin.
  4-Karşınıza çıkan silme penceresinde aşşağıda bulunan bir checkbox var: Close existing connections, Bu seçeneği aktif hale getirin ve OK tuşuna basın.
  5-Tekrar SQL server management studio'dan sol taraftan "databases" klasörünün üstüne gelip sağ tık ile "Restore Database..." butonuna basın.
  6-Açılan pencereden üst tarafta default olarak Database tiki seçili olarak gelecektir onun yerine hemen altındaki Device butonuna basın. Device tikinin hizasında en sağda "..." şeklinde üç nokta bulunmakta bu butona tıklayın.
  7-Üç noktaya tıklayınca açılan küçük pencereden Add butonuna basın. Açılan yeni pencereden sol taraftan yardım alarak VeritabaniBackup.bak dosyanızın yerini belirtin. ve OK tuşuna basın daha sonra Add butonunun solunda çıkmış olması gerekmekte. Eğer çıktıysa OK diyin.
  8- Otomatik olarak veritabanının adının yüklenmiş olması gerekmektedir.
  9-Son olarak aşşağıdan OK butonuna basın ve biraz bekleyince veritabanı yedeği geri dönülmüş olacaktır.

Veri tabanını SQL server'a ekledikten sonra projeyi başarılı bir şekilde çalıştırabilirsiniz.
Sorunuz ya da öneriniz olursa bana mail veya linkedln yolu ile ulaşabilirsiniz.
Mail: gdk.muharrem@gmail.com
Linkenln : https://www.linkedin.com/in/muharrem-gedik-0094331b6/

İyi günler dilerim,
Muharrem Gedik.
