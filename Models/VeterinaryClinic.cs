using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models
{
    public class VeterinaryClinic
    {

        public string? ClinicName { get; set; }
        public string? Adress { get; set; }
        public static List<Dog> Dogs { get; set; } = new List<Dog>();
        public static List<Cat> Cats { get; set; } = new List<Cat>();

        public VeterinaryClinic(string? clinicName, string? adress)
        {
            ClinicName = clinicName;
            Adress = adress;
        }


        
    }
}