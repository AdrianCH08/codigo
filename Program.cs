using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace platPropSegundoParcial
{
    //Clase program
    //Autor: Adrian Eduardo Castro Hernandez
    //Fecha: 16/03/2023
    //Versión: 1.0.0
    //Modificación: 16/03/2023
    class Program
    {
        static void Main(string[] args)
        {
            //Variables de la clase Program
            string leer = "";
            int n = 0;
            int libro = 0;
            int idlibro = 0;
            int opcion = 0;
            int separador = 0;
            int postit = 0;
            int pluma = 0;
            int trabajo = 0;
            int ventaseparador = 0;
            int ventapostit = 0;
            int ventapluma = 0;

            //Inicia ciclo del menu principal
            do
            {
                //Seleccionar menu
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("BIENVENIDO A LIBRERIA");
                Console.WriteLine("");
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("1.Libros  2.Almacén  3.Salir");
                leer = Console.ReadLine();
                opcion = Convert.ToInt32(leer);

                //Switch menu secundario
                switch (opcion)
                {
                    //Opcion INDEXER
                    case 1:
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");
                            Console.WriteLine("1.Ver lista de libros  2.Buscar libro  3.Regresar");
                            leer = Console.ReadLine();
                            libro = Convert.ToInt32(leer);

                            //Seleccionar opcion para indexer
                            switch (libro)
                            {

                                case 1:
                                    //Creamos al libro
                                    CLibros misLibros = new CLibros();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    //Imprime la lista de libros
                                    for (n = 0; n <= 19; n++)
                                    {
                                        misLibros[n].MuestraInformacion();
                                    }
                                    break;

                                case 2:
                                    //Declaramos el libro
                                    CLibros misLibro = new CLibros();

                                    //Obtener id del libro
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Ingrese ID");
                                    leer = Console.ReadLine();
                                    idlibro = Convert.ToInt32(leer);

                                    //Obtenemos el libro
                                    CLibro miLibro = misLibro[idlibro];
                                    miLibro.MuestraInformacion();

                                    break;

                                default:

                                    libro = 5;
                                    break;
                            }//Termina switch

                        } while (libro <= 3);

                        break;

                    //Parte del delegado
                    case 2:
                        //Creamos el CAlmacen
                        Console.WriteLine("Agregar datos al almacen");
                        Console.WriteLine("Agregar separadores");
                        //Se pregunta el total de separadores
                        leer = Console.ReadLine();
                        separador = Convert.ToInt32(leer);
                        Console.WriteLine("Agregar Post Its");
                        //Se pregunta el total de Post Its 
                        leer = Console.ReadLine();
                        postit = Convert.ToInt32(leer);
                        Console.WriteLine("Agregar plumas");
                        //Se pregunta el total de plumas
                        leer = Console.ReadLine();
                        pluma = Convert.ToInt32(leer);
                        CAlmacen miAlmacen = new CAlmacen(separador, postit, pluma);
                        miAlmacen.AdicionaSeparador(new CAlmacen.Separadores(InformeSeparadores));
                        miAlmacen.AdicionaPostit(new CAlmacen.Postits(InformePostits));
                        miAlmacen.AdicionaPluma(new CAlmacen.Plumas(InformePlumas));
                        //Guardamos los datos
                        miAlmacen.TrabajoSeparador(separador);
                        miAlmacen.TrabajoPost(postit);
                        miAlmacen.TrabajoPluma(pluma);

                        //Ciclamos el delegado
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Seleccionar la venta ");
                            Console.WriteLine("1.Separadores 2.Post its 3.Plumas");
                            leer = Console.ReadLine();
                            trabajo = Convert.ToInt32(leer);
                            switch (trabajo)
                            {
                                case 1:
                                    //Cuantificamos separadores
                                    Console.WriteLine("Ingrese cantidad unitaria");
                                    leer = Console.ReadLine();
                                    ventaseparador = Convert.ToInt32(leer);
                                    separador = separador - ventaseparador;

                                    //Validamos producto agotado
                                    if (separador <= 0)
                                    {
                                        trabajo = 5;
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Separadores agotados");
                                    }
                                    else
                                        miAlmacen.TrabajoSeparador(separador);
                                    break;

                                case 2:
                                    //Cuantificamos postits
                                    Console.WriteLine("Ingrese cantidad unitaria");
                                    leer = Console.ReadLine();
                                    ventapostit = Convert.ToInt32(leer);
                                    postit = postit - ventapostit;
                                    //Validamos producto agotado
                                    if (postit <= 0)
                                    {
                                        trabajo = 5;
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Postits agotados");
                                    }
                                    else
                                        miAlmacen.TrabajoPost(postit);
                                    break;

                                case 3:
                                    //Cuantificamos plumas
                                    Console.WriteLine("Ingrese cantidad unitaria");
                                    leer = Console.ReadLine();
                                    ventapluma = Convert.ToInt32(leer);
                                    pluma = pluma - ventapluma;

                                    //Validamos producto agotado
                                    if (pluma <= 0)
                                    {
                                        trabajo = 5;
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Plumas agotadas");
                                    }
                                    else
                                        miAlmacen.TrabajoPluma(pluma);
                                    break;
                                default:
                                    trabajo = 5;
                                    break;
                            }

                        } while (trabajo <= 4);//Termina ciclo delegado

                        break;

                    default:
                        opcion = 5;
                        break;

                }//Termina switch menu secundario

            } while (opcion <= 3); //Fin del menu inicial
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ha salido");
        }

        //Metodo para informar cuando se cumpla una condicion
        public static void InformeSeparadores(int numseparador)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ATENCION: Quedan menos de 10 separadores");
            Console.WriteLine(" Quedan {0} separadores", numseparador);
        }

        //Metodo para informar cuando se cumpla una condicion
        public static void InformePostits(int numpostit)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ATENCION: Quedan menos de 10 postits");
            Console.WriteLine("Quedan {0} postits", numpostit);
        }

        //Metodo para informar cuando se cumpla una condicion
        public static void InformePlumas(int numpluma)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ATENCION: Quedan menos de 10 plumas");
            Console.WriteLine("Quedan {0} plumas", numpluma);
        }
    }

}
