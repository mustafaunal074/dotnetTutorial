internal class Program
{
    private static void Main(string[] args)
    {
        #region Operatorler

            #region Giriş
            #endregion

            #region Aritmetik Operatörler

            // +
            // -
            // *
            // /
            // %

                #region Aritmatik Operatörler Geriye Dönüş Değeri

                //Aritmatik operatorler, iki sayısal değer üzerinde işlem yapan operatörler oldukları için işlem neticesindegeriye 'uygun türde' sonuç dönerler

                #region İnceleme 1

                    // int sonuc = 3+5;

                #endregion
                #region İnceleme 2

                    // int x = 3, y = 5;
                    // int y = 5;
                    // int z = x * y;


                #endregion
                //Aynı türde olan sayisal değer üzerinde işlem yaparken sonuç türü aynı olacaktır.
                #region İnceleme 3

                    // double s1 = 123;
                    // double s2 = 321;
                    // double sonuc = s1+s2;

                #endregion
                #region İnceleme 4

                    // decimal s1= 123123;
                    // decimal s2 = 3214532;
                    // decimal sonuc = s1 % s2;

                #endregion

                #endregion
                #region (int) * (int) = ?
                #endregion
                #region (int) * (double) = ?

                    //İki farklı türde sayısal değer üzerinde yapılan aritmetik işlem neticesinde sonuç büyük olan türde dönecektir.
                    // int s1 = 10;
                    // double s2 = 5;
                    // double sonuc = s1 + s2;
                    //Aritmetik operatörlerde küçük olan tur büyük olan türe bilinçsiz bir şekilde dönüştürülerek o şekilde hesap yapılır... O yüzden sonuc büyük olan türde elde edilecektir/edilmektedir.
                #endregion
                #region (byte) * (int) = ?

                    // int s1 = 3;
                    // byte s2 = 123;
                    // int sonuc = s1-s2;

                #endregion
                #region (byte) * (byte) = ? İstisna! - (Mülakat !!!)

                    // byte s1 = 10;
                    // byte s2 = 5;
                    // int sonuc = s1-s2;

                    //Normalde iki aynı türdedki sayısal değer üzerinde yapılan aritmatik işlem neticesinde sonuc aynı türde döncekken, bu iki değer byte ise sonuc her daim int döncektir.
                    //Böyle kabul edilmiştir.
                    //İstisnadir.

                #endregion
                #region Matematiksel İşlemler (Öncelik Sirasi)

                    // Matematik biliminde işlem sırası nasıl ise programla dilindede yapılan işlem sırası öyledir.

                #endregion
            #endregion

            #region Karşilaştirma Operatörleri

            // İki sayısal değer arasında büyüklük,küçükük ve eşitlik durumunda göre karşılaştırma yapan operatörlerdir.
            // <
            // >
            // <=
            // >=
            // ==

            #region Karşilaştirma Operatörlerinin Geriye Dönüş Değerleri
            //Karşılaştırma operatörleri geriye her daim bool türde bir değer döndürecektir.
            // int s1 = 123;
            // int s2 = 321;
            // bool sonuc = i1 > i2;

            #endregion

            #endregion

            #region Mantiksal Operatorler

            //Tüm şartları değerlendirip, kendine göre sonuc döndüren operatörlerdir.
            #region  ve &&

            // ve(&&) operatörü, tümm şartların yerine getirilmiş olmasını isterr.
            //Patates ve köfte
            // true   &&  true

            #endregion
            #region  veya ||

            //veya(||) operatörü, şartlardan en az bir tanesinin yerine getirilmiş olması yeterlidir.
            //patates veya köfte
            // ikisinden birini true olması yeterlidir.

            #endregion
            #region  ya da ^

            // ya da(^) operatörü, şartlardan kesinlikle bir tanesinin yerine getirilmesini ister.
            //ikiside true olursada false döner.

            // elma almayı düşünelim
            // kırmızı ve yeşil elma var ben sadece elma alacağım sadece 1 tane
            // eeğerki sadece kırımız yada şelil alırsam sıkıntı yok
            // ama ikisinide aynı anda alrısam olmaz
            // Örnek veriyorum:çünkü ben sadece tek tat tatmak istiyorum ikisinide tatınca bir şey anlamıyorum


            #endregion

            #region Mantiksal Operatörlerin Kullanim Mantiği

            // Mantiksa operatörler, mantıksa değerler üzerinde kullanilir.
            // mantıksal operatörler geriye bool/mantıksa sonuçlar dönerler.

            // bool patates = true, köfte = false;
            // bool sonuc1 = patates && köfte;
            // bool sonuc2 = patates || köfte;
            // bool sonuc3 = patates ^ köfte;

            // System.Console.WriteLine(sonuc1); => false
            // System.Console.WriteLine(sonuc2); => true
            // System.Console.WriteLine(sonuc3); => true

            #endregion

            #region Mantiksal Operatörlerin Geriye Dönüş Değeri

            //ve
            // System.Console.WriteLine(true  && true);  // true
            // System.Console.WriteLine(true  && false); // false
            // System.Console.WriteLine(false && false); // false
            // System.Console.WriteLine(false && true);  // false

            // //veya
            // System.Console.WriteLine(true  || true);  // true
            // System.Console.WriteLine(true  || false); // true
            // System.Console.WriteLine(false || false); // false
            // System.Console.WriteLine(false || true);  // true

            //ya da
            // System.Console.WriteLine(true  ^ true);  // false
            // System.Console.WriteLine(true  ^ false); // true
            // System.Console.WriteLine(false ^ false); // false
            // System.Console.WriteLine(false ^ true);  // true

            #region Ornek

            // System.Console.WriteLine(((true && true) || false && ((true ^ false) && false) || true));
            //                                          TRUE
            #endregion

            #endregion
            #endregion

            #region Arttirma Azaltma Operatörleri

            // işlem neticesinde işlemin değerini dönerler.

            #region ++

            //i++ => öncelikle i değerini döndürür, sonra +1 arttırır.
            //++i => Öncelikle i değeri +1 arttırılır, ardindan i değerini döndürür.
            // int i = 10;
            //      cw(++i) yazarsak => inin değeri 1 artar inin değerini yazdırır
            //          => Çıktı = 11 , Bellekteki değer => 11
            // eğerki
            //      cw(i++) yasarsak => i yi yazar(bellekteki değerini) sonra bellekteki i değerini 1 arttırır
            //          => Çıktı = 10 , Bellekteki değer => 11;
            #region Ornek 1

            // int i = 5
            // System.Console.WriteLine(i++); // Çıktı :5 , Bellek : 6
            // System.Console.WriteLine(++i); // Çıktı :7 , Bellek : 7

            #endregion
            #region Ornek 2
            //                                      STACK            
            // int a = 5;                        //| int a=5 => 6
            // int b = a++;                      //| int b=5
            // System.Console.WriteLine(a); // => 6|
            // System.Console.WriteLine(b); // => 5|
            //                                 //  |
            #endregion
            #region Ornek 3
            //                                  STACK
            // int i1 = 5;                     //|1. i1 = 5 => 2. 6
            // int i2 = ++i1;                  //|3. i2 = 6 => 5. 7
            // int i3 = i1;                    //|4. i3 = 6
            // i2 = ++i2;                      //|  
                // ++i2
            // System.Console.WriteLine(i1); // 6
            // System.Console.WriteLine(i2); // 7
            // System.Console.WriteLine(i3); // 6

            #endregion
            #endregion
            #region --



            #endregion



            #endregion
        
            #region Üzerine Ekleme Yiğma Operatörleri

            #region +=
            #endregion
            #region -=
            #endregion
            #region *=
            #endregion
            #region /=
            #endregion
            #region %=
            #endregion
            
            #endregion
        
            #region Metinsel İfadelerde Operatörler

            #region + Operatörü

            //Metinsel ifadeler + operatörüyle yanyana birleştirilebilirler.
            // int a = 5, b = 3;
            // System.Console.WriteLine(a+b); // 8

            // string x = "mustafa", y = "unal";
            // System.Console.WriteLine(x+y); // mustafaunal

            // int a = 5;
            // string b = "abc";
            // var result = a+b; // => 5abc
            // System.Console.WriteLine(result);
            // burada bir string ifadesi herhangi bir ifadeyler + operatörüyle toplanırsa eğer string dışındaki değer boxing edilip object türü olarak algılanır ve toplama işlemi sonucundada dönen değer string döner

            // tür dönüşümlerinde herhangi bir değeri string'e dönüştürebilmek için .ToString fonksiyonu kullanıyorduk.
            //ayriyetten ilgili türü string'e dönüştürebilmek için string bir ifade ile + operatörüne tabi tutulması yeterli oalcaktir.
            
            #endregion
            #region  += Operatörü

            // string a = "ahmet";
            // string b = "mehmet";
            // a = a + b;
            // a += b;
            // System.Console.WriteLine(a); => yukarıda yapılan iki işlemde aynıdır.
            #endregion
            #region == Operatörü

            // Metinsel ifadelerde kullanılabilen karşılaştırma operatörü oalrak == ifadesi kullanılabilir sadece
            // buda sadece karşılaştırma yapar diğer <,> gibi ifadeler kullanılamaz çünkü yazılımda bu operatörler string türlerde kullanılamaz. Çünkü tür karşılaştırmaya uygun değildir.
            // string a = "ahmet";
            // string b = "memet";
            // bool result = a == b; 
            // bool result 2 = a != b;
            
            #endregion
            #region ! Operatörü
            
            // ! -> değil,olumsuzluk anlamına gelir.
            // 1. Mantıksal yapılarda olumsuzluk ifade eder.
            // !true => false -- !false => true 

            // 2. != => eşit değillik anlamına gelir
            // int i = 3;
            // int i2 = 5;
            // System.Console.WriteLine(i == i2);
            // System.Console.WriteLine(i != i2);
            // System.Console.WriteLine(!(i == i2)); // !=bu operatorun dışnda sade ve sadece mantıksal değerlerin yanında kullanilabiir..

            // 3. Null References (C# 8.0)
            // bu konuya ileride değimeceğiz


            #endregion
            
            #endregion

            #region  Ternary Operatörü ?:

            // Bir değişkene/metoda/property'e değer atarken, eğer ki bu değer şarta göre fark edecekse satır bazlı/tek satırda bu şart kontrolünü yaparak duruma göre değeri döndürmemizi sağlayan bir kalıpsal operatördür.

            // Ternary operatörü if-else yapısındaki akış kontrollerideki mekanizmada fazla kod yazmamızı engeller.

            // değişken =  ...şart/durum... ? true durumu : false durumu
            //şart/durum : Geriye bir değer döndüren, karşılaştırma yahut mantıksal işlem neticesinde bool dönen bir sonuc.
            // true ve false durumuda dönecek değerelr aynı türde olmaz zorundadır.

            //EK BİLGİ:
            // Polimorfizm, kurallarina göre birbirlerinen türeyen değerlerde desteklenmektedir... C# 9.0 
            
            // bool medeniHal = true;
            // string mesaj = medeniHal ? "Evlilere Kampanya..." : "Bekarlara Kampanya...";
            // System.Console.WriteLine(mesaj);


            #region Birden Fazla Condition Uygulamak

            //Yaşı; 25den küçük olanlara A, 25 olanlar B ve 25'den büyük olanlara C değerini döndüren ternary operatörünü oluşturalım.
            // int yas = 25;
            // string sonuc = yas<25 ? "A" : (yas == 25 ? "B" : "C");

            #region Ornek 1
            
            // Kullanici tarafindan girilen sayının aşağıdaki önergelere göre hesabını gerçekleştiren kodu geliştiriniz.
            // sayi < 3                   => sayi * 5;
            // sayi > 3 && sayi < 9       => sayi * 3;
            // sayi >= 9 && sayi % 2 == 0 => sayi * 10;
            // sayi % 2 == 1              => sayi;
            // hiçbiri değilse            => -1

            // System.Console.WriteLine("Lütfen bir sayi giriniz : ");
            // int sayi = int.Parse(Console.ReadLine()); // Kullanicinini girdiği değeri string olarak getiren/yakalayan bir komuttur.
            //                                           // Console.ReadLine komutu kullancıının console'dan bir değer girmesini bekler

            // int sonuc = sayi < 3 ? sayi * 5 :
            //            (sayi > 3 && sayi <9 ? sayi * 3 :
            //            (sayi >= 9 && sayi % 2 == 0) ? sayi * 10 : 
            //            (sayi % 2 == 1 ? sayi : -1));
            // System.Console.WriteLine("Sonuc : " + sonuc);
            // #endregion

            #endregion
            #region Ornek 2
            
            //Hava durumunu tutan string değişkenin değerine göre aşağıdaki önergeeri uygulayan programı yazınız.
            //Yağmurlu => "Şemsiye almalısın
            //Güneşli => Bol bol d vitamini alman dileğiyle
            //Kapalı => Yağmur yağabilir
            
            // string havaDurumu = "Yağmurlu";
            // System.Console.WriteLine(havaDurumu == "Yağmurlu" ? "Şemsiye almalisin" : (havaDurumu == "Güneşli" ? "Bol bol d vitamini alman dileğiyle" : "Yağmur yağabilir"));
            #endregion 
            #endregion
            #endregion
       
            #region Atama(Assign) Operatörü
            
            // int a = 5;
            // atama operatörünü soluna gelen şey değişkenin kendisi sağa gelen değişkenin değeri oluyor

            //İleride referans türlü değişkenlerde atama operatörünü sorumluluğu değişip referans etme operatoru olduğunu konuşaağız.

            #endregion
        
            #region .(Member Access - üye Erişim) Operatörü

            // Member accessi elimizdeki bir değerin türüne uygun elemanlarını/fonksiyonlarını/metotlarını/propertylerini/field 'a erişmemzi/çalıştırmamızı/çağırmamızı sağlayan bir operatördür.
            //Member access kodun devamını getirir.
            
            // int i = 5;
            // i.
            #endregion

            #region Cast Operatörü
            
            //Genellikle tür dönüşümlerinde kullanılan bir operatördür
            // (type)value -> valueyi typa dönüştürür

            //1. Boxing -> Unboxing
            // object x = 123;
            // int y = (int)x;
            
            //2. Biliçli tür dönüşüm
            // int a = 5;
            // short b = (short)a;
            
            //3. char -> int | int -> char (ASCII)
            // int ascii = 93;
            // char c = (char)ascii;

            //***İleride polimorfizm durumunda base class referansı işaretlenen bir nesneyi kendi türünde de elde edebilmemizi sağlamaktadır.
            

            #endregion
        
            #region sizeof Operatörü

            //Verilen türün bellekte kaç byte'lık yer kapladığını integer olarak geriye döndürür.

            // System.Console.WriteLine("int : " + sizeof(int));
            // System.Console.WriteLine("long : " + sizeof(long));
            // System.Console.WriteLine("decimal : " + sizeof(decimal));

            #endregion

            #region typeof Operatörü

            // typeof operatörü verilen türün/değerin type'ını/türünü getirir.
            // O tür ile ilgili bilgileri edinmek için kullanılan bir operatörüdür.
            // İleride(ileri düzey programlamada) reflection dediğimiz bir konuda elimzdeki bir türün reflectionına girmek için kullanıldığını göreceğiz.

            // Type t = typeof(int); // int türüne ait tümm bilgiler buradaki t değişkenine atanmıştır.
            // System.Console.WriteLine(t.Name);
            // System.Console.WriteLine(t.IsPrimitive);
            // System.Console.WriteLine(t.IsClass);
            // System.Console.WriteLine(t.IsValueType);

            #endregion

            #region default Operatörü

            // Belirtilen türün default değerini döndüren operatördür
            // Default değer ne demektir?
            //Default değerler,her tür için yazılım tarafından tanımlanmış bir varsayilan değer demektir.

            //sayisal  = 0;
            //bool     = false
            //string   = null
            //char     = \0
            //referans = null

            // System.Console.WriteLine(default(decimal));
            // System.Console.WriteLine(default(string));
            // System.Console.WriteLine(default(Program));
            // System.Console.WriteLine(default(short));
            // System.Console.WriteLine(default(byte));

            // int a1= default;
            // int a2 = default(int);

            #endregion
        
            #region is Operatörü

            // Boxinge tabi tutulmuş bir değerin öz türünü öğrenebilmek/check edebilmek/kontrol edebilmek için kullanılan bir operatördür
            // is operatörü denetleme neticesinde durumu bool yani true ya da false olarak döndürecektir.

            // object x = true; //boxing
            // System.Console.WriteLine(x is bool);
            // System.Console.WriteLine(x is int);
            // System.Console.WriteLine(x is Program);
            
            // İleride if yapılanamsında vs. çok tercih ettiğimiz bir operatör olacaktır.
            // OOP yapılanmasında poliformizim is operatörüyle kalıtımsal durumlardaki nesnelerin türlerinide öğrenebileceğiz.
            #endregion

            #region is null Operatörü
            // Bir değişkenin değerimnin null olup olmamasını kontrol eden ve sonuç olarak geriye bool türde bir değer döndüren operatördür.
            // string a = "asfsd";
            // string b = null;
            // System.Console.WriteLine(a is null);
            // System.Console.WriteLine(b is null);

            //is null operatörünü sadece null olabilen türlerde kullanabilmekteyiz.
            // ValueType ve ReferenceType değişkenlerimiz var bu değişkenlerden sadece Referans Türlü değişklenler null olabilir.

            // int b = null;
            // System.Console.WriteLine(b is null); // hata döner int bir değeşeken türlüdür.

            #endregion

            #region is not null Operatörü

            // Elimizdeki değerin null olup olmamasıyla ilgilenmekte ve geriye bool sonuç döndürmektedir.
            
            // string a = null;
            // System.Console.WriteLine(a is not null);

            // Sadece null alabilen türlerde kullanılabilir...

            #endregion

            #region as Operatörü

            // Cast operatörünün UnBoxing işlemine alternatif olarak üretilmiş bir operatördür.

            // Turune uygun bir şekilde as edilmesi zaruru değildir.
            // Eğerki tür uygunsa unboxing işlemi başarıyla yapılacak,
            // yok eğer tur uyguun değise hata vermeyecek null değer döndüreektir

            // bu durumda programatik olarak yazılım sonlanmadan akista kontrol edilmesine musade edecek ve işleme devam edecektir.
            // as operatörü tur uygun olmadığı taktirde geriye null döndüreceği için bu null'u larşiyabilen türlerle çalşmak isteyecektir. Haliyle as operatörü değer turlu değişkenlerde kullanılamaz.
            // Referans türlerdeki değişkenlerle çalışabaliri.
            // x as Type

           
            #region Cast Ornek
           
            // object x = "Ahmet";
            // string y = string(x);
            // int z = int(x);
            // System.Console.WriteLine(y);
            // System.Console.WriteLine(z);
           
           #endregion

            // object x = "Ahmet";
            // string y = x as string;
            // Program z = z as Program;
            // System.Console.WriteLine(y);
            #endregion

            #region ?(Nullable) Operatörü
            
            // C# programlaa dilinde değer türlü değişkenler normal şartlarda null değer alamazlar(Not nullable)
            //Bir değer türlü değişkenin null değer alabilmesi için (yani nullable olabilmesi için) ? operaötürün kullanılması gerekmektedir.

            // int? a = null;
            // bool? b = null;

            //değişken_türü? değişken_adi = .... => bu formatta tanımlanan değişkenler null değer alabilirler.

            // System.Console.WriteLine(a is null);

            //Bir değer türlü değişken nullable yapıldıysa eğer; is null, is not null, as gibi null ile çalışan operatörleri  üzerinde kullanabiliriz.

            #region as Orneklendirme
            
            // object x = 123;
            // int? y = x as int?;

            #endregion
            
            #endregion
        
            #region ??(Null-Coalescing) Operatörü
            
            // Elimizdeki değişkenin değerinin null olma durumunda istinaden farklı bir değeri göndermemizi sağlayan operatördür.
            // Değişken değeri null değil ise değişkenin değerini ata değilse belirtilern değişkeni ata diye bir yapısı var
            // Null Coalescing operatöründe her iki taraftaki değişken yahut değerler aynı türde olmalıdır.
            // string a = null;
            // System.Console.WriteLine(a ?? "Merhaba"); // a dolu ise a yı null ise "Merhaba" yı yazdır demek

            // System.Console.WriteLine(a ?? 3); 
            
            #endregion
        
            #region ??=(Null-Coalescing Assign) Operatörü (C# 8.0)
            
            // string x = null;
            // System.Console.WriteLine(x ??= "Merhaba"); // x in değeri null ise x yerine "Merhaba" yazdır ve x'e "Merhaba" değerini ata
            //                                            // Eğerki x null değilse, direkt olarak x'in değerini yazdıracaktır
            // System.Console.WriteLine(x);

            // int? id = null;
            // id ??= 1; // id null ise 1 değerini ata değilse gelen değer ile devam et. // canlı örnek

            #endregion
        
        #endregion
    }
}