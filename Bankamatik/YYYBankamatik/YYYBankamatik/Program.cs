using System;

namespace YYYBankamatik
{
    class Program
    {
        static double bakiye = 250;
        static string dogrusifre = "ab18";

        static void Main(string[] args)
        {
        basla:

            Yaz("Yavuz Yağmur Yanık Bankamatiğe hoş geldiniz");
            Yaz();


            if (kullanicigirisi())
            {
                Ana_menu();
            }
            else
            {
                cikis();
            }








            Console.WriteLine();
            Console.ReadLine();
        bitis:
            goto basla;

        }
        //************************************** ANA METODUN DISI****************************************************

        public static bool kullanicigirisi()
        {
            int sayac = 3;
            do
            {
                Yaz("Sifrenizi Giriniz");
                string sifre = GirString();
                if (sifre == dogrusifre) { Yaz("Giris Basarili"); System.Threading.Thread.Sleep(500); return true; }
                else { sayac--; Yaz("Şifre hatalı " + sayac + " deneme hakkınız kaldı "); }

            } while (sayac > 0);

            Console.WriteLine("KARTINIZ BLOKE OLDU");
            System.Threading.Thread.Sleep(2500);
            return false;

        }




        /// <summary>
        /// YAZMA METODU
        /// </summary>
        /// <param name="deger"></param>
        public static void Yaz(string deger)
        {
            Console.WriteLine(deger);
        }

        /// <summary>
        /// YILDIZ YAZDIRMA METODU
        /// </summary>
        public static void Yaz()
        {
            Console.WriteLine("********************************************************");
        }

        /// <summary>
        /// DOUBLE GIRME METODU
        /// </summary>
        /// <returns></returns>
        public static double Gir()
        {


            do
            {
                try
                {
                    double mirnavkedi = Convert.ToDouble(Console.ReadLine());
                    if (mirnavkedi >= 0)
                    {
                        return mirnavkedi;
                    }
                    else { Console.WriteLine("pozitif deger giriniz"); }

                }
                catch (Exception)
                {

                    Console.WriteLine("lütfen sadece rakam giriniz");
                }
            } while (true);
        }

        /// <summary>
        /// STRİNG GİRİS
        /// </summary>
        /// <returns></returns>
        public static string GirString()
        {

            do
            {
                try
                {
                    return Console.ReadLine();
                }
                catch (Exception)
                {


                }
            } while (true);


        }





        /// <summary>
        /// ANA MENU
        /// </summary>
        /// 
        public static void Ana_menu()
        {
            bool tekrar = false;
            do
            {
                Console.Clear();
                Yaz("***ANA MENU***");
                Yaz();
                Yaz("Kartlı işlem    1");
                Yaz("Kartsız işlem   2");
                Yaz();
                double deger = Gir();
                if (deger == 1) { Kartli_islem_menu(); }
                else if (deger == 2) { Kartsiz_islem_menu(); }
                else { tekrar = true; }
            } while (tekrar);

        }


        /// <summary>
        /// KARTLI ISLEM MENUSU
        /// </summary>
        public static void Kartli_islem_menu()
        {
            bool tekrar = false;
            do
            {
                Console.Clear();
                Yaz("***KARTLI ISLEM MENUSU***");
                Yaz();
                Yaz("Para Çekmek için    1");
                Yaz("Para yatırmak için  2");
                Yaz("Para Transferleri   3");
                Yaz("Eğitim Ödemeleri    4");
                Yaz("Odemeler            5");
                Yaz("Bilgi Güncelleme    6");
                Yaz();
                double deger = Gir();
                if (deger == 1) { Para_cekme(); }
                else if (deger == 2) { Para_yatirma(); }
                else if (deger == 3) { Para_transferleri(); }
                else if (deger == 4) { Egitim_odemeleri(); }
                else if (deger == 5) { Odemeler(); }
                else if (deger == 6) { Bilgi_guncelleme(); }
                else { tekrar = true; }


            } while (tekrar);
        }



        /// <summary>
        /// PARA CEKME MENUSU
        /// </summary>
        public static void Para_cekme()
        {

            do
            {
                Console.Clear();
                Yaz("***PARA CEKME MENUSU***");
                Yaz();
                Yaz("Ana menu: 9");
                Yaz("Çikis: 0");
                Yaz("Devam: 1");
                Yaz();
                double deger = Gir();
                if (deger == 9)
                {
                    Ana_menu();
                }
                if (deger == 0)
                {
                    cikis();
                }
                if (deger == 1)
                {
                    Yaz(" Bakiye" + bakiye + "tl Kaç tl cekmek istersiniz?");
                    double Cekilen = Gir();
                    if (Cekilen <= bakiye && Cekilen > 0)
                    {
                        Yaz("çekilen miktar " + Cekilen + " Kalan Bakiye " + (bakiye - Cekilen)); System.Threading.Thread.Sleep(2000); cikis();

                    }
                    else { Yaz("Hatali giriş"); System.Threading.Thread.Sleep(1000); }
                }
            } while (true);

        }

        /// <summary>
        /// PARA YATIRMA MENUSU
        /// </summary>
        public static void Para_yatirma()
        {
            do
            {
                Console.Clear();
                Yaz("***PARA YATIRMA MENUSU***");
                Yaz();
                Yaz("Ana menu: 9");
                Yaz("Çikis: 0");
                Yaz("Kredi kartina: 1");
                Yaz("Kendi hesabina: 2");
                Yaz();
                double deger = Gir();
                if (deger == 9)
                {
                    Ana_menu();
                }
                if (deger == 0)
                {
                    cikis();
                }
                if (deger == 1)
                {
                    Console.Clear();
                    Yaz("Kredi Kartına para yatırmak için 12 Haneli kredi kartı numarasini giriniz");
                    double kredikarti = Gir();
                    if (kredikarti > 99999999999)
                    {
                        Yaz("yatirmak istediğiniz tutari giriniz bakiyeniz 250tl");
                        double girilen = Gir();
                        if (girilen <= bakiye) { Yaz(kredikarti + " numarali kredi kartina " + girilen + " tl gönderdiniz, kalan bakiye " + (bakiye - girilen)); bakiye -= girilen; System.Threading.Thread.Sleep(2000); cikis(); }
                    }
                    else
                    {
                        Yaz("Hatali giris yaptiniz");
                        System.Threading.Thread.Sleep(2000);
                        Para_yatirma();
                    }
                }
                if (deger == 2)
                {
                    Yaz("Kaç tl yatırmak istiyorsunuz?");
                    double kedicik = Gir();
                    Yaz(kedicik + "tl hesabiniza yatirildi");
                }


            } while (true);

        }




        /// <summary>
        /// PARA TRANSFERİ MENUSU
        /// </summary>
        public static void Para_transferleri()
        {

            do
            {
                Console.Clear();
                Yaz("***PARA TRANSFER MENUSU***");
                Yaz();
                Yaz("Ana menu: 9");
                Yaz("Çikis: 0");
                Yaz("Başka Hesaba EFT: 1");
                Yaz("Başka Hesaba Havale 2");
                Yaz();
                double deger = Gir();
                if (deger == 9)
                {
                    Ana_menu();
                }
                if (deger == 0)
                {
                    cikis();
                }
                if (deger == 1)
                {

                    EFT();


                }
                if (deger == 2)
                {
                    Yaz("11 haneli hesap numarasi giriniz");
                    string hesapno = GirString();
                    if (hesapno.Length == 11)
                    {
                        Console.WriteLine("yatırılacak miktarı giriniz");
                        double hesabahavale = Gir();
                        Yaz(hesapno + " hesabına " + hesabahavale + "tl gonderdiniz");
                        System.Threading.Thread.Sleep(2000);
                        cikis();

                    }
                    else
                    {
                        Yaz("Hesap no 11 karakterden olusmalidir");
                    }


                }


            } while (true);

        }



        /// <summary>
        /// EFT GONDERME
        /// </summary>
        public static void EFT()
        {
            try
            {
                Yaz("Başında TR olacak ve devamında 12 adet rakam olacak sekilde 14 haneli EFT numarasını giriniz");
                string girileneft = Console.ReadLine().ToUpper();
                if (girileneft[0] is 'T' && girileneft[1] is 'R' && girileneft.Length == 14)
                {
                    Yaz("basarili");

                    double EFTsayi = Convert.ToDouble(Char.ToString(girileneft[2]) + Convert.ToDouble(Char.ToString(girileneft[3])) + Convert.ToDouble(Char.ToString(girileneft[4])) + Convert.ToDouble(Char.ToString(girileneft[5])) + Convert.ToDouble(Char.ToString(girileneft[6])) + Convert.ToDouble(Char.ToString(girileneft[7])) + Convert.ToDouble(Char.ToString(girileneft[8])) + Convert.ToDouble(Char.ToString(girileneft[9])) + Convert.ToDouble(Char.ToString(girileneft[10])) + Convert.ToDouble(Char.ToString(girileneft[11])) + Convert.ToDouble(Char.ToString(girileneft[12])) + Convert.ToDouble(Char.ToString(girileneft[13])));

                    Console.WriteLine("TR alan kodlu " + EFTsayi + " numaralı hesaba kaç tl gondermek istersiniz? ");
                    double sarikedi = Gir();
                    Yaz(sarikedi + "tl gönderdiniz");
                    System.Threading.Thread.Sleep(2000);
                    cikis();
                }
                else { Yaz("Eft numarası TR ile başlamalı ve 12 rakam içermelidir"); }


                System.Threading.Thread.Sleep(2000);
            }
            catch (Exception)
            {

                Yaz("lütfen doğru formatta giriş yapınız");
            }

        }





        /// <summary>
        /// EDİGİM ODEMELERİ MENUSU
        /// </summary>
        public static void Egitim_odemeleri()
        {

            do
            {
                Console.Clear();
                Yaz("***EGITIM ODEME MENUSU***");
                Yaz();
                Yaz("Eğitim ödemeleri sayfası arızalı");
                Yaz("Ana menu: 9");
                Yaz("Çikis: 0");
                Yaz();

                double deger = Gir();
                if (deger == 9)
                {
                    Ana_menu();
                }
                if (deger == 0)
                {
                    cikis();
                }


            } while (true);

        }

        /// <summary>
        /// ODEMELER MENUSU
        /// </summary>
        public static void Odemeler()
        {

            do
            {
                Console.Clear();
                Yaz("***ODEMELER MENUSU***");
                Yaz();
                Yaz("Ana menu: 9");
                Yaz("Çikis: 0");
                Yaz("Elektrik Faturası 1");
                Yaz("Telefon Faturası 2");
                Yaz("İnternet Faturası 3");
                Yaz("Su Faturası 4");
                Yaz("OGS odenemeri 5");
                Yaz();
                double deger = Gir();
                if (deger == 9)
                {
                    Ana_menu();
                }
                if (deger == 0)
                {
                    cikis();
                }
                if (deger == 1)
                {
                    Odememetot("elektrik");
                }
                if (deger == 2)
                {
                    Odememetot("telefon");
                }
                if (deger == 3)
                {
                    Odememetot("internet");
                }
                if (deger == 4)
                {
                    Odememetot("su");
                }
                if (deger == 5)
                {
                    Odememetot("OGS");
                }


            } while (true);

        }


        public static void Odememetot(string odemeturu)
        {
            Yaz("Fatura tutarini giriniz");
            double faturatutari = Gir();
            switch (odemeturu)
            {
                case "elektrik":

                    Yaz("elektrik faturanız " + faturatutari + "tl ödendi");
                    System.Threading.Thread.Sleep(2000);
                    cikis();

                    break;

                case "telefon:":

                    Yaz("telefon faturanız " + faturatutari + "tl ödendi");
                    System.Threading.Thread.Sleep(2000);
                    cikis();

                    break;
                case "internet":

                    Yaz("internet faturanız " + faturatutari + "tl ödendi");
                    System.Threading.Thread.Sleep(2000);
                    cikis();

                    break;
                case "su":

                    Yaz("su faturanız " + faturatutari + "tl ödendi");
                    System.Threading.Thread.Sleep(2000);
                    cikis();

                    break;
                case "OGS":

                    Yaz("OGS faturanız " + faturatutari + "tl ödendi");
                    System.Threading.Thread.Sleep(2000);
                    cikis();

                    break;



                default:
                    break;
            }

        }









        /// <summary>
        /// BİLGİ GUNCELLEME MENUSU
        /// </summary>
        public static void Bilgi_guncelleme()
        {

            do
            {
                Console.Clear();
                Yaz("***BILGI GUNCELLEME MENUSU***");
                Yaz();
                Yaz("Ana menu: 9");
                Yaz("Çikis: 0");
                Yaz("Sifre değistirme: 1");
                Yaz();
                double deger = Gir();
                if (deger == 9)
                {
                    Ana_menu();
                }
                if (deger == 0)
                {
                    cikis();
                }
                if (deger == 1)
                {
                    sifredegis();
                }


            } while (true);

        }



        public static void sifredegis()
        {
            Console.Clear();
            string yenitut = "0";
            string yenitut2 = "1";
            do
            {
                Yaz("Mevcut sifrenizi giriniz");
                if (GirString() == dogrusifre)
                {
                    Yaz("Yeni şifrenizi giriniz");
                    yenitut = GirString();
                    Yaz("Yeni şifrenizi tekrar giriniz");
                    yenitut2 = GirString();
                    if (yenitut == yenitut2)
                    {
                        Yaz("yeni şifreniz " + yenitut + " olarak degistirildi");
                        dogrusifre = yenitut;
                        System.Threading.Thread.Sleep(2000);

                    }
                    else
                    {
                        Yaz("girdiğiniz şifreler eşleşmiyor");
                    }
                }


            } while (yenitut != yenitut2);
        }








        /// <summary>
        /// KARTSIZ ISLEM MENUSU
        /// </summary>
        public static void Kartsiz_islem_menu()
        {
            Console.Clear();
            Yaz("***KARTSIZ ISLEM MENUSU***");
            Yaz("kartsız işlem bulunmamaktadir. Ana menuye yonlendiriliyorsunuz");
            System.Threading.Thread.Sleep(2000);
            Ana_menu();

        }



        /// <summary>
        /// PROGRAMI KAPATMA
        /// </summary>
        public static void cikis()
        {
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Yaz("KARTINIZI CIKARINIZ");
            System.Threading.Thread.Sleep(1000);
            Environment.Exit(-1);
        }



    }
}
