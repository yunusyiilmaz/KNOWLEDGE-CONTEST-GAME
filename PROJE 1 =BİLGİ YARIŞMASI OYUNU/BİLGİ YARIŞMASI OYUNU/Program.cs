using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BİLGİ_YARIŞMASI_OYUNU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************");
            Console.WriteLine("BİLGİ YARIŞMASINA HOŞGELDİNİZ");
            Console.Title="BİLGİ YARIŞMASI OYUNU" ;            
            Console.Write("ADINIZ :");
            string ad=Console.ReadLine();
            Console.Write("SOYADINIZ :");
            string soyad=Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("MERHABA :"+ad+" "+"BEY");
            Console.WriteLine();
            Console.WriteLine("YARIŞMAMIZA HOŞ GELDİNİZ SİZE KURALLARI HATIRLATALIM.");
            Console.WriteLine();
            Console.WriteLine("HER SORUDAN SONRA ENTER TUŞUNA BASINIZ.");
            Console.WriteLine();
            Console.WriteLine("CEVAPLARI BÜYÜK HARFLE VERİNİZ .");
            Console.WriteLine();
            Console.WriteLine("BAŞARILAR.");
            Console.WriteLine("BAŞLAMAK İÇİN ENTERE BASINIZ");
            Console.ReadLine();
            Console.Clear();

            int doğru, yanliş, puan;
            doğru =0;
            yanliş =0;
            puan =0;

            Console.WriteLine("SORU-1: Türkiyenin başkenti neresidir ?");         
            Console.WriteLine(" A) İstanbul\n B) Trabzon\n C) Ankara\n D) Bursa\n " );
            Console.Write("CEVABINIZ :");
            string c1 = Console.ReadLine();
            if (c1=="C")
            {                
                doğru++;
                puan = puan + 1000;
                Console.WriteLine("TEBRİKLER ENTER TUŞUNA BASINIZ.");
                Console.ReadLine();
            }
            else
            {
                yanliş++;
                Console.WriteLine("CEVABINIZ YANLIŞ ENTER TUŞUNA BASINIZ");
                Console.ReadLine();
                
            }
            Console.Clear();
            Console.WriteLine("SORU-2: Türkiye'nin kaç bölgesi vardır ?");            
            Console.WriteLine(" A) 8\n B) 7\n C) 5\n D) 6\n ");
            Console.Write("CEVABINIZ :");
            string c2 = Console.ReadLine();
            if (c2 == "B")
            {
                doğru++;
                puan = puan + 1000;
                Console.WriteLine("TEBRİKLER ENTER TUŞUNA BASINIZ.");
                Console.ReadLine();
            }
            else
            {
                yanliş++;
                Console.WriteLine("CEVABINIZ YANLIŞ ENTER TUŞUNA BASINIZ");
                Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("SORU-3: TÜRKİYE HANGİ KITA ÜLKESİDİR ?");            
            Console.WriteLine(" A)Asya\n B)Afrika\n C)Avrupa\n D)Amerika\n");
            Console.Write("CEVABINIZ :");
            string c3 = Console.ReadLine();
            if (c3 == "A")
            {
                doğru++;
                puan = puan + 1000;
                Console.WriteLine("TEBRİKLER ENTER TUŞUNA BASINIZ.");
            }
            else
            {
                yanliş++;
                Console.WriteLine("CEVABINIZ YANLIŞ ENTER TUŞUNA BASINIZ");
                Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("SORU-4: Türkiyenin en büyük yüz ölçümü olan ili neresidir ?");            
            Console.WriteLine(" A) İstanbul\n B) Erzurum\n C) İzmir\n D) Konya\n ");
            Console.Write("CEVABINIZ :");
            string c4 = Console.ReadLine();
            if (c4 == "D")
            {
                doğru++;
                puan = puan + 1000;
                Console.WriteLine("TEBRİKLER ENTER TUŞUNA BASINIZ.");
                Console.ReadLine();
            }
            else
            {
                yanliş++;
                Console.WriteLine("CEVABINIZ YANLIŞ ENTER TUŞUNA BASINIZ");
                Console.ReadLine();
            }

            Console.Clear();

            Console.WriteLine("SORU-5: Türkiye'nin en kalabalık ili hangisidir ?");           
            Console.WriteLine(" A) İstanbul\n B) Trabzon\n C) Ankara\n D) Bursa\n ");
            Console.Write("CEVABINIZ :");
            string c5 = Console.ReadLine();
            if (c5 == "A")
            {
                doğru++;
                puan = puan + 1000;
                Console.WriteLine("TEBRİKLER ENTER TUŞUNA BASINIZ.");
                Console.ReadLine();
            }
            else
            {
                yanliş++;
                Console.WriteLine("CEVABINIZ YANLIŞ ENTER TUŞUNA BASINIZ");
                Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("SAYIN :"+ad+" "+soyad+"\n");
            Console.WriteLine("DOĞRU CEVAP SAYINIZ :"+doğru + "\n");
            Console.WriteLine("YANLIŞ CEVAP SAYINIZ :"+yanliş + "\n");
            Console.WriteLine("KAZANDIĞINIZ PARA :"+puan + "TL\n");
            Console.WriteLine("YARIŞMAMIZA KATILDIĞINIZ İÇİN TEŞEKKÜR EDERİZ.");


            Console.ReadLine();

           
        }
    }
}
