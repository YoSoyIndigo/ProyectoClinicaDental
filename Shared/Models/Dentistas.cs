using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ClinicaDental.Shared.Models;

namespace ClinicaDental.Shared.Models
{
    public class Dentistas
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El id no puede estar vacío")]
        public string NombreDentista { get; set; }
        //public ICollection<Servicios> Servicios { get; set; }
    }
}
