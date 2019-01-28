using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnnotationApp.Entity
{
    [Table("Adres", Schema = "dbo")]
    public class Adresler
    {
        [Key]
        [Column("AdresId")]
        public int AdresId { get; set; }


        [StringLength(500)]
        public string Adres1 { get; set; }

        [StringLength(500)]
        public string Adres2 { get; set; }



        [Phone(ErrorMessage ="Telefon numarasi hatalidir")]
        [StringLength(30)]
        public string Telefon { get; set; }


        [StringLength(50)]
        public string Ulke { get; set; }
    }
}
