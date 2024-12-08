namespace Ders01_MainNedir
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Uygulamalrada Program.cs dosyasi başalngıç kodların bulunduğu yani uygulamanın ayaga kalabilmesi için başlangıç kodlarının bulundugu bir dosyadır

            //Başlangıç kodlarıdnan kastımız,  Uygulama ayağa kalktığında işletimi sistemiyle iletişim kurabilecek metodun ve bu metot içerisinde başlangıca dair komutları barındıracak bir dosyadır.

            //Main Fonksiyonu :
            // herhangi bir uygulama olsada bu main fonksiyonun sade ve sadece 1 adet olmak zorundadir.
            // main fonksiyonu uygulamada Program.cs dosyası içerisinde Main isminde bulunur.
            // işte bu fonksiyon işletim sistemiyle iletişim kurar.(Bu uygulama adina, yani bu fonksiyon uygulama ilk ayağa kalktığında ilk tetiklenen fonksiyondur. Dolayisiyla ilk kodlarımızı bu fonksiyonda yazarız)

            Console.WriteLine("Hello World...");

            // hocam işletim sistmine parametre nasıl göndeririz peki ?
            // powershell veya cmd üzerindet dotnet CLI komutlarından run komutu ile projemizi ayağa kaldırdığımızda boşluk bırakıp yazacağımzı şey bizim göndereceğimiz parametre oluyor
            // örn => dotnet run mustafa (0. indekste değer var)
            // orn => dotnet run mustafa unal (0. ve 1. indekste değer var)

            // System.Console.WriteLine(args[0]);
            // System.Console.WriteLine(args[1]);

            //------------------------

            // Top-Level Statements Özelliği
            // Sıradan bir işlem için bile oluşturulan konsol uygulamasında basma kalıp(boilderplate) kodların gelmesi gerekmektedir(namespaca-class)
            // günlük hayatta basit kodlar insa edebilmek ve test süreclerinde hizli denemeler yapabilmek için bu tarz bir kod bloguna maruz kalmamıza sizce gerek var mı?
            // c# 9.0 ile gelen top-level statements özelliği ile main fonksiyonunun zoraki imzasının tanımlanması kaldırılmıştır.
            // main fonksitonun kullanılması developerın kararına bağlıdır

            // normalde c# 9.0 dan önce  topl level statemenst kodları derlenmezdi. cunku boyle bir syntax bulunmamamktaydı
            // lakin c# 9.0 ile top level statements özelliği bizlere bu şekilde bir kod isa etmemiz ağlamaktadır.

            // Kurallar
            // 1. using blokları ile namespace arasinda kodlar yazılabilir
            // 2. bu işlem sade ve sadece program.cs dosyasında gecerlidir. Yani main fonksiyonunda yazılacak komutların direkt burada yazılmasına musaa edilmemek lakn farklı bir dosyada bu işlem gerçekleştirememekteyiz.
            // bu şekilde yazılan komutlar derlendikten sonra esasinda bir main fonksiyonu içerisnde alinacaktır. (using ve namespace arasındaki kodları alır)
            // uygulama derlenirken  Program.cs dosyasında varsa top leve state ozelliği bu dosyaya özel algılayacak ve ilgii alana yazilan kodlari main içerisinde yorumlayacaktır.
            //bunun dısında zaten bu özelliği başka bir dosyada kullanamayacağımızdan dolayı sadece Program.cs dosyasına has bir özelliktir.

            // top level state, genellikle micro services yapılanmasında kodun gelişimi acısından hiz kazandirici bir niteliğe sahiptir.
        }
    }

    //  Açıklama Satırları
    // Kodun niteliğini,, ankaşılabilirliğini, kalitesini arttırabilmek için kullanılırlar.
    // Kritik noktalarda ve özet olarak kodalrı izah etmeliyiz.
    //  Tek satırlık yorum satırı
    /*
     Çok
     Satırlık
     Yorum
     Alanı
    */

    // Nerede kullanılırlar? => İstediğin her yerde yorum yazabilirsin lakin kod konseptini ve semantik akışı bozmaman kaydıyla...

    //  Region
    // Kod dosyasını kategorik hale getirmemizi sağlayan bir ön işlemci komutudur.(editörün yorumlayayabildiği bir komut)
    // Developerın yazmış olduğu kodu daha net görmesini ve kategorize etmesini sağlar.
}
