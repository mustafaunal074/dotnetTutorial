public class Program
{
    private static void Main(string[] args)
    {
        #region Döngüler
        
            #region Döngüler Nedir?

            //
            // for - while - doWhile
            // Hangi dögü nerede kullanılmalıdır sorusu YANLIŞTIR
            //Doğru soru, hangi döngü nereye/hangi senaryoya daha çok yakışır.
            //Bu döngülerin hepsi bir kombinasyona bağlı bir şekilde çalıştıkları için enn nihayetinde birbileriin yerine kullanılabilir.



            #endregion

            #region for Döngüsü

            #region Teorik Anlatim
            // Prosedurel programlamada donguu yapılarından biriside for döngüsüdür.
            // Genellikle ardaşık işlemlerde kullanılan bir döngü yapılanmasıdır.
            // for (baslangıc degeri tanımlama ; sart ; artıs miktarı)
            // {
            //     // ŞART TRUE OLDUKÇA BU SCOPE TETİKLENECEKTİR. VE DÖNGÜ ÇALIŞTIRILMIŞ OLACAKTIR.
            // }

            // Baslangıc degeri tanımlama:
            // ardaşık algoritmalar genellikle bir ilk degere htiyac vardır. Iste bu ihtiyacı burada tanımlayabiliriiz. Bu tanımlamam zorunlu DEĞİLİDR.

            // ŞART:
            // Herhangi bir şarT/koşul ifadesi tanımlanabilir.
            // Lakin genellikle ilk deger olarak tanımlanan değişken durumunu burada kontrol edilir. Yani şarta bağlanır
            // Sart true oldugu surece dongu tetiklenecektir

            // Artış Miktarı:
            // Herhangi bir değişken üzerinde işlem yapabiliriz. Genellikle başlangıç değeri üzerinde bir arttırma yahut azaltma işlemi yapılır. Amma velakin bir değerinin dışında diğer arttırma ve azaltma işlemleride ihtiyaca binaen yapılmaktadir.
            // Vee illaki kullanmak zorunda değiliz

            // for (1. kısım ; 2. kısım ; 3. kısım)
            // {
                
            // }

            // 1.kısım => Akış ilk olarak başlangıç değişkeni tanımlama kısmına girecektir. Egerki bir degisken tanimlama ifadesi varsa ilgili degiskeni taımlayacaktır.
            // 2.kısım => ardından kosula gidecek ve kosulu degerlendirecek
            // 2.1=> eger ki koşul true ise döngüye girecektir
            // 2.2=> eğer ki kosul false ise döngüden çıkacaktır
            // 3.kısım => eger ki 2.1 den devam ediyorsa dongu ilgili degeri arttıracak parametreye gidecek ve yapılan aritmetik işlemi değişkene uygulayacaktır.
            // Sayısal değeri arttırılmış ya da azaltılmış olan değişkenden sonra yeniden kosulu kontrol edecek ve ardından true ise 2.1 değilse 2.2 adımdan tekrar edecektir.

            // buradaki tüm işlemler koşul false olana kadar tekrar edecektir. 
            #endregion

            #region İncelemeler
            #region İnceleme - 1
            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine("Mustafa Ünal");
            // }
            #endregion
            #region İnceleme - 2
            
            //Hilmi değerini 10 kere ekrana yazdıralım
            // for (int i = 1; i <= 10; i++)
            // {
            //     System.Console.WriteLine(i + ".Hilmi");
            // }
            
            #endregion
            #region İnceleme - 3
            
            //Hilmi değerini 10 kere ekrana yazdıralım
            // Eğer ki ardaşık işlemlerde artış yapılıyorsa i'nin değeri genellikle <(küçüklük) durumuyla degerlendirilir.
            // Yok eğer ardaşık işlem eksilik gösteriyorsa i'nin değeri genellekikle >(büyüklük) durumuyla degerlendirili.
            // for (int i = 10; i > 0; i--)
            // {
            //     System.Console.WriteLine(i + ".Hilmi");
            // }
            
            #endregion
            #endregion
            
            #region Ornekler
            #region Ornek 1
            // 1'den 10'a kadar olan sayıları alt alta ekrana yazdıralım
            // for(int i = 1; i<=10; i++)
            // {
            //     System.Console.WriteLine(i + ".sayi");
            // }

            #endregion
            #region Ornek 2
            // 1 ile 40(dahil) arasındaki çift sayıları toplayarak sonucu ekranda gösterelim

            // int ciftToplam = 0;
            // for (int i = 1; i <= 40 ; i++) 
            // {
            //     if (i % 2 == 0)
            //         ciftToplam += i;
            // }
            // Console.WriteLine("Çift Toplam : " + ciftToplam);
            
            #endregion
            #region Ornek 3
            
            // Klavyeden girilen sayının faktöriyelini bulan programı yapalım.

            // Console.Write("Faktröiyelini bulmak istediğiniz sayiyi giriniz : ");
            // int sayi = int.Parse(Console.ReadLine());
            #region 1.Çözüm
            // int faktoriyelDeger = 1;
            // for (int i = sayi; i > 0; i--)
            // {
            //     faktoriyelDeger *= i;
            // }
            // Console.WriteLine(faktoriyelDeger);
            
            #endregion
            #region 2.Çözüm
            // int faktöriyel = 1;
            // for (int i = 1; i <= sayi; i++)
            // {
            //     faktöriyel *=i;
            // }
            // System.Console.WriteLine(faktöriyel);
            #endregion
            #region 3.Çözüm
            // int faktoriyel = 1;
            // string sonuc = "";
            // for (int i = sayi; i> 0; i--)
            // {
            //     faktoriyel *= i;
            //     sonuc += i + (i == 1 ? " = " : " x ");
            // }
            // System.Console.WriteLine("Faktöriyel : " + sonuc + faktoriyel);
            
            #endregion


            #endregion
            #endregion
            
            #region Varyasyonlar
            
            #region Varyasyon 1
            // for (int i = 0; i < 10; i++)
            // {
                
            // }
            #endregion
            #region Varyasyon 2
            // int i = 0;
            // for (; i < 10; i++)
            // {
                
            // }
            #endregion
            #region Varyasyon 3
            // int i = 0;
            // for (i=0; i < 10; i++) // bu varyasyonda dışarıda tanımlanan i değişkeninin for dongusunde baslangıc degeri olarak göstermek istiyorsak eger yine bir baslangıc degeri zorunlu kılmaktadir. Yani içeride bu başlangıc degerini vermemiz gerekmektedir.
            // {
                
            // }
            #endregion
            #region Varyasyon 4
            // int i = 0;
            // for(; i < 10;)
            // {
            //     i++;
            // }
            
            #endregion
            #region Varyasyon 5
            // int a = 10;
            // for (int i = 0; a != i*2; i++)
            // {
            //     System.Console.WriteLine("Mustafa");
            // }
            #endregion
            #region Varyasyon 6
            //sonsuz döngü
            // for (;;)
            // {
            //     Console.WriteLine("Mustafa");;
            // }
            
            #endregion
            #region Varyasyon 7
            //sonsuz döngü
            // for (int i = 0; ; i++)
            // {
            //     System.Console.WriteLine("asd");
            // }
            #endregion
            #region Varyasyon 8
            //birden fazla değişken tanımlayıp döngüyü ona göre dizayn edebilirizz
            // for (int i = 0, i2= 0; i < 10 && i2 < 5 ; i++, i2++)
            // {
            //     System.Console.WriteLine(i);
            //     System.Console.WriteLine(i2);
            // }
            #endregion
            
            #endregion
            #endregion

            #region while Döngüsü
            
            #region Teorik Anlatim
            // while döngüsü sadece şarta balı bir döngüdür.
            // Şart dogrulandıkça tetiklenecektir.
            // for'a nazaran daha ilkel ve sade bir döngüdür.
            // while dongusu programlamanin ilk tasarlanmış döngüdür.
            // Genellikle sonsuz döngülerde yahut süreci bilinmeyen durumlarda kullanılan bir döngüdür.
            // Amma velakin istediğimiz yerde kullanabiliriz.



            #endregion
            
            #region while - for Kiyaslama

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine("Mustafa");
            // }

            // while döngüsünde for gibi çalışabılmek için kombinasyonu kendimiz oluşturmalıyız.
            // int _i = 0;
            // while (_i < 10) // şart true oldugu sürece çalışır.
            // {
            //     Console.WriteLine("Mustafa");
            //     _i++;
            // }
            #endregion
            
            #region İncelemeler
            
            #region İnceleme 1
            
            // Ekrana 10 kere 'Merhaba Dünya' yazdıran bir program yazalım.
            // int i = 0;
            // while(i < 10)
            // {
            //     Console.WriteLine("Merhaba Dünya");
            //     i++;
            // }
            #endregion
            #region İnceleme 2
            
            //Klavyeden girilen sayıdan geriye doğru 0'a kadar sayan bir sayaç hazırlayalım.
            // int sayi = int.Parse(Console.ReadLine());
            // while(sayi >= 0)
            // {
            //     Console.WriteLine(sayi);
            //     sayi--;
            // }
            #endregion 
            #region İnceleme 3
            // 0 ile 100 arasındaki tek sayılari toplayarak sonucu ekranda gösteren programı yapalım
            // int i = 0, toplam=0;
            // while (i<=100)
            // {
            //     if (i % 2 == 1)
            //         toplam += i;
            //     i++;
            // }
            // Console.WriteLine("toplam : " + toplam);

            #endregion
            #region İnceleme 4
            //Klavyeden girilen sayının faktöriyelini hesaplayalım
            // Console.Write("Faktoriyel degerini hesaplama istediiginz sayiyi giriniiz : ");
            // int sayi = int.Parse(Console.ReadLine());
            // int faktoriyelDeger = 1;
            // while (sayi > 0)
            // {
            //     faktoriyelDeger *= sayi--;
            // }
            // System.Console.WriteLine("Faktoriyel deger : " + faktoriyelDeger);
            
            #endregion
            #region İnceleme 5
            // o anki tarihin saniye degeri 5'in katıysa eger tarihi ekranda gösteren uygulamayı yazalım.
            
            // while (true)
            // {
            //     if (DateTime.Now.Second % 5 == 0)
            //         System.Console.WriteLine(DateTime.Now);
            // }
            
            #endregion
            
            #endregion
            
            #endregion

            #region do while Döngüsü
            
            #region Teorik Anlatim
            
            //do while dögüsü önce kodu çalıştırır sonra şarta bakar.
            // while ise önce şarata bakar sonra kodu çalışıtır

            //while ile yapılan kontrolde sart true olursa dongu tetiklenecek, false olursa hicbir zaman tetiklenmeyecektir.
            //do while dongusu sart trueda olsa false'de olsa enn az bir kere tetiklenecektir.

            #endregion

            #region while vs doWhile Döngüsü
            // while (false)
            // {
            //     System.Console.WriteLine("while");
            // }
            // do
            // {
            //     System.Console.WriteLine("do while");
            // } while (false);
            #endregion



            #endregion
        
            #region Scopesuz Döngüler

            // for (int i = 0; i < 10; i++)
            //     System.Console.WriteLine("Mustafa Ünal");;

            // while(true)
            //     System.Console.WriteLine("");

            // do
            //     System.Console.WriteLine("asdsdf");
            // while (true);
            #endregion
        
            #region Sonsuz Döngü

            #region for
            // bool dongu = true;
            // for (;dongu;)
            // {
            //     if(true)
            //     {
            //         dongu = !dongu;
            //     }

            // }
                
            #endregion
            #region while

            // bool durum = false;
            // while (!durum)
            // {
            //     if (true)
            //     {
            //         durum = !durum;   
            //     }
            // }

            #endregion
            #region do while
            // bool durum = true;
            // do
            // {
            //     if (true)
            //     {
            //         durum = !durum; 
            //     }
            // } while (durum);

            #endregion

           
            #endregion

            #region İç İçe Döngüler
            
            // for (int i = 0; i < 10; i++)
            // {
            //     for (int j = 0; j < 5; j++)
            //     {
            //         while (true)
            //         {
                        
            //         }
            //     }
            // }
            #region for
            // iç içe for döngülerinde değiken ismi farklı olmalıdır.
            // İç içe döngülerde maaliyet tüm döngülerin maliyetibi/tur sayısını/periyodık çalışmasının çarpımına eşittir.
            
            // for (int i = 0; i < 10; i++)
            // {
            //     for (int j = 0; j < 5; j++)
            //     {
            //         for (int k = 0; k < 3; k++)
            //         {
            //             int p = 0;
            //             while (p<4)
            //             {
            //                 p++;
            //             }
            //         }
            //     }
            // }

            #endregion

            #endregion

            #region Foreach Bir Döngü mü?
            
            //foreach bir döngü değil iterasyondur.

            // Dongu: belirli bir kombinasyon esliginde calisan ve belirli bir sarta bagli olan periyodik islemler gercekleştiren yapilanmalardir.
            //
            // Iterasyon: Iterasyon mantığında ne kombinasyon ne de sart vardir. Iterasyonda; sonraki veri, oteki veri anlamina gelen itere etme fiili vardır. Bir veri kümesi üzerinde işlem yapmamizi/verileri elde etmemizi sağlayan yapılanmadır.

            #endregion

            #region Döngülerde Boş Scope Kullanmak İstemediğimz Durumlarda ;(Noktali Virgül) Operatörü ile Temiz Kod Yazimi

            // Bazen(ki ileride asenkron programlamada) için boş sonsuz döngülere ihtiyacımız olabilir.
            // Bu durumlarda normal döngü gövdelerini kullanabileceğimiz gibi scopesuz bu şekilde de kullanabilmekteyiz.

            // while(true)
            // {

            // }
            
            // while(true);

            // for (;;)
            // {
                
            // }

            // for(;;);
            
            #endregion

        #endregion
    }
}