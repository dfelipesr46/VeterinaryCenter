using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VeterinaryClinic veterinaryClinic = new();
            Console.Clear();
            bool follow = true;
            while (follow)
            {
                ManagerApp.Header("Veterinary Center");
                Console.WriteLine("1. Ingresar nuevo Paciente");
                Console.WriteLine("2. Actualizar Paciente");
                Console.WriteLine("3. Ver Pacientes Registrados");
                Console.WriteLine("4. Eliminar Paciente");
                Console.WriteLine("5. Servicios Veterinaria");
                Console.WriteLine("6. Salir");
                Console.Write("Ingresa la opción: ");

                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        bool createAnimal = true;
                        while (createAnimal)
                        {
                            ManagerApp.Header("INGRESANDO UN NUEVO PACIENTE: ");
                            Console.WriteLine("1. Registrar Perro");
                            Console.WriteLine("2. Registrar Gato");
                            Console.WriteLine("3. Salir");
                            Console.Write("Ingresa la opción: ");

                            int animalOpcion = int.Parse(Console.ReadLine());
                            switch (animalOpcion)
                            {
                                case 1:
                                    veterinaryClinic.SaveDog();
                                    break;
                                case 2:
                                    veterinaryClinic.SaveCat();
                                    break;
                                case 3:
                                    createAnimal = false;
                                    break;
                                default:
                                    ManagerApp.Footer("OPCION NO VALIDA");
                                    break;
                            }


                        }
                        break;
                    case 2:
                        bool updateAnimal = true;
                        while (updateAnimal)
                        {
                            ManagerApp.Header("ACTUALIZANDO PACIENTE: ");
                            Console.WriteLine("1. Actualizar Perro");
                            Console.WriteLine("2. Actualizar Gato");
                            Console.WriteLine("3. Salir");
                            Console.Write("Ingresa la opción: ");
                            int animalOpcion = int.Parse(Console.ReadLine());
                            switch (animalOpcion)
                            {
                                case 1:
                                    veterinaryClinic.UpdateDog();
                                    break;
                                case 2:
                                    veterinaryClinic.UpdateCat();
                                    break;
                                case 3:
                                    updateAnimal = false;
                                    break;
                                default:
                                    ManagerApp.Footer("OPCION NO VALIDA");
                                    break;
                            }
                        }
                        break;

                    case 3:
                        bool showPatient = true;
                        while (showPatient)
                        {
                            ManagerApp.Header("Escoja el tipo de informe: ");
                            Console.WriteLine("1. Ver todos los pacientes");
                            Console.WriteLine("2. Ver paciente por tipo de Animal");
                            Console.WriteLine("3. Buscar paciente");
                            Console.WriteLine("4. Salir");
                            Console.Write("Ingresa la opción: ");
                            int informeOpcion = int.Parse(Console.ReadLine());
                            switch (informeOpcion)
                            {
                                case 1:
                                    veterinaryClinic.ShowAllPatiens();
                                    break;
                                case 2:
                                    string? type = Console.ReadLine();
                                    veterinaryClinic.ShowAnimals(type);
                                    break;
                                case 3:
                                    string? name = Console.ReadLine();
                                    veterinaryClinic.ShowPatient(name);
                                    break;
                                case 4:
                                    showPatient = false;
                                    break;
                                default:
                                    ManagerApp.Footer("OPCION NO VALIDA");
                                    break;
                            }
                        }
                        break;

                    case 4:
                        bool deletePatient = true;
                        while (deletePatient)
                        {
                            ManagerApp.Header("Escoja el tipo de Animal que desea eliminar: ");
                            Console.WriteLine("1. Eliminar Perro");
                            Console.WriteLine("2. Eliminar Gato");
                            Console.WriteLine("3. Salir");
                            int deleteOption = int.Parse(Console.ReadLine());


                            switch (deleteOption)
                            {
                                case 1:
                                    veterinaryClinic.DeleteDog();
                                    break;
                                case 2:
                                    veterinaryClinic.DeleteDog();
                                    break;
                                case 3:
                                    deletePatient = false;
                                    break;
                                default:
                                    ManagerApp.Footer("OPCION NO VALIDA");
                                    break;
                            }
                        }
                        break;
                    case 5:
                        bool service = true;
                        while (service)
                        {
                            ManagerApp.Header("Escoja el tipo de servicio que desea: ");
                            Console.WriteLine("1. Castrar Perro");
                            Console.WriteLine("2. Castrar Gato");
                            Console.WriteLine("3. Cortar pelo Perro");
                            Console.WriteLine("4. Cortar pelo Gato");                            
                            Console.WriteLine("5. Salir");
                            int serviceOption = int.Parse(Console.ReadLine());


                            switch (serviceOption)
                            {
                                case 1:
                                    Dog.CastrateAnimal();
                                    break;
                                case 2:
                                    Cat.CastrateAnimal();
                                    break;
                                case 3:
                                    Dog.Hairdress();
                                    break;
                                    case 4:
                                    Cat.Hairdress();
                                    break;
                                    case 5:
                                    service = false;
                                    break;
                                default:
                                    ManagerApp.Footer("OPCION NO VALIDA");
                                    break;
                            }
                        }


                        break;

                    case 6:
                        follow = false;
                        break;
                    default:
                        ManagerApp.Footer("OPCION NO VALIDA");
                        break;
                }
            }

        }
    }
}


