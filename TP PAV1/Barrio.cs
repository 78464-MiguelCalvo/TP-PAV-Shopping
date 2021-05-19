using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV1
{
    class Barrio
    {
        private int idBarrio;
        private string Nombre;

        public Barrio()
        {

        }

        public int IdBarrio
        {
            get => idBarrio;
            set => idBarrio = value;
        }

        public string NombreBarrio
        {
            get => Nombre;
            set => Nombre = value;
        }
    }
}
