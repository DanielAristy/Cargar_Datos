using System;
using System.Collections.Generic;
using System.Text;

namespace CompiladorNuevo.Transversal
{
    public class ComponenteLexico
    {
        public String Lexema { get; set; }
        public Categoria Categoria { get; set; }
        public int NumeroLinea { get; set; }
        public int PosicionInicial { get; set; }
        public int PosicionFinal { get; set; }
        public TipoComponente Tipo { get; set; }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append("Tipo componente: " + Tipo.ToString() + "\n");
            retorno.Append("Categoria: " + Categoria + "\n");
            retorno.Append("Lexema: " + Lexema + "\n");
            retorno.Append("Numero de linea: " + NumeroLinea + "\n");
            retorno.Append("Posicion inicial: " + PosicionInicial + "\n");
            retorno.Append("Posicion final : " + PosicionFinal + "\n");

            return base.ToString();

        }
    }
}
