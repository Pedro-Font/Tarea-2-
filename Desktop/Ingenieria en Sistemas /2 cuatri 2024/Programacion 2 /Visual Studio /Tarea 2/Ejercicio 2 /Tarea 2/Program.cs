using System;

namespace MyApp
{
    internal class Program
    {
        static void Main()
        {
            // Profe, debido a que en la tarea 1 yo use otros elementos para la construccion 
            //  por esa razon en esta tarea primero dejare en comentario el codigo sin arreglos
            // y despues viene el codigo normal con arreglos ya en ejecutable


            // Entrada:
            // Variables para guardar info de los empleados.
            //Proceso:
            // a partir de la informacion ingresada por el usuario,
            // calcular el aumento y los diferentes tipos de salario.
            //Salida:
            // los datos del usuario, los salarios y los resultados obtenidos

            /*int countOperarios = 0, countTecnicos = 0, countProfesionales = 0;
            double totalNetoOp = 0, totalNetoTec = 0, totalNetoPro = 0;

            Console.WriteLine("Esto es un programa para calcular aumentos salariales");
            string continuar;

            do
            {
                //Recibir la informacion en la variables
                Console.WriteLine("Ingrese el número de cédula del empleado:");
                string cedula = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre del empleado:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el tipo de empleado (1-Operario, 2-Técnico, 3-Profesional):");
                int tipoEmpleado = int.Parse(Console.ReadLine());

                Console.WriteLine("Idngrese la cantidad de horas laboradas:");
                float horasLaboradas = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el precio por hora:");
                float precioHora = float.Parse(Console.ReadLine());

                float salarioOrdinario = horasLaboradas * precioHora;
                float aumento = 0;
                //determinar el aumento del salario
                switch (tipoEmpleado)
                {
                    case 1:
                        aumento = salarioOrdinario * 0.15f;
                        break;
                    case 2:
                        aumento = salarioOrdinario * 0.10f;
                        break;
                    case 3:
                        aumento = salarioOrdinario * 0.05f;
                        break;
                }
                // Salario Bruto
                float salarioBruto = salarioOrdinario + aumento;
                //rebajos
                float rebajosCCSS = salarioBruto * 0.0917f;
                //salario Neto
                float salarioNeto = salarioBruto - rebajosCCSS;
                //Mostrar los resultados almacenados y calculados:

                Console.WriteLine("--- Datos del Empleado ---");
                Console.WriteLine($"Cedula: {cedula}");
                Console.WriteLine($"Nombre Empleado: {nombre}");
                Console.WriteLine($"Tipo Empleado: {tipoEmpleado}");
                Console.WriteLine($"Salario por Hora: {precioHora}");
                Console.WriteLine($"Cantidad de Horas: {horasLaboradas}");
                Console.WriteLine($"Salario Ordinario: {salarioOrdinario}");
                Console.WriteLine($"Aumento: {aumento}");
                Console.WriteLine($"Salario Bruto: {salarioBruto}");
                Console.WriteLine($"Deducción CCSS: {rebajosCCSS}");
                Console.WriteLine($"Salario Neto: {salarioNeto}");
                switch (tipoEmpleado)
                {
                    case 1:
                        countOperarios++;
                        totalNetoOp = +salarioNeto;
                        break;
                    case 2:
                        countProfesionales++;
                        totalNetoPro = +salarioNeto;
                        break;
                    case 3:
                        countTecnicos++;
                        totalNetoTec = +salarioNeto;
                        break;
                }
                Console.WriteLine("Desea ingresar otro empledo?-- (S/N)");
                continuar = Console.ReadLine().ToUpper();
                // Repetir el codigo cada vez que la respuesta sea si
            } while (continuar == "S");
            //Mostrar estadisticas de los totales:
            if (countOperarios > 0)
            {
                Console.WriteLine($"El total de operarios es de: {countOperarios}");
                Console.WriteLine($"El total de salarios netos es de: {totalNetoOp}");
                Console.WriteLine($"El promedio de los salarios es de:{totalNetoOp / countOperarios}");
       
            }
            else
            {
                Console.Write("No hay operarios");
            }
            if (countProfesionales > 0)
            {
                Console.WriteLine($"El total de profesionales es de: {countProfesionales}");
                Console.WriteLine($"El total de salarios netos es de: {totalNetoPro}");
                Console.WriteLine($"El promedio de los salarios es de:{totalNetoPro / countProfesionales}");

            }
            else
            {
                Console.Write("No hay profesionales");
            }
            if (countTecnicos > 0)
            {
                Console.WriteLine($"El total de Tecnicos es de: {countTecnicos}");
                Console.WriteLine($"El total de salarios netos es de: {totalNetoTec}");
                Console.WriteLine($"El promedio de los salarios es de:{totalNetoTec / countTecnicos}");
            }
            else
            {
                Console.Write("No hay Tecnicos");
            }
            Console.ReadLine();

        }
         }

    }*/
            // Listas para almacenar los datos de los empleados
            List<string> cedulas = new List<string>();
            List<string> nombres = new List<string>();
            List<int> tiposEmpleado = new List<int>();
            List<int> horasLaboradas = new List<int>();
            List<int> preciosPorHora = new List<int>();
            List<float> salariosNetos = new List<float>();

            // Variables para estadísticas
            int cantidadOperarios = 0, cantidadTecnicos = 0, cantidadProfesionales = 0;
            double acumuladoSalarioNetoOperarios = 0, acumuladoSalarioNetoTecnicos = 0, acumuladoSalarioNetoProfesionales = 0;

            string continuar = "S";

            while (continuar.ToUpper() == "S")
            {
                // Solicitar y leer los datos del empleado
                Console.WriteLine("Número de cédula: ");
                cedulas.Add(Console.ReadLine());

                Console.WriteLine("Nombre del empleado: ");
                nombres.Add(Console.ReadLine());

                Console.WriteLine("Tipo de empleado (1-Operario, 2-Técnico, 3-Profesional): ");
                tiposEmpleado.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Cantidad de horas laboradas: ");
                horasLaboradas.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Precio por hora: ");
                preciosPorHora.Add(int.Parse(Console.ReadLine()));

                // Calcular salario base la expresion [^1] lo que hace es ir al ultimo elemento añadido a la lista
                int salarioBase = horasLaboradas[^1] * preciosPorHora[^1];

                // Calcular el aumento según el tipo de empleado
                float aumento = 0;
                switch (tiposEmpleado[^1])
                {
                    case 1:
                        aumento = salarioBase * 0.15f;
                        break;
                    case 2:
                        aumento = salarioBase * 0.10f;
                        break;
                    case 3:
                        aumento = salarioBase * 0.05f;
                        break;
                }

                // Calcular salario bruto
                float salarioBruto = salarioBase + aumento;

                // Calcular las deducciones de ley (CCSS)
                float rebajosCCSS = salarioBruto * 0.0917f;

                // Calcular el salario neto
                float salarioNeto = salarioBruto - rebajosCCSS;
                salariosNetos.Add(salarioNeto);

                // Actualizar estadísticas
                switch (tiposEmpleado[^1])
                {
                    case 1:
                        cantidadOperarios++;
                        acumuladoSalarioNetoOperarios += salarioNeto;
                        break;
                    case 2:
                        cantidadTecnicos++;
                        acumuladoSalarioNetoTecnicos += salarioNeto;
                        break;
                    case 3:
                        cantidadProfesionales++;
                        acumuladoSalarioNetoProfesionales += salarioNeto;
                        break;
                }

                // Preguntar al usuario si desea continuar
                Console.Write("¿Desea continuar agregando empleados? (S/N): ");
                continuar = Console.ReadLine();
            }

            // Mostrar todos los empleados
            Console.WriteLine("\nLista de empleados:");
            for (int contador  = 0; contador < cedulas.Count; contador++)
            {
                Console.WriteLine($"Cédula: {cedulas[contador]}");
                Console.WriteLine($"Nombre: {nombres[contador]}");
                Console.WriteLine($"Tipo de Empleado: {tiposEmpleado[contador]}");
                Console.WriteLine($"Horas Laboradas: {horasLaboradas[contador]}");
                Console.WriteLine($"Precio por Hora: {preciosPorHora[contador]}");
                Console.WriteLine($"Salario Neto: {salariosNetos[contador]}");
            }

            // Calcular promedios
            double promedioSalarioNetoOperarios = acumuladoSalarioNetoOperarios / cantidadOperarios ;
            double promedioSalarioNetoTecnicos =  acumuladoSalarioNetoTecnicos / cantidadTecnicos ;
            double promedioSalarioNetoProfesionales =  acumuladoSalarioNetoProfesionales / cantidadProfesionales;

            // Mostrar estadísticas finales
            Console.WriteLine("Estadísticas:");
            Console.WriteLine($"1) Cantidad Empleados Tipo Operarios: {cantidadOperarios}");
            Console.WriteLine($"2) Acumulado Salario Neto para Operarios: {acumuladoSalarioNetoOperarios}");
            Console.WriteLine($"3) Promedio Salario Neto para Operarios: {promedioSalarioNetoOperarios}");
            Console.WriteLine($"4) Cantidad Empleados Tipo Técnico: {cantidadTecnicos}");
            Console.WriteLine($"5) Acumulado Salario Neto para Técnicos: {acumuladoSalarioNetoTecnicos}");
            Console.WriteLine($"6) Promedio Salario Neto para Técnicos: {promedioSalarioNetoTecnicos}");
            Console.WriteLine($"7) Cantidad Empleados Tipo Profesional: {cantidadProfesionales}");
            Console.WriteLine($"8) Acumulado Salario Neto para Profesionales: {acumuladoSalarioNetoProfesionales}");
            Console.WriteLine($"9) Promedio Salario Neto para Profesionales: {promedioSalarioNetoProfesionales}");

            Console.ReadKey();
        }
    }
}