﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Aprende_ASPNETCoreMVC6.Entidades
{
    public class Tarea
    {

        public int Id { get; set; }
        [StringLength(250)]
        [Required]
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
        public DateTime FechaCreacion { get; set; }

        // Relacion entre Tarea y Usuario
        public string UsuarioCreacionId { get; set; }
        // Propiedad de navegacion
        public IdentityUser UsuarioCreacion { get; set; }

        // Propiedad de navegacion
        public List<Paso> Pasos { get; set; }
        public List<ArchivoAdjunto>  ArchivosAdjuntos { get; set; }

    }
}
