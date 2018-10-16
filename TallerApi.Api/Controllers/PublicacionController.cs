using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TallerApi.Api.Models;

namespace TallerApi.Api.Controllers
{
    //creado porJjose Ayala
    public class PublicacionController : ApiController
    {
        [HttpGet]
        public IEnumerable<Publicacion> Get()
        {
            using (var context = new PublicacionContext())
            {
                return context.Publicacion.ToList();
            }
        }

        [HttpGet]
        public Publicacion Get(int id)
        {
            using (var context = new PublicacionContext())
            {
                return context.Publicacion.FirstOrDefault(x => x.Id == id);
            }
        }
        [HttpPost]
        public Publicacion Post(Publicacion publicacion)
        {
            using (var context = new PublicacionContext())
            {
                context.Publicacion.Add(publicacion);
                context.SaveChanges();
                return publicacion;
            }

        }

        [HttpPut]
        public Publicacion Put(Publicacion publicacion)
        {
            using (var context = new PublicacionContext())
            {
                var publicacionActualizar = context.Publicacion.FirstOrDefault(x => x.Id == publicacion.Id);
                publicacionActualizar.Usuario = publicacion.Usuario;
                publicacionActualizar.Descripcion = publicacion.Descripcion;
                publicacionActualizar.FechaPublicacion = publicacion.FechaPublicacion;
                publicacionActualizar.MeGusta = publicacion.MeGusta;
                publicacionActualizar.MeDisgusta = publicacion.MeDisgusta;
                publicacionActualizar.VecesCompartido = publicacion.VecesCompartido;
                publicacionActualizar.EsPrivada = publicacion.EsPrivada;
                context.SaveChanges();
                return publicacion;
            }

        }

        [HttpDelete]
        public bool Delete(int id)
        {
            using (var context = new PublicacionContext())
            {
                var publicacionEliminar = context.Publicacion.FirstOrDefault(x => x.Id == id);
                context.Publicacion.Remove(publicacionEliminar);
                context.SaveChanges();
                return true;
            }

        }

    }
}
