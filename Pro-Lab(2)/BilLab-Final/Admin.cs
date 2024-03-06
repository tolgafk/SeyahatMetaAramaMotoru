using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BilLab_Final
{
    internal class Admin : User
    {
        private string kullanici_ad = "admin";
        private string sifre = "admin";
        public static int hizmet_bedeli = 1000;
        

        public override int Login(string Kullanici_ad, string Sifre)
        {
            if (Kullanici_ad == kullanici_ad)
            {
                if (Sifre == sifre)
                { 
                    return 1;
                }
                return 0;
            }
            else { return 0; };
        }

        public void firma_sil(int b)
        {
            int a = 0;
            if(Firma.giris1[b] == "a")
            {
                a = 1;
            }
            else if (Firma.giris1[b] == "b")
            {
                a = 2;
            }
            else if (Firma.giris1[b] == "c")
            {
                a = 3;
            }
            else if (Firma.giris1[b] == "d")
            {
                a = 4;
            }
            else if (Firma.giris1[b] == "f")
            {
                a = 5;
            }

            Firma.giris1[b] = -1;
            Firma.giris2[b] = -1;
            int modlama;
            for (int i = 0; i < Form9.pzt.aracID.Length; i++)
            {
                modlama = Form9.pzt.aracID[i]%100;
                modlama /= 10;
                
                if (modlama == a)
                {
                    for (int j = 0; j < Form9.pzt.seferler1[i].Length; j++)
                    {
                        Form9.pzt.seferler1[i][j] = -1;
                        Form9.sal.seferler1[i][j] = -1;
                        Form9.car.seferler1[i][j] = -1;
                        Form9.per.seferler1[i][j] = -1;
                        Form9.cum.seferler1[i][j] = -1;
                        Form9.cmt.seferler1[i][j] = -1;
                        Form9.pzr.seferler1[i][j] = -1;
                    }
                    for (int j = 0; j < Form9.pzt.doluluk[i].Length; j++)
                    {
                        Form9.pzt.doluluk[i][j] = -1;
                        Form9.sal.doluluk[i][j] = -1;
                        Form9.car.doluluk[i][j] = -1;
                        Form9.per.doluluk[i][j] = -1;
                        Form9.cum.doluluk[i][j] = -1;
                        Form9.cmt.doluluk[i][j] = -1;
                        Form9.pzr.doluluk[i][j] = -1;
                    }
                    Form9.pzt.aracID[i] = -1;
                    Form9.sal.aracID[i] = -1;
                    Form9.car.aracID[i] = -1;
                    Form9.per.aracID[i] = -1;
                    Form9.cum.aracID[i] = -1;
                    Form9.cmt.aracID[i] = -1;
                    Form9.pzr.aracID[i] = -1;



                }
            }
        }

        public void firma_ekle(String a, String b)
        {
            Firma.giris1.Add(a);
            Firma.giris2.Add(b);
        }
        
    }
}
