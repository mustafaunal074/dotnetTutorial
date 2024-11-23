using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Koleksiyonlar
        
        #region Giris


            
        #endregion

        #region ArrayList
            
        #region ArrayList Koleksiyonu Tanimlama

        // Diziler tanimlanirken kaç eleman tutacakları bildirilmek zorundadir.
        int[] yaslar = new int[17];

        // Koleksiyonlarda böyle bir zorunluluk yoktur.
        ArrayList _yaslar = new ArrayList();


        #endregion
        #region Tanimlanmis Koleksiyona Deger Atama
        
        // yaslar[5] = 123;
        for (int i = 0; i < 17; i++)
        {
            yaslar[i] = i+10;
            _yaslar.Add(i+10);
        }

        // _yaslar.Add(123);


        #endregion
        #region Tanimlanmiş Koleksiyondan Deger Okuma

        // Diziler
        // Console.WriteLine(yaslar[5]);
        
        //Koleksiyonlar
        // Console.WriteLine(_yaslar[5]);

        #endregion
        #region ArrayList Kullanilirken Boxing - Unboxing Durumlari

        // ArrayList, verilen datayı boxing işlemine tabi tutar.
        // ArrayList içerisindeki herhangi bir veriyi talep ettiğimizde o veri object olarak gelecektir. Dolayisiyla kendi türünde işlem yapabilmek için unboxing işlemine tabi tutmamız gerekir.

        int toplam = 0;
        for (int i = 0; i < _yaslar.Count; i++)
        {
            if (_yaslar[i] is int)
            {
                toplam += (int)_yaslar[i];
            }
        }
        System.Console.WriteLine(toplam/_yaslar.Count);


            
        #endregion
        #region ArrayList Koleksiyonun Sinirliliklari ve Diger Kolekstion Yapilarinin Cikis Nedenleri
        
        

        #endregion
        #region ArrayList Collection Unitializers(Koleksiyno İlkendirici) İle Deger Ekleme
        
        // ArrayList arrayList = new ArrayList();
        // arrayList.Add();

        ArrayList arrayList = new ArrayList()
        {
            "Ahmet",
            123,
            'a',
            false
        };

        #endregion
        #region Ornek
            
        #endregion
        
        #endregion

        #endregion
    }
}