﻿using Personas.contentcontrols;
using Personas.vistas;
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

        // Devuelve un nuevo UserControl de NuevaPersona
        internal UserControl AbrirNuevaPersona() => new NuevaPersonaControl();

        // Devuelve un nuevo UserControl de ListaPersonas
        internal UserControl AbrirListaPersonas() => new ListaPersonasControl();

        // Abre un diálogo y devuelve el resultado
        public bool? AbrirAñadirDialog() => new AñadirDialog().ShowDialog();
        
    }
}
