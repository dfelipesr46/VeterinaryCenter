using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models
{
    public class Dog : Animal
    {

        public bool BreedingStatus { get; set; }
        public string? Temperament { get; set; }
        public string? MicroShipNumber { get; set; }
        public string? BarkVolume { get; set; }
        public string? CoatType { get; set; }

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

        public void CastrateAnimal()
        {

        }

        public void Hairdress()
        {

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