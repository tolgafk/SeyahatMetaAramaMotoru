using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BilLab_Final
{
    internal class Firma : User
    {
        
        
        public static ArrayList giris1 = new ArrayList();
        public static ArrayList giris2 = new ArrayList();

        public static void firma_kur()
        {
            giris1.Add("a");
            giris2.Add("a1234");
            giris1.Add("b");
            giris2.Add("b1234");
            giris1.Add("c");
            giris2.Add("c1234");
            giris1.Add("d");
            giris2.Add("d1234");
            giris1.Add("e");
            giris2.Add("e1234");
        }
        
        public Firma()
        {
        }

        public static bool var_mi(string a)
        {
            for (int i = 0; i < giris1.Count; i++) 
            {
                if (giris1[i].ToString() == a)
                {
                    return true;
                }
            }
            return false;
        }
        public override int Login(string a, string b)
        {
            for (int i = 0; i<giris1.Count; i++)
            {
                String str1 = giris1[i].ToString();
                String str2 = giris2[i].ToString();
                if (str1 == a && str2 == b)
                {
                    return i + 2;
                }
                if (i == giris1.Count-1) break;
            }
            return 0;
        }
        public static int gunlukKar(int firma_no)
        {
            int modlama;
            int sayac = 0;
            for (int i = 0; i < 24; i++)
            {
                modlama = Form9.pzt.aracID[i] % 100;
                modlama /= 10;
                if (modlama == firma_no)
                {
                    for(int j = 0; j < Form9.pzt.doluluk[i].Length; j++)
                    {
                        if (Form9.pzt.doluluk[i][j] == 1)
                        {
                            sayac++;
                        }
                    }
                }
            }

            return 1;
        }
        public static void aracEkle(string yol, int Id)
        {
            
            if (yol == "Karayolu")
            {
                
                BusClass otobus = new BusClass(Id, 20, 3, 0, 10);
            }
            else if(yol == "Havayolu")
            {
                AirplaneClass ucak = new AirplaneClass(Id, 30, 5, 20);
            }
            else if (yol == "Demiryolu")
            {
                TrainClass tren = new TrainClass(Id, 25, 1, 3);
            }
        }
    }
}
