using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace E_Ticaret.Models
{
    [Table("Kullanıcı")]
    public class Login
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100),Required]
        public string KullaniciAdi { get; set; }

        [StringLength(100),Required]
        public string Sifre { get; set; }
    }
}