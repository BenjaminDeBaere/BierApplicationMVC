using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBierenApplicatie.Models
{
    public class Bier
    {
        [DisplayFormat(DataFormatString ="{0:000}")]
        public Int32 ID { get; set; }
        [StringLength(20,MinimumLength =1, ErrorMessage ="Geef een naam in van minstens 1 en maximum 20 karakters" )]
        [Required(ErrorMessage ="Naam is een verplicht veld.")]
        public string Naam { get; set; }
        [UIHint("Kleuren")]
        public float Alcohol { get; set; }
    }
}