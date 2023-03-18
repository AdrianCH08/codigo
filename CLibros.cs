using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace platPropSegundoParcial
{
    //Clase encargada de asignar valores al indexer
    //Autor: Adrian Eduardo Castro Hernandez
    //Fecha: 16/03/2023
    //Versión: 1.0.0
    //Modificación: 16/03/2023
    class CLibros
    {
        //Creacion array
        private CLibro[] disponibles;

        //Metodo para constructor de intancias para el indexer
        public CLibros()
        {
            disponibles = new CLibro[20];

            disponibles[0] = new CLibro(0, "Cien años de soledad", "ISBN 978-0307474728");
            disponibles[1] = new CLibro(1, "El gran Gatsby", "ISBN 978-0743273565");
            disponibles[2] = new CLibro(2, "Matar a un ruiseñor", "ISBN 978-0060935467");
            disponibles[3] = new CLibro(3, "Orgullo y prejuicio", "ISBN 978-0141439518");
            disponibles[4] = new CLibro(4, "Breve historia del tiempo", "(ISBN 978-8499895062");
            disponibles[5] = new CLibro(5, "El señor de los anillos", "ISBN 978-84-450-7559-9");
            disponibles[6] = new CLibro(6, "La Odisea", "ISBN 978-84-376-0304-9");
            disponibles[7] = new CLibro(7, "El alquimista", "ISBN 978-84-204-7627-0");
            disponibles[8] = new CLibro(8, "Don Quijote de la Mancha", " ISBN 978-84-376-0494-7");
            disponibles[9] = new CLibro(9, "1984", " ISBN 978-84-666-6642-3");
            disponibles[10] = new CLibro(10, "Crónica de una muerte anunciada", "ISBN 978-84-322-0247-4");
            disponibles[11] = new CLibro(11, "Moby Dick", " ISBN 978-84-9816-793-2");
            disponibles[12] = new CLibro(12, "Drácula", " ISBN 978-84-376-1131-0");
            disponibles[13] = new CLibro(13, "La metamorfosi", "ISBN 978-84-939460-2-8");
            disponibles[14] = new CLibro(14, "Rayuela", " ISBN 978-84-204-0755-5");
            disponibles[15] = new CLibro(15, "La Divina Comedia", "ISBN 978-84-670-4117-5");
            disponibles[16] = new CLibro(16, "La isla del tesoro", "22267982468");
            disponibles[17] = new CLibro(17, "El retrato de Dorian Gray", "ISBN 978-84-666-6159-6");
            disponibles[18] = new CLibro(18, "La casa de los espíritus", "ISBN 978-84-8306-049-9");
            disponibles[19] = new CLibro(19, "Los miserables", " ISBN 978-84-322-2352-4");
        }

        //Creamos indexer
        public CLibro this[int indice]
        {
            //Usamos el get para obtener el elemento en ese indice
            get { return disponibles[indice]; }

            //Usamos el set para colocar un elemento en ese indice
            set { disponibles[indice] = value; }
        }
    }

}
