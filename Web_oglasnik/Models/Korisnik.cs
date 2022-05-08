using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Web_oglasnik.Models
{
    [Table("korisnici")]
    public class Korisnik
    {
        [Key]
        [Display(Name = "ID korisnika")]
        public int ID { get; set; }

        [Column("ime")]
        [Display(Name = "Ime korisnika")]
        public string Ime { get; set; }

        [Column("prezime")]
        [Display(Name = "Prezime korisnika")]
        public string Prezime { get; set; }

        [Column("email")]
        [Display(Name = "Email korisnika")]
        public string Email { get; set; }

        [Column("username")]
        [Display(Name = "Username korisnika")]
        public string Username { get; set; }

        [Column("lozinka")]
        [Display(Name = "Lozinka korisnika")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}