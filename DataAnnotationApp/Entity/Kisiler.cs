using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAnnotationApp.Entity
{
    [Table("Kisiler",Schema ="dbo")]
   public class Kisiler
    {
        [Key]
        [Column("KisiId",Order =0)]
        public Guid KisiId { get; set; }


        public Guid FirmaRefID { get; set; }


        [Column("KisiAdi")]
        [Required]
        [StringLength(40)]
        public string KisiAdi { get; set; }

        [StringLength(50)]
        public string Soyadi { get; set; }

        [Required(ErrorMessage ="mail giriniz")]
        [EmailAddress()]
        [MaxLength(100)]
        public string email { get; set; }


        [MaxLength(1000)]
        public byte[] Foto { get; set; }

        [ForeignKey("FirmaRefID")]
        public Firma firma { get; set; }

    }   
}       
        