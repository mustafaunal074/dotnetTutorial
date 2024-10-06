internal class Program
{
    // Yazılımın amacı : var olan veriyi doğru bir şekilde işleyip bir çıktı almak
    // int a; //=> global değişken
    private static void Main(string[] args)
    {
        #region DEĞİŞKENLER

        // Değişken Nedir?
        // İşlenen veri ramde tutulur.
        // Yazılım veriyi tutmaz ramden alır rame yerleştirir
        // Bir yazılımda işlenecek veriyi ramde tutabilmek için değişkenler kullanılır.
        // Değişken yazılım adına rame veri koymamızı ve ihtiyaç halinde ramden o veriyi okuyabilmemizi sağlayan yapılardır.

        // Neden değişkene ihtiyaç duyarız peki =>  
        //Veriyi tutabilmek için. İşlem yapabilmek için 
        // Yazılımda işlenece veriyi yazılım adına RAM'e yerleştirebilmek için biz programcılar degiskenleri kullanırız.

        #region ValueType- Primitive Type

        //C# programlama dilinde RAM'de veri tutabilmek/depolayabilemk için tanımlamacak olan değişkenin türü/veri türü bildirilmelidir.
        // Tur elimizdeki eriye göre bildirilir.

        #region ValueType - Değer Türlü Değişkenler

        // Bir değişkenle RAM'de alan tahsisinde bulunduğunda buna Değer Türlü değişken diyoruz. Yani tuttuğu değer bir normal değer olan değişkenlere Değer Türlü denmektedir.
        // Değer Türlü Değişkenler : Sade ve sadece bir değeri tutan değişkenlerdir. Yani adımız,soyadımız,doğum tarihimiz gibi değerleri tutarlar.

        // Değişken tanımlarken RAM'e tutulacak veriye uygun bir alan tahsisinde bulunulmasi gerekmektedir. RAM'de alan tahsisinde bulunabilmek için ilgili değişkenin türünden hareket edilir.

        // Bir türde tanımlanmış alana farklı bir türde deger atayamayiz.

        #endregion

        #region PrimitiveType
        
        // En ilkel türdür.
        //byte : bir primitive turdur. hiçbir şey olmadan tek başına var olan bir tür olduğundan primitive dir. Lakin byte'lardan meydana gelmiş olan decimal türü ise primitive değildir. Lakin value typedir.

        /
        
        #endregion
        #endregion

        #region  c# dil özellikleri
        
        // c# programlama dili büyük küçük harf duyarlılığına sahip olan bir dildir.
        // c# programlama dili tip güvenliği olan bir dildir. => rame koyacağın verinin türünü önceden belirlemek
        
        #endregion

        #region Değişken Tanimlama 

        // degisken_turu degisken adi; => değişken tanımlama
        // int tcKimlikNo;

        #region RAM'in yapisi(Stack)

        // İçerisinde deger türlü değişkenleri ve değerlerini tutabildiğimiz bolumdur
        // Nesneleri Heapte tutarz !! ==> OOP konusu
        // değişken türü,adi ve değerini tutuyor
        // not => burada tutulan değişken ismini nadirde olsa referans dendiğini görebilirsiniz(değer türlü olsa bile)
        // metotların bellek adresleride burada tutulur. => ileride göreceğimiz metotların bellek adresleri burada tutulur.


        #endregion
        #region Değişkenler RAM'de Nasil Tutulur?

        // int yas;
        // string adi;    // => bu değişkenlere runtimede ramde alan ayrılır.
        // string soyad, // => Stackte FIFO(First In First Out) mantığıya çalışır yani ilk giren ilk çıkar

        #endregion
        #region C# Kurallari

        /*
        1.Anlamlı İsmlendirme
        Personelin yaşı tutulacaksa => int yas; - int personelYas; gibi vermek bizim için düzenli bir kod yazma süreci getirir.


        2.Özel Karakter Olmamali
        Değişken isimlendirmede .,' gibi özel karakter barındıramazlar
        Tek İSTİSNA '_' operatörüdür.
        
        3.Değişken isimleri sayısal ifade ile başlayamaz
        int sayi1; => true
        int 2sayi; => false

        4.Bir scope içerisinde aynı isimde birden fazla değişken tanımlanamaz. 
        */

        #endregion
        #region Değişken Tanimlama Kurallari

        #endregion
        #region  Değişken İsmilerini @ Operatörüyle Tanumlama

        // string @x; //=> değişken başında getirilen @ işareti
        // değişken isimlerinde programatik keyword kullannılamaz.
        // Eğer ki bir değişken isminde programatik olarak kullanılan bir keywrodü vermek istiyorsanız eğer bunu @operatörü ile ezebilir ve öylece verebilirsiniz

        // string @static;

        #endregion
        #endregion
    
        #region  Tanimlanmiş Değişkene Değer atama

        #region Tanımlama Aşamasında Değer Atama
        
        // int x = 5;
        // = => assign atama öperatörüdür.
        // sağ taraftaki değeri soldaki değişkene,field,property vs. atar.
        // string adi = "Mustafa";
        
        #endregion
        #region Tanımlandıktan sonra Değer Atama


        // Eğerki bir değişken ismi assign operatorunun solunda çağrılıyorsa o alana değişkenin kendisi gelecektir.
        // int y;
        // y = 15;

        #endregion

        //Dikkat
        //Bir değişkene atanan en son değer geçerlidir.
        // int a =5;
        // a=15;
        // a=20;

        // tanımlanmış olan değişkene türüne uygun bir değer atılmalıdır.

        #region Değişkene Değer Atama Kurallari
        #region Metinsel

        //string keywordü ile tanımlanır
        // metinsel ifadeler çift tırnak içinde yazılmalıdır.
        //Bir sayisal ifade metinsel olarak tutuluyorsa eğer yazilim açısından o metinsel bir ifadededir. yani üzerinde matematiksel işlem yapılamayan ve "Hüseyin" gibi metinsel ifadelerden farki olmayan bir değerdir.
        
        #endregion
        #region Karakter

        // char :karaktersel ifadeler tek tirnak içerisinde yazılmalıdırç
        // char basHarf = 'M'

        
        #endregion
        #region Mantiksal

        // bool: mantiksal ifadeler direkt olarak true ya da false olarak belirtilir.
        // bool medeniHal = false;
        // true : 1- dogru
        // false: 0 - yanlis
        
        #endregion
        #region Sayisal

        // sayisal ifadelere deger atarken direkt olarak degeri gönderirirz.
        // int sayi = 1000;
        // sayisal ifadelerde bir deger varsayilan olarak integer kabul edilir.

        //Ondalikli Sayilar => tum ondalikli sayilar tam sayilari karşılayabilirler.
        //float: float türünde bir kusuratli değer tutarken ilgili degerin sonuna f yada F getirilmelidir
        // float  x = 3.14F;

        //double: double türünde bir ksuuratli değer tutarken ilgili degerin sonunda d yada D getirilmelidir.
        // 3.14d or 3.14D


        //decimal: türünde bir kusuratli değer tutarken ilgili değerin sonudan m yada M getirlmelidir.


        //Notlar => 
        //1.Bir sayisal tür değere aralığına girmeyen değeri tutamaz. Compiler hata verir.
        //2.tam sayilarda default değer nasılki int ise ondalıklı değerdeki default değer double dır ve sonunda d veya D kullanmak zorunda değiliz.


        #endregion
        #endregion


        #region (_a,_b) = (a,b) Tuple türüyle Değer Atama

        //Tupple => tek bir syntax üzerinde birden fazla değişken tanımlamamızı sağlayan bir nesnedir.
        // (int a,int b, typpe c, typeof d) z; => tupple değişken
        // (int a,string b) c = (5,"ahmet");
        // c.a => int değişken
        // c.b => string değişken 

        //(int a,int b) c = (5,10);
        // (int yas,string adi,bool medeniHal) kisi = (23,"Mustafa",false);

        #endregion
        #region Literal Düzenlemeler c#7.0

        // kompleks sayisal ifadeleri _(alt tire) ile düzenlememizi sağlayan özelliktir
        // int sayi = 1_000_000; =>bir milyonu okunabilirliğini bu şekilde kolaylaştırabiliriz.

        #endregion
        #region Değişken Türüne Uygun Defaut Değer Atama

        // değişkenlerin default değerleri
        // ileride oope dediğimiz yaklaşımı gördüğümüzde class içerisinde tanimlaan değişkenlerin default değerlerin otomatik atandığını konuşacağız.
        // string => null --- null => değersiz demektir boş demek değildir.
        // char => '\0'
        // sayisal => 0
        // bool => false

        // default keywördü : içerisinde verilen türün varsayılan değerini geri döndürür
        // bool x= default(bool);
        // int y = default(int);
        // string z = default(string);
        // char t = default(char);

        // main içerisinde oluşturulan değişkenlerin ilk değerlerini manuel atmaya özen gösteriniz.
        #endregion
        #region Default Literals c# 7.1

        // bool x = default;
        // decimal y = default;


        #endregion
    
        #endregion
    
        #region  Tanimlanmiş Değişkenin Değerini Okuma
    
        // int x= 5;
        // bir değişkenin değerini elde edebilmek için değişkenin adından faydalanmaktayız.
        // Bir değişkenin adi assign(=) operatörünün sağında yahut metotların parametrelrinde çağrılıyorsa ilgili değişkenin değeri gönderilir.
        // Console.WriteLine(x);
        // int y = x;

        #region Kritik 1

        // int a = 5;   => stackte a=5
        // int b = 10;  => stackte b=10
        // int c = b;   => stackte c=10(b nin değeri)
        // int d =a ;   => stackte d=5(a nin değeri)  
        // b=a;         => stackte new b => 5(a nin değeri) 10 değeri ezildi
        // c=b;         => stackte new c => 5(b nin değeri)  10 değeri ezildi

        #endregion
        #region Kritik 2

        // int a = 5;  stackte => a =5
        // a = a;      stackte a= 5 değeri ezilir a= ya a nin değeri atanir

        #endregion
        
        #region Değeri Olmayan Değişkenler !

        // bu değişkenler ile hiç bir şey yapılmaz. metota parametre verilmez assignın sağına yazılmaz
        // int a; 

        // class içerisinde tanimlanan değişkenlerde varsayilan değerler otomatik atanır.
        // lakin main içerisinde tanimlanan değişkenlerde değer atanma yapılmaz ise o değişken kullanılamaz
        // bir metot içerisinde tanımlanan değişkenleri ilk değerlerini manuel olarak vermeyi alışkanlık haline getiriniz.

        #endregion
        
        #region Değişken Davranişlari Genel Bakiş (ref için farkinadalik)

        

        #endregion
        
        
        #endregion

        #endregion

        #region Scope

        #region Scope Nedir

        // Faaliyet alannı ( KAPSAM )
        // Değişken ve fonksiyonların erişilebilirlik sınırlarını belirleyen alandır.
        //Tanımlamalarda ve algoritmik çalışmalarda karıklılığı önleyen bir sınır çizer.
        // C#: Süslü parantez ile ifade edilmektedir { }

        // bir scope içerisinde tanımlanan değişkeni o scope içierinsen her yerde erişebiliriz.
        // bir scopeta tanımlanan değişken farklı bir scopete erişilemez
        // bi scopte ayni isimde birden fazla değişken olamaz.
        // farklı scopelerde aynı isimlerde değişkenler olabilir
        #endregion
        #region Değişkenin Faaliyet Alani Nedir ?

        // bir değişken tanımlandığı scope içeriisnden erişilebilir ve kullanılabilir


        #endregion
        #region Custom Scope Oluşturmak?
        // string a = "a";
        {
            // int a =5;
            {
                  
            }
        }
        {

        }
        

        #endregion
        #endregion
    
        #region Sabitler

        // Sabitler, değişmeyen değerleri tutabilmek için oluşturulmuş yapılardır.
        // Süreçte var olan değeri değiştirilemez, değiştirlmeye çalışıldığı taktirde compiler tarafından hata verilir.

        //const
        // Constant tan gelir
        // değişmeyendir
        // const değişkenler tanımlama aşamasında değerlerini isterler aksi taktirde hata alır.
        // prototip olarak değişkenlere çok benzer lakin davranışsal olarak değeri bir daha değiştirilemez.
        // bir const tanimlandığinda STACK'te ilgili türde alan tahsis edilecektir ve ilk atanan değer dışında bir daha değer kabul etmeyecektir
        // constlar değişitirilemez lakin istenildiği kadar okunabilir/değerleri elde edilebilir.
        // özünde static yapılanmadır.
        //
        // peki static ne demektri => Uygulama bazlı veri depolayabildiğimiz bellekte bir alandır.
        
        // peki static ile const arasındaki fark nedir ?
        // static değişkenler adı üzerinde değerleri değişebilir lakin const'lar sabittir.


        // const double pi = 3.14;
        // pi = 5;

        //readonly
        // sadece okunabilir değişkenler tanımlamaktır.

        //const ile readonly arasındaki fark nedir?
        // readonlynin const'tan farkı tanımlamdığı yerde değil, ayrıca constructor içerisinde de değeri atanabilir. Dependency Injection deseninde çok sık tercih edilir
        // readonly static değildir.


        #endregion
    
        #region Global Değişkenler
        
        // bir değişken class scopu içerisinde tanımlanıyorsa buna global değişken diyoruz...
        
        
        #endregion
    
        #region Değişken Tanimlama Varyasyonlari

        #region  Varyasyon 1

        // int a = 5;
        // int b = 10;

        #endregion
        #region  Varyasyon 2

        // aynı türde birden fazla değişken oluşturulacaksa eğer bu değişkenleri tek imzada aşağıdaki gibi tanımlayabiliriz.
        //int a ,b;
        

        #endregion
        #endregion

        #region Değişkenler Arasi Değer Atama

        // Değişkenler arası değer atanırken verisel açıdan iki davranış söz konusudur.
        // Deep Copy - Shallow Copy

        #region Deep Copy - Derin Kopyalama.

        // Deep copy neticesinde eldeki veri çoğalır/klonlanır.(telefon üretimi gibi)
        // Değer türlü değişkenler(int,deciaml,bool...) birbirlerine atanırken default olarak deep copy geçerlidir. Yani veri otomatik oalrak türetilir.


        // int a=5;
        // int b=a;  => burada a daki 5 değeri tekrar üretilir ve b ye verilir.
        // a = a * 5;  => eğer ki a da yapılan değişiklik b ye yansımaz ise bu deep copydir.
        // System.Console.WriteLine(a); => 25
        // System.Console.WriteLine(b); => 5
        
        #endregion
    
        #region Shallow Copy-

        // Değişkenler arasi değer atamalarında değeri türetmek/çoğaltmak/klonlamak yerine var olanı birden fazla referansla işaretlemeye shallow copy denir.
        // bellekte birden fazla referansın tek bir veriyi işaret etmesidir.
        // neticede ilgili değer bir değişikliğe uğradığında tüm işaretleyen referanslara bu değişiklik yansıyacaktır.

        // normalde değer türlü değişkenler default olarak Deep Copy edilirler.
        // bu eğitimin ierideki konusu olan 'ref keywordü' ile değer türlü değişkenlerde nasıl shallow copy yapıldığını ele alacağız.

        // Shallow Copy OOP derslerinde ele alacağımız nesne ve referans arasındaki ilişkikde varsayılan davranış olarak kabul edilmektedir. Bu konuya nesneler üzerinde de ayriyetten DeepCopy'nin nasıl gerçekleştiğinide ele alacağız

        #endregion

        // Deep Copy değer türlüde varsayılan copydir
        // shallow copyde referans türlüde varsayılan copydir.


        #endregion

        #region Object

        // object,tümmmm türleri karşılayabileyen bir türdür.
        // tümm türler varsayılan olarak object'ten türerler
        // object türlerin ademidir. bu yüzden tümm türleri karşılayabilmektedir.
        // object yapısal olarak referans türlü bir değişkendir.
        //lakin değer türlü değerleride karşılayabilir.
        // object değişkenler ilgili verileri RAM'de object türde tutarlar. lakin verinin öz türünde içerisinde bozmadan saklarlar. Yani object içerisindeki veri kendi öz türünde tutulur. Orneğin beni al şarap fıçısına koy dışardıan neye benziyorum sarap fıçısına içerde kim var Mustafa var. Dışardan objectim ama iççerde stringim
        // bu durum object içerisindeki veriyi kendi türünde tekrar elde edebiliriz anlamına gelmektedir.
        // Veriyi objectin içine koymaya => boxing
        // objectin içinden kendi türünde elde etmeye => unboxing

        #region Boxing

        // object türdeki bir değişkene herhangi bir türdeki değeri göndermek boxing olarak nitelindirilmektedir.

        // int yas = 23;
        // object _yas = 23; // boxing
        // boxing işlemi neticesinde ilgili değer objectin içerisinde kendi türüyle saklanır.
        //lakin _yas değişkeni artık 23 değerini bizlere object türünde getirecektir. _yas => (object)23
        // burda dikkat edersek object türünden elde edilen değer üzerinden türüne özgü işlemler gerçekleştririlemez
        //orneğin sayisal bir değer varsa o değer object olarak geleceğinden dolayı matematiksel işlemler yapılamaz.

        // object bir değişkenin içerisindeki değer üzerinde turune özgü işlemler yapabilmek için o objectin içerisindeki değeri kendi/has türünde elde etmemiz gerekmektedir.

        // işte bu işleme unboxing diyeceğiz

        // herhangi bir değer object türe assign ediliyorsa eğer bu işlem boxingdir.

        #endregion
        #region Cast Operatörü

        // boxing edilmiş bir veriyi kendi türünde elde etmemizi sağlayan bir operatördür.
        // tür dönüşümlerinde bilinçli tür donumu konusunda cast operatörünü kullanacağız
        // kalıtımsal durumlarda da karşımıza çıkacaktır.

        // (T)object; => 
        // cast operatörü parantez'dir.
        // cast operatörü, object olan değişkenin solunda o objecti hangi türe unboxing etmek istiyorsak parantez içerisine hedef türü bildirerek kullanılır.

        // int a = 5;
        // object b = a; => boxing oldu
        // (int)b; => b nin içerisindeki değeri int olarak elde edecem demektir.

        #endregion
        #region UnBoxing

        // int yas = 28;
        // object _yas =28;
        // _yas * 5; => boxing edilmiş veriyi kendi z türündeki nitelikleriyle kullanılamıyorduk
        // yani elimizdeki int veriyi matematiksel işlemlere object olduğu için tabi tutamiyorum

        #region UnBoxing
        
        // int unboxingYas = (int)_yas; // unboxing
        // System.Console.WriteLine(_yas * 5); false
        // System.Console.WriteLine(unboxingYas * 5); true

        // unboxing esnasında boxing edilmiş verinin orjina türü ne ise o bildirilmelidir.
        // yani int türünde boxing edilmiş bir veriyi char olarak unboxing edemezsin int olarak unboxing etmelisin
        
        #endregion

        #endregion

        #endregion
    
        #region var

        // var bir değişken değildir bir keyworttür.
        // tutulacak değerin türüne uygun bir değişken tanımlayabilmek için kullanılan bir keyword'dür.
        // var keyword'ü kendisine atana değerin türüne burünür.

        // var medeniHal = true; ==> bool olduğundan dolayı var bool türüne bürünecektir
        
        // var keyword'ü, compiler tarafından değerin türüne göre otomatik burunduruen bir keyworddur. Lakin bir tür değildir.

        // genellikle, yazacağımız değişkenlerin türlerini yazmaktan üşendiğimiz için kullanmaktayız.
        // halbuki esas olma sebebi ise farklı diller arasında desteklenmeyen türlerdeki verileri karşılayabilmek için oluşturulmuş ortak bir keyword'dür.
        // diller arasındaki entegrasyonda kullanılıyordu.

        // türünü bilebildiğimiz verilerin değişken türlerini var ile compiler'a yaptırmak ufakta olsa bir maalyettir!
        // bunun için bizler bu maaliyetten kaçınmak adına bildiğimiz türleri mümkün mertebe usenmeden belirteceğiz.



        // 1.var keywordüyle tanımlanan değişkenin değeri tanımlama aşamasında verilmelidir. Verilmelidir ki türü belirleyip direkt ona dönüşebilsin o türde davranış sergileyebilsin...
        // 2.var keywordüyle tanımlanan değişkene ilk değer verdikten sonra o değerin türüne bürüneceği için sonraki durumlarda değeri farklı türlerde verilemez.
        // var x =3.14;
        // x = "sadkas"; diye gidip değiştiremezsin

        // var ile object arasındaki farkı
        // var bir keyword iken objcet bir türdür. var atana değerin türüne bürünürken, object atanan değeri boxing yapar

        // var x = 5;   => stackte int olarak tutacak => matematiksel işlem yapabilirsin
        // object y = 15; => heapte object türünde tutulacak => unboxing yapmadan matematiksel işlem yapamzsın




        #endregion

        #region dynamic

        // var a =5; => a compile sürecinde/development asamasında int davranışı sergileyecektir
        // dynamic a =5; =>development aşamasında a'nın hala dynamic olduğu gözlenmektedir. Ne zamanki uygulama derlenip çalıştırıilir o zaman dynamic ilgili değerin türüne bürünmüş olacaktir

        // var derleme aşamasında değerin türüne bürünürken, dynamic ise runtime'da verilen değerin türüne bürünecektir


        var a = 5; 
        dynamic _a = 5;
        a.ToString();
        _a.ToString();
        System.Console.WriteLine(_a.GetType());

        // dynamic tüm kararı runtimeye bırakır. değeri orada belirleyip işlemi orada yapar.


        // dynamic keywordü runtime'de türü belirleyecektir. lakin kararlı davranmayacaktır.
        // dynamic x = "Mustafa";
        // System.Console.WriteLine(x.GetType()); => string
        // x = 3.14D;
        // System.Console.WriteLine(x.GetType()); => double


        // dynamic nerelerde tercih edilir??
        //x yerden data geliyor gelen datanın türünü bilmiyoruz runtimede dynamic ile karşılayabiliriz.
        //uzaktan gelen veriler var keywordü ile karşılanamaz. çünkü var keywordu tanımlandığı esnada verinin atanmasını ister!!!

        #endregion
    }
}