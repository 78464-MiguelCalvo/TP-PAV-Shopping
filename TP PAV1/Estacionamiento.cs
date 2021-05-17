using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV1
{
    public class Estacionamiento
    {
        private int idEstacionamiento;
        private int idPlaya;

        public Estacionamiento()
        {

        }

        public int IdEstacionamiento
        {
            get => IdEstacionamiento;
            set => IdEstacionamiento = value;
        }


        public string IdPlaya
        {
            get => IdPlaya;
            set => IdPlaya = value;
        }




    }
}
