using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models
{
    public class Cat : Animal
    {


        public bool BreedingStatus {get; set;}
        public string? FurLength {get; set;}

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
    }
}