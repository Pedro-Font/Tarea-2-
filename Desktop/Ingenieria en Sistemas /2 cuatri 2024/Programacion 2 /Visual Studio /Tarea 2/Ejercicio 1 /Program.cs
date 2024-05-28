using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lo mismo con este ejercicio, al haberlo hecho con otros
            // elementos (diccionarios y arreglos), lo dejo aca primero sin usar arreglos ni diccionarios
            // en comentario y posteriormente dejo la tarea como se solicito

            /*
             * using System;

class Program
{
    static void Main()
    {
        int cantidadSol = 0, cantidadSombra = 0, cantidadPreferencial = 0;
        int acumuladoSol = 0, acumuladoSombra = 0, acumuladoPreferencial = 0;
        string continuar = "S";

        while (continuar.ToUpper() == "S")
        {
            // Leer datos de la venta
            Console.WriteLine("Ingrese los datos de la venta:");
            Console.Write("Número de factura: ");
            int numeroFactura = int.Parse(Console.ReadLine());

            Console.Write("Cédula del comprador: ");
            string cedula = Console.ReadLine();

            Console.Write("Nombre del comprador: ");
            string nombreComprador = Console.ReadLine();

            Console.WriteLine("Seleccione la localidad:");
            Console.WriteLine("1 - Sol Norte/Sur");
            Console.WriteLine("2 - Sombra Este/Oeste");
            Console.WriteLine("3 - Preferencial");
            int localidad = int.Parse(Console.ReadLine());

            Console.Write("Cantidad de entradas (máximo 4): ");
            int cantidadEntradas = int.Parse(Console.ReadLine());
            if (cantidadEntradas < 1 || cantidadEntradas > 4)
            {
                Console.WriteLine("Error: La cantidad de entradas debe estar entre 1 y 4.");
                continue;
            }

            // Calcular precio y subtotal
            int precioEntrada = 0;
            string nombreLocalidad = "";
            switch (localidad)
            {
                case 1:
                    precioEntrada = 10500;
                    nombreLocalidad = "Sol Norte/Sur";
                    cantidadSol += cantidadEntradas;
                    acumuladoSol += cantidadEntradas * precioEntrada;
                    break;
                case 2:
                    precioEntrada = 20500;
                    nombreLocalidad = "Sombra Este/Oeste";
                    cantidadSombra += cantidadEntradas;
                    acumuladoSombra += cantidadEntradas * precioEntrada;
                    break;
                case 3:
                    precioEntrada = 25500;
                    nombreLocalidad = "Preferencial";
                    cantidadPreferencial += cantidadEntradas;
                    acumuladoPreferencial += cantidadEntradas * precioEntrada;
                    break;
            }

            int subtotal = cantidadEntradas * precioEntrada;
            int cargosServicios = cantidadEntradas * 1000;
            int totalPagar = subtotal + cargosServicios;

            // Mostrar información de la venta
            Console.WriteLine("\nInformación de la venta:");
            Console.WriteLine("Número de Factura: " + numeroFactura);
            Console.WriteLine("Cédula del comprador: " + cedula);
            Console.WriteLine("Nombre del comprador: " + nombreComprador);
            Console.WriteLine("Localidad: " + nombreLocalidad);
            Console.WriteLine("Cantidad de Entradas: " + cantidadEntradas);
            Console.WriteLine("Subtotal: " + subtotal);
            Console.WriteLine("Cargos por Servicios: " + cargosServicios);
            Console.WriteLine("Total a Pagar: " + totalPagar);

            // Preguntar si desea continuar
            Console.Write("\n¿Desea realizar otra venta? (S/N): ");
            continuar = Console.ReadLine();
        }

        // Mostrar estadísticas
        Console.WriteLine("\nEstadísticas:");
        Console.WriteLine("Cantidad Entradas Localidad Sol Norte/Sur: " + cantidadSol);
        Console.WriteLine("Acumulado Dinero Localidad Sol Norte/Sur: " + acumuladoSol);
        Console.WriteLine("Cantidad Entradas Localidad Sombra Este/Oeste: " + cantidadSombra);
        Console.WriteLine("Acumulado Dinero Localidad Sombra Este/Oeste: " + acumuladoSombra);
        Console.WriteLine("Cantidad Entradas Localidad Preferencial: " + cantidadPreferencial);
        Console.WriteLine("Acumulado Dinero Localidad Preferencial: " + acumuladoPreferencial);

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
            //Ahora a continuacion la tarea como fue solicitada: 
             */
            List<string> numFactura = new List<string>();
            List<string> cedulaComprador = new List<string>(); 
            List<string> nombreComprador = new List<string>(); 
            List<int> localidad = new List<int>();
            List<int> cantidadEntradas = new List<int>();

            string continuar = "S";

            while (continuar.ToUpper() == "S")
            {
                Console.WriteLine("Número de factura: ");
                numFactura.Add(Console.ReadLine());

                Console.WriteLine("Cédula del comprador: ");
                cedulaComprador.Add(Console.ReadLine());

                Console.WriteLine("Nombre del comprador: ");
                nombreComprador.Add(Console.ReadLine());

                Console.Write("Localidad (1- Sol Norte/Sur, 2- Sombra Este/Oeste, 3- Preferencial): ");
                localidad.Add(int.Parse(Console.ReadLine()));

                int entradas;
                do
                {
                    Console.WriteLine("Cuantas entradas desea comprar (Maximo 4)");
                    entradas = int.Parse(Console.ReadLine());
                    if (entradas < 1 || entradas > 4)
                    {
                        Console.WriteLine("Número de entradas inválido, por favor seleccione entre 1 o 4 entradas únicamente");
                    }
                } while (entradas < 1 || entradas > 4);
                cantidadEntradas.Add(entradas);

                //Preguntar si se desean hacer mas compras
                Console.WriteLine("Desea registrar mas ventas de entradas? (S/N"));
                continuar = Console.ReadLine().ToUpper();
            }
            // Variables para poder sacar las estadisticas 
            int cantEntradasSol = 0, cantEntradasSombra = 0, cantEntradasPreferencial = 0;
            float acumDineroSol = 0, acumDineroSombra = 0, acumDineroPreferencial = 0;
            for (int contador = 0; contador < cantidadEntradas.Count(); contador++) 
            {
                string nombreLocalidad = "";
                float precioEntrada = 0;

                switch (localidad[contador])
                {
                    case 1:
                        nombreLocalidad = "Sol Norte/Sur";
                        precioEntrada = 10500;
                        // almacenar la cantidad de entradas ingresadas por el usuario
                        cantEntradasSol = +cantidadEntradas[contador];
                        acumDineroSol = +cantidadEntradas[contador] * precioEntrada;
                        break;
                    case 2:
                        nombreLocalidad = "Sombra Este/Oeste";
                        precioEntrada = 20500;
                        cantEntradasSombra = +cantidadEntradas[contador];
                        acumDineroSombra = +cantidadEntradas[contador] * precioEntrada;
                        break;
                    case 3:
                        nombreLocalidad = "Preferencial";
                        precioEntrada = 25500;
                        cantEntradasPreferencial = +cantidadEntradas[contador];
                        acumDineroPreferencial = +cantidadEntradas[contador] * precioEntrada;
                        break; 
                }
                float subtotal = cantidadEntradas[contador] * precioEntrada;
                float cargoXServicio = cantidadEntradas[contador] * 1000;
                float totalPagar = subtotal + cargoXServicio;
                Console.WriteLine("Venta:");
                Console.WriteLine($"Número de Factura: {numFactura[contador]}");
                Console.WriteLine($"Cédula del Comprador: {cedulaComprador[contador]}");
                Console.WriteLine($"Nombre del Comprador: {nombreComprador[contador]}");
                Console.WriteLine($"Localidad: {nombreLocalidad}");
                Console.WriteLine($"Cantidad de Entradas: {cantidadEntradas[contador]}");
                Console.WriteLine($"Subtotal: {subtotal}");
                Console.WriteLine($"Cargos por servicio: {cargoXServicio}");
                Console.WriteLine($"Total a Pagar: {totalPagar}");

            }
            //Estadisticas Finales
            Console.WriteLine("Estadísticas Finales:");
            Console.WriteLine($"Cantidad Entradas Localidad Sol Norte/Sur: {cantEntradasSol}");
            Console.WriteLine($"Acumulado Dinero Localidad Sol Norte/Sur: {acumDineroSol}");
            Console.WriteLine($"Cantidad Entradas Localidad Sombra Este/Oeste: {cantEntradasSombra}");
            Console.WriteLine($"Acumulado Dinero Localidad Sombra Este/Oeste: {acumDineroSombra}");
            Console.WriteLine($"Cantidad Entradas Localidad Preferencial: {cantEntradasPreferencial}");
            Console.WriteLine($"Acumulado Dinero Localidad Preferencial: {acumDineroPreferencial}");

            Console.ReadLine();

        }
    }
}