using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerApi.Api.Models
{
    /*[Table("Publicacion")]*/
    public class Publicacion
    {
        public int Id { get; set; }

        /*[MaxLength(50)]
        [Required]*/
        public string Usuario { get; set; }

        /*[MaxLength(50)]
        [Required]*/
        public string Descripcion { get; set; }

        
        public DateTime FechaPublicacion { get; set; }

        /*[MaxLength(10)]
        [Required]*/
        public int MeGustas { get; set; }

       /* [MaxLength(10)]
        [Required]*/
        public int MeDisgusta { get; set; }

       /* [MaxLength(1)]
        [Required]*/
        public int VecesCompartido { get; set; }

        public Boolean EsPrivada { get; set; }


    }
}