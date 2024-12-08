namespace Ders04_TurDonusumleri
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region TypeConversion

            #region Giriş

            // Yazılım sürecinde elimizdeki değerlerin türlerini değiştirebilmekteyiz.
            //Peki bir yazılımcı bunu neden ister ?
            // Tür dönüşümleri elimizdeki verinin fıtratınkdai/mahayiteindeki ture uygun işlemlere tabi tutabilmek için uygulanabilir.
            // farklı servislerden gelen değerleri uygun türlere donusturmek isteyebiliriz.

            // dikkat 
            // tür dönüşümlerinde amac türü dönüştürmektir değeri/veriyi dönüştürmek değildir. Yani elimizdeki veriye uygun bir türe geçiş yapmaktir.
            //Yani elimizdeki veriyi uygun olmayan bir türe dönüştürmeye çalışırsak bu mumkun değildir. Hata verecektir.
            // Elimizdeki ture uygun dönüşüm yapilmalidir. Elmayı armuta dönüştürmeyecez
            // Amaç veriyi değiştirmek değildir
            //Amacc elimizdeki veriyi karşıalyabilecek bir türe dönüştürmektir.

            #endregion

            #region Metinsel İfadeleri Diğer İfadelere Dönüştürülmesi

            // tür dönüşümlerinde dikkat edilmesi gereken tek bir husus vardır ki, o da; dönüşüm yapılacak verinin türüne uygun bir hedef belirlenmelidir.

            #region Parse Methodu

            //Parse metodu sadece string dataları hedef türe dönüştürürken kullanılır!

            #region Örnek1

            // string x = "123";
            // int y = int.Parse(x);
            // System.Console.WriteLine(x * 5);
            // short x2 = short.Parse(x);
            // System.Console.WriteLine(short.Parse(x) * 5);
            // System.Console.WriteLine(x2 * 5);

            #endregion
            #region Örnek2

            // string a = "Ahmet";
            // int a2 = int.Parse(a); => hata verecektri

            #endregion
            #region Örnek3

            //evli : true - bekar :false
            // string medeniHal = "true";
            // bool medeniHal2 = bool.Parse(medeniHal);
            // System.Console.WriteLine(medeniHal2);

            #endregion
            #region Örnek4

            // string x = "a";
            // char x2 = char.Parse(x);

            #endregion


            #endregion

            #region Convert Fonksiyonlari

            #region Örnek1

            // string x ="25";
            // int x2 = Convert.ToInt32(x);

            #endregion
            #region Örnek2

            // string x = "3,14";
            // double d = Convert.ToDouble(x);
            // System.Console.WriteLine(d *5);

            #endregion



            #endregion


            #endregion

            #region Diğer İfadelerin Metinsel İfadelere Dönüştürülmesi

            #region Convert Fonksiyonu

            // int a = 25;
            // string b = Convert.ToString(a);

            #endregion
            #region ToString Fonksiyonu

            // float f = 35;
            // string f2 = Convert.ToString(f);
            // string f3 = f.ToString();

            // toString fonksiyonu tümm ama tüm türlerde mevcuttur.

            #endregion

            #endregion

            #region Sayisal İfadelerin Kendi Aralarinda Tür Dönüşümü

            // bir sayisal türün alt türüne bir veriyi donüştürdüğümzde eğer ki veri o alt türün değer aralığına girmez ise Veri kaybi söz konusu olacaktir
            //Orn

            #region Bilinçsiz Tür Dönüşümü

            // bir sayısal türün kendisinden daha geniş aralıktaki bir başka sayısal türe atanması bilinçsiz tür dönüşümüdür.

            #region örnek

            // int a = 3000; 
            // float f = a; // şu anda burada bir tür dönüşümü söz konusudur. Lakin buradaki tür dönüşümü bizim irademizle/kararımızla/bilincimizle yaptığımız bir dönüşüm değildir.

            #endregion


            #endregion

            #region Bilinçli Tür Dönüşümü

            //Cast Operatörü:
            // Boxing işlemlerinde tanıştığımız cast operatörü bilinçli tür dönüşümünde de sayisal türleri kendi aralarında donustururken iradeli bir şekilde bu işlemin yapılmasını sağlayan bir operatördür.

            // int x = 3000;
            // short y = (short)x;

            // int x = 60000;
            // byte y = (byte)x; => hata verir daha doprusu vermez byte göre modunu alır veri kaybı gerçekleşir
            // System.Console.WriteLine(y);

            // int a = 3000;
            // short s = (byte)a;

            // (byte)a; => kısmında int ten byte turune bilinçli bir dönüşüm yapılmıştır
            // short s = (byte)a; => bytedan shorta bilinçsiz bir dönüşüm yapılmıştır.


            #region checked

            // bilinçli tür dönüşümü esnansında bir veri kaybı söz konusu olursa eğer runtime'de bizleri uyaracak olan bir kontrol mekanizmasıdır.
            // veri kaybı yaşanan senrayolarda hata fırlatmaya yarayarak veri kaybına müsade etmez.
            // veri kaybı olabileceğini düşündüğüzü kodları checked bloğuna alıp işinizi garantiye alabilirsiniz
            // checked
            // {
            //     int a = 500;
            //     byte b = (byte)a;
            //     System.Console.WriteLine(b);
            // }



            #endregion
            #region unchecked

            // Normal bir kod bloğunda default olarak unchecked dir.
            // veri kaybına izin verir.

            // unchecked
            // {
            //     int a = 500;
            //     byte b = (byte)a;
            //     System.Console.WriteLine(b);
            // }       

            #endregion

            #endregion

            #endregion

            #region bool Türünün Sayisal Türe Dönüştürülmesi

            // elimizdeki mantıksal bir değeri herhangi bir sayısal değere convert edersek ilgili değern mantıksal karşılığını elde debiliriz.
            // bool b = true;
            // int i = Convert.ToInt32(b);
            // System.Console.WriteLine(i);

            #endregion

            #region Sayisal Türlerin bool Türüne Dönüştürülmesi
            // tür dönüşümlerinde dönüştürülecek türün hedef türe uygun olamsı gerekiyordu
            //burada bir istisna var.
            // noramlde;
            // 1-> true
            //0 -> false
            // eşit olması ve ger ikalanın mümkün olmaması gerekmektedir.
            //Halbuki burada 0'ın dışındaki tümm değerler true olarak kabul edilmesi bir istisnadır.

            // int i = 1;
            // bool b = Convert.ToBoolean(i);
            // System.Console.WriteLine(b);

            #endregion

            #region char Türünün Sayisal Değere Dönüştürülmesi.

            // ASCII: bilgisayadaki her bir karakterin sayisa bir karşılığı vardır
            //bu sayısal değerlere ASCII kaynak kodu denmektedir.

            // char --> int e cast edersek bize ASCII kaynak kodu verilir
            // herhangi bir int değeri --> chara cast edersek inte karşılık gelen char karakterini verecek

            // char a = 'a';
            // int _a = (int)a;
            // System.Console.WriteLine(_a);

            // cast operatorunu :UnBoxing, bilinçli tür dönüşümü,ascii kaynak kodunu elde etmek için kullandık şimdiye kadar.
            #endregion

            #region Sayisal Türün char Türüne Dönüştürülmesi

            // int oascii = 111;
            // int Oascii = 79;
            // System.Console.WriteLine((char)oascii);  
            // System.Console.WriteLine((char)Oascii);

            #endregion

            #endregion

        }
    }
}
