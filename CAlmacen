using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace platPropSegundoParcial
{
    //Clase encargada del Delegado
    //Autor: Adrian Eduardo Castro Hernandez
    //Fecha: 16/03/2023
    //Versión: 1.0.0
    //Modificación: 16/03/2023
    class CAlmacen
    {
        //Declaramos los delegados
        public delegate void Separadores(int numseparador);
        public delegate void Postits(int numpostit);
        public delegate void Plumas(int numpluma);

        //Variables de los delegados
        private int separadores = 0;
        private int postits = 0;
        private int plumas = 0;

        //Aqui estan las variables que usaremos para invocar
        private Separadores delseparadores;
        private Postits delpostits;
        private Plumas delplumas;

        //Metodo constructor de CAlmacen
        public CAlmacen(int numseparador, int numpostit, int numpluma)
        {
            //Asignamos valores iniciales
            separadores = numseparador;
            postits = numpostit;
            plumas = numpluma;
        }

        //Metodo de referencia para invocacion
        public void AdicionaSeparador(Separadores pMetodo)
        {
            delseparadores = pMetodo;
        }

        //Metodo de referencia para invocacion
        public void AdicionaPostit(Postits pMetodo)
        {
            delpostits = pMetodo;
        }

        //Metodo de referencia para invocacion
        public void AdicionaPluma(Plumas pMetodo)
        {
            delplumas = pMetodo;
        }

        //Propiedades get
        public int Separador { get { return separadores; } }
        public int Postit { get { return postits; } }
        public int Pluma { get { return plumas; } }

        //Metodo que realiza el trabajo del separador
        public void TrabajoSeparador(int pConsumo)
        {
            //Actualizamos los separadores
            separadores = pConsumo;

            Console.WriteLine("{0} separadores, {1} postits, {2} plumas", separadores, postits, plumas);

            //Verificamos que se cumpla la condicion para
            //invocar los handlers del evento

            //Condicion del evento para separadores
            if (separadores < 10)
            {
                //Invocamos el metodo
                delseparadores(separadores);
            }
        }

        //Metodo que realiza el trabajo del postit
        public void TrabajoPost(int pConsumo)
        {
            //Actualizamos las postits
            postits = pConsumo;

            Console.WriteLine("{0} separadores, {1} postits, {2} plumas", separadores, postits, plumas);

            //Verificamos que se cumpla la condicion para
            //invocar los handlers del evento

            //Condicion del evento para postits
            if (postits < 10)
            {
                //Invocamos el metodo
                delpostits(postits);
            }
        }

        //Metodo que realiza el trabajo de la pluma
        public void TrabajoPluma(int pConsumo)
        {
            //Actualizamos las plumas
            plumas = pConsumo;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0} separadores, {1} postits, {2} plumas", separadores, postits, plumas);

            //Verificamos que se cumpla la condicion para
            //invocar los handlers del evento

            //Condicion del evento para plumas
            if (plumas < 10)
            {
                //Invocamos el metodo
                delplumas(plumas);
            }
        }
    }


}
