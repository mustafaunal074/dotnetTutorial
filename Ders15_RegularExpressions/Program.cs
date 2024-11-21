using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Regular Expressions

        #region Giris

         // Metinsel yapılanmalarda belirli koşulları sağlayabilen ifadelerdir
        // Metinsel ifade içerisinde ihtiyaca istinaden düzenlenirler

        //Örnek
        //Bir metinsel ifade içerisinde @ karakteri geçen bütün aralıkları elde etmek istediğimizi varsayalım
        // adjhabshjq@uh31b2@jdnjkabsd'@'1321q@asdas
        // Dikkat ederseniz bu değerlerdeki karakterlerin uzunluğu ve ne olduğu önemli değil. Yeter ki @ karakteri olsun

        // Peki bu aralıkları nasıl elde edeceğiz ?
        //@ karakteri geçen tüm aralıkları elde etmenin çeşitli yolları olabilir.
        //Ancak şartlar arttıkça işlemi koda dökmek zorlaşacaktır.

        //misal
        //Milyonlarca email adresi olduğunu düşünelim
        //Biliyoruz ki tek bir email formatı vardır

        //Her email adresi mutlaka @ ve ardından .(nokta) karakteri barındırır. Eğer birden fazla nokta varsa, noktalardan biri mutlaka @ karakterinde sonra olmalıdır.
        //mustafa.unal@asdfg.com
        //Haliyle bir karakter dizisinin email adresi olup olmadığını test etmek oldukça zor olacaktır.

        //Regex
        //Bu yüzden c# ta bu tür düzenli ifadeleri temsil edebilme için Regular Expressions operatörleri geliştirilmitir.
        //Bu operatörler eşliğinde elde edilen verinin tasarlanan metinse düzene uyup uymadığı değerlendirilebilmektedir.
        //Reguler ifadeler System.Test.RegulerExpression namespace'i altında Regex sınıfı tarafından temsil edilmektedir.
        //Regular Expressins'lar ufak tefek farklılık olsa dahi hemen hemen tüm programlama dillerinde olan evrensel yapılanmalardır.
        //Düzenli ifadeler başlı başına bir konudur.
        //Ya hayat kurtarırlar, ya da ömür törpülerler.
            
        #endregion
        
        #region Regular Expressions Operators

        #region ^ Operatörü
            
        // Satır başının istenilen ifadeyle başlamasını sağlar.

        // ^9 => satır 9 ile başlamalı
        // string text = "91asd91243asffg";
        // Regex regex = new Regex("^91"); // sana verilecek metin 9 ile başlamalıdır.
        // Match match = regex.Match(text);
        // System.Console.WriteLine(match.Success);
        
        #endregion
        #region \ Operatörü

        // \ => belirli karakter gruplarının içermesini istiyorsak kullanırız

        // \D => Metinsel değerin ilgili yerinde rakam olmayan tek bir karakterin bulunması gerektiğini belirtilir.
        // \d => Metinsel değerin ilgili yerinde 0-9 arasında tek bir sayı olacağı ifade edilir.

        // \W => Metinsel değerin ilgili yerinde alfanümerik olmayan karakterin olması gerektiğini belirtilir. Alfanümerik karakterler : a-z A-Z 0-9
        // \w => Metinsel değerin ilgili yerinde  alfanümerik olan karakterlerin olacağı ifade edilir.

        // \S => Metinsel değerin ilgili yerinde boşluk karakterli(tab/space) dışında herhangi bir karakterin olamayacğı belirtilir.
        // \s => Metinsel değerin ilgili yerinde sadece boşluk karakterin olacağı ifade edilir.

        // Örnek
        // 9 ile başlayan, ikinci karakteri herhangi bir sayı olan ve son karakteri de boşluk olmayan bir düzenli ifade oluşturalım.
        // ^9\d\S

        // string text = "91asd91243asffg";
        // Regex regex = new Regex(@"^9\d\S"); 
        // Match match = regex.Match(text);
        // System.Console.WriteLine(match.Success);
            
        #endregion
        #region + Operatörü

        // Belirtilen gruptaki karakterlerden bir ya da daha fazlasının olmasını istiyorsak kullanılan operatördür.
        
        // Örnek
        // 9 ile başlayan, arada herhangi bir sayısal değerleri olan ve son karakteri de boşluk olmayan bir düzenli ifade oluşturalım.
        // ^9\d+\S

        // string text = "91 24dksaö3D ";
        // Regex regex = new Regex(@"^9\d+\S"); 
        // Match match = regex.Match(text);
        // System.Console.WriteLine(match.Success);

        #endregion
        #region | Operatörü

        // Birden fazla karakter grubundan bir ya da birkaçının ilgili yerde olabilecğinin belirtmek istiyorsak mantıksal veya operatörü kullanılır.

        //Baş harfi a yada b yada c olan metinsel ifadeyi girelim
        // a|b|c

        // string text = "asd";
        // Regex regex = new Regex(@"a|b|c"); 
        // Match match = regex.Match(text);
        // System.Console.WriteLine(match.Success);
            
        #endregion
        #region {n} Operatörü

        // Sabit sayıda karakterin olması isteniyorsa {adet} şeklinde belirtilmeli

        // telefon numarası alalım 
        // 507-7514592
        // \d\d\d-\d....\d şeklinde yazılır
        // \d{3}-\d{6}

        // string text = "507-7514592";
        // Regex regex = new Regex(@"\d{3}-\d{6}"); 
        // Match match = regex.Match(text);
        // System.Console.WriteLine(match.Success);

            
        #endregion
        #region ? Operatörü

        // Bu karakterin önüne gelen karakter en fazla bir en az sıfır defa olabilmektedir.
        // n? => bu ifadenin metinsel ifadenin içinde EN FAZLA 1 defa olamsı gerektiğin söylüyor.

        // ilk üç karakteri sayısal değer olacak sonra gelen karakter B karakteri olacak ve sondada A karakteri olacak
        // \d{3}B?A => 234BA - 543BA- 543A ---- 123BBA

        // string text = "123BBA // İKİ B VAR FALSE";
        // Regex regex = new Regex(@"\d{3}B?A"); 
        // Match match = regex.Match(text);
        // System.Console.WriteLine(match.Success);
            
        #endregion
        #region . Operatörü
        
        // Kullanıldığı yerde \n karakteri dışında bir karakter bulunabilir

        // \d{3}.A => 123'A olur 123\nA olmaz

        // string text = "1233A";
        // Regex regex = new Regex(@"\d{3}.A"); 
        // Match match = regex.Match(text);
        // System.Console.WriteLine(match.Success);
        #endregion
        #region \b \B Operatörleri
        
        // \B : Bu ifade ile kelimenin başında ya da sonunda olmaması gereken karakterler bildirilir.
        // \b : Bu ifade ilgili kelimenin belirtilen karakter dizisi ile sonlanmasını sağlar

        // \d{3}dır\B => 3 sayi olsun sonrasında gelen bölümde başında ve sonunda 'dır' olmasın
        // 123dır - olur
        // dır123 - olmaz
        // 123dır2 - olur

        // string text = "123dır";
        // Regex regex = new Regex(@"\d{3}dır\B"); 
        // Match match = regex.Match(text);
        // System.Console.WriteLine(match.Success);

        #endregion
        #region [n] Operatörü

        // [n] :Karakter aralığı belirtilebilir
        // Ayrıca özel karakterlerin yerinde yazılmasınıda ifade eder

        // \d{3}[A-E] => 3 sayısal ile başla sonrasında gelen değer A-E aralığında olsun
        // 123A - true
        // 123P - fasle

        // (507) 751 45 92
        //[(\d{3})]\s\d{3}\s\d{2}\s\d{2}

        // string text = "(507) 751 45 92"; 
        // Regex regex = new Regex(@"[(\d{3})]\s\d{3}\s\d{2}\s\d{2}"); 
        // Match match = regex.Match(text);
        // System.Console.WriteLine(match.Success);

            
        #endregion


        

        #endregion
        
        #region Match Sinifi

        string text = "(507) 751 45 92"; 
        Regex regex = new Regex(@"[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}"); 
        Match match = regex.Match(text);

        System.Console.WriteLine($"Success : {match.Success}");  // true
        System.Console.WriteLine($"Value : {match.Value}");      // (507) 751 45 92
        System.Console.WriteLine($"Index : {match.Index}");      // 0. indexte başlıyor diyor
        System.Console.WriteLine($"Length : {match.Length}");    // 15 => doğrulamanın yapıldığı karakter sayısını veriyor
            
        #endregion
        
        #endregion
    }
}