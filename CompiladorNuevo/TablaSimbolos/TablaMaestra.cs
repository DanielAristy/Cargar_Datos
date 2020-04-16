using CompiladorNuevo.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorNuevo.TablaSimbolos
{
   public class TablaMaestra
    {
        public static void SincronizarSimbolo(ComponenteLexico componente)
        {
            if (componente != null)
            {
                switch (componente.Tipo)
                {
                    case TipoComponente.SIMBOLO:
                        TablaSimbolos.Agregar(componente);
                        break;

                    case TipoComponente.DUMMY:
                        TablaDummy.Agregar(componente);
                        break;

                }
            }
        }
    }
}
