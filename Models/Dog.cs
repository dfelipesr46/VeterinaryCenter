using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models
{
    public class Dog : Animal
    {

        public static bool BreedingStatus { get; set; }
        public string? Temperament { get; set; }
        public string? MicroShipNumber { get; set; }
        public string? BarkVolume { get; set; }
        public static string? CoatType { get; set; }

        public Dog(bool breedingStatus, string? temperament, string? microShipNumber, string? barkVolume, string? coatType, string? name, DateOnly birthDate, string? breed, string? color, double weightInKg) :
        base(name, birthDate, breed, color, weightInKg)
        {
            BreedingStatus = breedingStatus;
            Temperament = temperament;
            MicroShipNumber = microShipNumber;
            BarkVolume = barkVolume;
            CoatType = coatType;
            Name = name;
            BirthDate = birthDate;
            Breed = breed;
            Color = color;
            WeightInKg = weightInKg;
        }

        public static void CastrateAnimal()
        {
            ManagerApp.Header("INICIANDO PROCEDIMIENTO");
            Console.Write("Debemos verificar que el animal no haya sido intervenido anteriormente, porfavor Ingrese el nombre del perro: ");
            string name = Console.ReadLine();
            name = name.Trim();

            Dog dog = VeterinaryClinic.Dogs.Find(d => d.GetName() == name);

            if (dog != null)
            {

                if (BreedingStatus == true)
                {
                    Console.WriteLine("El animal ya esta castrado");
                }
                else
                {
                    Console.WriteLine("Iniciando el proceso de Castración del animal");
                    BreedingStatus = true;
                }
            }
            else
            {
                Console.WriteLine("El animal no está registrado");

            }


        }

        public static void Hairdress()
        {
            ManagerApp.Header("INICIANDO PROCEDIMIENTO");
            Console.Write("porfavor Ingrese el nombre del perro: ");
            string name = Console.ReadLine();
            name = name.Trim();

            

            Dog dog = VeterinaryClinic.Dogs.Find(d => d.GetName() == name);

            if (dog != null)
            {

                if (BreedingStatus == true)
                {
                    Console.WriteLine("El animal ya esta castrado");
                }
                else
                {
                    Console.WriteLine("Iniciando el proceso de Castración del animal");
                    BreedingStatus = true;
                }
            }
            else
            {
                Console.WriteLine("El animal no está registrado");

            }
        }

        public override void ShowInformation()
        {
            Console.WriteLine($"Nombre: {GetName()}");
            Console.WriteLine($"Fecha de Cumpleaños: {GetBirthDate()}");
            Console.WriteLine($"Raza: {GetBreed()}");
            Console.WriteLine($"Color: {GetColor()}");
            Console.WriteLine($"Peso en Kilos: {GetWeightInkg()}");
        }

        internal void ShowInformation(string name)
        {
            throw new NotImplementedException();
        }
    }
}