using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorNuevo.Transversal
{
    public enum Categoria
    {
        IDENTIFICADOR,
        ENTERO, DECIMAL,
        SUMA, RESTA, MULTIPLICACION, DIVISION, MODULO,
        ASIGNACION,
        MAYOR_QUE, MENOR_QUE, IGUAL_QUE, MAYOR_O_IGUAL_QUE, MENOR_O_IGUAL_QUE, DIFERENTE_QUE,  
        PARENTESIS_ABRE, PARENTESIS_CIERRA,
        SALTO_LINEA, EOF,
        CARACTER_NO_VALIDO
    }
}
