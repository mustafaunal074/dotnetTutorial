using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Metotlar
        
        #region Giris
        // Yöntem yahut yordam hatta functions diyebiliriz.
        // Yazılımda gerçekleştirdiğimiz, fiili olarak gerçekleştirdiimiz tummm operasyonlar bir metottur.

        // Metot prosedurel porgramlamanın temel elemanıdır. Bir iş/fiilyat/operasyon yapan enn küçük program parçacıklaridir.

        // metotlar kodun içerisinde tekrar eden yapıları tek seferde inşa edip defalarca çağırmamıza yardımcı olur.   
        // yazılmış olan bir kodu tekrar çağırmakla, tekrar yazmak arasında fark vardır!

        // Metotlar, içerisine yazılan kodun, tekrarli bir şekilde kullanılmasını sağlarlar
        //ve bunu yaparken kaynak kodun tekrar etmesini de engekeniş olurlar. Böylece ideal kodlamaya erişmiş oluruz.

        
        #endregion
        
        #region Method Tanimlama

        //       ----   methodun imzasi -------
        // [erisimBelirleyicisi][geriDonusDegeri][methodAdi]()
        //{             |
        //      Methodun gövdesi
        //}             |

        // ErisimBelirleyicisi => Oluşturulmuş olan bir yapının dısarıdan erişilip erişlmeyeceğini belirlememizi sağlayan komutlarıdr.
        // GeriDönüsDegeri => Metotlar yaptıkları operasyonlar/algoritmalar/islemler neticesinde geriye degerler donebilmektedirler. Bu deger kodun içerisinde yakalanabilir ve grogramatik olarak işlemlere tabii tutulabilir
        // Geri donus degerini ekran çıktısıyla karıştırmamak gerekmektedir.
        // () => Metot dedigimiz bu yapılanmalar dış dünyadan paramaetreler alabilmekte ve bu parametrelerdeki degerler uzerinde islemler gerceklestirebilmektedir... Iste bu parametreleri parantez icerisinden alabilmekteyiz.
        //bir methot illaki almak zorunda değildir. gelen parametrenini türü belirtilmelidir.

        #endregion
        
        
        #endregion

        #region 1.Methot Turleri
        
        // Yapılacak işleme göre 4 farklı türde/varyasyonda metot oluşturulabilmektedir.
        // Geriye deger döndürmeyen, parametre almayan
        // geriye deger döndürmeyeni parametre alan
        // geriye deger döndüreni parametre almayan
        // geriye deger döndüre parametre alan

        #region Geriye Deger Dondurmeyen, Parametre Almayan Metot
        // bir method geriye deger döndürmüyorsa void ile bildirilmesi Zorunludur.
        // private void Metot1()
        // {
        //     System.Console.WriteLine("Geriye Değer Döndürmeyen, parametre almayan metot oluşturuldu");
        // }


        #endregion
        #region Geriye Deger Dondurmeyen, Parametre Alan Metot

        // public void Metot2(int a)
        // {
            
        // }   
        // public void Metot3(int a,bool b)
        // {
            
        // }
        // public void Metot4(int a,bool b, char c)
        // {
            
        // }


        #endregion
        #region Geriye Deger Donduren, Parametre Almayan Metot
        // eğerki bir metot geriye herhangi bir türde deger döndüreceğini ifade ediyorsa kesinlikle o türde bir deger Dondurmelidir aksi taktirde hata verir
        // private char Metot5()
        // {

        //     return 'a'; // geriye deger döndüren fonksiyonlarda, bildirilen türde bir deger döndürebilmek için return keywordunu kullanmamiz gerekmektedir.

        //     // return keywordü nerde işlenirse ilgili fonksiyonlardan cikilir.
        // }
        // private int Metot6()
        // {
        //     if (DateTime.Now.Second > 10)
        //         return 5;
        //     return 6;         
        // }

        #endregion
        #region Geriye Deger Donduren, Parametre Alan Metot

        // public bool Metot7(int x)
        // {
        //     return true || false;
        // }
        // public int Metot8(int x)
        // {
        //     return DateTime.Now.Year > 2000 ? 1 : 0;
        // }

        #endregion

        #endregion

        #region 2.Metodun Geriye Deger Dondurmesi Ne Demektir ?

        // Bir methodun geriye deger döndürmesi demek, içeride yapılan işlem neticesinde üretilen sonuçların ekrana yazılması demek değildir!
        // Methodun geriye dondurdugu deger, programatik olarak yakalanip algoritmanın akısında farklı yönlendirmelere sebebiyet verebilen degerdir.
        // Methodun geriye döndürdüğü deger algoritmanon akısında kullanılabilir degerdir.
            
        #endregion
    
        #region 3.Optional Parameters(İstege Bağli Parametreler)


        // Bir parametrenin opsiyonel olması demek o parametrenini varsayilan/default degeri olması demektir..
        // Method parametrelerine = (assign) operatoru ile bir deger atanırsa eğer o parametreye vasayılan bir deger atanmiş olur.  Haliyle opsiyonel parametre haline getirilmiş olunur...
        //
        // static public void X(int a, int x, int y, int b = 0, int c = 0)
        // {

        // }

        // Parametreli bir methot kullanılirken/çağrılırken  parametrelerini türlerine uygun degerler gönderilmek ZORUNLUDUR.
        // Eger ki, bir methodun parametrelerine zorunlu bir şekilde deger göndermek istemiyorsak, parametreye degeri istegimize göre/opiyonel larak göndermek istiyorsak o parametrenin bu durumu karşılayabilecek bir özellikte olması gerekmektedir. İşte bu özelliğe opsiyonel parametreler denmektedir.
        
        // X(15,20);
        // X(5);
        // X();

        #region Kritik 1
        // tüm parametrele opsiyonel olabilir
        #endregion
        #region Kritik 2
        // Birden fazla parametre içerisinde bir kısmı opsiyonel olabilir mi?
        // Birden fazla parametre durumunda opsiyonel olanlar sağ tarafta TANIMLANMALIDIR.
        // X(5,10,15);
        #endregion
        #region Kritik 3
        
        #endregion

        #endregion
    
        #region Tanimlanmiş Methodun Kullanimi

        #region Tanimlandiği Sinif Icerisinde Kullanimi
        
        // bir methot tanımlandığı sınıf içerisinde farklı bir metot içerisinden çağrılacaksa eğer tek yapılması gereken sadece isminin çağrılmasıdır.

        #endregion
        #region Başka Siniflarda Kullanimi
            
        #endregion
        
        #region Referans ve Nesne İlişkisine Hafiften Temas Edelim
        
        // Sınıf(Class) = Yeryüzündeki herhangi bir olguyu modellemimizi sağlayan yapılanma! İçerisinde ilgili olguya dair verileri tutacak alanları(field) barındıran ve bu alanlar üzerinde işlem yapmamızı sağlayacak olan metotları barındırıan bir yapı
        // Nesne = Class'tan üretilen değer
        // Referans = Class'tan üretilen değeri kullanmamoza sağlayan yapı
        #endregion
        #region Nesne İşaretliyen Referans Üzerinden Metoda Erişim
            
        #endregion
        
        #region Başka Sinifta Tanimlanmiş Bir Metodun Kullanimi
        
        // Matematik matematik = new Matematik();
        // Console.WriteLine(matematik.Carp(3,5));

        #endregion
        
        #region Non-Trailing Named Arguments
        
        // X(3,5,"abc");
        // X(c:"asd", a:4, b:5);

        // hangi parametreye hangi değerlerin gönderildiğini direkt görebilmek için bu özelliği kullanırız.
        // Göreceli bir şekilde çok parametreli fonksiyonlarda hedef parametreler değer göndermemizi sağlayan bir özelliktir.

        #endregion
        #endregion

        #region In Parameters
        
        // Parametrenini değerini metodun içerisinde herhangi bir yerde çağırıp kullanabiliriz.
        // Metot içerisinde üretilen herhangi bir değeri tutacak değişken oluşturmaktansa parametre üzerinde bu değeri tutabiliriz. Yani parametreinin değerini değiştirebiliriz.

        // In komutu sayesinde parametreye verilen değeri sabit tutabilmekteyiz.
        // In komutu metodun parametresini readonly(sadece okunabilir) hale getirir
        // In komutu kullanıldığı parametrelerde eğer ki metot içerisinde farklı bir assign durumu söz konusu olursa derleyici hatası verecektir.

        //     static void X(in int a, int b, in char c)
        // {
        //     // a = 123;
        //     // b = 23;
        //     // c = 'a';
        // }


        #endregion
    
        #region Local Functions

        // bir metot içerisinde tanımlanmış olan metotlardır.
        // c# ta metotlar sade ve sadece class içerisnide tanımlanırlar diye söylemiştik! Halbuki OOP'de göreceğimiz struct, abstract class, interface, recor yapılanmalarında da metotlar tanımlanmaktadır. Metotlar bu saydıklarımzın dışında KESİNLİKLE başka bir yerde tanımlanamaz.
        // Metotlar kesinlikle metotların içerisinde tanımlanamaz demiştik !!! Halbuki C# 7.0 da gelen local function özelliği sayesinde metot içerisinde metot tanımlanabilmektedir.   

        // Local functionlarda erisim belirleyicisi yoktur
        // Yani direkt geri donus degerinden baslanir.

        #region Tanimlama Kurallari

        // 1. Erişim belirleyicisi (access modifier) yazılmaz
        // 2. Local function olarak tanimlanan fonksiyon adi tanımladığı fonksiyon adından farklı olmalıdır! Aksi taktirde derleyici hatası vermez !!
            
        #endregion
        #region Kullanim Kurallari
            
        // Bir local function sade ve sadece tanımlandığı metotun içerisinde kullanılabilir.
        // Local functino tanımlandığı metodun içerisinde her yerden erişilebilir.

        #endregion
        #region Amaci
        
        #endregion
        #region Muadilleri

        // anonim , delegate, func
            
        #endregion
        // Bir metot sadece tek bir metotta tekrarli bir şekilde kullanılacak bir algoritmayı/kod parçacıgını/işlemi o metoda özel bir şekilde tek seferlik tanımlamammız ve kullanmamızı sağlamaktadır.

        #endregion
    
        #region Static Local Funcitons (C# 8.0)

        //     public void X(int a)
        // {
        //     int b = 0;
    
        //     static void Y(int a, int b)
        //     {
        //         System.Console.WriteLine(a);
        //         System.Console.WriteLine(b);
        //     }
        //     Y(a,b);
        // }
            
        #endregion
        
        #region Method Overloading(Çoklu Yükleme)

        // Bir class içerisinde aynı isimde birden fazla metot tanımlanamaz.
        // Overloading : Çoklu yükleme
        // Bir sınıfın içerisine birde falza metot tanımlanamaz (bellirli kurallar dışında).
        // Bir classta ayni isimde birden fazla metot tanımlanmışsa eger(belirli kurallar cercevesinde) o isme overloading yapılmıştır.
        // Bir class içerisinde belirli kuralalr çerçevesinde aynı ısımde birden fazla metot oluşturmaya Method Overloading denir.

        #region Overloadin Kurallari
        
        // Bir sınıf içeriside birden fazla aynı isimde metot tanımlayabilmek için şu kurallara dikkat edilmesi gerekmektedir.
        // Metot overloading işlemini yapabilemk için metotların isimleri aynı olmalıdır.
        // Bu metotlar içerisinde fark yaratmamız gerekmektedir.
        // Bu fark bizzat metot imzalarında olmalıdır.
        // Metotlar arasında farkı yaratırken erişim belirleyici ve geri dönüş değerleri aktif rol oynamamaktadır.
        // !! Parametre sayıları ya da parametre türleri farklı olmalıdır.

        #endregion
            
        // Overloading işlemine tabi tutulmuş metotlardan istedigimizi kullanabilmek için o metodun imzasına uygun parametreleri tetiklememiz (ya da bir başka deyişle o imzadaki metodu kullanmamız) yeterli oalcaktır.
        #endregion
    
        #region Recursive(Tekrarlamali/Özyinelemeli) Metotlar
            
        // Recursive Fonk : Kendi içerisinde kendisini çağıran/tetikleyen fonksiyonlardır.
        // Özyinelemeli/Tekrarlamali Fonk.

        // Recursive fonk. bir yaklaşımdır.
        // Anlaşılması, kullanması ve anlatılması zordur!

        // Recursive fonk. ne amaçla kullanılmaktadır.
        // Öngörülemeyen, derinliği tahmin edilemeyen, sonu bilineyen durumlarda tercih edilebilir.

        // Döngülerin kullanıldığı her noktada recursive fonk. kullanılabilir. Amma velakin, rec fonk. kullanıldığı her yer de döngü Kullanılamaz.

        #region Ornek 1

        // Belirli değer aralığındaki 5'in katı olan tüm sayıları toplayan rec fonk yazalım.
        System.Console.WriteLine(Topla(10,20));

        int Topla(int baslangic, int bitis)
        {
            if (baslangic % 5 == 0 )
                return baslangic + Topla(++baslangic,bitis);
            if (baslangic < bitis)
                return Topla(++baslangic,bitis);
            return 0;
            
        }


        #endregion
        #region Ornek 2

        List<FileInfo> files = DosyaYazdir("C:\\Users\\musta\\OneDrive\\Masaüstü\\dotnetTutorial");
        foreach (FileInfo file in files)
        {
            System.Console.WriteLine(file.FullName);
        }
        
        List<FileInfo> DosyaYazdir(string path)
        {
            List<FileInfo> fileInfos = new();
            DirectoryInfo directoryInfo = new(path);
            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
            if (directoryInfos.Any())
                foreach (DirectoryInfo directory in directoryInfos)
                    fileInfos.AddRange(DosyaYazdir(directory.FullName));
            else
                fileInfos.AddRange(directoryInfo.GetFiles());
            return fileInfos;
        }

        #endregion



        // X();

        // void X(int a = 1)
        // {
        //     System.Console.WriteLine("Merhaba");
        //     if (a<3)
        //     {
        //         X(++a);
        //     }
        // }
        // X(++a)
        // 1.giriş => a 1 geldi, merhaba yazıldı, 1<3 içeri girdi a yı arttrıp gönderi
        // 2.giriş => a 2 geldi, merhaba yazıldı, 2<3 içeri girdi a yı arttırıp gönderdi
        // 3.giriş => a 3 geldi, merhaba yazıldı, 3<3 döngü bitti

        // X(a++)
        // 1.giriş => a 1 geldi, merhaba yazıldı, 1<3 içeri girdi a yı gönderdi sonra bir arttırdı(görünen değer 1 bellekte 2)
        // 2.giriş => a 1 geldi, merhaba yazıldı, 1<3 içeri girdi a yı gönderdi sonra bir arttırdı(görünen değer 2 bellekte 3)
        // 3.giriş => a 2 geldi, merhaba yazıldı, 2<3 içeri girdi a yı gönderdi sonra bir arttırdı(görünen değer 3 bellekte 4)
        // 4.giriş => a 3 geldi, merhaba yazıldı, 3<3 döngü bitti


        // void X(int a = 1)
        // {
        //     System.Console.WriteLine("Merhaba");
        //     if (a < 3)
        //     {
        //         X(++a);
        //     }
        //     System.Console.WriteLine("Dünya");
        // }

        // void Y()
        // {
        //         Y();
        // }

        

        #endregion

        #region Ref Keywordü
        
        // ref keywordü, referanstan gelmektedir.
        // referans, oop kavramıdır.
        // oop'de nesneler(object) RAM'de Heap bölgesine tutulmaktadır.
        // oop'de referanslar = operatörü ile iletişime geçebilmektedirler. Bir referans, işaretlediği herhangi bir nesneyi = operatörü sayesinde farklı bir referansa işaretlenebilir.
        // yani, referanslarda = operatörü neticesinde herhangi bir verisel/nesnesel türeme söz konusu olmamakta, işaretlenmiş nesne diğer refrans tarafından işaretlenmektedir.

        // ref keywordü, deger türlü değişkenlerde referans operasyonları yapmamızı sağlayan bir keyworddür.
        // ref keywordü, deger türlü değişkenlerin referanslarını cağırmamızı/kullanmamizi sağlayan bir keyworddür

        // değer türlü değişkenlerde referans çalışması yapmak istiyorsak eğer ref keywordü kullanılır!
        // ref keywordü, değer türlü değişkenleri referans türlü değikenler gibi çalışmasını sağlayan bir komuttur.
        // değer türlü değişkenlerde shallow copy yapmamızı sağlayan bir keyworddür.

        #region Ornek 1
            
        // int a = 5;
        // ref int b = ref a;

        // System.Console.WriteLine(a);
        // System.Console.WriteLine(b);

        // a *= 5;
        // System.Console.WriteLine(b);
        // b-=10;
        // System.Console.WriteLine(a);
        
        #endregion

        #region Ornek2
        
        // int y = 10;
        // Z(ref y);
        // Console.WriteLine(y);

        // void Z(ref int a)
        // {
        //     a = 25;
        // }

        #endregion
        
        
        #endregion
        
        #region Ref Returns

        // ref returns özelliği sadece metotlarda geçerlidir.
        // metotlar geriye değer döndürebilen yapılardır.. ayrıca metotlarda geriye nesnelerde döndürebilmekteyiz. ayrıca ref retutns özelliği sayesinde değer türlü değişkenlerin referanslarınıda geriye döndüreilmekteyiz.

        #region Ornek 1

        #region Part 1

        // int a = 5;
        // int b = x(a);
        // System.Console.WriteLine(a); // 5
        // System.Console.WriteLine(b); // 25
        // int x(int y)
        // {
        //     y = 25;
        //     return y;
        // }
            
        #endregion

        #region Part 2
            
        // int a = 5;
        // int b = x(ref a);
        // System.Console.WriteLine(a); // 25
        // System.Console.WriteLine(b); // 25
        // ref int x(ref int y)
        // {
        //     y = 25;
        //     return ref y;
        // }

        #endregion
            
        #endregion
            
        #endregion
    
        #region Out Keyword

        // out keywordu metotları Parametrelei üzerinden disariya deger göndermemizi sağlayan bir keyworddür.
        // bir metodun parametreleri varsayilan olarak inputtur. haliyle metotolarda tanımlanmış parametrele direkt olarak iceriye deger almaya odaklanırlar.
        // eğer ki bir metodun parametresi disariya deger çıkarıcaksa o parametrein out keywordu ile işaretlenmesi gerekmektedir.

        //Output parametre barındıran bir metodu kullanırken, out parametrelerden gelecek olan değerleri karşılayacak değişkenler tanımlanmalıdır.
        
        #region Kullanim 1
            
        // int _b = 0;
        // string _d = "";
        // int a = X(out _b, 123, out _d);

        #endregion
        #region Kullanim 2
        
        int a = X(out int _b, 123, out string _d);
        System.Console.WriteLine(_b);
        System.Console.WriteLine(_d);

        #endregion
        int X(out int b,int c, out string d)
        {
            // Bir method out parametresi barındırıyorsa o parametreleri kendi içerisinde değer atanması gerekmektedir. Aksi takdirde derleyci hatası alacaktır.
            b= 25;
            d = "ahmet";
            return 0;
        }



        #region TryParse
            
        #endregion
            
        #endregion
    }
    
    // public void X(int a)
    // {
    //     int b = 0;

    //     static void Y(int a, int b)
    //     {
    //         System.Console.WriteLine(a);
    //         System.Console.WriteLine(b);
    //     }
    //     Y(a,b);
    // }
    
    // static void X(int a, int b ,string c)
    // {

    // }
}

class Matematik
{
    public int Topla(int sayi1,int sayi2)
    {
        return sayi1 + sayi2;
    }
    public int Topla (int sayi1,int sayi2,int sayi3)
    {
        return sayi1 + sayi2 + sayi3;
    }
    public int Cikar(int sayi1,int sayi2)
    {
        return sayi1 - sayi2;
    }
    public int Carp(int sayi1,int sayi2)
    {
        return sayi1 * sayi2;
    }
    public int Bol(int sayi1,int sayi2)
    {
        return sayi1 / sayi2;
    }
}