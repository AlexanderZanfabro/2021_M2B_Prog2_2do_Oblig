using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Like
    {
        public int idActividad;
        public int idUsuario;

        public Like(int idActividad, int idUsuario)
        {
            this.idActividad = idActividad;
            this.idUsuario = idUsuario;
        }
    }
}
