using System;
internal class Program
{
    private static void Main(string[] args)
    {
        #region Akis Kontrol Mekanizmalari

        #region Giris
        //Akıs kontrol mekanizmaları kodun akis sürecinde belirli sartlara göre farklı yönlendirmelei yapmamızı ve farklı   algoritmaları/kodları/yapılanmmaları çalıştırmamızı sağlayan mekanizmalardır.

        //Yazilim kodun akıs sürrecinde şarta göre yönlendirilmesini sağlamaktadir.

        //Algoritmalarda ciddi manada kullanılan yapilardir. Oyüzden yazilimcilar acisindan olmazsa olmaz yapilanmalardır.

        //Akış kontrol mekanizmalarıdna if else yahut switch yapilanmlaarı ayni isi farklı şekilde yapmamizi sağlayan birbirlerinde     farkli yapılanmlardir. İkisi arasinda teknik olarak fark olsada isleyis/kullanım acisidan bir fark yoktur.
        #endregion

        #region SWITCH CASE YAPISI
        #region Switch Case

        // switch case, kodun akısında belirli bir sarta göre yönlendirme yapmamızı(farklı algoritma çalıştırmamızı/farklı operasyon gerçekleştirmemizi/tetiklememizi) sağlayan yapılanmadır.
        //Switch case yapılanması sadece bir değişkenin değerini sadece eşitlik durumlarını kontrol ederken kullanilabilir.
        //Sadece eşitlik durumu check edilecekse o zaman swtch kullanılabilir.

        //Switch yapılanmasında verilen değerin eşitlei durumularını kontrol edeceğimiz diğer değerleri case bloklarına yerleştiriyoruz.
        //break: casi ile break arasına yazılan kodlar ilgili case'in doğrulanması sürecinde islenecek kodlardır.

        //switch case yapılanmasında kontrol edilen deger ilse esitlik sağlayan case varsa diğer caselere bakmaksizin switch blogundan cikilacaktir.
        // switch yapılanmasında amac eşitlik duruma göre belirli bir kod blogunu tetiklemektri.

        //defaut => swith case tapılanmasında hicbir case esitlik durumunu sağlayamıyorsa default break arasındai kodlar çalıştırılacaktır...
        //deafult kalıbı zorunlu değildir.

        // string adi = "Mustafa";
        // switch (adi) 
        // {
        //     case "Mehmet":
        //         System.Console.WriteLine("Adi Mehmet");
        //         break;
        //     case "Ayşe":
        //         System.Console.WriteLine("Adi Ayşe");
        //         break;
        //     case "Mustafa": // eşitlik saplandığı durumda diger caselerde bakmadan switch blgundan cikip gidecektir compiler
        //         System.Console.WriteLine("Adi Mustafa");
        //         break;
        //     default:
        //         System.Console.WriteLine("Hiçbiri değil.");
        //         break;

        // }
        // kontrol edilen degerin türü ne ise case bloklarında da aynı türde degerlerle konyrol edilmelidir.
        // switch parantezinde kontrol edilen deger bir değişken yahut sabit/statik bir değer olabilirken
        //case bloklarındaki degerler kesinlikle sabit/statik olmak zorundadir. Caselerdeki degerle değişkenlerden alinamaz.

        //case bloklarından hicbiri eşleşmeye uymuyıorsa eger varsa default blogu tetiklenir.
        //case bloklarının siralamsi ve defaultun yerleştirildiği yer önemli değildir.


        #endregion

        #region when 

        //switch yapılanmasında  sadece elimizdeki degerin eşitlik durumunu kontrol edebilmekteyiz. Bunun dışında bu kontrol esnasında farklı sartlarıda degerlendirmek istiyorsak efer when keywordunu kullanabiliriz.

        // switch(satisTutari)
        // {
        //     case 100 when ..sart..:  // satis tutarı hem 100 e eşitmi hemde sart doğru mu?(when)

        //         break;
        // }

        // int satisTutar = 1000;
        // switch (satisTutar)
        // {
        //     case 1000 when(3 == 5):  // (satisTutarı == 1000) && (3==5) mi şeklinde çalışır

        //         break;
        //     case 1000 when(3 == 3):

        //         break;
        // }

        #endregion

        #region goto

        //switch case yapılanmasinda sadece esitlik durumunu inceleyebildiğimiz için mantıksal bir işlem gerçekleştirememekteyiz. Dolayisiyla bazen farklı değerlere esit olma durumunda ayni operasyonu/kodu/akisi kullancağımız senaryolarla karşılaşabilmektyiz.

        // switch(value)
        // {
        //     case "a":
        //         A işlemini uygula
        //         break;
        //     case "b":
        //         B işlemini uygula
        //         break;
        //     case "c":
        //         A işlemini uygula
        //         break;
        // }

        // farklı eşitliklerde aynı kodu çalıştıracaksak eger kod tekrarına girmemek için goto keywordu ile su casedeki kodu çalıştır diyebiliyoruz. Yani caseler arasında ziplamalar yapabiliyoruz.

        // int i = 10;
        // switch (i)
        // {
        //     case 5:
        //         System.Console.WriteLine(i * 10);
        //         break;
        //     case 6:
        //         System.Console.WriteLine(i / 5);
        //         break;
        //     case 7:
        //         System.Console.WriteLine(i * 10);
        //         break;
        //     case 10:
        //         System.Console.WriteLine(i * 10);
        //         break;
        // }
        // yukarıdaki gibi kod tekraraı olan durumlarda goto keywordu kullanabilmekteyiz
        // switch (i)
        // {
        //     case 5:
        //         System.Console.WriteLine(i * 10);
        //         break;
        //     case 6:
        //         System.Console.WriteLine(i / 5);
        //         break;
        //     case 7:
        //         goto case 5; // case 5 teki kodu çalıştırı demis oluyoruz. goto kullanılan case^de break komutu kullanmıyourz.
        //     case 10:
        //         goto case 5; // goto keywordü kullanıldığı case'in eşleştirmesine bakmaksizin direkt kodu çalıştıracaktır.
        // }

        // birden fazla aynı case yönlendirilen goto keywordun kullanıldığı durumlarda alttaki gibi daha pratik bir yaklaşım sergileyebiliriz.
        // switch (i)
        // {
        //     case 5:
        //         System.Console.WriteLine(i * 10);
        //         break;
        //     case 6:
        //         System.Console.WriteLine(i / 5);
        //         break;
        //     case 7: 
        //     case 10:
        //         goto case 5; // bu şekilde her ikisinden biri olduğunda case 5 e yönlendir diyebiliyoruz.
        // }

        #endregion

        #region Switch Expressions

        // tek satırlık işlemler için maliyet düşürücü ve kullanışlı semantikleridr.

        #region Eski
        // string isim = "";
        // int i = 10;
        // switch(i)
        // {
        //     case 5:
        //         isim = "Hilmi";
        //         break;
        //     case 7:
        //         isim = "Rifki";
        //         break;
        //     case 10:
        //         isim = "Mustafa";
        //         break;
        // }
        #endregion
        #region Yeni
        // int i = 10;
        // string isim = i switch
        // {
        //     5 => "Hilmi",
        //     7 => "Rifki",
        //     10 => "Mustafa"
        // };
        #endregion

        #region when sarti ile Switch Expressions

        // int i = 10;
        // string isim = i switch
        // {
        //     5 => "Hilmi",
        //     int x when x == 7 && x % 2 == 1 => "Rifki",
        //     10 => "Mustafa",
        //     var x => "Hicbiri" // default : Hicbirinin olamdığı durumda default tanımlamasına karşılık gelecektir.
        // };

        #endregion

        #region Tupple Patterns

        //Tupple patterns ise switch yapılanmasını Tuple nesnelerini kontrol edebilecek şekilde hem standar hemde yeni yapılanmayla bizlere sunmaktadır.

        // int s1 = 10;
        // int s2 = 20;
        // string mesaj = "";
        // switch(s1,s2)
        // {
        //     case(5,10):
        //         mesaj = "5 ile 10 değerleri";
        //         break;
        //     case(10,20):
        //         mesaj = "10 ile 20 değerleri";
        //         break;
        // }
        // System.Console.WriteLine(mesaj);

        // eğerki switch case de tek satırlık işlem yapyıorsak aynı amtıkla swich exp uygulayabiliriz.
        // string mesaj = (s1,s2) switch
        // {
        //     (5,10) => "5 ile 10 değerleri",
        //     (10,20) => "10 ile 20 değerleri"
        // };
        // string mesaj = (s1,s2) switch
        // {
        //     (5,10) when (true) => "5 ile 10 değerleri",
        //     var x when x.s1 % 2 == 1 || x.s2 == 10 => "10 ile 20 değerleri"
        // };
        // System.Console.WriteLine(mesaj);

        #endregion

        #region Positionla Patterns

        // Positional patterns ise Deconstruct özelliği olan nesleri kıyaslamak yahut değersel karşılaştırmak için kullanılan bir gelişimdir.


        #endregion

        #region Property Patterns

        // Property patterns, nesnenin propertylerine girerek belirli durumları hızlı bir şekilde kontrol etmemizi gerçekleştiren ve bunu arklı değerler için birden fazla kez tekrarlı bir şekilde yapmamıza olana sağlayan güzel bir gelişmedir.
        #endregion


        #endregion

        #endregion

        #region IF ELSE YAPISI

        #region IF

        //If yapılanmasıi elimizdeki bir değerin eşitlik durumuda dahil tümmm butun karşılaştırlamalrı yapmamızı sağlayna ve sonuca göre akısı yönlendirmemmizi sağlayan bir yapılanmadır.

        //if(sart) => eğerki bu şart doğru/true ise burası tetikleinr, false ise compiler if scopundan çıkacak ve yoluna        devam edecekitir.
        // bu sart her daim bool turde olmalidir.
        //karşılaştırma operatörler ve mantıksal operatörlerin hepsi burada kullanilabilir.

        // bool medeniHal = true;
        // if (medeniHal == true)
        // {
        //     System.Console.WriteLine("Allah tek yastikta kocatsin...");
        // }
        // if yapılanması tek başına kullanılıyorsa sadece şarta bağlı çalışacak koda odaklanır.

        #region Kritik 1

        //if yapılanmasında illa ki else kullanmak zorunda değiliz.
        // int i = 10;
        // if (i != 10)
        // {
        //     System.Console.WriteLine("Merhaba");
        // }
        // System.Console.WriteLine("Dünya");
        #endregion

        #region Kritik 2

        // bool medeniHal = true;
        // // if(medeniHal == true)
        // if(medeniHal)
        // {
        //     System.Console.WriteLine("Hayirli olsun...");
        // }
        // // bool türdeki değişkenlerin değerleri zatenn bool olacağından dolayı karşılaştırma operatorunu kullanmak zorunda değiliz.

        #endregion


        #endregion

        #region if - else

        // if else yapısı -> sarta göre bir kodun çalışıp, şartın olmadığı durumda bir başka kodun çalışmasını belirleyen bir yapılanma..
        //şartın olumsuz/değil durumunda da çalışacak kodu belirlemiş oluyoruzz..
        // if blogunda else varsa, sartın false olmasi durumunda kesinlikle else blogu tetiklenir.
        //if else yapılanmasında şart doğru olduğunda sadece if, yanlış odluğunda ise sadece else blokları tetiklenir.
        // if(sart)
        // {
        //     // sart true ise burası
        // }
        // else
        // {
        //     //false ise burası tetiklenecez
        // }

        // int i = 10;
        // if (i > 5)
        // {
        //     System.Console.WriteLine("i değeri 5 ten büyüktür.");
        // }
        // else
        // {
        //     System.Console.WriteLine("i değeri 5 ten küçüktür.");
        // }

        #region if - else - KRİTİK 1
        // int i = 10;
        // if (i == 10)                                        
        // {                                               
        //     System.Console.WriteLine("i değeri 10");    
        // }                                                   
        // else                                                
        // {                                                   
        //     System.Console.WriteLine("i değeri 10 değil."); 
        // }                                                       
        // if (i != 10)                
        // {
        //     System.Console.WriteLine("i değeri 10 değil.");
        // }
        // else
        // {
        //     System.Console.WriteLine("i değeri 10");
        // }
        #endregion

        #region if - else - KRİTİK 2

        // int i = 10;
        // if(i == 10)
        // {
        //     System.Console.WriteLine("i değeri 10");
        //     // System.Console.WriteLine("Merhaba");
        // }
        // else
        // {
        //     System.Console.WriteLine("i değeri 10 değil");
        //     // System.Console.WriteLine("Merhaba");
        // }
        // System.Console.WriteLine("Merhaba");
        // if else yapılanmasında if ve else bloklarında ayni işlemleri ypaacaksak eğer bunları bu şekilde blok içerisinde tekrarlı bir şekilde yapmamamiz GEREKMEKTEDİR..
        // her iki durumda da ortak olacak olan/çalıştırılaack olan komutları if else blogunun dişina yazmamiz olayi çözecektir...

        #endregion

        #endregion

        #region if - else if

        // birden fazla şartı kontrol etmemizi sağlayan bir yapılanmadir.
        // if yapılanmlaraında herhangi biri dogrulandıysa eğer diğer ifler denetlenmeyecekti

        // int sayi = 30;
        // if (sayi > 5 && sayi <= 10)
        // {
        //     System.Console.WriteLine(sayi * 5);
        // }
        // else if (sayi > 10 && sayi <= 20)
        // {
        //     System.Console.WriteLine(sayi * 10);
        // }
        // else if (sayi > 20 && sayi <= 30)
        // {
        //     System.Console.WriteLine(sayi * 20);
        // }

        #region if - else if - KRİTİK
        // int sayi = int.Parse(Console.ReadLine());
        // if(sayi > 100 && sayi <= 200)
        // {
        //     System.Console.WriteLine("100 ile 200 arasinda");
        // }
        // else if(sayi > 200 && sayi <= 300)
        // {
        //     System.Console.WriteLine("200 ile 300 arasinda");
        // }
        // else if(sayi > 200 && sayi <= 400)
        // {
        //     System.Console.WriteLine("300 ile 400 arasinda");
        // }
        // // ---

        // int sayi = int.Parse(Console.ReadLine());
        // if(sayi > 100 && sayi <= 200)
        // {
        //     System.Console.WriteLine("100 ile 200 arasinda");
        // }
        // if(sayi > 200 && sayi <= 300)
        // {
        //     System.Console.WriteLine("200 ile 300 arasinda");
        // }
        // if(sayi > 200 && sayi <= 400)
        // {
        //     System.Console.WriteLine("300 ile 400 arasinda");
        // }
        #endregion
        #endregion

        #region if - else if - ... - else

        // int i = 100;
        // if(i < 100)
        // {
        //     System.Console.WriteLine("100 den küçük");
        // }
        // else if (i > 100)
        // {
        //     System.Console.WriteLine("100 den büyük");
        // }
        // else
        // {
        //     System.Console.WriteLine("100 e eşit");
        // }
        #endregion

        #region Scopesuz if Yapisi

        // // if yapılanması tek satırlık bir islem gercekletsitiyorsa egen bunu scope icerisinde yazmak mecburuyietinde degiliz.
        // if (true)
        // {
        //     System.Console.WriteLine("sakndm");
        // }
        // if(true)
        //     System.Console.WriteLine("askndsak");
        // eğerki birden fazla konspet/isle/operasyon barıdıracaksa bunları kesinlik scope icerisinde almamız gerekmekterdir.
        // aksi taktirde scopesuz calısılırsa ilk islemi if blogu alacak digerlerini almayacaktır

        #endregion

        #region Senaryo 1
        //Klavyeden iki ürün fiyatı girildiğinde toplam fiyat 200 TL'den fazla ise, 2.üründen %25 indirim yaparak ödenecek tutarı gösteren uygulamayı yapalım.

        // Console.Write("Lütfen birinci ürün fiyatini giriniz : ");
        // int urun1 = int.Parse(Console.ReadLine());
        // Console.Write("Lütfen ikinci ürün fiyatini giriniz  : ");
        // int urun2 = int.Parse(Console.ReadLine());

        #region 1.Kritik
        // int toplam = urun1 + urun2
        // if (toplam > 200)
        // {
        //     //....
        // }
        #endregion
        #region 2.Kritik

        // if(urun1 + urun2 > 200)
        //     Console.WriteLine(urun1 + (urun2 * 0.75));
        // else
        //     Console.WriteLine(urun1 + urun2);
        #endregion
        #endregion

        #region Senaryo 2
        //Belirlenen kullancı adi ve şifre doğru girildiğinde "Giriş Başarılı",yanlış girildiğinde "Girdiğiniz kullanıcı adı veya şifre hatalı" mesajı veren Console uygulamasını yapalım.

        // System.Console.Write("Lütfen Kullanici adini giriniz :");
        // string kullaniciAdi = Console.ReadLine();
        // System.Console.Write("Lütfen şifrenizi giriniz : ");
        // // string sifre = Console.ReadLine();
        // // if(kullaniciAdi == "mustafa" && sifre == "12345")
        // //     Console.WriteLine("Giriş basarili");
        // // else
        // //     Console.WriteLine("Girdiğiniz kullanici adi veya sifre hatalidir");
        // Console.WriteLine(kullaniciAdi == "mustafa" && sifre == "12345" ? "Giris basarili" : "Girdiginiz kullanici adi veya sifre hatalidir.");
        #endregion

        #region Senaryo 3
        //  Kullanıcıdan alınan iki sayının ve yapılacak islem turunun (toplama-cikarma-çarpma-bolme) seçilmesiyle, sonucu hesaplayan programı yazalım.

        // System.Console.WriteLine("Lütfen birinci sayiyi giriniz:");
        // int sayi1 = int.Parse(Console.ReadLine());
        // System.Console.WriteLine("Lütfen ikinci sayiyi giriniz:");
        // int sayi2 = int.Parse(Console.ReadLine());
        // System.Console.WriteLine("Lütfen yapilacak islemi belirtiniz(+,-,*,/) :");
        // char islem = char.Parse(Console.ReadLine());


        #region 1.Kritik
        // if(islem == '+')
        // {
        //     System.Console.WriteLine(sayi1 + sayi2);
        // }
        // else if(islem == '-')
        // {
        //     System.Console.WriteLine(sayi1 - sayi2);
        // }
        // else if(islem == '*')
        // {
        //     System.Console.WriteLine(sayi1 * sayi2);
        // }
        // else if(islem == '/')
        // {
        //     System.Console.WriteLine(sayi1 / sayi2);
        // }
        #endregion
        #region 2.Kritik
        // switch(islem)
        // {
        //     case '+':

        //         break;
        //     case '-':

        //         break;
        //     case '*':

        //         break;
        //     case '/':

        //         break;
        // }

        #endregion
        #region 3.Kritik
        // int sonuc = islem switch
        // {
        //     '+' => sayi1 + sayi2,
        //     '-' => sayi1 - sayi2,
        //     '*' => sayi1 * sayi2,
        //     '/' => sayi1 / sayi2
        // }
        // System.Console.WriteLine(sonuc);
        #endregion
        #region 4.Kritik
        // System.Console.WriteLine(islem == '+' ? sayi1 + sayi2 : (islem == '-' ? sayi1-sayi2 : (islem == '*' ? sayi1*sayi2 :(islem == '/' ? sayi1/sayi2)) ));
        #endregion







        #endregion

        #region Senaryo 4
        //Girilen sayinin degeri 10 değilse 'sayi yanlıs' yazdiralim.
        // int sayi = int.Parse(Console.ReadLine());
        #region 1.Kritik
        // if(sayi == 10)
        // {

        // }
        // else
        // {
        //     System.Console.WriteLine("sayi yanlis");
        // }
        #endregion
        #region 2.Kritik
        // if(sayi != 10)
        //     Console.WriteLine("sayi yanliş");
        #endregion
        #region 3.Kritik
        // Console.WriteLine(sayi == 10 ? "" : "sayi yanliş");
        #endregion
        #endregion

        #region Senaryo 5
        //Girilen sayini negatif yada pozitif olduğunu gösteren uygulamayı yazalim.
        // int sayi = int.Parse(Console.ReadLine());
        // string sonuc = "";
        // if(sayi < 0)
        // {
        //     // System.Console.WriteLine("Negatif");
        //     sonuc = "Negatif";
        // }
        // else
        // {
        //     // System.Console.WriteLine("Pozitif");
        //     sonuc = "Pozitif";
        // }
        // System.Console.WriteLine(sonuc);

        // Console.WriteLine(sayi < 0 ? "Negatif" : (sayi > 0 "Pozitif" : "sayi sifirdir."));
        #endregion


        #endregion

        #region Pattern Matching

        #region Type Pattern ( is operatörü )
        // Object içerisindeki bir tipin belirlenmesinde kullanılan 'is' operatörünün desenleştirilmiş halidir.
        // is ile belirlenen türün direkt dönüşümünü sağlar

        // scope içinde kullanılır lakin if scopunun dışında kullanamazsın çünkü değer null olabilir

        // object x = "Mustafa";
        // if(x is string)
        // {
        //     string a =  (string)x;
        // }
        // if (x is string a)
        // {
        //     Console.WriteLine(a); 
        // }
        // else if (x is int b)
        // {

        // }

        #endregion
        #region Constant Pattern

        //Elimizdeki veriyi sabir bir değer ile karşılaştırabilmemizi sağlar
        // is operatörü bir değişkenin türünü sormamızı / belirlememizi sağlayan bir operatördür.
        //ve bu operatörünün kullanıldığı değişkenleri türü illa bir referans türlü olmak zorunda değildir.
        // İstersek değer türlü değişkenlerde de is operatörünü kullanabiliriz ve hatta primitive türlerde bile kullanılabilmektedir.

        // object x = "Mustafa Unal"
        // if (x is "Mustafa")
        //     System.Console.WriteLine($"Mustafa");
        // else if(x is null)
        //     System.Console.WriteLine($"null");

        // objecy y = 125;
        // if(x is 125)
        //     System.Console.WriteLine($"x değişkenini değeri 125'tir");

        // System.Console.WriteLine(y is 125); // => true;

        // Eğer ki is operatörüyle bir değişkenin değerini == operatörünü sorumluluğuyla check ediyorsa işte bu constant pattern demektir.
        // int a = 5;
        // System.Console.WriteLine(a is int); // constant pattern değildir.(tür kontrolü)
        // System.Console.WriteLine(a is 5); //=> constant patterndir(değer kontrolü)
        #endregion
        #region var Pattern

        //Eldeki veriyi 'var' değişkeni ile elde etmemizi sağlamaktadır.
        // var => verilen değerin türüne burunun bir keyword. runtimeda burunme işlemini gerçekleştirmektedir.
        // var keywordü ile var patterndeki var yapılanmaıs arasında davranıs farkı varıdır.

        // var keywordü => derleme zamanında türünü belirler
        // var pattenrdeki var keywordğ => runtimeda türünü belirler


        // object x = "Türkiye";
        // if(x is var a)
        // {
        //     System.Console.WriteLine(a);
        // }

        // object x = "amdsd";
        // if (x is var a) // varın türü runtiemede belirlenecektir.
        // {

        // }
        // var b = "akdbas"; // varın türü derleme zamanında belirlenir.




        #endregion
        #region Recursive Pattern

        // bu desen switch-case yapılanması üzerinde birçok yenilik getirmektedir.
        //switch bloğunda referans türlü değişkenlerde kontrol edilebilmekteidr.
        //ayrıca switch bloğuna when komuti ile çeşitli şart/koşul niteliği kazandırılmıştır.
        // tür kontrolü yaptığı için Type Patterni kapsamaktadir.
        //case null komutu ile ilgili türün/refernasın null olup olamamasını kontrol edebilmesinden dolayi Constant Pattern'i kapsamaktadir.

        #endregion

        #region var ile Type Pattern Arasindaki Kritik

        // object x = "asdx";
        // if(x is string a)
        // {
        //     System.Console.WriteLine(a);
        // }
        // if (x is var b)
        // {

        // }

        // type patternda x değişkenin değerinini string olmamma ihtimalinde a1'in null olma ihtimali soz konusu olduğu için a1 kullanırlıken hata vermektedir
        // bool result = x is string a;
        // System.Console.WriteLine(a);

        // var pattern'de ise x değişkenin değeri ne olursa olsun var ile a2 ye atanacağından dolayı o2nin null olma ihtimali yoktur...
        //dolayisiyla a2yi rahatca kullanabilmekteyiz
        // bool result2 = x is var a2;
        // System.Console.WriteLine(a2);


        #endregion

        #region Enhancements

        #region Simple Type Patterns

        //Bir değişken içerisinde değerin belirli bir türde olup olmadığını hızlı bir şekilde kontrol etmemizi sağlayan desendir.
        // c# 9.0 dan önce type Pattern ile yapılan tür bildirimlerinini yanına değişken adı tanımlaması yahut discard ifadesinin kullanılması zaruruyid. c# 9.0 ile bu gereksiz zorunluluk ortadan kaldırılmış ve direkt olarak tür kontorl işlemne odaklanılması sağlanmıştır

        #endregion
        #region Relational Patterns
        // Desenlerde <,>,<= ve >= operatörleri kullanılabilmekte ve belirli karşılaştırmalar hızlıca gerçekleştirilebilmektedir.

        //Switch özü itibariyle sadece eşitlik durumunu inceleyen bir kontrol akis semasiydi.. Relatinot patten sayesinde karşılaştırma yapabilmekteyiz

        //    int number = 100;
        //    string result = number switch
        //    {
        //     < 50 => "50 den küçük",
        //     > 50 => "50 den büyük",
        //     50 => "50ye eşit"
        //     _ => "Hiçbiri" // default
        //    };


        #endregion
        #region Logical Patterns
        //and, or ve not gibi mantıksal operatörler kullanılabilmektedir.

        // int number = 60;
        // string result = number switch
        // {
        //     > 10 and < 50 => "10'dan büyük 50'den küçük",
        //     > 50 or < 100 and 60 => "50 den büyük 100 den küçük ve 60 a eşir",
        //     not 51 => "51 değil"
        // };
        #endregion
        #region Not Pattterns
        //not operatörünün kullanılabildiği bir desendir.
        #endregion

        #endregion

        #endregion

        #endregion
    }
}