using System;
public class Program
{
    private static void Main(string[] args)
    {
        #region Hata Kontrol Mekanizmalari

        #region Giriş

        // 

        #endregion

        #region Hata Türleri

        #region Syntax Error - Sözdizimi/Derleme Hatalari

        // Program dili kurallarına aykırı olan hatalardır.
        // Özellikle gelişmiş editörler sayesinde söz dizimi hataları derlemeye gerek bile kalmaksızın fark edilebilmektedir.
        // Hatanun bulunduğu satır derleyici tarafından rapo edilir
        // Genelde ide hata yerinin altını çizer.
        // O yüzden fark edilmesi ve çözülmesi enn kolay hata türüdür.

        #endregion

        #region Run-Time Error - Çalişma Zamani Hatalari
        
        #region Teorik Anlatim

        // Syntax'da bir problem yoksa, kodun semantiğinde kusursuz ise, ve çalışma zamanında patalamaya sebep veriyorsa bu hata run-time errordür.
        // Yazılım ayaktayken ortyaya çıkan bir takım aykırı durumlardan dolayı programın işletim sistemi tarafından kesilmesiyle/sonlandırılmasıyla sonuçlanır.
        // Çalışma zamanı hataları programın işleyişinin ortasında direkt kullanıcıla temas edebilecek hatalardır.
        // Ve hiçbir yazılımcı son kullanıcının hatayla karşılaşmasını istemeyiz.
        // Genellikle kültürden kültüre boyutu değişsede bir hatayla karşılaşan son kullanıcı derinden kulak kaşındırabilir.
        // Böyle bir durumda çalışma zamanında alınabilecek olası hatalari yönetmek ve bir şekilde manüpile etmemiz gerekecektir.

        // Çalışma zamanı hataları genellikle kullanılan mimaride öntanımlı mesajları verecektir.
        // Eğer ki alınan hatanın mimairde bir karşılığı yok ise işletim sistemi dili kullanılacak ve daha kompleks bir açıklamaya karşılaşacaktır.
        // Olması gereken ies çalışma zamanı hatalarının önceden tespit edilip programcı tarafından daha anlaşılabilir bir şekilde düzenlenmesidir.
        // Tabi bunu içinde çalışma zamanı hataların sağlam bir öngörüyle tespit çalışması yapılması gerekmektedir.
        // Çalışma zamanı hatalarını önceden kestirmek oldukça zor olabilmektedir.
        // Bu hataları öngörebilmek genellikle testerların işidir.
        // Uygulama mümkün mertebe test edilerek çalışma zamani hatalari tespit edilmeli ve programcı tarfından tanımlanmaldır.
        // Tüm bunlara rağmen gözden kaçan durumlar olması oldukça normaldir. Dolayısıyla bir programın gelişimi sahadaki belli bir sürece bağlıdır.
        // Bu süreçten toplanan loglar ve son kullanıcı dönütleri değerlendirilerek çalışma zamanı hataları tespit edilip arındırılabilir.

        // Tespit edilen çalışma zamanlarının manipülasyonunun oldukça önemli odluğunu söyledik.
        // Peki bunu nasıl yapacağız?

        // Yazılmdaki hata kontrol mekanizmalarını devreye sokarak...
        // Hata kontrol mekanizmaları çalışma zamanı hatalarını kullanıcıya hissettirmeden yakalayailmek ve ilgili hatayı manipüle edebilmek için vardır.

        #endregion

        #region  Çalisma Zamani Hata Durumlari
        
        // Olmayan bir dosyayı açmaya yahut üzerine yazmaya, okumaya vs. çalışmak.
        // Olmayan değer üzerinde işlem yapmaya çalışmak.
        // Uygun olmayan formatlarda çalışmak.
        // Veritabanı bağlantısının kopması
        #region Ornek
        // System.Console.Write("Lütfen birinci sayiyi giriniz: ");
        // int sayi1 = int.Parse(Console.ReadLine());
        // System.Console.Write("Lütfen ikinci sayiyi giriniz: ");
        // int sayi2 = int.Parse(Console.ReadLine());
        // System.Console.WriteLine("Toplam : " + (sayi1 + sayi2));
        #endregion

        #endregion

        
        #endregion

        #region Logic Error - Mantiksal Hatalar
        
        // Programın mantığında, akışında algortimasında, stratejesinde bir takım şeylerin yanlış hesaplanması, düşünülmesi, tasarlanması neticesinde alınan hatalardır.
        // Ssyntax'tai kodun derlenmesinde hatta çalışma zamanında hata yoktur
        // Kod çalışır ve sonuç veriri
        // Lakin sonuçlar hatalıdıri Beklenen sonuçlar elde edilemez.
        // Anlaşılan kodun mantığında ve hesapta bir yanlış vardır.
        // Mantıksal hatalar vancak test süreçlerinde yahut müşteri kullanımında tespit edilebilir.
        // Bazen hesaplanması gereken bir değerin eksik hesaplanmasıyla, bazen yanlış katsayının kullanılmasıyla, bazende mantıksal işlemdeki yapılan bir hatayla ortaya çıkabilir
        // Günlük hayattaki karşılı 'bug' dur.
        // Tespiti çok zor oldugu için hata türleri arasında en tehlikeli hatadır.

        // Mantıksal hatalarda bazen tek çözüm debug'dır.

        #region Ornek 1
        // iki ile 5 i çarp
        // Console.WriteLine(2 * 6); // yanlışıkla 5 yerine 6 yazıdm ve sonuc 12 geldi işte mantıksal bir hata
        #endregion
        #region Ornek 2
        // evlilik durumunu tutan durumu check edelim ve true ise hediye gönder.
        // bool medeniHal = true;
        // if (!medeniHal)
        // {
        //     System.Console.WriteLine("Hediye gönder.");
        // }
        // else
        // {
        //     System.Console.WriteLine("Hediye gönderme");
        // }
        #endregion
        #region Ornek 3
        // aritmetik ort. al
        //int i = 10, i2 = 20;
        // System.Console.WriteLine(i + i2); // toplama yaptım art ort. almadım işlem eksikliği var
        #endregion
        #endregion

        #endregion

        #region try-catch Yapilanmasi

        #region Teorik Anlatim

        // Calisma zamanında alinan olasi hatalari kontrol etmemizi, karşılamamizi, manipüle etmemizi sağlayan bir yapılanmadir.
        // try-catch yapilanmasi, uygulama sürecinde yaşanan olasi hatayi kullaniciya hissettirmeksizin farklı bir durum ya da olagan bir mesaj gibi gostermemizi saglayan ve bunun yaninda patlamaya/hataya dair bizlere bilgi sunan ve boylece bu bilgiler esliginde kayitlar/log olusturmamizi saglayan bir programmatik yapılanmadir.

        // AMAC : 
        //1. Kullaniciya alinan hatayi hissettirmemek.
        //2. Alinan hatanin nedenine dair kullaniciyi bilgilendirmek.
        //3. İşletim sistemleri aykiri durum yaşandığında uygulamayi sonlandırmak isterler ve sonlandirirlar try-catch yapilanmasi ile alinan hataya dair bir manüpilasyon gerçekleştiriliyor ve uygulamanıın kapanmadan devam edilmesi sağlanabiliyor.

        // try
        // {
        //     // olasi çalişma zamani hatalarini verebilecek kodlari buraya yaziyoruz.
        // }
        // catch (System.Exception)
        // {
        //     // try içerisinde olasi hata söz konusuysa kodun akışı oarada kesilecek ve akış catch blogundan devam edecektir.
        //     // hataya dair; log, kullanıcı bilgilendirme, kontrollü kapanış...
        // }

        #endregion

        #region Ornek
        // try
        // {
        //     Console.Write("Lütfen birinci sayiyi giriniz: ");
        //     int sayi1 = int.Parse(Console.ReadLine());
        //     Console.Write("Lütfen ikinci sayiyi giriniz: ");
        //     int sayi2 = int.Parse(Console.ReadLine());
        
        //     Console.WriteLine("Toplam : " + (sayi1 + sayi2));
        // }
        // catch (Exception)
        // {
        //     Console.WriteLine("Lütfen doğru bir ifade giriniz.");
        //     throw;
        // }
        #endregion

        #region NOT
        // try-catch yapilanmasi olasi hatanin ihtimal olduğu kodlari durmadan kontrol eden maliyetli bir yapidir.
        // Dolayisiyla try içerisinde kontrol edilen kodlar lüzümsüz yere tüm kodlar olmamalidir.
        // Sadece olasi hata verebilecek kodları barindiran bir yaklaşım sergilememiz kontrol maliyeti acisindan daha verimli ve performansli olacaktir.

        // Console.Write("Lütfen birinci sayiyi giriniz: ");
        // int sayi1 = 0, sayi2 =0;
        // try
        // {
        //     sayi1 = int.Parse(Console.ReadLine());
        //     Console.Write("Lütfen ikinci sayiyi giriniz: ");
        //     sayi2 = int.Parse(Console.ReadLine());
        //     Console.WriteLine("Toplam : " + (sayi1 + sayi2));
        // }
        // catch (Exception)
        // {
        //     Console.WriteLine("Lütfen doğru bir ifade giriniz.");
        //     throw;
        // }

        #endregion
        
        #region Hata Parametreleri
        
        // Çalışma zamanında alınan hataya dair bizlere bilgi veren/taşıyan parametrelerdir.

        // int s1=0, s2=10;
        // int a = s2/s1;

        // Runtimede hata alındığında bunu editor üzerinde görebilmekteyiz. Burada görülen DivideByZeroException bizim aldığımız/karşılaştığımız hatanın türünü ifade etmektedir.
        //Alinan hatanın yapisina, fitratina göre hata türü firlatilacaktir.

        // object x = null;
        // x.ToString();

        // int a = int.Parse("asdsdsf");

        // try
        // {
        //     int s1=0, s2=10;
        //     int a = s2/s1;
        // }
        // catch (Exception ex) // Exception => bizlere firlatilan hatayla ilgili tüm bilgileri getirecek olan bir üst türdür.          bütün hataları karşılayabilir. ex => bu parametre üzerincen bizler alinan hataya dair bilgiler edinebilmekte ve gerekli loglama vs. gibi operasyonları gerçekleştirebilmekteyiz. ex parametresi catch bloguna yazılmak/tanımlanmak zorunda değildir. eğer ki tanimlama yapilirsa hataya dair bilgi alabiliriz. Yok eğer tanımlama yapilmazsa hata neticesinde catch calisacak lakin bilgi alamayacağiz
        // {
        //     System.Console.WriteLine("Mesaj : " + ex.Message);
        // }
        #endregion
        
        #region Exception Disinda Farkli Bir Tur İle Hata Yakalama
        // try
        // {
        //     int s1 = 0, s2 = 10;
        //     int a = s2/s1;

        //     int.Parse("asd"); // bu senaryoda try-catch blogu kullanıldığı halde fiziksel olarak patlama meydana gelmis ve uygulama sona ermiş bulunmaktadir.
        //     // catch blogu eğer ki bir ture özgü ise(genel olmayan) böyle bir durumda sadece o türden hatalari yakalayabileyen bir yapi haline gelmektedir.
        //     // Dolayisiyla try-catch blogu hangi parametre tanımlandıysa o parametrenin yakalayabileceği turdeki hataları manupüle etmekte eğğer ki parametreini dişinda farklı bir türde hata firlatilirsa try-catch blogu ilgili hatayı manupile edemeyecek ve fiziksel olarak uygulamayi patlatıp sonlandıracaktır.
        //     // Cozum olarak bu durumda birden fazla catch blogu ile türdeki parametreleri kontrol etmek olacaktir.
        // }
        // catch (DivideByZeroException ex) // Catch blogu bir parametre tanımlanmaz ise eğer tüm hatalari karşılayabileyen bir bloktur. Eger ki parametre tanımlanı ve bu parametrenin türü exception'sa yine tüm hataları karşılayabilecektir. Eğer ki, parametre exception değil özelleştirilmiş bir hataya indirgenmişse böyle bir durumda sadece ilgili türe ait hatalari yakalayabilecek/karşılayabilecektir.
        // {
        //     Console.WriteLine("Mesaj : " + ex.Message); // dikkat edersek catch blogu verilen parametrenin türüyle badağmaktadir.
        // }
        #endregion

        #region Birden Çok Catch Durumu
        
        #region İlk Durum
        // try
        // {
        //     int s1 = 0, s2 = 10;
        //     int a = s2/s1; // divideByZeroException

        //     int.Parse("fsd"); // formatException
        // }
        // catch(Exception ex) // her iki ihtiamlde de ayni davarnışı sergileyecektir. Dolayisiyla farklı türlerdeki hata durumlarıda bu sekilde bir fark yaratamayiz.
        // {
            
        // }
        #endregion
        #region İkinci Durum
        
        // try
        // {
        //     int s1 = 0, s2 = 10;
        //     int a = s2/s1; // divideByZeroException

        //     int.Parse("fsd"); // formatException
        // }
        // catch(DivideByZeroException ex) // DivideByZeroExcepiton hatası alındığında bu hatayı karşılayacak olan catch haline getirilmiş oldu.
        // {
            
        // }
        // catch(FormatException ex) // FormatException hatasını karşılayack olan catch tanımlanmış oldu.
        // {
            
        // }
        // //Bu catchlerin dışında farkli bir turde hata alınırsa eğer o hatayida karşılayack bir catch blogu tanımlanmalıdır.
        // catch(Exception ex)
        // {
        //     // catch bloklarının en sonunda Exception turunde parametre(catch) tanımlarsak alınan hata üstteki türlerden herhangi biri degilse kesinlikle bu Exception tarfından karşılanabilir olacağında dolayi en kötü buraya girecektir.
        // }
        // Anlaşılıyorki try-catch yapılanması olası run time hatasi alındığında catch sıralamasına göre kontrol etmektedir.
        // Bu sıralama önemlidir.
        // Eğer ki birden fazla catch blogunun tanımlanmasında exception kullanılacaksa bu Exception en sonra tanımlanması gerekmetedir.
        #endregion
        #endregion
        
        #region finally blogu
        
        //finally blogu try-catch yapılanamsında hata alınsada alınmasada her ik durumda da tetiklenmesi/çalıştırılamsı gereken kodları yazdığımız bloktur.
        // try
        // {
        //     System.Console.WriteLine("try");
        // }
        // catch (Exception)
        // {
        //     System.Console.WriteLine("catch");    
        // }
        // finally
        // {
        //     System.Console.WriteLine("finally");
        //     // her iki durumda da çalışmasını istediğimiz kodlar buraya yazılmaktadır.
        // }
        #endregion
        
        #region when Yapisi ile Hata Filtreleme (c# 6.0)

        // try-catch bloklarına when keywordu ile şart uygulayabilmekteyiz.

        // string x = "a";
        // try
        // {
        //     int s1 = 0, s2 = 10;
        //     int a = s2/s1;
        // }
        // catch (DivideByZeroException ex) when(x == "a")
        // {
        //     Console.WriteLine("Mesaj : " + ex.Message);
        // }
        // catch (DivideByZeroException ex) when(x == "b")
        // {
        //     Console.WriteLine("Mesaj : " + ex.Message);
        // }
        // catch(Exception ex)
        // {

        // }
        #endregion

        #endregion

        #endregion
    }
}