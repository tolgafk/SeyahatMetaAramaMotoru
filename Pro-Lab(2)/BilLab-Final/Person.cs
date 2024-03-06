using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilLab_Final
{
    public abstract class Person
    {
        public String name;
        public String surname;
        public string getName() {  return name; }
        public void setName(String name) { this.name = name; }
        public string getSurname() { return surname; }
        public void setSurname(String surname) { this.surname = surname; }
    }
}
