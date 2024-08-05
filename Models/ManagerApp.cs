using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models
{
    public class ManagerApp
    {

        public static void CreateDog()
        {
            Header("AGREGANDO NUEVO PERRO");

            Console.Write("Ingrese el nombre del Perro: ");
            string? dogName = Console.ReadLine();
            Separator();

            Console.Write("Ingrese la fecha de nacimiento (aaaa/mm/dd): ");
            DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
            Separator();

            Console.Write("Ingrese la Raza del perro: ");
            string breed = Console.ReadLine();
            Separator();

            Console.Write("Que color es el perro: ");
            string color = Console.ReadLine();
            Separator();

            Console.Write("Cuanto pesa el Perro en KG? ");
            double weightInKg = double.Parse(Console.ReadLine());
            Separator();

            Console.Write("El perro está castrado? ");
            Console.WriteLine(@"Escriba si o no: ");
            string? breedingStatus = Console.ReadLine();
            breedingStatus = breedingStatus.Trim().ToLower();
            bool newBreedingStatus;

            switch (breedingStatus)
            {
                case "si":
                    newBreedingStatus = true;
                    break;
                case "no":
                    newBreedingStatus = false;
                    break;
                default:
                    Footer("OPCIÓN NO VALIDA");
                    return;
            }

            Console.Write(@"Ingrese el temperamento del perro (Escriba el número según corresponda): 
                            1. Timido
                            2. Normal
                            3. Agresivo
                            Ingresa una opción: ");
            string? selectTemperament = Console.ReadLine();
            selectTemperament = selectTemperament.Trim().ToLower();
            string? temperamentUpdate = null;
            switch (selectTemperament)
            {
                case "1":
                    temperamentUpdate = "Timido";
                    break;
                case "2":
                    temperamentUpdate = "Normal";
                    break;
                case "3":
                    temperamentUpdate = "Agresivo";
                    break;
                default:
                    Footer("OPCIÓN NO VALIDA");
                    return;
            }
            Separator();

            Console.Write("Escriba el número del microship ");
            string microShipNumber = Console.ReadLine();
            Separator();

            Console.Write($"¿Como es el ladrido del perro?: ");
            Console.WriteLine(@"
                1. No ladra
                2. Normal
                3. Ladrido fuerte

                Escriba el número según corresponda: 
                ");
            string? barkVolumeUpdate = Console.ReadLine();
            barkVolumeUpdate = barkVolumeUpdate.Trim().ToLower();
            string? newBarkVolumeUpdate = null;
            switch (barkVolumeUpdate)
            {
                case "1":
                    newBarkVolumeUpdate = "No ladra";
                    break;
                case "2":
                    newBarkVolumeUpdate = "Normal";
                    break;
                case "3":
                    newBarkVolumeUpdate = "Ladrido fuerte";
                    break;
                default:
                    Footer("OPCIÓN NO VALIDA");
                    return;
            }
            Separator();

            Console.Write($"¿Cual es el tipo de pelo del perro?: ");
            Console.WriteLine(@"
                1. Sin pelo
                2. Pelo corto
                3. Pelo Mediano
                4. Pelo Largo

                Escriba el número según corresponda: 
                ");
            string? coatType = Console.ReadLine();
            coatType = coatType.Trim().ToLower();
            string? newCoatType = null;
            switch (coatType)
            {
                case "1":
                    newCoatType = "Sin pelo";
                    break;
                case "2":
                    newCoatType = "Pelo corto";
                    break;
                case "3":
                    newCoatType = "Pelo Mediano";
                    break;
                case "4":
                    newCoatType = "Pelo Largo";
                    break;
                default:
                    Footer("OPCIÓN NO VALIDA");
                    return;
            }
            Separator();

            Dog dog = new Dog(newBreedingStatus, temperamentUpdate, microShipNumber, newBarkVolumeUpdate, newCoatType, dogName, birthDate, breed, color, weightInKg);
            VeterinaryClinic.Dogs.Add(dog);
            Footer("AGREGANDO CLIENTE CON ÉXITO");
        }


        public static void CreateCat()
        {
            Header("AGREGANDO NUEVO GATO");

            Console.Write("Ingrese el nombre del Gato: ");
            string? dogName = Console.ReadLine();
            Separator();

            Console.Write("Ingrese la fecha de nacimiento (aaaa/mm/dd): ");
            DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
            Separator();

            Console.Write("Ingrese la Raza del gato: ");
            string breed = Console.ReadLine();
            Separator();

            Console.Write("Que color es el gato: ");
            string color = Console.ReadLine();
            Separator();

            Console.Write("Cuanto pesa el gato en KG? ");
            double weightInKg = double.Parse(Console.ReadLine());
            Separator();

            Console.Write("El gato está castrado? ");
            Console.WriteLine(@"Escriba si o no: ");
            string? breedingStatus = Console.ReadLine();
            breedingStatus = breedingStatus.Trim().ToLower();
            bool newBreedingStatus;

            switch (breedingStatus)
            {
                case "si":
                    newBreedingStatus = true;
                    break;
                case "no":
                    newBreedingStatus = false;
                    break;
                default:
                    Footer("OPCIÓN NO VALIDA");
                    return;
            }


            Console.Write($"¿Cual es el tipo de pelo del gato?: ");
            Console.WriteLine(@"
                1. Sin pelo
                2. Pelo corto
                3. Pelo Mediano
                4. Pelo Largo

                Escriba el número según corresponda: 
                ");
            string? furLength = Console.ReadLine();
            furLength = furLength.Trim().ToLower();
            string? newfurLength = null;
            switch (furLength)
            {
                case "1":
                    newfurLength = "Sin pelo";
                    break;
                case "2":
                    newfurLength = "Pelo corto";
                    break;
                case "3":
                    newfurLength = "Pelo Mediano";
                    break;
                case "4":
                    newfurLength = "Pelo Largo";
                    break;
                default:
                    ManagerApp.Footer("OPCIÓN NO VALIDA");
                    return;
            }
            Separator();

            Cat cat = new Cat(newBreedingStatus, newfurLength, dogName, birthDate, breed, color, weightInKg);
            VeterinaryClinic.Cats.Add(cat);
            Footer("AGREGANDO CLIENTE CON ÉXITO");

        }



        public static void Header(string tittle)
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(TextCenter(tittle, 50));
            Console.WriteLine(new string('=', 50));
        }

        public static void Footer(string footer)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(TextCenter(footer, 50));
            Console.WriteLine(new string('-', 50));
        }

        public static void Separator()
        {
            Console.WriteLine(new string('-', 50));
        }

        private static string TextCenter(string text, int longitudTotal)
        {
            if (text.Length >= longitudTotal)
                return text;

            int spaceLeft = (longitudTotal - text.Length) / 2;
            int spaceRight = longitudTotal - text.Length - spaceLeft;

            return new string(' ', spaceLeft) + text + new string(' ', spaceRight);
        }
    }
}