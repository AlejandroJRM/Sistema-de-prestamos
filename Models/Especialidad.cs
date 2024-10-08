﻿using System.ComponentModel.DataAnnotations;

namespace Sistema_Prestamos_TI.Models
{
    public class Especialidad
    {
        // Primary key
        [Key]
        public int Id { get; set; }

        //No puede ser null
        [Required(ErrorMessage = "La descripcion de especialidad es obligatorio")]
        public string Descripcion { get; set; }

        //Estado
        public Boolean Estado { get; set; }
    }
}
