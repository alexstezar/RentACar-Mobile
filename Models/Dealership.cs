using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensions.Attributes;

namespace RentACar_Mobile_.Models
{
    public class Dealership
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Details { get { return Name + " " + Adress; } }

        [OneToMany]
        public List<Car> Cars { get; set; }

    }
}
