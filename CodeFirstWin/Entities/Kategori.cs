using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWin.Entities
{

    
    public  class Kategori:BaseEntity
    {

        // Ef Id alanini gordugunde primary key kabul eder
       

        [Column("AdKategori")]
        [StringLength(50)]
        [Required]
        public string KategoriAdi { get; set; }
        
        
        [StringLength(100)]
        public string Aciklama { get; set; }

        public List<Stok> Stoklar { get; set; }

        public Kategori? UstKategori { get; set; }
        public List<Kategori> AltKategoriler { get; set; }
    }
}
