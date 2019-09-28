using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI_Fairy.Models
{
    public class Fairy
    {
        [Key]
        public int FairyID { get; set; }
        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(24,ErrorMessage = "El nombre debe tener entre 2 y 24 caracteres", MinimumLength = 2)]
        public string NickName { get; set; }
        [Required]
        public Wishlist Wishes { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Cumpleaños")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
    }
    public enum Wishlist
    {
        Computadora,
        ColeccionDeAutos,
        Cancion
    }
}