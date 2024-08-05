using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models
{
    public class Cat : Animal
    {


        public static bool BreedingStatus {get; set;}
        public static string? FurLength {get; set;}

        public Cat(bool breedingStatus, string? furLength, string? name, DateOnly birthDate, string? breed, string? color, double weightInKg):
        base (name, birthDate, breed, color, weightInKg)
        {
            BreedingStatus = breedingStatus;
            FurLength = furLength;
            Name = name;
            BirthDate = birthDate;
            Breed = breed;
            Color = color;
            WeightInKg = weightInKg;
        }

        public override void ShowInformation()
        {
            Console.WriteLine($"Nombre: {GetName()}");
            Console.WriteLine($"Fecha de Cumpleaños: {GetBirthDate()}");
            Console.WriteLine($"Raza: {GetBreed()}");
            Console.WriteLine($"Color: {GetColor()}");
            Console.WriteLine($"Peso en Kilos: {GetWeightInkg()}");
        }

        public static void CastrateAnimal()
        {
            ManagerApp.Header("INICIANDO PROCEDIMIENTO");
            Console.Write("Debemos verificar que el animal no haya sido intervenido anteriormente, porfavor Ingrese el nombre del perro: ");
            string name = Console.ReadLine();
            name = name.Trim();

            Cat cat = VeterinaryClinic.Cats.Find(d => d.GetName() == name);

            if (cat != null)
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

            

            Cat cat = VeterinaryClinic.Cats.Find(d => d.GetName() == name);

            if (cat != null)
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
    }
}