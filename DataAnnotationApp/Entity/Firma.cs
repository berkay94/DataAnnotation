using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAnnotationApp.Entity
{
    [Table("Firma",Schema ="dbo")]
    public class Firma
    {
        [Key]
        [Column("FirmaId",Order =0)]
        public Guid FirmaId { get; set; }

        [Column("FirmaUnvani",Order =1,TypeName ="ntext")]
        public string Unvan { get; set; }

        [StringLength(500)]
        public string Adres { get; set; }

        [Column("TelefonNo",Order =3)]
        public string Tel1 { get; set; }

        public ICollection<Kisiler> Kisiler { get; set; }
    }
}
