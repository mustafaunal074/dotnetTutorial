internal class Program
{
    private static void Main(string[] args)
    {
        #region Hazir Sinif ve Fonksiyonlar

        #region Math Sinifi

        #region Abs
        // Mutlak değer işlemi yapar.
        // Absolute Value

        // int i = Math.Abs(5);
        // int i2 = Math.Abs(-5);

        #endregion   
        #region Ceiling

        // Yukarıya yuvarlar.
            
        // System.Console.WriteLine(Math.Ceiling(3.14)); // 4

        #endregion
        #region Floor
        
        // Aşağıya yuvarlar.
        // System.Console.WriteLine(Math.Floor(3.14)); // 3

        #endregion
        #region Round

        // Ondaklıklı değeri en yakın tam sayıya yuvarlar
        // System.Console.WriteLine(Math.Round(3.4)); // 3
        // System.Console.WriteLine(Math.Round(3.5)); // 4
        // System.Console.WriteLine(Math.Round(3.6)); // 4

        #endregion
        #region Pow
            
        // Verilen değerin üstünü almaya yarar
        // System.Console.WriteLine(Math.Pow(2,2)); // 2^2 => 4
        // System.Console.WriteLine(Math.Pow(7,9)); // 7^9 =>40353607

        #endregion
        #region Sqrt
        
        // Verilen değerin karekökünü alır (2. dereceden)
        // System.Console.WriteLine(Math.Sqrt(4)); // 2
        // System.Console.WriteLine(Math.Sqrt(16)); // 4
        // System.Console.WriteLine(Math.Sqrt(55)); // 7.41619..

        #endregion
        #region Truncate

        // Ondaklıklı değerlerin tam sayı kısmını elde etmeye yarar.
        // System.Console.WriteLine(Math.Truncate(3.14)); // 3

        #endregion
        
        #endregion
        
        #region DateTime Struct'i

        #region Now

        // System.Console.WriteLine(DateTime.Now);

        #endregion
        #region Today

        // System.Console.WriteLine(DateTime.Today); // Nowdan farkı sadece tarihi getitir (dd.mm.yyyy 00.00.00)

        #endregion
        #region Compare
        
        // verilmiş iki tarihi kıyaslayarak int değer döndürür.

        // DateTime tarih1 = new DateTime(2024,01,01);
        // DateTime tarih2 = new DateTime(2025,01,01);

        // int result = DateTime.Compare(tarih1,tarih2); // -1,0-1 değerini döner
        // if (result < 0)
        // {
        //     System.Console.WriteLine($"{tarih1} küçüktür {tarih2}");
        // }
        // else if (result == 0)
        // {
        //     System.Console.WriteLine($"{tarih1} eşittir {tarih2}");
        // }
        // else
        // {
        //     System.Console.WriteLine($"{tarih1} büyüktür {tarih2}");
        // }


        #endregion
        #region AddDays
        
        // DateTime tarih = DateTime.Now.AddYears(1); // 2024 + 1 = 2025
        // System.Console.WriteLine(tarih);

        #endregion
        #region AddHours
        


        #endregion
        #region AddMonths
            
        #endregion
        #region AddYears
            
        #endregion
        #region AddMiliseconds
            
        #endregion
        
        #endregion
        
        #region TimeSpan Struct'i
        
        // iki tarih arasındaki farkı timeSpan türü ile karşılayabiliriz.
        // DateTime t1 = DateTime.Now;
        // DateTime t2 = new DateTime(2000,1,1);
        // TimeSpan span = t1-t2;
        // System.Console.WriteLine(span.Days);
        // System.Console.WriteLine(span.Minutes);

        #endregion
        
        #region Random Sinifi
        
        // Randomu kullanmak için nesne oluşturmamaız gereklidir
        // Rastgele sayısal değer oluşturmamız sağlıyor

        Random random = new Random();

        #region Next Fonksiyonu

        // belli sayısa aralıkta tam sayı değer oluşturmak istiyorsak kullanırız.

        // System.Console.WriteLine(random.Next()); // 0--int değer aralığı
        // System.Console.WriteLine(random.Next(100)); // 0--100 değer aralığı
        // System.Console.WriteLine(random.Next(50,100)); // 50--100 değer aralığı

        // Max değerler dahil DEĞİLDİR.
        // Negatif değer üretmez negatif istersek -1 ile çarpmalıyız.

        #endregion
        #region NextDouble Fonksiyonu
    
        // 0-1 arasında rastgele değer üretir
        System.Console.WriteLine(random.NextDouble());

        #endregion
        
        #endregion
        
        #endregion
        
    }
}