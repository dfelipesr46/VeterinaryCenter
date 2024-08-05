using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models
{
    public class Animal
    {

        protected int Id { get; set; }
        protected string? Name { get; set; }
        protected DateOnly BirthDate { get; set; }
        protected string? Breed { get; set; }
        protected string? Color { get; set; }
        protected double WeightInKg { get; set; }


        public string GetName() => Name;
        public DateOnly GetBirthDate() => BirthDate;
        public string GetBreed() => Breed;
        public string GetColor() => Color;
        public double GetWeightInkg() => WeightInKg;


        public string SetName(string name) => Name = name;
        public DateOnly SetBirthDate(DateOnly birthDate) => BirthDate = birthDate;
        public string SetBreed(string breed) => Breed = breed;
        public string SetColor(string color) => Color = color;
        public double SetWeightInKg(double weightInKg) => WeightInKg = weightInKg;


        public Animal(string? name, DateOnly birthDate, string? breed, string? color, double weightInKg)
        {
            Name = name;
            BirthDate = birthDate;
            Breed = breed;
            Color = color;
            WeightInKg = weightInKg;
        }


        public void ShowInformation()
        {
            Console.WriteLine($"Nombre: {GetName()}");
            Console.WriteLine($"Fecha de Cumpleaños: {GetBirthDate()}");
            Console.WriteLine($"Raza: {GetBreed()}");
            Console.WriteLine($"Color: {GetColor()}");
            Console.WriteLine($"Peso en Kilos: {GetWeightInkg()}");
        }

        protected void BasicReview()
        {

        }

        protected void CalculateAgeInMonths()
        {
            var ageInMonths = DateTime.Now.Month - BirthDate.Month  ;
            if (DateTime.Now.Month < BirthDate.Month)
            {
                age--;
            }
            return age;
        }
    }
}