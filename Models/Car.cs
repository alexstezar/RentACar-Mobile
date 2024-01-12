using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace RentACar_Mobile_.Models
{
    public class Car
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }

        [MaxLength(250), Unique]
        public string Description { get; set; }
        public string Collection { get; set; }

        [ForeignKey(nameof(Car))]
        public int CarId {  get; set; }
         
    }
}
