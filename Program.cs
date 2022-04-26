/****************************************************************************
**					        SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				        BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				       NESNEYE DAYALI PROGRAMLAMA DERSİ
**					        2021-2022 BAHAR DÖNEMİ
**	
**				        ÖDEV NUMARASI:1. ÖDEV
**				        ÖĞRENCİ ADI:SUDE ÖZKANOĞLU
**				        ÖĞRENCİ NUMARASI:G201210034
**                      DERSİN ALINDIĞI GRUP:II. ÖĞRETİM C GRUBU
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değişkenlerimizi tanımladık
            string sifre;
            int rToplam;
            int bToplam;
            int kToplam;
            int sToplam;
            int tumToplam;
            
            //Kullanıcıdan şifreyi aldık
            Console.WriteLine("Lütfen Şifre Giriniz...");
            sifre = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            //Şifrenin boşluk içerip içermediğini kontrol ettik
            for (int d = 0; d < sifre.Length; d++)
            {
                if (sifre[d] == (char)ConsoleKey.Spacebar)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;                         //Hataları belirtmek için yazı rengini kırmızı yaptık
                    Console.WriteLine("Şifre Kabul Edilemez! Şifre Boşluk İçermemelidir.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            //Static methodlarla şifre içinden puanlama yapacağımız kadar değişkenlerin sayısını aldık
            rToplam = SifreKontrol.rakam(sifre);
            bToplam = SifreKontrol.bHarf(sifre);
            kToplam = SifreKontrol.kHarf(sifre);
            sToplam = SifreKontrol.sembol(sifre);

            //Ekrana puanlamaya girecek olan değişkenlerin sayısını yazdırdık
            Console.WriteLine("Puanlamaya Girecek Rakam Sayısı:{0}", rToplam);
            Console.WriteLine("Puanlamaya Girecek Büyük Harf Sayısı:{0}", bToplam);
            Console.WriteLine("Puanlamaya Girecek Küçük Harf Sayısı:{0}", kToplam);
            Console.WriteLine("Puanlamaya Girecek Sembol Sayısı:{0}", sToplam);
            Console.WriteLine();

            //Şifre uzunluğumuzu kontrol ettik 
            if (sifre.Length > 9)
            {
                tumToplam = (rToplam + bToplam + kToplam + sToplam) * 10;

                //Şifrenin değişkenleri içerip içermediğini kontrol ettik
                if (rToplam == 0 && kToplam == 0 && bToplam == 0 && sToplam == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Şifre Kabul Edilemez!");
                }
                else if (rToplam == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Şifre Kabul Edilemez! Şifre Rakam,Küçük Harf,Büyük Harf ve Sembol İçermek Zorundadır!");
                }
                else if (kToplam == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Şifre Kabul Edilemez! Şifre Rakam,Küçük Harf,Büyük Harf ve Sembol İçermek Zorundadır!");
                }
                else if (bToplam == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Şifre Kabul Edilemez! Şifre Rakam,Küçük Harf,Büyük Harf ve Sembol İçermek Zorundadır!");
                }
                else if (sToplam == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Şifre Kabul Edilemez! Şifre Rakam,Küçük Harf,Büyük Harf ve Sembol İçermek Zorundadır!");
                }
                else
                {
                    //Şifre puanlarını kontrol ettik
                    if (tumToplam < 70)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Şifre Kabul Edilemez! Puan 70'ten Küçüktür!");
                        Console.WriteLine("Şifre Puanı:{0}", tumToplam);
                    }
                    else if (tumToplam >= 70 && tumToplam < 90)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;                   //Şifrenin kabul edildiğini belirtmek için yazı rengini yeşil yaptık
                        Console.WriteLine("Şifre Kabul Edilir!");
                        Console.WriteLine("Şifre Puanı:{0}", tumToplam);
                    }
                    else if (tumToplam >= 90 && tumToplam <= 100)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Şifre Kabul Edilir! Şifre Güçlüdür!");
                        Console.WriteLine("Şifre Puanı:{0}", tumToplam);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Şifre Kabul Edilir!");
                        Console.WriteLine("Şifre Puanı:{0}", tumToplam);
                    }
                }
            }
            else if (sifre.Length == 9)
            {
                //Şifre uzunluğu 9'a eşitse şifreye 10 puan daha ekledik
                tumToplam = (rToplam + bToplam + kToplam + sToplam) * 10;
                tumToplam = tumToplam + 10;

                //Şifrenin değişkenleri içerip içermediğini kontrol ettik
                if (rToplam == 0 && kToplam == 0 && bToplam == 0 && sToplam == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Şifre Kabul Edilemez!");
                }
                else if (rToplam == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Şifre Kabul Edilemez! Şifre Rakam,Küçük Harf,Büyük Harf ve Sembol İçermek Zorundadır!");
                }
                else if (kToplam == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Şifre Kabul Edilemez! Şifre Rakam,Küçük Harf,Büyük Harf ve Sembol İçermek Zorundadır!");
                }
                else if (bToplam == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Şifre Kabul Edilemez! Şifre Rakam,Küçük Harf,Büyük Harf ve Sembol İçermek Zorundadır!");
                }
                else if (sToplam == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Şifre Kabul Edilemez! Şifre Rakam,Küçük Harf,Büyük Harf ve Sembol İçermek Zorundadır!");
                }
                else
                {
                    //Şifre puanlarını kontrol ettik
                    if (tumToplam < 70)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Şifre Kabul Edilemez! Puan 70'ten Küçüktür!");
                        Console.WriteLine("Şifre Puanı:{0}", tumToplam);
                    }
                    else if (tumToplam >= 70 && tumToplam < 90)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Şifre Kabul Edilir!");
                        Console.WriteLine("Şifre Puanı:{0}", tumToplam);
                    }
                    else if (tumToplam >= 90 && tumToplam <= 100)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Şifre Kabul Edilir! Şifre Güçlüdür!");
                        Console.WriteLine("Şifre Puanı:{0}", tumToplam);
                    }
                    else if (tumToplam > 100)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Şifre Kabul Edilir!");
                        Console.WriteLine("Şifre Puanı:{0}", tumToplam);
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Şifre 9 Haneden Az!");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
    //ŞifreKontrol adında bir static class tanımladık
    static class SifreKontrol
    {
        //Static public int rakam methodumuzu tanımladık
        static public int rakam(string rSifreMethod)
        {
            string rakamlar = "1,2,3,4,5,6,7,8,9,0";
            string rSifre = rSifreMethod;
            int count = 0;

            //Şifrenin içerisindeki rakam sayısını kontrol eden for döngüsünü yazdık
            for (int i = 0; i < rSifre.Length; i++)
            {
                if (rakamlar.Contains(rSifre[i]))
                {
                    if (count < 2)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return count;
        }

        //Static public int bHarf methodumuzu tanımadık
        static public int bHarf(string bSifreMethod)
        {
            string büyükHarf = "A,B,C,Ç,D,E,F,G,Ğ,H,I,İ,J,K,L,M,N,O,Ö,P,R,S,Ş,T,U,Ü,V,Y,Z,X,W,Q";
            string bSifre = bSifreMethod;
            int count1 = 0;

            //Şifre içerisindeki büyük harf sayısını kontrol eden for döngüsü yazdık
            for (int j = 0; j < bSifre.Length; j++)
            {
                if (büyükHarf.Contains(bSifre[j]))
                {
                    if (count1 < 2)
                    {
                        count1++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return count1;
        }
        
        //Static public int kHarf methodumuzu tanımladık
        static public int kHarf(string kSifreMethod)
        {
            string kücükHarf = "a,b,c,ç,d,e,f,g,ğ,h,ı,i,j,k,l,m,n,o,ö,p,r,s,ş,t,u,ü,v,y,z,x,w,q";
            string kSifre = kSifreMethod;
            int count2 = 0;

            //Şifre içerisindeki küçük harf sayısını kontrol eden for döngüsü yazdık
            for (int k = 0; k < kSifre.Length; k++)
            {
                if (kücükHarf.Contains(kSifre[k]))
                {
                    if (count2 < 2)
                    {
                        count2++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return count2;
        }

        //Static public int sembol methodumuzu tanımladık
        static public int sembol(string sSifreMethod)
        {
            string semboller;
            
            //Sembol sayısını bulabilmek için şifre içerisindeki rakam,büyük ve küçük harf sayısını hesapladık
            string rakamlarSembol = "1,2,3,4,5,6,7,8,9,0";
            string rSifreSembol = sSifreMethod;
            int count4 = 0;

            for (int a = 0; a < rSifreSembol.Length; a++)
            {
                if (rakamlarSembol.Contains(rSifreSembol[a]))
                {
                    count4++;
                }
            }

            string büyükHarfSembol = "A,B,C,Ç,D,E,F,G,Ğ,H,I,İ,J,K,L,M,N,O,Ö,P,R,S,Ş,T,U,Ü,V,Y,Z,X,W,Q";
            string bSifreSembol = sSifreMethod;
            int count5 = 0;

            for (int b = 0; b < bSifreSembol.Length; b++)
            {
                if (büyükHarfSembol.Contains(bSifreSembol[b]))
                {
                    count5++;
                }
            }

            string kücükHarfSembol = "a,b,c,ç,d,e,f,g,ğ,h,ı,i,j,k,l,m,n,o,ö,p,r,s,ş,t,u,ü,v,y,z,x,w,q";
            string kSifreSembol = sSifreMethod;
            int count6 = 0;

            for (int c = 0; c < kSifreSembol.Length; c++)
            {
                if (kücükHarfSembol.Contains(kSifreSembol[c]))
                {
                    count6++;
                }
            }

            //Sembol sayısını bulabilmek için diğer değişken sayılarının toplamını şifre uzunluğundan çıkarttık
            return sSifreMethod.Length - (count4 + count5 + count6);
        }
    }
}
