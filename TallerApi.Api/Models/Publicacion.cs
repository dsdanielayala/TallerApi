using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TallerApi.Api.Models
{
    [Table("Publicacion")]
    public class Publicacion
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Usuario { get; set; }

        [MaxLength(200)]
        [Required]
        public string Descripcion { get; set; }

        [Required]
        public DateTime FechaPublicacion { get; set; }

        
        public int MeGusta { get; set; }

        public int MeDisgusta { get; set; }

       
        public int VecesCompartido { get; set; }

        [Required]
        public Boolean EsPrivada { get; set; }


    }
}