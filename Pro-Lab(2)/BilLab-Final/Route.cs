using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace BilLab_Final
{
    public class Route
    {
        static string[] sehirler = new string[]
        {
             new string("İstanbul"),
             new string("Kocaeli"),
             new string("Bilecik"),
             new string("Eskisehir"),
             new string("Ankara"),
             new string("Konya"),
        };
        public string hangiYol;
        //yol 1-6
        public string kalkisNoktasi;
        public string varisNoktasi;
        public int aracID;
        public int mesafe;
        public int guzergah;
        public string gunAdi;
        private int kik = 100;
        private int kka = 400;
        private int kke = 200;
        private int kek = 300;
        private int dik = 75;
        private int dkb = 150;
        private int dbe = 75;
        private int dea = 75;
        private int dek = 150;
        private int hia = 250;
        private int hik = 300;
        public Route(string hangiYol, string kalkisNoktasi, string varisNoktasi, int aracID, int guzergah, string gunAdi)
        {
            this.hangiYol = hangiYol;
            this.kalkisNoktasi = kalkisNoktasi;
            this.varisNoktasi = varisNoktasi;
            this.aracID = aracID;
            this.guzergah = guzergah;
            this.gunAdi = gunAdi;
            int k_index = 0;
            int v_index = 0;
            for (int i = 0; i < sehirler.Length; i++)
            {
                if (sehirler[i] == kalkisNoktasi)
                {
                    k_index = i;
                }
                if (sehirler[i] == varisNoktasi)
                {
                    v_index = i;
                }
            }
            if (hangiYol == "Karayolu")
            {
                if ((k_index == 0 || v_index == 0) && (v_index == 1 || k_index == 1)) { mesafe = kik; }
                else if ((k_index == 0 || v_index == 0) && (v_index == 3 || k_index == 3)) { mesafe = kik+kke; }
                else if ((k_index == 0 || v_index == 0) && (v_index == 4 || k_index == 4)) { mesafe = kik+kka; }
                else if ((k_index == 0 || v_index == 0) && (v_index == 5 || k_index == 5)) { mesafe = kik+kke+kek; }

                else if ((k_index == 1 || v_index == 1) && (v_index == 3 || k_index == 3)) { mesafe = kke; }
                else if ((k_index == 1 || v_index == 1) && (v_index == 4 || k_index == 4)) { mesafe = kka; }
                else if ((k_index == 1 || v_index == 1) && (v_index == 5 || k_index == 5)) { mesafe = kke + kek; }
                
                else if ((k_index == 3 || v_index == 3) && (v_index == 5 || k_index == 5)) { mesafe = kek; }
            }

            else if (hangiYol == "Demiryolu")
            {
                if ((k_index == 0 || v_index == 0) && (v_index == 1 || k_index == 1)) { mesafe = dik; }
                else if ((k_index == 0 || v_index == 0) && (v_index == 2 || k_index == 2)) { mesafe = dik + dkb; }
                else if ((k_index == 0 || v_index == 0) && (v_index == 3 || k_index == 3)) { mesafe = dik + dkb + dbe; }
                else if ((k_index == 0 || v_index == 0) && (v_index == 5 || k_index == 5)) { mesafe = dik + dkb + dbe + dek; }
                else if ((k_index == 0 || v_index == 0) && (v_index == 4 || k_index == 4)) { mesafe = dik + dkb + dbe + dea; }

                else if ((k_index == 1 || v_index == 1) && (v_index == 2 || k_index == 2)) { mesafe = dkb; }
                else if ((k_index == 1 || v_index == 1) && (v_index == 3 || k_index == 3)) { mesafe = dkb + dbe; }
                else if ((k_index == 1 || v_index == 1) && (v_index == 4 || k_index == 4)) { mesafe = dkb + dbe + dea; }
                else if ((k_index == 1 || v_index == 1) && (v_index == 5 || k_index == 5)) { mesafe = dkb + dbe + dek; }

                else if ((k_index == 2 || v_index == 2) && (v_index == 3 || k_index == 3)) { mesafe = dbe; }
                else if ((k_index == 2 || v_index == 2) && (v_index == 4 || k_index == 4)) { mesafe = dbe + dea; }
                else if ((k_index == 2 || v_index == 2) && (v_index == 5 || k_index == 5)) { mesafe = dbe + dek; }

                else if ((k_index == 3 || v_index == 3) && (v_index == 4 || k_index == 4)) { mesafe = dea; }
                else if ((k_index == 3 || v_index == 3) && (v_index == 5 || k_index == 5)) { mesafe = dek; }
            }
            else if (hangiYol == "Havayolu")
            {
                if ((k_index == 0 || v_index == 0) && (v_index == 4 || k_index == 4)) { mesafe = hia; }
                else if ((k_index == 0 || v_index == 0) && (v_index == 5 || k_index == 5)) { mesafe = hik; }
            }
        }
         

        public class Seferler
        {
            public int[][] seferler1 = new int[24][];
            public int[] aracID = new int[24];
            public int[][] doluluk = new int[24][];


            public Seferler()
            {
                seferler1[0] = new int[3] {0, 1, 4 };
                aracID[0] = 111;

                seferler1[1] = new int[3] { 0, 1, 4 };
                aracID[1] = 112;

                seferler1[2] = new int[3] {0, 1, 4 };
                aracID[2] = 121;

                seferler1[3] = new int[4] {0, 1, 3, 5};
                aracID[3] = 122;

                seferler1[4] = new int[4] { 0, 1, 3, 5};
                aracID[4] = 131;

                seferler1[5] = new int[2] {0, 5 };
                aracID[5] = 231;

                seferler1[6] = new int[2] { 0, 5 };
                aracID[6] = 232;

                seferler1[7] = new int[5] { 0, 1, 2, 3, 4 };
                aracID[7] = 041;

                seferler1[8] = new int[5] { 0, 1, 2, 3, 5 };
                aracID[8] = 042;

                seferler1[9] = new int[5] { 0, 1, 2, 3, 5 };
                aracID[9] = 043;

                seferler1[10] = new int[2] { 0, 4 };
                aracID[10] = 251;

                seferler1[11] = new int[2] { 0, 4 };
                aracID[11] = 252;

                seferler1[12] = new int[3] { 0, 1, 4 };
                aracID[12] = 111;

                seferler1[13] = new int[3] { 0, 1, 4 };
                aracID[13] = 112;

                seferler1[14] = new int[3] { 0, 1, 4 };
                aracID[14] = 121;

                seferler1[15] = new int[4] { 0, 1, 3, 5 };
                aracID[15] = 122;

                seferler1[16] = new int[4] { 0, 1, 3, 5 };
                aracID[16] = 131;

                seferler1[17] = new int[2] { 0, 5 };
                aracID[17] = 231;

                seferler1[18] = new int[2] { 0, 5 };
                aracID[18] = 232;

                seferler1[19] = new int[5] { 0, 1, 2, 3, 4 };
                aracID[19] = 041;

                seferler1[20] = new int[5] { 0, 1, 2, 3, 5 };
                aracID[20] = 042;

                seferler1[21] = new int[5] { 0, 1, 2, 3, 5 };
                aracID[21] = 043;

                seferler1[22] = new int[2] { 0, 4 };
                aracID[22] = 251;

                seferler1[23] = new int[2] { 0, 4 };
                aracID[23] = 252;

                Random random = new Random();
                int bosluk = 15;
                int az_cok;
               
                for (int i = 0, z = 0; i <24; i++, z++)
                {
                    az_cok = random.Next(1, 3);
                    if (az_cok == 1)
                    {
                        bosluk = random.Next(0, 5);
                    }
                    else if (az_cok == 2)
                    {
                        bosluk = random.Next(10, 15);
                    }
                    if (Vehicle.araclar[z].AracID == aracID[i])
                    {
                        doluluk[i] = new int[Vehicle.araclar[z].kapasite];
                        for (int j = 0; j < bosluk; j++)
                        {
                            int bos_koltuk = random.Next(1, Vehicle.araclar[z].kapasite);
                            doluluk[i][bos_koltuk] = 2; 
                        }
                        for (int j = 0;j < Vehicle.araclar[z].kapasite; j++)
                        {
                            if (doluluk[i][j] != 2)
                            {
                                doluluk[i][j] = 1;
                            }
                        }
                    }
                    if(z == 11) z = -1;
                }
            }
        }

        public class Sehir
        {
            public string SehirAdi { get; set; }

            public Sehir(string sehirAdi)
            {
                SehirAdi = sehirAdi;
            }

            public static string sehir_adi_dondur(int a)
            {
                return sehirler[a];
            }
        }
        public class AltSeferler
        {
            public static List<Route> seferlerListesi = new List<Route>();
            public static void sefer_kur(int a, int b, string gunAdi)
            {
                seferlerListesi.Clear();
                int kalkisIndex = a;
                string kalkisSehir = sehirler[kalkisIndex];

                int varisIndex = b;
                string varisSehir = sehirler[varisIndex];

                string yol;

                
                Route.Seferler gun = Form9.pzt;
                        
                
                // Seçilen şehirler arasındaki seferleri ekleyen döngü
                if (a < b)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        if (gun.seferler1[i].Contains(a) && gun.seferler1[i].Contains(b))
                        {
                            if (i >= 0 && i < 5)
                            {
                                seferlerListesi.Add(new Route("Karayolu", kalkisSehir, varisSehir, gun.aracID[i], i, gunAdi));
                            }
                            else if (i > 6 && i < 10)
                            {
                                seferlerListesi.Add(new Route("Demiryolu", kalkisSehir, varisSehir, gun.aracID[i], i, gunAdi));
                            }
                            else
                            {
                                seferlerListesi.Add(new Route("Havayolu", kalkisSehir, varisSehir, gun.aracID[i], i, gunAdi));
                            }
                        }
                    }
                }
                else if (a > b)
                {
                    for (int i = 12; i < 24; i++)
                    {
                        if (gun.seferler1[i].Contains(a) && gun.seferler1[i].Contains(b))
                        {
                            if (i >= 12 && i < 17)
                            {
                                seferlerListesi.Add(new Route("Karayolu", kalkisSehir, varisSehir, gun.aracID[i], i, gunAdi));
                            }
                            else if (i > 18 && i < 22)
                            {
                                seferlerListesi.Add(new Route("Demiryolu", kalkisSehir, varisSehir, gun.aracID[i], i, gunAdi));
                            }
                            else
                            {
                                seferlerListesi.Add(new Route("Havayolu", kalkisSehir, varisSehir, gun.aracID[i], i, gunAdi));
                            }
                        }
                    }
                }
                
            }
        }
    }
}