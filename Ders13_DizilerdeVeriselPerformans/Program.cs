using System.Text;
using Microsoft.Extensions.Primitives;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Dizilerde Verisel Performans
            
        #region Giriş

        // Bir referan tarafından işaretlenmiş herhangi bir diziyi düşünelim

        // int[] sayilar = { 10,20,30,40,50,60,70,80,90,100 };
        // int[] sayilar2 = sayilar[2..5]; // ilgili alan ayrı bir dizi olarak elde edilecek ve değerler RAM'de tekrardan tahsis edilecektir. Mükerre bir şekilde olacak yani

        // o zaman şöyle düşünebiliriz => Zaten var olan dizinin dışında neden başka dizi tanımlandı? Bu ekstradan maaliyet değil mi?
        // Cevapta => maaliyettir.

        // Esasında diziler üzerinde işlem yapmak oldukça maliyetli olabilmektedir.
        // Çünkü dizi üzerinde bir alanı temsil etmek, esasında o alandaki verileri yeni bir diziye kkoyarak tekrar etmek demektir.
        // Özellikle bu maaliyetli durumlar string değerler için fazlasıyla geçerlidir.
        // Çünkü string değerler için kullanılan string fonksiyonları arkaplanda sürekli yeni diziler oluşturmakta ve yüksek maaliyetli olmaktadırlari
        
        // Hatta string ifadeleri + operatörüyle birleştirmek bile sonuç olarak eldeki string değerleri arttıracağından dolayı muazzam bir bellek israfına yol açmakta ve maliyeti arttırmaktadır. Bundan dolayı stirng birleştirmeler + operatörüyle tavsiye edilmemektedir

        // İşte, diziler üzerinde yapılan çalışmalarda bu maaliyeti ortadan kaldırabilmek ve daha performanslı çalışabilmek için ArraySegment ve StringSegment türleri geliştirilmiştir.
        // Bu türler yapısal olarak dizi yahut string ifadelerdeki bir bölümü temsil etmemizi sağlayan ve bütünsel açıdan ilgili veri kümesini parça parça birden fazla referans eşliğinde yönetmemize imkan veren türlerdir
            
        #endregion

        int[] sayilar = { 10,20,30,40,50,60,70,80,90,100 };
        int[] sayilar2 = sayilar[2..5];

        #region ArraySegment Nedir ?
            
        // Bir dizinin bütününden ziyade belirli bir kısmına yahut parçasına ihtiyaç dahilinde ilgili diziyi kopyalamak yerine(ki görece oldukça maliyetli bir operasyondur) bağımsız bir referans ile erişmemizi ve böylece salt bir şekilde temsil etmemizi sağlayan bir yapıdır.

        #endregion
        #region ArraySegment İle Dizinin Belli Bir Alanini Referans Etmek
        
        // ArraySegment<int> segment1 = new ArraySegment<int>(sayilar); // sayilar dizisini tümüyle temsil eden bir referans oluşturduk.
        // ArraySegment<int> segment2 = new ArraySegment<int>(sayilar,2,5); // 2.indexten 5.adete kadar olan kısmı refere et.

        // segment1[0] *= 10;
        // segment2[0] *= 10;

        #endregion
        #region ArraySegment Slicing(Dilimleme)
        
        // Bir dizi üzerinde birden fazla parçada çalışacaksak eğer herbir parçayı ayrı bir ArraySegment olarak tanımlayabiliriz.
        // Bu tanımlamaların dışında diziyi tek bir arraysegment ile referans edip ilgili parçaları o segment üzerinden talep edebiliriz. Yani ilgili diziyi tek bir segment üzerinden daha rahat bir şekilde parçalayabiliriz. Bu durumda bize yazılımsal açıdan efektiflik kazandırmış olacaktır.

        // ArraySegment<int> segment = new ArraySegment<int>(sayilar);
        // ArraySegment<int> segment1 = segment.Slice(0,3);
        // ArraySegment<int> segment2 = segment.Slice(4,7);
        // ArraySegment<int> segment3 = segment.Slice(5,10);

        #endregion

        string text = "Ölüme gidelim dedin de mazot mu yok dedik";

        #region StringSegment Nedir ?

        // StringSegment, ArraySegment'in string değerler nezdindeki bir muadilidir.
        // Esasında metinsel değerlerdeki birçok analitik operasyonlardan bizleri kurtarmakta ve Substring vs. gibi fonksiyonlar yerine string değerde hedef kesit üzerinde işlem yapmamızı sağlayan bir türdür.
            
        #endregion
        #region StringSegment İle Dizinin Belli Bir Alanini Referans Etmek
        
        //StringSegment türünü kullanabilmek için uygulamaya Microsofr.Extensions.Primitives paketinin yüklenmesi gerekmektedir.
        // StringSegment segment = new StringSegment(text);
        // StringSegment segment1 = new StringSegment(text,2,5);
        // System.Console.WriteLine(segment1);
        
        #endregion
        #region StringBuilder Sinifi

        string isim = "Mustafa", soyisim = "Ünal";

        // StringBuilder, string birleştirme operasyonlarında + operatörüne nazaran yüksek maliyeti absorbe edebilmek için arkaplanda StringSegment algoritmasını kullanan ve bu algoritma ile bizlere ilgili değerleri olabilecek enn az maliyetle birleştirip döndüren bir siniftir.

        System.Console.WriteLine(isim + " " + soyisim);

        StringBuilder builder = new StringBuilder();
        builder.Append(isim);
        builder.Append(" ");
        builder.Append(soyisim);

        System.Console.WriteLine(builder.ToString()); // bu işlem daha az maaliyetlidir.
            
        #endregion






        #endregion
    }
}