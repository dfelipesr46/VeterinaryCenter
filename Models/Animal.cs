using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models
{
    public abstract class Animal
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


        public abstract void ShowInformation();

        protected void BasicReview()
        {
            
        }

        protected int CalculateAgeInMonths()
        {
            int ageInMonths = (DateTime.Now.Year - BirthDate.Year) * 12 + DateTime.Now.Month - BirthDate.Month;
            if (DateTime.Now.Day < BirthDate.Day)
            {
                ageInMonths--;
            }
            return ageInMonths;
        }
    }
}