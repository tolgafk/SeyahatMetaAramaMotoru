using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilLab_Final
{
    public abstract class Vehicle
    {
        public int aracID;
        public int kapasite;
        public int sefer_no;
        private int kullananTL;
        private int hizmetliTL;


        public int AracID
        {
            get { return aracID; }
            set { aracID = value; }
        }

        public int Kapasite
        {
            get { return kapasite; }
            set { kapasite = value; }
        }

        //Constructor
        public Vehicle(int aracID, int kapasite, int sefer_no)
        {
            this.aracID = aracID;
            this.kapasite = kapasite;
            this.sefer_no = sefer_no;
        }

        public static List<Vehicle> araclar = new List<Vehicle>();
        public static void arac_kur()
        {
            

            // Araçları oluşturup listeye ekledim
            TrainClass tren1 = new TrainClass(041, 25, 1, 3);
            TrainClass tren2 = new TrainClass(042, 25, 2, 3);
            TrainClass tren3 = new TrainClass(043, 25, 2, 3);

            AirplaneClass ucak1_C = new AirplaneClass(231, 30, 5, 25);
            AirplaneClass ucak2_C = new AirplaneClass(232, 30, 5, 25);
            AirplaneClass ucak1_F = new AirplaneClass(251, 30, 6, 20);
            AirplaneClass ucak2_F = new AirplaneClass(252, 30, 6, 20);

            BusClass otobus1_A = new BusClass(111, 20, 3, 0, 10);
            BusClass otobus2_A = new BusClass(112, 15, 3, 0, 10);
            BusClass otobus1_B = new BusClass(121, 15, 3, 5, 0);
            BusClass otobus2_B = new BusClass(122, 20, 4, 5, 0);
            BusClass otobus1_C = new BusClass(131, 20, 4, 6, 0);

            araclar.Add(otobus1_A);
            araclar.Add(otobus2_A);
            araclar.Add(otobus1_B);
            araclar.Add(otobus2_B);
            araclar.Add(otobus1_C);
            araclar.Add(ucak1_C);
            araclar.Add(ucak2_C);
            araclar.Add(tren1);
            araclar.Add(tren2);
            araclar.Add(tren3);
            araclar.Add(ucak1_F);
            araclar.Add(ucak2_F);

        }
    }


    public class TrainClass : Vehicle
    {
        public int elektrikTL { get; set; }
        public TrainClass(int aracID, int kapasite, int sefer_no, int elektrikTL) : base(aracID, kapasite, sefer_no)
        {

        }


    }

    public class AirplaneClass : Vehicle
    {
        public int gazTL { get; set; }
        public AirplaneClass(int aracID, int kapasite, int sefer_no, int gazTL) : base(aracID, kapasite, sefer_no)
        {

        }

    }

    public class BusClass : Vehicle
    {
        public int motorinTL { get; set; }
        public int benzinTL { get; set; }
        public BusClass(int aracID, int kapasite, int sefer_no, int motorinTL, int benzinTL) : base(aracID, kapasite, sefer_no)
        {

        }

    }
}