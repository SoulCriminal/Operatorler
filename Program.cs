using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve işlemli Atama

            int a = 3;
            int b = 3;
            b = b+3;
            Console.WriteLine(b);  //3+3
            b += 3;
            Console.WriteLine(b);   //6+3
            b /=3;
            Console.WriteLine(b);   //9/3
            a *=b;
            Console.WriteLine(a);   //3*3


            //Mantıksal Operatörler

            //||,&&,!

            //İlişkisel operatörler
            // <,>,<=,>=,==,!=

            //DateTime tarih = DateTime.Now;
            string guncelyil = DateTime.Now.ToString("yyyy");


            // Kullanıcıdan bilgilerin alınması ve başvuru şartlarını karşılayıp karşılamaması
            Console.WriteLine("Lütfen Adınızı Soyadınızı Giriniz.");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen Doğum Yılınızı Giriniz.");
            int dogumYili = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Eğitim Durumunuzu Giriniz (örn: ilkokul-lise-üniversite)");
            string egitimDurum = Console.ReadLine();

            int yasi= Convert.ToInt32(guncelyil)-dogumYili;
            // kullanıcı yaşı ve eğitim durumunu kontrol eden kod
            if (yasi >=18 && (egitimDurum =="lise"||egitimDurum=="üniversite")){
                Console.WriteLine("Tebrikler "+ad+" başvurusu yapmaya hak kazandınız yaşınız: "+yasi);
            // yaşın 18 den büyük küçük olduğunu kontrol eden kod
            }else if (yasi <18) {
                Console.WriteLine("Yaşınız 18 den küçük! Malesef başvuru yapamazsınız");
            // eğitim durumunu sorgulayan kod
            }else if (egitimDurum !="lise"||egitimDurum !="üniversite"){
                Console.WriteLine("Malesef eğitim durumunuz lise yada üniversite olmalıdır.");
            // girilen bilgilerde hata olması durumunda gösterilecek mesaj
            }else{
                Console.WriteLine("Bilgilerde Hata var kontrol ederek tekrar deneyiniz!");
            }



            // Aritmatik Operatörler
            // /,*,+,-
        Console.WriteLine("\nAritmatik operatörler");
            int sayi1 = 4;
            int sayi2 = 2;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1-sayi2;
            Console.WriteLine(sonuc1);

            // % : mod alma oparatörü
            int sonuc2 = 5%2;
            Console.WriteLine("\n5 mod 2 ="+sonuc2);



        }
    }
}
