using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety- tip güvenliği ve iki slaş yorum etiketi
            // deger tutucu, yani alias, kategori için takma isim burda kategori etiketidir


            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45; //ondalıklı sayı double veri tipinde gösteriliy
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            } // eğer ifteki şart geçerliyse o, else if teki geçerliyse o, else geçerliyse o süslü parantezlerin içindeki o çalışır


            // unutmayalım alttaki if çalışırsa çalışır eğer çalışmazsa else çalışır 
            //bu şu demek if parantez içine yazılan geçerliyse süslü parantez içindekiler çalışsın demek, python da bu bloğu indentation ile yapıyorduk
            // eğer bu if bloğunu daha hızlı yapmak istiyorsak önce if yazıp ardından hemen 2 tane tab a bas

            if (sistemeGirisYapmisMi== true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            //eğer sisteme giriş yapılsaydı örneğin true da çalışırdı eger yapmamış yani false olsa çalışmazdı, bir de bu true false lar gerçek hayatta bir veri kaynağından gelir biz burda tamamen öğrenmek için true false olarak yazıyoruz
            // bu nasıl çalışıyo dersek bool değerine bakıyo true mu false mu diye






        }
    }
}




