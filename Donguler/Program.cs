using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = " Yazılım gelitrici kampı";
            string kurs2 = "Programcı kampı";
            string kurs3 = "java eğitim";

            //array- dizi demek şu şekilde tanımlanır: string[]

            string[] kurslar = new string[] { " Yazılım gelitrici kampı", "Programcı kampı", "java eğitim", "python", "c++"};




            for (int i = 0; i <kurslar.Length; i++) //burada kurslardan sonra .lenght eklememin sebebi verileri dinamiğe çevirip hangi kursu eklersem ekleyeyim kursların uzunluğu kadar yazılması 
            {
                Console.WriteLine(kurslar[i]); // burdaki i sayaç anlamına gelir ve döngüyü kontrol eder, anlamı şu: 1 den başla 10 dan küçük olduğu sürece çalış ve bir bir arttır, 10 olduğunda çalışmaz 
                                      // bunu çalıştırdığımızda 1,2,3,4,5,6,7,8,9 yazılır ama 10 u yazmaz çünkü 10 10 dan küçük değil fakat biz başta 10 dan küçük değilde, küçük eşittir 10 yapsaydık, 10 da yazılırdı
            }


            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar) // foreach dizilere uygulanır for un kolay halidir yerine yazılabilir, dizi temelli yapıları tek tek dönmeye yarıyor
            {

                Console.WriteLine(kurs);
            }

            
            Console.WriteLine("sayfa sonu - footer"); 
        }
    }
}
