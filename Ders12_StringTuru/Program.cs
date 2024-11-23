internal class Program
{
    private static void Main(string[] args)
    {
        #region STRING

        #region Giris
        
        // string referans türlü olduğu halde programlama dilinde bir keyword barındıran tek değerdir.
        
        #endregion
        
        #region Null - Empty Durumlari, Farklari
            
        #region Null

        // Bir değişken/nullable/referans eğer ki nuull alıyorsa bu durum ilgili değişkenin herhangi bir alanı tahsis etmediği anlamına gelir
        // Arsa YOK!
        // Değer türlü değişkenler null alamazlar
        // Null alabilen türler sadece referans türlerdir
        // Değer türlü değişkenlerin null alabilmesi için nullable(?) olmaları gerekmektedir.
        // Null bellekte yer kaplamaz

        // int? a = null;
        // string b = null;

        // Null olan bir değer üzerinde işlem yapmaya çalıştığımızda run time hatası meydana gelir. Amma velakin empty olan bir değer üzerinde işlem gerçekleştirebilir.
            
        #endregion
        #region Empty

        // Bir değişken/nullable/referans eğer ki empty ise bu değişkenin değeri yok anlamına gelir. Lakin alan tahsisinde bulunulmuştur.
        // Arsa VAR lakin ev YOK
        // Tüm değerlere empty atanabilir.
        // Alan tahsisinde bulunduktan sonra ilgili alana bir değer koymamak empty durumudur.
        // Default değerlerin olduğu durumlar empty olarak geçerler.
        // Empty her ne kadar deger olmasada bellekte yer kaplayacak ve bir alan tahsisinde bulunmus olacaktır

        // int a = 0;
        // bool b = false;
        // int[] x = new int[55];

        // Empty dendiğinde aklımıza string'e "" değerinin verilmesi gelsin yeter!
        // Bir string değişkeni empty yapmak istiyorsak a veya a2 gibi varyasyonlarda atama yapabiliriz.

        // string a = "";
        // string a2 = string.Empty;
        // string _a = null;

            
        #endregion
        
        #endregion
        
        #region IsNullOrEmpty

        // Elimizdeki string ifadelerin işleme tabi tutulmadan önce kesinlikle kontrol edilmesi gerekmektedir.

        // string x = ""; // empty
        // if (x != "" && x != null)
        // {
        //     // Operasyon...
        // }

        // IsNullOrEmpty fonksiyonu; elimizdeki string ifadenin null yahut empty olup olmama durumları hakkında bir check yapar ve geriye bool türde sonuç döner.
        // Eğerki null yada empty ise geriye True değilse False dönecektir.
        // if (!string.IsNullOrEmpty(x))
        // {
            
        // }

        #endregion
        
        #region IsNullOrWhiteSpace

        // IsNullOrWhiteSpace: Elimizdeki string ifadenin null, empty yahut boşluk karakterlerinden ibaret olma durumunda geriye bool true değerini döndüren bir fonksiyondur.
        // string x = "   ";
        // if (string.IsNullOrWhiteSpace(x))
        // {
            
        // }
    
        #endregion
        
        #region String RAM(Heap) İliskisi
            
        #region String - char Dizisi

        // String ifadeler esasında bir char dizisidir. Yani yazılım açısından string ifade yoktur! Esasında karakterlerin bir araya gelmis hali vardır. Dolayasıyla karakterleri bir araya getirebilecek yegane şey bir dizidir.
        // String ifadeler yazılımsal açıdan bilgisayarda bir char dizisi tarif olarak tarif edilmekte ve o şekilde tutulmaktadırlar.
        // String ifadeler özünde bir char dizisi/ yani dizi olmasından dolayı referans türlü değişkenlerdir. Çünkü diziler referans türlüdürler. Yani nesnedirler yani heapte tutulurlar.
        // String ifadeler char dizisi olduklarından dolayı yapısal olarak her bir karakter baştan sona otomatik indexlenmektedir. Dolayısıyla string bir ifade üzerinde bizler indexer operatöründe kullanabilmekteyiz

        // string metin = "sebepsiz boş yere ayrilacaksin";
        // System.Console.WriteLine(metin[3]);

        // Array array = metin;// String özünde bir char dizisi olabilir amma velakin yapısal olarak yinede string olduğu için Array referansına tılamaz, Array ile karşılanamaz.

        // for (int i = 0; i < metin.Length; i++)
        // {
        //     if (metin[i] == 'e')
        //     {
        //         System.Console.WriteLine(i);
        //     }
        // }

        // int i = 0;
        // do
        // {
        //     if(metin[i] == 'e')
        //         System.Console.WriteLine(i);
        //     i++;
        // } while (i< metin.Length);
            
        #endregion


        #endregion
        
        #region String İfadelerde + Operatörü
            
        // String ifadelerde + operatörü kullanılabilmektedir.
        // İki string ifade arasında birleştirme görevi görür.
        // string a = "merhaba", b = "dünya";
        // System.Console.WriteLine(a + b);
        // Bir string ifade ile herhangi bir tür + operatörüyle işleme tabi tutulabilir.
        // + operatörü string bir ifadeyle herhangi bir türdeki ifadeleri işleme tabi tutarken object + string davranışı sergileyecek ve sonuç olarak geriye string deger döndürecektir.
        // Dolayısıyla herhangi bir ifadeyi string'e dönüştürebilmek için o ifadeyi + "" ile işleme tutmak yeterli olabilir.

        // System.Console.WriteLine(5 + 7 + 20 + "ahmet"); // 32ahmet

        
        #endregion
        
        #region String Formatlandirma

        // string isim = "Mustafa", soyisim = "Unal", tcNo = "12345678910";
        // int yas = 23;
        // bool medeniHal = true;

        // System.Console.WriteLine("TC NO : ........... olan ....... .... şahsin bilgileri | Yas : ... | Medeni Hal : ... ");

        #region + Operatörü
        
        // System.Console.WriteLine("TC NO : " + tcNo + " olan " + isim + " " + soyisim + " şahsin bilgileri | Yas : " + yas + " | Medeni hal :  " + (medeniHal ? "Evli" : "Bekar"));

        // + operatörünü string formatlandırmada TERCİH ETMEMELİYİZ. 

        #endregion
        #region string.Format
        // string.Format fonksiyonu metinsel kalibin içerisindeki idexel belirlenen noktalara sirasiyla deger göndermemizi sağlayan bir fonksiyondur.
        // string sonuc = string.Format("TC NO : {0} olan {1} {2} sahsin bilgileri | Yas : {3} | MedeniHal : {4} ",tcNo,isim,soyisim,yas,medeniHal ? "Evli" : "Bekar");
        // System.Console.WriteLine(sonuc);

        #endregion
        #region $(String Interpolation) (C# 6.0)
        // string Interpolation string ifadenin icerisinde suslu parantez ile araya girerek programatik bir degiskenin degerini birakmamizi/eklememizi saglayan bir operatordur.
        // bir string degerin basina $"" operatörü koyulursa bu ifadenin icerisinde string interpolation operasyonunu/operatorunun kullanılabilirli saglanır.
        // string sonuc = $"TC NO : {tcNo} olan {isim} {soyisim} sahsin bilgileri | Yas :{yas} | Medeni Hal : {(medeniHal?"Evli":"Bekar")}";
        // System.Console.WriteLine(sonuc);

        // string interpolation yapisal olarak arkaplanda string.Format fonksiyonuyla sekillenen bir operatördür
        // ternary if kulanıyorsak paraneteze almalıyız
        // string interpolation kullanilan string ifadelerde metinsel olarak {} suslu parantez kullanmak ihtiyacı durumunda operatif olarak suslu parantezleri yine ayni operatore ezerek metinsel hale getirebiliriz.

        #endregion
        #endregion
        
        #region String Kacis Karakterleri
        
        // Eger ki string icin özel eylemsel mahiyet ifade eden bir karakteri metinsel olarak kullancaksam bu karakterin o anlik ozel karakter olmadigini ifade etmem gerekmektedir.
        // Bunun için kaçis karakterleri kullanılmalıdır
        // String icerisinde kacis karakteri olarak \(Backward Slash) kullanilmaktadir.
        // String icerisinde ozel/operatif karakterleri ezen ve bunlari metinsel hale getirmemizi saglayan bir karakterdir.

        //  \... kendisinden sonra gelen karakterin bir özel/eylemsel/operatif karakter olmadığını söyler.
        // System.Console.WriteLine("\"Bu gün hava çok güzel\"");
        // metinsel olarak \ kullanmak istiyorsak ilgili operatörü kendisiyle ezmeliyiz. \\ 
        // System.Console.WriteLine("Mustafa\\Unal");
        // \a bip sesi çıkartır
        // System.Console.WriteLine("\a");
        // \b kendinden bir önceki karakteri siler
        // System.Console.WriteLine("abc\b\b");
        // \t tab oluşturur
        // System.Console.WriteLine("İsim\tSoyisim");
        // char c = '\''; // chara tek tırnak koyabilmek için

        // Görüldüğü üzere tab,enter satir sonu vs gibi dogrudan klavye tarafindan girilemeyen bazi tusları oluşturmak için kullanilabilir



        #endregion
        
        #region @(Verbatim Strings) Operatörü
    
        #region 1.Kullanim
        // Bir değişken yahut metot vs. gibi yapılanma isimlerinin programatik bir keyworde karşılık gelmesi mümkün değildir. Derleyici hatasi verilir.
        // İllaki be bir keyword ismi kullanacam diyorsan eger @ kullanabiliriz
        // int @void = 5;
        // string @string = "asds";
        #endregion
        #region 2.Kullanim
        // Escape karakterlerinin kullanilmasi icap eden durumlarda @ operatörünü kullanarak eylemsel karakterleri kendileriyle ezebilecek ozellik kazandırabiliyoruz.
        // string metin = "hava çok \"güzel\"";
        // string metin = @"hava çok ""güzel""";
        #endregion
        #region 3.Kullanim
        
        //c# ta string ifade birleştirilmeden alt alta yazılamaz yazabilemek için @operatronu kullanabiliriz yada metinsel birleştirme kullanabiliriz

        // string metin = @"
        // adkasmfsd
        // adasmkfd 
        // asdksdfs";
        // string metin2 = "adkasmfsd" +
        // "adasmkfd" +
        // "asdksdfs";

        #endregion
        
        #region String Interpolation İle Verbatim Strings Birlikteliği (C# 8.0)
        // string isim = "Mustafa",soyisim = "Ünal",siparisNo = "123123";
        // int fiyat = 150;
        
        // @ oper ile $ ope birlikte kullaniliyorsa once @ sonra $ kullanılmalidir.
//         string mailMessage = @"Merhaba .... ....\n
//             ... nolu siprais talebiniz tarafimzica alinmistir.\n
//             Fiyat : ...";

//         string mailMessage2 = @$"Merhaba {isim} {soyisim} 
// {siparisNo} nolu siparis talebini tarafimizca alinmistir
// Fiyat : {fiyat}";
//         System.Console.WriteLine(mailMessage);
//         System.Console.WriteLine(mailMessage2);

        #endregion
        
        #endregion
        
        #region String Fonksiyonlari

        // string metin = "laylaylom galiba sana göre sevmeler";

        #region Contains

        // metinsel ifade belirtilen harf/kelime nin olup olamdığını sorgulayan fonksiyon.
        // bool sonuc = metin.Contains("sana");
        // System.Console.WriteLine(sonuc);
            
        #endregion
        #region StartsWith
        
        // İlgili değerin belirtilen değer ile başlayıp başlamadığını kontrol eden fonksiyon
        // System.Console.WriteLine(metin.StartsWith("laylay"));

        #endregion 
        #region EndsWith

        // verilen değer ile sonlanıp sonlanmadığını kontrol ediyoruz.
        // System.Console.WriteLine(metin.EndsWith("....")); // false

        #endregion
        #region Equals
            
        // elimizdeki metinsel ifade ile herhangi bir ifadenin eşit olup olmaduğını kontrol eden fonksiyon
        // System.Console.WriteLine(metin.Equals("mehmet")); // false
        // System.Console.WriteLine(metin.Equals("laylaylom galiba sana göre sevmeler")); // true

        #endregion
        #region Compare
            
        // metinsel ifadeleri karşılaştırmamızı ve sonuç olarak int türde değer elde etmemizi sağlar.
        //  0 : her iki değer birbirine eşittir.
        //  1 : soldaki sağdakinden alfanumerik olarak büyük
        // -1 : soldaki sağdakinden alfanumerik olarak küçük

        // System.Console.WriteLine(string.Compare(metin,"Z"));   // Z > l old -1 oldu
        // System.Console.WriteLine(string.Compare(metin,"a"));   // Z < a old 1 oldu
        // System.Console.WriteLine(string.Compare(metin,metin)); // Z = < old 0 oldu

        // System.Console.WriteLine(string.Compare(metin,9,metin,8,5)); //


        #endregion
        #region CompareTo
            
        // System.Console.WriteLine(metin.CompareTo("Z"));
        // System.Console.WriteLine(metin.CompareTo("a"));
        // System.Console.WriteLine(metin.CompareTo(metin));

        #endregion
        #region IndexOf
            
        // verilen değerin string ifade içerisinde olup olmamasını geriye int döndüren bir fonksiyondur
        // geriye int olarak indexNoyu döndürür
        // aradığım kelime ise kelimein ilk harfinini indexnosunu döner.
        // bulamaz ise -1 döndürür

        // System.Console.WriteLine(metin.IndexOf("la"));
        // System.Console.WriteLine(metin.IndexOf("lay"));
        // System.Console.WriteLine(metin.IndexOf("La"));
        // System.Console.WriteLine(metin.IndexOf("sana"));

        // indexof ilk eşleşen değerin indexini döndürür.

        #endregion
        #region Insert
            
        // elimizdeki metinsel ifadeye değer eklememize yarayan fonksiyondur.
        // string newMetin = metin.Insert(17,"merhaba ");
        // ilgili ekleme operasyonu gerçekleştikten sonra eklenmiş hali string olarak döndürülecektri
        // Lakin metin orjinal verisi ayri bir şekilde tutulacaktır. Yani dönen eklenmiş veriyle var olan metin arasında fark vardır.
        // System.Console.WriteLine(metin);
        // System.Console.WriteLine(newMetin);

        #endregion
        #region Remove
            
        // metinsel ifade indexel olarak verilen değer aralığını silen bir fonksiyondur.
        // Insertte olduğu gibi ilgili fonksiyon yapmış olduğu işlem neticesinde yeni değeri üreterek bize string olarak dönecektir.
        // Elimizdeki orjinal veri değişmeyecektir
        // System.Console.WriteLine(metin.Remove(5)); // 5. indesten sonraki tüm değerleri sil
        // System.Console.WriteLine(metin.Remove(5,10)); // 5. indexten başla 10 adet sil
        // System.Console.WriteLine(metin); 

        #endregion
        #region Replace
            
        // elimizdeki metinsel ifade de belirtilen değerleri/karakterleri ,belirtilen diğer ydeğerler ya da karakterler ile değiştirmemizi sağlayan fonksiyondur
        // Sonuc olarak string deger üretecek ve geriye döndürecektir.
        // System.Console.WriteLine(metin.Replace('a','b'));
        // System.Console.WriteLine(metin.Replace("la","lo"));
        // System.Console.WriteLine(metin);

        #endregion
        #region Split
            
        // metinsel ifadeyi verilen değeri ayraç olarak kullanıp ve sonucu string dizisi olarak döndüren bir fonksiyondur.
        // string[] dizi = metin.Split(' ');
        // string[] dizi2 = metin.Split(' ','a'); // hem boşlukta hem a da parçalayacak;

        #endregion
        #region Substring
            
        // elimizdeki metinsel ifadeninin belirli bir aralığını elde etmemizi sağlar
        // System.Console.WriteLine(metin.Substring(5)); // 5.indexten sonuna kadar tüm değerleri getir.
        // System.Console.WriteLine(metin.Substring(5,10));  // 5.indexten başlayıp 10 karakter getirecektr

        #endregion
        #region ToLower

        // eldeki metinsel ifadenin tüm karakterleri küçük karakter olarak düzenler
        // System.Console.WriteLine(metin);
        // System.Console.WriteLine(metin.ToLower()); 

        #endregion
        #region ToUpper
            
        // eldeki metinsel ifadenin tüm karakterleri büyük karakter olarak düzenler
        // System.Console.WriteLine(metin);
        // System.Console.WriteLine(metin.ToUpper()); 

        #endregion
        #region Trim
            
        // metinsel ifadelerin varsa solundaki ve sağındaki boşluk karakterini temizleten bir fonksiyondur
        // System.Console.WriteLine("ahmet cümbül");
        // System.Console.WriteLine("   ahmet cümbül    ".Trim());

        #endregion
        #region TrimEnd
            
        // elimizdeki sonundaki boşlukları temizleyen fonk.
        // System.Console.WriteLine("     asdgfdg       ".TrimEnd());

        #endregion
        #region TrimStart

        // System.Console.WriteLine("        asdgfd      ".TrimStart());


        #endregion
       

        #region Adimizin İlkten 3. Soyadimizin 5. Karakterini Getirelim
        // string adSoyad = "Mustafa Ünal";
        #region Çözüm 1
        // System.Console.WriteLine(adSoyad[2]);
        // System.Console.WriteLine(adSoyad[adSoyad.Length-5]);
        #endregion
        #region Çözüm 2

        // string aralik = adSoyad[2..^4];
        // System.Console.WriteLine(aralik[0]);
        // System.Console.WriteLine(aralik[aralik.Length-1]);

        #endregion
        #endregion
        #region Girilen Metin İcerisinde Kac Aden 'n' karakterinin gectigini hesaplayalin

        // System.Console.Write("Lütfen bir metin giriniz : ");
        // string metin = Console.ReadLine();
        // int adet = 0;
        // for (int i = 0; i < metin.Length; i++)
        // {
        //     if(metin[i] == 'n')
        //         adet++;
        // }
        // System.Console.WriteLine(adet);
            
        #endregion
        #region Girilen Metindeki Kelime Sayisisin Hesaplayalim

        // Console.Write("Lütfen bir metin giriniz : ");
        // string metin = Console.ReadLine();
        
        #region Çözüm 1
        
        // string[] kelimeler = metin.Split(' ');
        // System.Console.WriteLine(kelimeler.Length);

        #endregion
        #region Çözüm 2
        // int adet = 1;
        // while(true)
        // {
        //     int index = metin.IndexOf(' ');
        //     if(index == -1)
        //         break;
        //     adet++;
        //     metin = metin.Substring(index + 1);
        // }
        // System.Console.WriteLine(adet);

        #endregion
        #endregion
        
        #endregion
        
        
        #endregion
    }
}