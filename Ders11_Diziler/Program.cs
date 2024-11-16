using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Diziler - Array

        #region Giriş

        // Tek bir değişken altında birden fazla 'aynı türde' değeri tutmamızı sağlayan veri kümelerine dizi denmektedir.
        // Prosedürel programlamanın temel veri kümeleridir. Yani yazilimsal boyutta yazılım adina RAM'de birden fazla degeri tek bir degisken altında bir veri kümesi halinde tutabilirler.

        // Diziler, veri kümeleti oldukları için içlerindek birden fazla veri üzerinde kumesel işlemler yapmamızı sağlayabilirler.
        // Diziler, prosedurel prog. temel yapıları oldukları için daha gelişmiş yapılar olan kolektsiynlarında temelini teskil etmektedirler ve gelişmelerine katkıda bulunmaktadirlar.

        // Diziler referans türlü değişkenlerdir. Yani nesnel yapılardır. Ozzlerinde classtirlar.
        // Yapısal olarak RAM'de Heap'te tutulurlar..

        // Dizi içerisine her türlü değer koyulabilir.(Deger türlüde olur Referans türlüde)
        // Bir dizi sade ve sadece tek bir türde deger alabilir.
        // Dizi içerisine koyulan degerler işlevsel olarak aynı mahiyette olmalıdır(Oğrenci yaşı ile Müdürn maaşı gibi farklı bir şekilde yapısal olarak farklı türde olmamalı mantıksal oalrak aynı yapıda değerler olmalı)

        // Diziler içerisine eleman/deger eklendikçe bunları serseri bir şekilde depolamaz. Düzenli bir şekilde sıralı depolayacaktir.
        // Dizilerde eklenen elemanlar 'index' ismini verdiğimiz numaralarla ardaşık bir şekilde numaralandırılırlar.
        // indexler 0 dan başlar n-1'e kadar gider.

        // type[] a ---> dizi tanımı
        // [] => bir değişken tanımlanırken turunun yanına bu operatoru koyarsak o değişken o türde bir dizi değişkeni olacaktir. Bu operatöre Indexer ismi verilmektedir.

        // type[] name = new type[...] => eleman sayısını gireriz.
            
        #endregion

        #region Sinirliliklar
        
        // Dizilerde tanımlama aparken eleman sayısının bildirilmesi zorunluluğu bir sınırlılıktır.
        // Diziler tanımlandığında kullansakta kullanmasakta bellekte belirtilen eleman sayısı kadar alan tahsisinde bulunurlar. Bu durumda bellek boyunda ekstradan maliyete sebep olacağı için bir sınırlılıktır.
        // Dizilerde eleman sayısının başta belirlenmesi durumunda, ihtiyaca binayen daha fazla deger atamak istedigimizde bu degerleri atayacağımızdan ve dizinin aralığını genişletemeyeceğimizden dolayı bu durum bir sınırlıkık olarak akrşımıza çıkmaktadır.
        // Dizilerde elemanlara değer atarken indexer operatörüyle çok haşır neşir olunmaktadır. Bu da bir sınırlılıktır.
        
        // int[] yaslar = new int[5]; 
        // string[] asd = new string[99999];
        // Bir dizi tanımlaması yapıldığı an bellekte o diziyi kullansakta kullanmasakta verilen eleman sayisi kadar alan tahsisinde bulunur.
        // Dizilerde tanimlama yapıldığı an alan tahsisinde bulunulması bizim için pekte dogru bir durum degildir.
        // Diziler alan tahsisi yapıldığında ilgili alanlara turune uygun default degerleri atarlar.

        // Index numarası dizilere sistem tarafindan otomatik verilen ve kimlik mahiyetinde kullanabileceğimiz bir numaradır.
        // Her bir elemana karşılık gelen unique degerlerdir. Haliyle boyle olması demek her bir elemana istedigimiz zaman erisip, deger atama yapabilmemizi yahut var olan degeri okuyabilmemizi sağlamaktadır.

        // Dolayisiyla dizilerde tanımlanmış alanlara^/elemanlara deger atama yahut deger okuma operasyonları index numaraları esliginde gerceklestirmekteyiz.

        // int[] yaslar = new int[7];
        // yaslar[3] = 10;
        // yaslar[2] = 5;
        // yaslar[0] = 5;
        // yaslar[5] = 123;

        // System.Console.WriteLine(yaslar[3]);
        // System.Console.WriteLine(yaslar[7]); // dizilerde deger okurken deger aralıgının aşmamak gerekmektedir.

        // dizinin icerisinde elemanlara deger atarken degisken davranısı gösterir. Dolayisiyla herhangi bir elemana atanan enn sonuncu deger gecerlidir
        // dizilerde deger atama ve hatta deger okuma islemlerinde eger ki dizinini sinirini aşarsak  hata verecektiir
        // dizilerde atama yaparken siralamyı göz önünde tutmak zorunda değiliz.
        // diziye deger koyarken hangi index'e karsılık deger koyacaksak yine indexer operatoruyle bunu bildirmeli ve ilgili degeri atamalıyız.


        #endregion

        #region Tanimlanmiş Dizi İçerisinde Döngüyle Dönme
        
        // Döngülerde genellikle dizilerle ya da ileride göreceğimiz koleksiyonlarla birlikte de kullanılmaktadırlar.

        // string[] personeller = new string[10];
        // personeller[0] = "Hilmi";
        // personeller[1] = "Ahmet";
        // personeller[2] = "Hüseyin";
        // personeller[3] = "Rifki";
        // personeller[4] = "Şuayip";
        // personeller[5] = "Muiddin";
        // personeller[6] = "Kerem";
        // personeller[7] = "Veli";
        // personeller[8] = "Ali";
        // personeller[9] = "Mustafa";

        // for (int i = 0; i < 10; i++)
        // {
        //     System.Console.WriteLine(personeller[i]);
        // }
        // foreach (var personel in personeller)
        // {
        //     System.Console.WriteLine(personel);
        // }
        // int k = 0;
        // do
        // {
        //     System.Console.WriteLine(personeller[k++]);
        // } while (k < 10);

        #region Kritik-1
            
        //Dizi içerisinde dönecek olan dongu kombinasyonda dizinin eleman sayısını manuel bir şekilde kullanmamalı bu sayisal değerin dizinin kendisinden almalıyız
        // for (int i = 0; i < personeller.Length; i++)
        // {
        //     System.Console.WriteLine(personeller[i]);
        // }

        #endregion

        #endregion

        #region Dizi Tanimlama Varyasyonlari

        #region 1. Varyasyon

        // int[] yaslar = new int[3];
        // yaslar[0] = 123;
        // Console.WriteLine(yaslar[0]);

        #endregion

        #region 2. Varyasyon

        // int[] yaslar2 = {30,25,41,52};
        // string[] isimler2 = {"Ahmet","Mustafa"};

        #endregion

        #region 3. Varyasyon
        //2. le aynı aslında
        // string[] isimler3 = new string[] {"Ahmet","Mustafa"};

        #endregion

        #region 4. Varyasyon

        // string[] isimler4 = new string[3] {"","",""}; // kaç eleman olacaksa o kadarı bu şekilde tam vermelisin

        #endregion
        
        #region 5. Varyasyon

        // int[] sayilar5 = new[] {3,4,5};
        // var sayilar6 = new[] {3,4,5,6,7};
        // var sayilar7 = new[] {"3","4","5","6","7"};

        #endregion
        
        #endregion

        #region Array Sinifi

        // Dizi olarak tanımlanan değişkenler Array sınıfından türetilmektedirler.
        // Dolayısıyla dizilerde Array sınıfından gelen belirli metotlar ve özellikler mevcuttur.

        #region Bir Dizinin Kendi Türünde Tanimlanmasiyle Array Türünde Tanimlaasi Arasindaki Fark Nedir?
        
        // Dizi eğer kendi türüne referans ediliyorsa indexer operatoru kullanılabilir
        // Bu şekilde çalışıldığında ilgili diziye verisel mudahaleler operatif gerçekleştirilirken
        // Genellikle bu format algoritmalarda tercih edilir.
        // int[] yaslar = new int[3];

        // Yok eğer array türünde referans ediliyorsa indexer op. kullanılamaz.
        // Bu şekilde ise fonksoyinel çözümler getirilmektedir.
        // Genellikle eleimzdeki dizinin üzerinde işlem yaparken tercih edilen formattir. Dizi hakkında bilgi edinirken vs. kullanilir.
        // Array yaslarr = new int[3];

        #endregion

        #region Array Türünden Dizilere Değer Atama/Okuma

        #region 1.Yöntem

        // int[] dizi = new int[3];
        // dizi[0] = 30;
        // dizi[1] = 31;
        // dizi[2] = 32;
        // Array dizi2 = dizi;
        
        #endregion
        #region 2.Yöntem
        
        // Array dizi = new int[] { 3,5,7,9 };
        // Array dizi = new int[4] { 3,5,7,9 };
        // Array dizi = new[] { 3,5,7,9 };
        // Array dizi =  { 3,5,7,9 }; // bu kullanılamaz
        
        #endregion
        #region 3.Yöntem
        // Array dizi = new int[3];
        // dizi.SetValue(30,0);
        // dizi.SetValue(31,1);
        // dizi.SetValue(32,2);

        // object value = dizi.GetValue(1); 
        // System.Console.WriteLine(value);
        #endregion

        #endregion

        // Array isimler = new[] {"Hilmi","Hüseyin","Şuayip","Rifki","Hamdullah"};
        #region Metotlar
        
        #region Clear
        
        // Dizi içerisindeki tüm elemanları siliyor diye bilinir. Halbuki bu yanlıştır. Dizi içerisindeki tüm elemanlara, dizinin türüne uygun default değerleri atayan bir fonksiyondur.
        // for (int i = 0; i < isimler.Length; i++)
        // {
        //     System.Console.WriteLine(isimler.GetValue(i));
        // }
        // Array.Clear(isimler, 0, isimler.Length);
        // System.Console.WriteLine("---");
        // for (int i = 0; i < isimler.Length; i++)
        // {
        //     System.Console.WriteLine(isimler.GetValue(i));
        // }



        #endregion
        #region Copy
            
        // Elimizdeki bir dizinin verilerini bir başka diziye kopyalamamızı sağlayan bir fonksiyondur.
        // string[] isimler2 = new string[isimler.Length];
        // Array.Copy(isimler,isimler2,isimler.Length);
        // for (int i = 0; i < isimler.Length; i++)
        //     System.Console.WriteLine(isimler2[i]);
        
        // Array.Copy(isimler,2,isimler2,0,2);
        // for (int i = 0; i < isimler.Length; i++)
        //     System.Console.WriteLine(isimler2[i]);
        #endregion        
        #region IndexOf
        // Dizi içerisinde bir elemanın var olup olmadığını sorgulayabildiğimiz fonksiyondur.
        // Arama neticesinde ilgili değer varsa int olarak o değerin index numarasını döndürür
        // yok ise -1 değerini döndürür.
        // int index = Array.IndexOf(isimler,"Rifki");
        // if (index != -1)
        // {
        //     System.Console.WriteLine("Var");
        // }

        // int indexx = Array.IndexOf(isimler,"Rifki",1,3); 
            
        #endregion        
        #region Reverse
        
        // Elimizdeki dizinin elemanların tersine sıralayan bir fonksiyondur.
        // for (int i = 0; i < isimler.Length; i++)
        //     Console.WriteLine(isimler.GetValue(i));
        // Array.Reverse(isimler);
        // System.Console.WriteLine("----");
        // for (int i = 0; i < isimler.Length; i++)
        //     Console.WriteLine(isimler.GetValue(i));

        // for (int i = 0; i < isimler.Length; i++)
        //     Console.WriteLine(isimler.GetValue(i));
        // System.Console.WriteLine("--");
        // Array.Reverse(isimler,0,3);
        // for (int i = 0; i < isimler.Length; i++)
        //     Console.WriteLine(isimler.GetValue(i));
        #endregion        
        #region Sort
            
        // for (int i = 0; i < isimler.Length; i++)
        // {
        //     System.Console.WriteLine(isimler.GetValue(i));
        // }
        // Array.Sort(isimler);
        // System.Console.WriteLine("---");
        // for (int i = 0; i < isimler.Length; i++)
        // {
        //     System.Console.WriteLine(isimler.GetValue(i));
        // }

            
        #endregion
        #region CreatInstance

        // int[] yaslar = new int[3];
        // //Normalde yukarıdaki gibi yapılan dizi tanımlaması esasında arkaplanda Array sınıfıfın CreateInstance methodunu kullanmkatadır.
        // //Bizlerde bu methodu kullnarak fonksiyonel diziler oluşturabilmekteyiz.
        // Array yaslar2 = Array.CreateInstance(typeof(int),3);

        #region Çok Boyutlu Kullanimi

        // Array dizi =  Array.CreateInstance(typeof(int),5,3,5,6);
        // System.Console.WriteLine(dizi.Rank);    
        #endregion

        #endregion
        #endregion

        #region Özellikler
        
        #region IsReadOnly
        
        // Bir dizinin sadece okunabilir olup olmadığını bool türde bildiren bir özelliktir
        // System.Console.WriteLine(isimler.IsReadOnly);
            
        #endregion
        #region IsFixedSize
            
        // Bir veri kümesinin eleman sayısının sabit olup olmama durumunu IsFixedSize ile öğrenebiliriz.
        // System.Console.WriteLine(isimler.IsFixedSize);
        // tüm dizilerde eleman sayısı sabit olduğu için sürekli true dönecektir
        // Orneğin ArrayList koleksiyonunda false dönecektir.
            
        #endregion
        #region Length
        
        //Bir dizinin elaman sayısını verir
        // System.Console.WriteLine(isimler.Length);

            
        #endregion       
        #region Rank
            
        // Bir dizinin derecesini verir.
        // System.Console.WriteLine(isimler.Rank);

        // int[,,] x = new int[3,4,5];
        // System.Console.WriteLine(x.Rank);
            
        #endregion
        
        #endregion

        #region Ranges and Indices
        
        #region System.Index

        // Dizi ve koleksiyon yapılarındaki index kavramını tip olarak belirlenmiş halidir.
        // Temelde index değerini bir tür ile tutmakla beraber ^ operatörüyle birlikte daha fazla anlam ifade etmekte ve diziin index değerlrini tersine ifade edecek şekilde bir sorumluluk yüklenmketedir.

        // int[] sayilar = {3,5,7,9,1,2,31,321,534,5643,457,56,78};
        // Index index = 5; //--> soldan 0 - (n-1)
        // Index index = ^8; //--> sağdan n - 1
        // System.Console.WriteLine(sayilar[index]);

            
        #endregion
        #region System.Range
        
        // Veri kümelerinde hangi değerler ile çalışacağımızı belirleyebilmek için index üzerinden aralık vermemizi ve bunu .. operatörü ile gerçekleştirmemizi sağlayan yapılanmadır.

        // Range range = a..b;
        //a -> IndexNo
        //b -> SiraNo

        // int[] sayilar = {3,5,7,9,1,2,31,321,534,5643,457,56,78};
        
        // Range range = 5..10; // 
        // var sayilar2 = sayilar[range]; // bize ilgili alanı bir dizi olarak geri döner {2,31,321,534,5643}
        // sayilar2[0] = 100;

        // Range range = ..; //=> tüm diziye karşılık gelir.
        // var sayilar2 = sayilar[range];
        // sayilar2[0] = 100;
        // .. operatörünü sayısal değerler olmadan kullanırsınız ilgili diziyi topyekün kopyalar ve geriye döndürürsünüz.

        // Range range = 5..^3;
        // var sayilar2 = sayilar[range];

        // Range range = ^8..^3;
        // var sayilar2 = sayilar[range];

        //.. Operatörü
        //Veri kümelerinde belirli bir aralığı temsil eden opretördür
        //Aralık operatörü diyede isimlendirilebilir.
        //Sağına ve solunda Index türündende değerler alabiliyiro
        //Geriye System.Range türünde döner.

        // Index i1 = 5, i2 = 10;
        // Range range = i1..i2;
        // var sayilar2 = sayilar[range];

        //^ Operatörü
        //Veri kümelerinde index değerinin tersini ifade eder.
        //Normal index yapılanmasına nazaran ters index durumu 0'dan değil 1'den başlamaktadır.
        // Bu operatörü kullanabilmek için index türünde çalışılması gerekmektedir. cunu bu operatör geriye index döndürür.

        // Index i = ^3;
        // System.Console.WriteLine(sayilar[i]);

        // Range range = ^7..^3; 
        // var sayilar2 = sayilar[range]; // 31,32,534,5643



        #endregion


        #endregion

        

        #endregion
        
        #region Çok Boyutlu/Biçimli/Dereceli Diziler
        
        // Çok boyutlu diziler oyun programlamada yahut yüksek istatiksel çalışmalarda kullanılan bir yapıdır.

        #region Çok Boyutlu Dizi Tanimlama
        // Çok boyutlu dizilerde indexer içerisinde virgül(,) ile tanımlama yapilmaktadir.
        //[] parantez içindeki her virgül sayısı dizi dereceisini arttırır.
        //type[] -> tek boyutlu dizi tanimlamasi
        //typr[,] -> iki boyutlu dizi tanimalasit(çift)
        //type[,,,] -> 4 boyutlu dizi tanimlamasi 
        
        #region Çift/2 Boyutlu Dizi Tanimlamasi
        // İki boyutlu diziler x ve y kordinatlariyla taahul edebileceğimiz dizlierdir
        // int[,] sayilar = new int[3,5];
            
        #endregion
        #region 2 Boyutludan Fazla Dizi Tanimlamasi
        // İki dereceliden fazla olan dizileri gunlük hayatta tahayyul etmek pek mümkün olmasada programatik olarak inşa edebilmekteyiz.
        // int[,,,] sayilar = new int[3,4,5,6];
            
        #endregion

        #endregion

        #region Tanimlanmiş Çok Boyutlu Diziye Değer Atama

        #region İki Boyutlu Dizi Örneklendirme
        // int[,] sayilar = new int[3,4];
        // sayilar[1,2] = 5;
        // sayilar[2,0] = 15;
            
            
        #endregion
        #region Çok Boyutlu Dizi Örneklendirme
        #region Ornek 1
        // int[,,,] sayilar = new int[2,3,4,5];
        // sayilar[0,0,0,0] = 15;
        // sayilar[0,0,0,1] = 16;
        // sayilar[0,0,0,2] = 17;
        // sayilar[0,0,0,3] = 18;
        // sayilar[0,0,0,4] = 19;
        // sayilar[1,0,0,0] = 19;    
        // #endregion
        #endregion
        #region Ornek 2
        // int[,,] sayilar = new int[2,3,4];
        // sayilar[0,0,1] = 15;
        #endregion
        
        #endregion

        #endregion

        #region Varyasyonla Değer Atama

        // int[,] sayilar = {
        //     {3,5,7},
        //     {5,6,7},
        //     {7,8,9},
        //     {9,11,13},
        // };
        // int[,,,] sayilar2 ={
        //     {
        //         {
        //             {0,1,2}
        //         }
        //     },
        //     {
        //         {
        //             {10,21,32}
        //         }
        //     },
        //     {
        //         {
        //             {40,51,62}
        //         }
        //     },
        // };
            
        #endregion

        #region Tanimlanmiş Çok Boyutlu Diziden Değer Okuma
        
        // int[,] sayilar = new int[4,3];
        // sayilar[0,0] = 3;
        // sayilar[0,1] = 5;
        // sayilar[0,2] = 7;
        // sayilar[1,0] = 5;
        // sayilar[1,1] = 6;
        // sayilar[1,2] = 7;
        // sayilar[3,2] = 67;

        // System.Console.WriteLine(sayilar[3,2]);
        // System.Console.WriteLine(sayilar[0,0]);
        // System.Console.WriteLine(sayilar.Rank);

        #endregion
        
        #region Eleman Sayisinin Hesaplanmasi

        // int[,,] sayilar = new int[2,2,4];
        // sayilar[0,0,0] = 1;
        // sayilar[0,0,1] = 2;
        // sayilar[0,0,2] = 3;
        // sayilar[0,0,3] = 4;
        // sayilar[1,1,0] = 13;
        // sayilar[1,1,1] = 14;
        // sayilar[1,1,2] = 15;
        // sayilar[1,1,3] = 16;
        // sayilar[0,1,0] = 5;
        // sayilar[0,1,1] = 6;
        // sayilar[0,1,2] = 7;
        // sayilar[0,1,3] = 8;
        // sayilar[1,0,0] = 9;
        // sayilar[1,0,1] = 10;
        // sayilar[1,0,2] = 11;
        // sayilar[1,0,3] = 12;

        // System.Console.WriteLine(sayilar.Length); // 2*2*4 = 16 -> ilgili dizinin totaldeki eleman sayisi
        // System.Console.WriteLine(sayilar.GetLength(0)); // 2
        // System.Console.WriteLine(sayilar.GetLength(1)); // 2
        // System.Console.WriteLine(sayilar.GetLength(2)); // 4

        // for (int i = 0; i < sayilar.GetLength(0); i++)
        // {
        //     for (int j = 0; j < sayilar.GetLength(1); j++)
        //     {
        //         for (int k = 0; k < sayilar.GetLength(2); k++)
        //         {
        //             System.Console.WriteLine(sayilar[i,j,k] + "     ");
        //         }
        //         System.Console.WriteLine("");
        //     }
        // }
            
        #endregion

        #endregion
        
        #region Düzensiz Diziler

        // Düzensiz diziler; her bir elemanı kendi içerisinde farklı bir dizi barındıran dizilerdir.
        // Çok boyutlu dizilerden tek farkı, çok boyutlu dizilerin sütün sayılarıın sabit,halbuki düzensiz dizlerin ise sutun sayilarırın değişken olmasıdır.

        #region Düzensiz Dizi Tanimlama

        int[][] sayilar = new int[3][];
        sayilar[0] = new int[3] {3,5,7};
        sayilar[1] = new int[5] {3,5,7,523,01};
        sayilar[2] = new int[10] {3,5,7,234,234,23,4,234,234,123};

        // System.Console.WriteLine(sayilar[0][0]);
        // sayilar[0][0] = 13;
        // System.Console.WriteLine(sayilar[0][0]);

        #region Eleman Sayisini Öğrenme
        
        // System.Console.WriteLine(sayilar.Length);
        // düzensiz dizinini eleman sayısını getirir. Bu bize total eleman sayısını vermez. Çok boyutlu dizilerde olduğu gibi düzensiz diziler başlı başına farklı bir dizi yapısı değildir. Normal dizi yapılanmasıdır. Lakin içerisinde dizi barindiran bir dizidir. Haliyle eleman sayisini döndürür.
        //İçteki dizilerin eleman sayilarını tıtalde elde edebilmek için herbirini toplamamız gerekmektedir.

        // System.Console.WriteLine(sayilar[0].Length + sayilar[1].Length + sayilar[2].Length); 
        
        #endregion

        #region İç İçe Döngü Kullanimi
        // for (int i = 0; i < sayilar.Length; i++)
        // {
        //     for (int j = 0; j < sayilar[i].Length; j++)
        //     {
        //         System.Console.Write(sayilar[i][j] + "  -  ");
        //     }
        //     System.Console.WriteLine("");
        // }
            
        #endregion


        #endregion
            
        #endregion
        
        #endregion
    }
}