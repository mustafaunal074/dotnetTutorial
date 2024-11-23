internal class Program
{
    private static void Main(string[] args)
    {
        #region Span & Memory Türleri

        #region Span Nedir ?

        // Bellek üzerinde belirli bir alanı temsil ederek işlemler gerçekleştirmemizi sağlayan bir structur
        // Bu belirli alanlardan kasıt tabi ki de ardaşıl alan kaplayan Array değerlerdir
        // Normal şartlarda Array'lerin belleğin HEAP kısmında tutulduğunu biliyoruz. Lakin stackalloc keyword'ü sayesinde STACK'te de Array tanımlayabilmekteyiz.
        // Span, stack yahut heap farketmeksizin tanımlanmış olan Array'lerin tümünü yahut bir bölümünü bizler için refere edebilen ve üzerinde işlemler gerçekleştirebilmemizi sağlayan kullanışlı bir yapıdır.

        // Span, dizi ve string gibi maliyetli veriler üzerinde yapılacak operasyonlarda performans açısından yüksek getiriyle değer kopyalamaya gerek kalmaksızın tüm faaliyetleri gerçekleştirmemize olanak sağlamaktadır.

            
        #endregion
        #region ReadOnlySpan<T>

        // Span niteliklerini tümünü sağlamakta lakin adı üzerinde sadece okunabilir kılmaktadır.
            
        #endregion
        #region Span ile ArraySegment & StringSegment Farki Nedir ?
        
        // ArraySegment sadece string ve dizilerde temsiliyet yapabiliyorken, Span bellek üzerinde olan herhangi bir yeri temsil edebilir.
        // ArraySegment'te referans edilen hertürlü müdahala edilebilirken, ReadOnlySpan'da verisel operasyonlar engellenebilir ve sadece okunabilir bir davranış sergilenebilir
        // Sadece string yahut Array türler ile çalışılacaksa eğer ArraySegment ve StringSegment tavsiye edilir.

        #endregion
        
        #region Memory Nedir?

        // Span ref struct olarak tasarlanmış bir struct'tır.
        // Dolayısıyla Heap'te allocation(tahsis) edilememe, object, dynamic yahut interface türleri aracılığıyla referans edilememe yahut bir class içerisinde field veya property olarak tanımlanamama gibi kısıtlamaları vardır.
        // Memory türü Span'ın bu kısıtlamalarından münezzeh versiyonudur.
            
        #endregion
        #region ReadOnlyMemory
        
        // Memory türünün sadece okunabilir halidir.
        
        #endregion

        int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        Span<int> span = new Span<int>(sayilar);
        Span<int> span2 = sayilar;
        Span<int> span3 = new Span<int>(sayilar,3,5);

        Span<int> span4 = sayilar.AsSpan(); 
        Span<int> span5 = sayilar.AsSpan(3,5);


        string text = "Sen kalbimde batan güneş, ben yollarda çilekeş..";

        ReadOnlySpan<char> readOnlySpan = text.AsSpan();
        ReadOnlySpan<char> span6 = text;

        #endregion
    }
}