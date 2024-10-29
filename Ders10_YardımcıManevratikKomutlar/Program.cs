internal class Program
{
    private static void Main(string[] args)
    {
        #region Yardimci Manevratik Komutlar

            #region Giris
            
            //Kodu durdurmak, devamini okumamak, var olan bir döngüden çıkıs yapmak yahut komple methodu sonlandirmak yani kodun yönlendirmek icin kullanılan komutlardır.

            // Manevratik komutlar yapamayacağımız şeyleri yapmamızı sağlayan komutlar değildir.
            // Yapabileceğimiz manevraları/kodun yönlendirmelerini daha efektif yapmamızı sağlamaktadır.

            // for (int i = 0; i < 100; i++)
            // {
            //     if (i == 22)
            //     {
            //         i = 100;
            //     }    
            // }

            #endregion

            #region break
                
            #region Giris
                
            // kullanıldığı yapıdan çıkış yapılmasını/kullanıldığı yapıyı sonlandırmaya yarayan bir keyworddur.
            // switch-case ve dongülerde kullanılr.

            // switch (10)
            // {
            //     case 5:
            //         Console.WriteLine("asd");
            //         break;
            //     case 10:
            //         Console.WriteLine("askmd");
            //         break;
            // }

            // while (true)
            // {   
            //     break;
            // }
            // for (int i = 0; i < 10; i++)
            // {
            //     break;
            // }
            // foreach (var item in new[] { "" })
            // {
            //     break;
            // }

            // for (int i = 0; i < 10; i++)
            // {
            //     while (true)
            //     {
            //         break;
            //     }
            // }
            
            // eğerki dönügünnü scope'u içindeysek istediğimiz şekilde kullanırız

            // do
            // {
            //     if (true)
            //     {
            //         break;
            //     }
            // } while (true);

            // while (true)
            // {
            //     try
            //     {
            //         break;   
            //     }
            //     catch 
            //     {
                    
            //     }
            // }

            #region Ornek
            // while (true)
            // {
            //     if (DateTime.Now.Second == 35)
            //         break;
            //     System.Console.WriteLine(DateTime.Now);
                
            // }
            #endregion
            #region Ornek
            // for (int i = 0; i < 5; i++)
            // {
            //     for (int j = 0; j < 3; j++)
            //     {
            //         if (j == 1)
            //             break;           
            //         System.Console.WriteLine("i : " + i + " j :" + j);
            //     }
            // }
            #endregion

            #endregion
            #region Ornek 1
            //Kullanıcıdan 't' harfi gelene kadar alınan sınırsız sayıda sayıyı toplayan ve sonucu ekrana yazdıran uygulamayı yazalım
            // int toplam = 0;
            // while (true)
            // {
            //     Console.Write("Lütfen bir sayi giriniz (t girerseniz girdiginiz tüm sayilar toplanir) : ");
            //     string girilenDeger = Console.ReadLine();
            //     if (girilenDeger == "t")
            //     {
            //         Console.WriteLine("Toplam : " + toplam);
            //         break;
            //     }
            //     else
            //         toplam += int.Parse(girilenDeger);
            // }            
            #endregion
            #region Ornek 2
            //Kullanıcıdan alınan sonsuz adet sayı degerlerinden 37'nin katı girildiginde sonlanan uygulmayı yazalım
            // while (true)
            // {
            //     Console.Write("Lütfen bir sayi giriniz : ");
            //     int sayi = int.Parse(Console.ReadLine());
            //     if (sayi % 37 == 0)
            //     {
            //         Console.WriteLine("Uygulama sonlanmıştır");
            //         break;
            //     }   
            // }
            #endregion
            
            #endregion

            #region continue
            
            #region Giris
            
            //sade ve sadece döngülerden erişilebilen ve dongulerde kullanılabilen bir keyworddur.
            // Amaç => Dongude bir sonraki tura gecilmesini saglar. Yani bir sonraki periyoda direkt gecis yaptırır.
            
            #region Ornek
            // for (int i = 0; i < 10; i++)
            // {
            //     if (i % 2 != 0)
            //         continue;
            //     Console.WriteLine(i);
                
            // }
            #endregion
            #endregion
            #region Ornek
            // Kullanıcının girdihi sonsuz adet sayıdan pozitif olanlarını çarpan ve 't'(enter) yapıldığında sonucu ekrana yazdıran kdou yazalım
            // int carpim = 1;
            // while (true)
            // {
            //     Console.Write("Lütfen bir sayi giriniz (t ye basarsaniz girdiginiz sayilar carpilir) : ");
            //     string girilenDeger = Console.ReadLine();
            //     if (girilenDeger == "t")
            //     {
            //         Console.WriteLine("Carpim Deger : " + carpim);
            //         break;
            //     }
            //     else
            //     {
            //         int sayisalDeger = int.Parse(girilenDeger);
            //         #region 1.İhtimal
            //         // if (sayisalDeger > 0)
            //         //     carpim *= sayisalDeger;
            //         #endregion
            //         #region 2.İhtimal
            //         if (sayisalDeger < 0)
            //             continue;
            //         carpim *= sayisalDeger;
            //         #endregion
            //     }
            // }
            #endregion
            #region Ornek
            // 1 ile 10000 arasında 7'nin katı olmayan sayıları ekrana yazdıralım
            // for (int i = 1; i < 1000; i++)
            // {
            //     if(i % 7 != 0)
            //         continue;
            //     Console.WriteLine(i);
            // }
            #endregion
            
            #endregion
            
            #region return
            
            #region Giris
            
            // Her yerde(metot içerisinde) kullanılabilir, erişilebilir bir keyworddür.
            // İki işlevi görmektedir.
            //1.Nerede çağrılıyorsa çağrılsın bulundugu metottan cıkıs yapar. Yani metotu sonlandırır.
            //2.İleride görecceğimiz metotlar konusunda geriye deger dondurme sorumlulugunuda ustlenen bir keyworddür

            //returnden sonra hangi komut geliyorsa gelsin metot sonlanacağı için işlenmeyecektir.

            #endregion
            #region Ornek
            
            //kullanıcı 'c' tusuna basana kadar sonsuz döngüde donen uygulamayı yazınız
            // while (true)
            // {
            //     if (Console.ReadKey().KeyChar == 'c')
            //     {
            //         Console.WriteLine("Uygulama sona ermiştir..");
            //         return;
            //     }
            //     Console.WriteLine("");
            //     Console.WriteLine("Uygulama çalisiyor.");
            // }

            #endregion

            #endregion

            #region goto
            
            #region Giris
                
            // Kodun senkranizasyonun bozup, akisi ters istikamette almamizi saglayan bir manevratik komuttur.
            // Davranışsal olarak dongulere benzer.
            // switch-case yapılanmasında dahili olarak kullanılan bu komut, metot içerisinde heryerde kullanılabilir.

            #region Dedikodular
                
            // Geleneksel coderlar tarafından pek sevilmeyen goto keywordu tavsiye edilmemektedir.
            // Teknik olarak programı yavaşlattığı söylenmektedir. Hatta yapılmış olan performans testlerini incelediğimizde bir nebze kayıp ve yavaşlık söz konusudur. Yani maaliyeti diger durumlara nazaran oldukca fazladir.
            // goto keywordu ile senkronizasyonu bozup başa dönme durumu bir döngüyle aynı işlemi yapmaya nazaran daha maaliyetli olacaktir.
            // İyi bir c# programcısı gerekmedigi sürece kesinlikli goto anahtar sözcüğünü kullanmamalidir. => Sefer Algan
            
            // Diller gelistikce ve yüksek seviyede oldukca bu komutun kalkmasi dogal bir süreçtir.

            #endregion

            // switch (10)
            // {
            //     case 5:
            //         System.Console.WriteLine("asds");
            //         break;
            //     case 10:
            //         goto case 5;
            //     case 15:

            //         break;
            // }

            // böyle bir duruma nazaran önerilen dongu kullanmaktir. Amma velakin cok zaruriyse goto keywordu kullanilabilir.
            // a:
            // System.Console.WriteLine("Merhaba");
            // System.Console.WriteLine("Dünya");
            // goto a;
            #endregion

            #region Ornek
            // 1 den 100 e kadar sayalım
            // int i = 1;
            // x:
            // System.Console.WriteLine(i++);
            // if (i <= 100)
            //     goto x;
            
            #region for
            // for (int j = 0; j <= 100; j++)
            //     System.Console.WriteLine(i);
            #endregion
            
            #endregion

            #region Kritik
            // 0 yazar sonsuz döngüye sebep olur. Scope dışından açğrıldığından dolayı.
            // a:
            // for (int i = 0; i < 190; i++)
            // {
            //     System.Console.WriteLine(i);
            //     goto a;
            // }

            #endregion
           
            #endregion
        
        #endregion
    }
}