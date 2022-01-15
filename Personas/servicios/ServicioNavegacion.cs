using Personas.contentcontrols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas.servicios
{
    class ServicioNavegacion
    {
        public ServicioNavegacion() {; }

        internal UserControl AbrirNuevaPersona()
        {
            return new NuevaPersonaControl();
        }

        internal UserControl AbrirListaPersonas()
        {
            return new ListaPersonasControl();
        }
    }
}
