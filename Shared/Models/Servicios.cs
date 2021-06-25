using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ClinicaDental.Shared.Models;

namespace ClinicaDental.Shared.Models
{
    public class Servicios
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="La descripción no debe ser vacía")]
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public int Precio { get; set; }
        public int DentistasId { get; set; }
        public Dentistas Dentistas { get; set; }
    }
}
