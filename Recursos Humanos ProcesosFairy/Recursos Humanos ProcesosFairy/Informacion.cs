using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursos_Humanos_ProcesosFairy
{
    class Informacion
    {
        public static String _Informacion = ("Es un programa que optimiza el trabajo y procesos que se realizan en el departamento de recursos humanos");
        public StringBuilder InformacionRRHH()//uso de los tab
        {
            StringBuilder Informacion = new StringBuilder(_Informacion);
            return Informacion;
        }

    }
}
