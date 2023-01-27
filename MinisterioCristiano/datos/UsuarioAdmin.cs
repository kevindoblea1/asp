using MinisterioCristiano.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinisterioCristiano.datos
{
    public class UsuarioAdmin
    {
        public void Save(Usuarios modelo) {
            using (ministeriodbEntities contexto =new ministeriodbEntities()) {
                contexto.Usuarios.Add(modelo);
                contexto.SaveChanges();
            }

        }
        public IEnumerable<Usuarios> GetAll()
        {
            using (ministeriodbEntities contexto = new ministeriodbEntities())
            {
                return contexto.Usuarios.AsNoTracking().ToList();
            }
        }

    }
}