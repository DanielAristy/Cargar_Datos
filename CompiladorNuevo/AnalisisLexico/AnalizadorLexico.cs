using CompiladorNuevo.Caches;
using CompiladorNuevo.ManejadorErrores;
using CompiladorNuevo.TablaSimbolos;
using CompiladorNuevo.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorNuevo.AnalisisLexico
{
    public class AnalizadorLexico
    {
        private int numeroLineaActual;
        private int puntero;
        private String caracterActual;
        private Linea lineaActual;
        String lexema;

        public AnalizadorLexico()
        {
            numeroLineaActual = 0;
            CargarNuevaLinea();
        }

        private void CargarNuevaLinea()
        {
            numeroLineaActual = numeroLineaActual + 1;

            lineaActual = Cache.ObtenerLinea(numeroLineaActual);

            if (lineaActual.Contenido.Equals("@EOF@"))
            {
                numeroLineaActual = lineaActual.Numero;
            }

            puntero = 1;
        }

        private void DevolverPuntero()
        {
            puntero = puntero - 1;
        }

        private void LeerSiguienteCaracter()
        {

            if ("@EOF@".Equals(lineaActual.Contenido))
            { 
                caracterActual = lineaActual.Contenido; 

            } else if (puntero > lineaActual.Contenido.Length)
            { 
                caracterActual = "@FL@";
                puntero++;
            }
            else
            {
                caracterActual = lineaActual.Contenido.Substring(puntero-1, 1);
                puntero = puntero + 1;
            }

        }

        private void concatenarLexema()
        {
            lexema = lexema + caracterActual;
        }
        private void LimpiarLexema()
        {
            lexema = "";
        }
        private void DevorarEspaciosBlanco()
        {
            while (caracterActual.Equals(" "))
            {
                LeerSiguienteCaracter();
            }
        }

        public bool EsLetra(String simbolo)
        {
            return Char.IsLetter(simbolo, 0);
        }

        public bool EsDigito(String simbolo)
        {
            return Char.IsDigit(simbolo, 0);
        }

        public bool EsLetraODigito(String simbolo)
        {
            return EsLetra(simbolo) || EsDigito(simbolo);
        }

        public ComponenteLexico Analizar()
        {
            ComponenteLexico componenteLexico = new ComponenteLexico();
            LimpiarLexema();
            int estadoActual = 0;
            bool continuarAnalisis = true;

            while (continuarAnalisis)
            {
                if (estadoActual == 0)
                {
                    LeerSiguienteCaracter();
                    DevorarEspaciosBlanco();

                    if (EsLetra(caracterActual) || caracterActual.Equals("$") || caracterActual.Equals("_"))
                    {
                        estadoActual = 4;
                        concatenarLexema();
                    }
                    else if (EsDigito(caracterActual))
                    {
                        estadoActual = 1;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals("+"))
                    {
                        estadoActual = 5;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals("-"))
                    {
                        estadoActual = 6;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals("*"))
                    {
                        estadoActual = 7;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals("/"))
                    {
                        estadoActual = 8;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals("%"))
                    {
                        estadoActual = 9;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals("("))
                    {
                        estadoActual = 10;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals(")"))
                    {
                        estadoActual = 11;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals("@EOF@"))
                    {
                        estadoActual = 12;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals("="))
                    {
                        estadoActual = 19;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals("<"))
                    {
                        estadoActual = 20;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals(">"))
                    {
                        estadoActual = 21;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals(":"))
                    {
                        estadoActual = 22;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals("!"))
                    {
                        estadoActual = 30;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals("@FL@"))
                    {
                        estadoActual = 13;
                    }
                    else
                    {
                        estadoActual = 18;
                    }
                }
                else if (estadoActual == 1)
                {
                    LeerSiguienteCaracter();

                    if (EsDigito(caracterActual))
                    {
                        estadoActual = 1;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals(","))
                    {
                        estadoActual = 2;
                        concatenarLexema();
                    }
                    else
                    {
                        estadoActual = 14;
                    }

                }
                else if (estadoActual == 2)
                {
                    LeerSiguienteCaracter();

                    if (EsDigito(caracterActual))
                    {
                        estadoActual = 3;
                        concatenarLexema();
                    }
                    else
                    {
                        estadoActual = 17;
                    }
                }
                else if (estadoActual == 3)
                {
                    LeerSiguienteCaracter();
                    if (EsDigito(caracterActual))
                    {
                        estadoActual = 3;
                        concatenarLexema();
                    }
                    else
                    {
                        estadoActual = 15;
                    }
                }
                else if (estadoActual == 4)
                {
                    LeerSiguienteCaracter();
                    if (EsLetraODigito(caracterActual) || caracterActual.Equals("$") || caracterActual.Equals("_"))
                    { 
                        estadoActual = 4; concatenarLexema();
                    } else {
                        estadoActual = 16;
                    } 
                }
                else if (estadoActual == 5)
                {
                    continuarAnalisis = false;

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.SUMA;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);

                }
                else if (estadoActual == 6)
                {
                    continuarAnalisis = false;

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.RESTA;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);

                }
                else if (estadoActual == 7)
                {
                    continuarAnalisis = false;

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.MULTIPLICACION;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);

                }
                else if (estadoActual == 8)
                {
                    LeerSiguienteCaracter();

                    if (caracterActual.Equals("*"))
                    {
                        estadoActual = 34;
                        concatenarLexema();

                        LeerSiguienteCaracter();

                        if (caracterActual != "*" && caracterActual != "@FL@")
                        {
                            estadoActual = 34;
                            concatenarLexema();
                        }
                        else if (caracterActual.Equals("*"))
                        {
                            estadoActual = 35;
                            concatenarLexema();
                        }
                        else if (caracterActual.Equals("*"))
                        {
                            estadoActual = 35;
                            concatenarLexema();
                        }
                        else if (caracterActual != "*" && caracterActual != "/")
                        {
                            estadoActual = 34;
                            concatenarLexema();
                        }
                        else if (caracterActual.Equals("@FL@"))
                        {
                            estadoActual = 37;
                            concatenarLexema();
                        }
                        //else if (caracterActual.Equals("CNL"))
                        //{
                        //    estadoActual = 34;
                        //    concatenarLexema();
                        //}
                    }
                    else if (caracterActual.Equals("/"))
                    {
                        estadoActual = 36;
                        concatenarLexema();

                        LeerSiguienteCaracter();

                        if (caracterActual != "@FL@")
                        {
                            estadoActual = 36;
                            concatenarLexema();
                        }
                        else if (caracterActual.Equals("@FL@"))
                        {
                            estadoActual = 13;
                            concatenarLexema();
                        }
                    }
                    else
                    {
                        estadoActual = 33;
                    }
                }//****
                else if (estadoActual == 9)
                {
                    continuarAnalisis = false;

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.MODULO;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);

                }
                else if (estadoActual == 10)
                {
                    continuarAnalisis = false;

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.PARENTESIS_ABRE;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);

                }
                else if (estadoActual == 11)
                {
                    continuarAnalisis = false;

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.PARENTESIS_CIERRA;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);

                }
                else if (estadoActual == 12)
                {
                    continuarAnalisis = false;

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.EOF;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    //componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    //TablaMaestra.SincronizarSimbolo(componenteLexico);

                }
                else if (estadoActual == 13)
                {
                    CargarNuevaLinea();
                    estadoActual = 0;
                }
                else if (estadoActual == 14)
                {
                    continuarAnalisis = false;
                    DevolverPuntero();

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.ENTERO;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);
                }
                else if (estadoActual == 15)
                {
                    continuarAnalisis = false;
                    DevolverPuntero();

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.DECIMAL;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);
                }
                else if (estadoActual == 16)
                {
                    continuarAnalisis = false;
                    DevolverPuntero();

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.IDENTIFICADOR;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);
                }
                else if (estadoActual == 17)
                {
                    continuarAnalisis = false;
                    DevolverPuntero();

                    Error error = Error.CrearErrorLexico(lexema, Categoria.DECIMAL,
                        numeroLineaActual, puntero - lexema.Length, puntero - 1,
                        "Numero decimal no válido",
                        "Lei \"" + caracterActual + "\" y esperaba un digito del 0 al 9",
                        "Asegurese que el caracter que se reciba sea un digito del 0 al 9");

                    GestorErrores.Reportar(error);

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.DECIMAL;
                    componenteLexico.Lexema = lexema + "0"; //Comodin
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.DUMMY;//Lo tuvo que crear para recuperarse del problema

                    TablaMaestra.SincronizarSimbolo(componenteLexico);
                }
                else if (estadoActual == 18)
                {
                    Error error = Error.CrearErrorLexico(caracterActual, Categoria.CARACTER_NO_VALIDO,
                        numeroLineaActual, puntero - 1, puntero - 1,
                        "Carcater no reconocido por el lenguaje",
                        "Lei \"" + caracterActual + "\"",
                        "Asegurese que el caracter que se reciba sea valido dentro del lenguaje");

                    GestorErrores.Reportar(error);

                    throw new Exception("Se ha presentado un error de tipo stopper durante el " +
                        "analisis léxico. Por favor verifique la consola de errores...");
                }
                else if (estadoActual == 19)
                {
                    continuarAnalisis = false;

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.IGUAL_QUE;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);

                }
                else if (estadoActual == 20)
                {
                    LeerSiguienteCaracter();

                    if (caracterActual.Equals(">"))
                    {
                        estadoActual = 23;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals("="))
                    {
                        estadoActual = 24;
                        concatenarLexema();
                    }
                    else
                    {
                        estadoActual = 25;

                    }
                }
                else if (estadoActual == 21)
                {
                    LeerSiguienteCaracter();

                    if (caracterActual.Equals(">"))
                    {
                        estadoActual = 26;
                        concatenarLexema();
                    }
                    else
                    {
                        estadoActual = 27;

                    }
                }
                else if (estadoActual == 22)
                {
                    LeerSiguienteCaracter();

                    if (caracterActual.Equals("="))
                    {
                        estadoActual = 28;
                        concatenarLexema();
                    }
                    else
                    {
                        estadoActual = 29;

                    }
                }
                else if (estadoActual == 23)
                {
                    continuarAnalisis = false;

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.DIFERENTE_QUE;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);
                }
                else if (estadoActual == 24)
                {
                    continuarAnalisis = false;

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.MENOR_O_IGUAL_QUE;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);
                }
                else if (estadoActual == 25)
                {
                    continuarAnalisis = false;
                    DevolverPuntero();

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.MENOR_QUE;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);
                }
                else if (estadoActual == 26)
                {
                    continuarAnalisis = false;

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.MAYOR_O_IGUAL_QUE;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);
                }
                else if (estadoActual == 27)
                {
                    continuarAnalisis = false;
                    DevolverPuntero();

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.MAYOR_QUE;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);
                }
                else if (estadoActual == 28)
                {
                    continuarAnalisis = false;

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.ASIGNACION;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);
                }
                else if (estadoActual == 29)
                {
                    continuarAnalisis = false;
                    DevolverPuntero();

                    Error error = Error.CrearErrorLexico(lexema, Categoria.ASIGNACION,
                        numeroLineaActual, puntero - lexema.Length, puntero - 1,
                        "Caracter no válido",
                        "Lei \"" + caracterActual + "\" y esperaba un =",
                        "Asegurese que la estructura ASIGNACION sea la adecuada");

                    GestorErrores.Reportar(error);

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.ASIGNACION;
                    componenteLexico.Lexema = lexema + "0"; //Comodin
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.DUMMY;//Lo tuvo que crear para recuperarse del problema

                    TablaMaestra.SincronizarSimbolo(componenteLexico);

                }
                else if (estadoActual == 30)
                {
                    LeerSiguienteCaracter();

                    if (caracterActual.Equals("="))
                    {
                        estadoActual = 31;
                        concatenarLexema();
                    }
                    else
                    {
                        estadoActual = 32;
                    }
                }
                else if (estadoActual == 31)
                {
                    continuarAnalisis = false;

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.DIFERENTE_QUE;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);
                }
                else if (estadoActual == 32)
                {
                    continuarAnalisis = false;
                    DevolverPuntero();

                    Error error = Error.CrearErrorLexico(lexema, Categoria.DIFERENTE_QUE,
                        numeroLineaActual, puntero - lexema.Length, puntero - 1,
                        "Caracter no válido",
                        "Lei \"" + caracterActual + "\" y esperaba un =",
                        "Asegurese que la estructura DIFERENTE QUE sea la adecuada");

                    GestorErrores.Reportar(error);

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.DIFERENTE_QUE;
                    componenteLexico.Lexema = lexema + "0"; //Comodin
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.DUMMY;//Lo tuvo que crear para recuperarse del problema

                    TablaMaestra.SincronizarSimbolo(componenteLexico);

                }
                else if (estadoActual == 33)
                {
                    continuarAnalisis = false;
                    DevolverPuntero();

                    componenteLexico = new ComponenteLexico();
                    componenteLexico.Categoria = Categoria.DIVISION;
                    componenteLexico.Lexema = lexema;
                    componenteLexico.NumeroLinea = numeroLineaActual;
                    componenteLexico.PosicionInicial = puntero - lexema.Length;
                    componenteLexico.PosicionFinal = puntero - 1;
                    componenteLexico.Tipo = TipoComponente.SIMBOLO;

                    TablaMaestra.SincronizarSimbolo(componenteLexico);
                }
                else if (estadoActual == 34)
                {
                    LeerSiguienteCaracter();

                    if (caracterActual.Equals("*"))
                    {
                        estadoActual = 35;
                        concatenarLexema();
                    }
                    else if (caracterActual.Equals("@FL@"))
                    {
                        estadoActual = 37;
                    }
                    else
                    {
                        estadoActual = 34;
                        concatenarLexema();
                    }
                }
                else if (estadoActual == 35)
                {
                    LeerSiguienteCaracter();

                    if (caracterActual.Equals("/"))
                    {
                        estadoActual = 0;
                    }
                    else if (caracterActual.Equals("*"))
                    {
                        estadoActual = 35;
                        concatenarLexema();
                    }
                    else
                    {
                        estadoActual = 34;
                        concatenarLexema();
                    }
                }
                else if (estadoActual == 36)
                {
                    LeerSiguienteCaracter();

                    if (caracterActual.Equals("@FL@"))
                    {
                        estadoActual = 13;
                    }
                    else
                    {
                        estadoActual = 36;
                        concatenarLexema();
                    }
                }
                else if (estadoActual == 37)
                {
                    CargarNuevaLinea();
                    estadoActual = 34;
                }
            }
            if (componenteLexico.Equals("@EOF@"))
            {
                //TablaMaestra.ObtenerTablaMaestra().Sincronizar(componente);
                TablaMaestra.SincronizarSimbolo(componenteLexico);
            }
            return componenteLexico;
        }
    }
}
