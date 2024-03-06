using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BilLab_Final
{
    internal class Personel : Person
    {
        private int maas;
        public int getMaas() {  return maas; }
        public void setMaas(int m) { maas = m; }
        private int seferIndeks;
        public int getSefer() {  return seferIndeks; }
        public void setSefer(int i) { seferIndeks = i; }
        public Personel(int maas, int sefer_indeks) 
        {
            setName("Ozan");
            setSurname("Mullaoğlu");
            setMaas(maas);
            setSefer(sefer_indeks);
        }
    }
}
