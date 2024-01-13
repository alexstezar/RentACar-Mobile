using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_Mobile_.Models
{
    public class Collection
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }

        [MaxLength(250), Unique]
        public string Description { get; set; }

        [ForeignKey(nameof(Car))]
        public int CarID { get; set; }

    }
}
