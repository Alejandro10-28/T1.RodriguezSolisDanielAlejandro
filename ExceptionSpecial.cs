using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion2
{

   public class ExeptionEspecial: ApplicationException//Es la clase base para las excepciones que se presenten.
    {
        //Se hace un metodo como parametro un string para mandar el mensaje generado 
        //en ApplicationException el cual se le mostrara al usuario.
        public ExeptionEspecial(string Msg) : base(Msg)
        {


        }
    }
}
