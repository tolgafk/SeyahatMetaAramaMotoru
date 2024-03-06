namespace BilLab_Final
{
    internal static class Program 
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            List<Personel> list = new List<Personel>();
            list.Add(new Personel(5000, 0));
            list.Add(new Personel(5000, 0));
            list.Add(new Personel(2000, 0));
            list.Add(new Personel(2000, 0));
            list.Add(new Personel(5000, 1));
            list.Add(new Personel(5000, 1));
            list.Add(new Personel(2000, 1));
            list.Add(new Personel(2000, 1));

            list.Add(new Personel(3000, 2));
            list.Add(new Personel(3000, 2));
            list.Add(new Personel(1500, 2));
            list.Add(new Personel(1500, 2));
            list.Add(new Personel(3000, 3));
            list.Add(new Personel(3000, 3));
            list.Add(new Personel(1500, 3));
            list.Add(new Personel(1500, 3));

            list.Add(new Personel(4000, 4));
            list.Add(new Personel(4000, 4));
            list.Add(new Personel(2000, 4));
            list.Add(new Personel(2000, 4));
            list.Add(new Personel(10000, 5));
            list.Add(new Personel(10000, 5));
            list.Add(new Personel(6000, 5));
            list.Add(new Personel(6000, 5));
            list.Add(new Personel(10000, 6));
            list.Add(new Personel(10000, 6));
            list.Add(new Personel(6000, 6));
            list.Add(new Personel(6000, 6));

            list.Add(new Personel(2000, 7));
            list.Add(new Personel(2000, 7));
            list.Add(new Personel(1000, 7));
            list.Add(new Personel(1000, 7));
            list.Add(new Personel(2000, 8));
            list.Add(new Personel(2000, 8));
            list.Add(new Personel(1000, 8));
            list.Add(new Personel(1000, 8));
            list.Add(new Personel(2000, 9));
            list.Add(new Personel(2000, 9));
            list.Add(new Personel(1000, 9));
            list.Add(new Personel(1000, 9));

            list.Add(new Personel(7500, 10));
            list.Add(new Personel(7500, 10));
            list.Add(new Personel(4000, 10));
            list.Add(new Personel(4000, 10));
            list.Add(new Personel(7500, 11));
            list.Add(new Personel(7500, 11));
            list.Add(new Personel(4000, 11));
            list.Add(new Personel(4000, 11));
            

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Firma.firma_kur();
            Vehicle.arac_kur();
            
            ApplicationConfiguration.Initialize();
            
            Application.Run(new Form1());
        }
    }
}