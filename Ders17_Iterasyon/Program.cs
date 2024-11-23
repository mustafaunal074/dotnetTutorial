using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Iterasyon

        #region Giris
        
        // Mantiksal açıdan hher tahminin altinda bir iterasyon yatar.
        // biz eğer size bir sayı dizisi versek 1-3-5 siz 5 ten sonra gelecek değerin 7 geleceğini bilmeniz iterasyon matığıdır.
        //mermer, baba gibi gelimeler kendini tekraralayan heceler vardır bunlarda iterasyon kelimlerdir.

        // Yazılımda ise biz bunu birden çok fazla eleman barındınra verilerde(dizi-koleksiyon) kullanabilmekteyiz.

        #endregion
        #region Iterasyon vs Dongu

        // Foreach(Iterasyon) bir döngü değildir.
        // Dongulerde illaki bir dizi-koleksiyon gibi bir yapıya ihtiyac duyulmaksızın foreachte bir dizi veye koleksiyona ihtiyac vardır.

        
        // int[] sayilar = { 3,213,423,42,34,234,234,234 };


        // for (int i = 0; i < sayilar.Length; i++)
        // {

        // }
        // foreach (var sayi in sayilar)
        // {
            
        // }
            
        #endregion
        #region Foreach Iterasyonu

        ArrayList sayilar = new ArrayList { 123,123,325,2,54,5,345,345 };
        
        foreach (object sayi in sayilar)
        {
            sayilar.Add(123123); // e ğer bu şekilde iiterasyon içinde kaynağı değiştiriresek kodumuz patlar
            System.Console.WriteLine(sayi);
        }

        #endregion
        #endregion
    }
}