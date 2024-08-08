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


        public void SaveDog()
        {
            ManagerApp.CreateDog();

        }
        public void SaveCat()
        {
            ManagerApp.CreateCat();
        }


        public void UpdateDog()
        {
            ManagerApp.Header("ACTUALIZANDO INFORMACIÓN DEL PERRO");
            Console.Write("Ingrese el nombre del perro: ");
            string name = Console.ReadLine();
            name = name.Trim();

            Dog dog = Dogs.Find(d => d.GetName() == name);

            if (dog != null)
            {
                Console.Write($"Nuevo nombre del perro o presione enter para mantener el mismo ({dog.GetName()}): ");
                string? nameUpdate = Console.ReadLine();
                nameUpdate = nameUpdate.Trim();
                ManagerApp.Separator();

                Console.Write($"¿Desea corregir la fecha de nacimiento del perro? o presione enter para mantener el mismo ({dog.GetBirthDate()}): ");
                DateOnly birthDateUpdate = DateOnly.Parse(Console.ReadLine());
                ManagerApp.Separator();

                Console.Write($"Nueva Raza del perro o presione enter para mantener el mismo ({dog.GetBreed()}): ");
                string? breedUpdate = Console.ReadLine();
                breedUpdate = breedUpdate.Trim();
                ManagerApp.Separator();

                Console.Write($"Nuevo color del perro o presione enter para mantener el mismo ({dog.GetColor()}): ");
                string? colorUpdate = Console.ReadLine();
                colorUpdate = colorUpdate.Trim();
                ManagerApp.Separator();

                Console.Write($"Nuevo peso en Kilos del perro o presione enter para mantener el mismo ({dog.GetWeightInkg()}): ");
                double weightInKgUpdate = double.Parse(Console.ReadLine());
                ManagerApp.Separator();

                Console.Write($"El perro está castrado? presione enter para mantener el mismo ({Dog.BreedingStatus}): ");
                Console.WriteLine("Si el perro ha sido castrado por favor escriba 'si' ");
                string? breedingStatusUpdate = Console.ReadLine();
                breedingStatusUpdate = breedingStatusUpdate.Trim().ToLower();
                bool newBreedingStatus;

                switch (breedingStatusUpdate)
                {
                    case "si":
                        newBreedingStatus = true;
                        break;
                    default:
                        ManagerApp.Footer("OPCIÓN NO VALIDA");
                        return;
                }

                ManagerApp.Separator();

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
                        ManagerApp.Footer("OPCIÓN NO VALIDA");
                        return;
                }
                ManagerApp.Separator();


                Console.Write($"Nuevo número de Micro Ship o presione enter para mantener el mismo ({dog.MicroShipNumber}): ");
                string? microShipNumberUpdate = Console.ReadLine();
                microShipNumberUpdate = microShipNumberUpdate.Trim();
                ManagerApp.Separator();

                Console.Write($"¿El ladrido del perro a cambiado? o presione enter para mantener el mismo ({dog.BarkVolume}): ");
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
                        ManagerApp.Footer("OPCIÓN NO VALIDA");
                        return;
                }
                ManagerApp.Separator();

                Console.Write($"El tipo de pelo actual es: ({Dog.CoatType}), presione enter para continuar ");

                dog.SetName(string.IsNullOrEmpty(nameUpdate) ? dog.GetName() : nameUpdate);
                dog.SetBirthDate(birthDateUpdate == null ? dog.GetBirthDate() : birthDateUpdate);
                dog.SetBreed(string.IsNullOrEmpty(breedUpdate) ? dog.GetBreed() : breedUpdate);
                dog.SetColor(string.IsNullOrEmpty(colorUpdate) ? dog.GetColor() : colorUpdate);
                dog.SetWeightInKg(weightInKgUpdate == null ? dog.GetWeightInkg() : weightInKgUpdate);
                Dog.BreedingStatus = newBreedingStatus ? Dog.BreedingStatus : newBreedingStatus;
                dog.Temperament = string.IsNullOrEmpty(temperamentUpdate) ? dog.Temperament : temperamentUpdate;
                dog.BarkVolume = string.IsNullOrEmpty(newBarkVolumeUpdate) ? dog.BarkVolume : newBarkVolumeUpdate;
                ManagerApp.Footer("MASCOTA ACTUALIZADA CON ÉXITO");

            }
        }
        public void UpdateCat()
        {
            ManagerApp.Header("ACTUALIZANDO INFORMACIÓN DEL GATO");
            Console.Write("Ingrese el nombre del gato: ");
            string name = Console.ReadLine();
            name = name.Trim();

            Cat cat = Cats.Find(d => d.GetName() == name);

            if (cat != null)
            {
                Console.Write($"Nuevo nombre del gato o presione enter para mantener el mismo ({cat.GetName()}): ");
                string? nameUpdate = Console.ReadLine();
                nameUpdate = nameUpdate.Trim();
                ManagerApp.Separator();

                Console.Write($"¿Desea corregir la fecha de nacimiento del gato? o presione enter para mantener el mismo ({cat.GetBirthDate()}): ");
                DateOnly birthDateUpdate = DateOnly.Parse(Console.ReadLine());
                ManagerApp.Separator();

                Console.Write($"Nueva Raza del gato o presione enter para mantener el mismo ({cat.GetBreed()}): ");
                string? breedUpdate = Console.ReadLine();
                breedUpdate = breedUpdate.Trim();
                ManagerApp.Separator();

                Console.Write($"Nuevo color del gato o presione enter para mantener el mismo ({cat.GetColor()}): ");
                string? colorUpdate = Console.ReadLine();
                colorUpdate = colorUpdate.Trim();
                ManagerApp.Separator();

                Console.Write($"Nuevo peso en Kilos del gato o presione enter para mantener el mismo ({cat.GetWeightInkg()}): ");
                double weightInKgUpdate = double.Parse(Console.ReadLine());
                ManagerApp.Separator();

                Console.Write($"El gato está castrado? presione enter para mantener el mismo ({Cat.BreedingStatus}): ");
                Console.WriteLine("Si el gato ha sido castrado por favor escriba 'si' ");
                string? breedingStatusUpdate = Console.ReadLine();
                breedingStatusUpdate = breedingStatusUpdate.Trim().ToLower();
                bool newBreedingStatus;

                switch (breedingStatusUpdate)
                {
                    case "si":
                        newBreedingStatus = true;
                        break;
                    default:
                        ManagerApp.Footer("OPCIÓN NO VALIDA");
                        return;
                }

                ManagerApp.Separator();


                Console.Write($"El tipo de pelo actual es: ({Cat.FurLength}), presione enter para continuar ");



                cat.SetName(string.IsNullOrEmpty(nameUpdate) ? cat.GetName() : nameUpdate);
                cat.SetBirthDate(birthDateUpdate == null ? cat.GetBirthDate() : birthDateUpdate);
                cat.SetBreed(string.IsNullOrEmpty(breedUpdate) ? cat.GetBreed() : breedUpdate);
                cat.SetColor(string.IsNullOrEmpty(colorUpdate) ? cat.GetColor() : colorUpdate);
                cat.SetWeightInKg(weightInKgUpdate == null ? cat.GetWeightInkg() : weightInKgUpdate);
                Cat.BreedingStatus = newBreedingStatus ? Cat.BreedingStatus : newBreedingStatus;

                ManagerApp.Footer("MASCOTA ACTUALIZADA CON ÉXITO");

            }
        }


        public void DeleteDog()
        {
            ManagerApp.Header("ELIMINANDO PERRO");
            Console.Write("Ingrese el nombre del perro: ");
            string? name = Console.ReadLine();
            name = name.Trim().ToLower();

            Dog dog = Dogs.Find(x => x.GetName() == name);
            if (name != null)
            {
                Dogs.Remove(dog);
                ManagerApp.Footer("PERRO ELIMINANDO CON ÉXITO");
            }
            else
            {
                ManagerApp.Footer("PERRO NO ENCONTRADO");
            }
        }
        public void DeleteCat()
        {
            ManagerApp.Header("ELIMINANDO GATO");
            Console.Write("Ingrese el nombre del gato: ");
            string? name = Console.ReadLine();
            name = name.Trim().ToLower();

            Cat cat = Cats.Find(x => x.GetName() == name);
            if (name != null)
            {
                Cats.Remove(cat);
                ManagerApp.Footer("GATO ELIMINANDO CON ÉXITO");
            }
            else
            {
                ManagerApp.Footer("GATO NO ENCONTRADO");
            }
        }


        public void ShowAllPatiens()
        {
            ManagerApp.Header("PACIENTES GUARDADOS");
            foreach (Dog dog in Dogs)
            {
                dog.ShowInformation();
            }

            ManagerApp.Separator();

            foreach (Cat cat in Cats)
            {
                cat.ShowInformation();
            }
            ManagerApp.Separator();
        }


        public void ShowAnimals(string type)
        {
            Console.WriteLine("Ingrese el tipo de animal que desea ver: ");
            Console.WriteLine(@"Seleccione el numero según corresponda
            1. perro
            2. gato
            ");

            // type = Console.ReadLine();
            type = type.Trim().ToLower();
            switch (type)
            {
                case "1":
                    foreach (Dog dog in Dogs)
                    {
                        dog.ShowInformation();
                    }
                    break;
                case "2":
                    foreach (Cat cat in Cats)
                    {
                        cat.ShowInformation();
                    }
                    break;
                default:
                    ManagerApp.Footer("OPCIÓN NO VALIDA");
                    return;
            }

        }

        public void ShowPatient(string name)
        {
            Console.WriteLine("Ingrese el tipo de animal: ");
            Console.WriteLine(@"Seleccione el numero según corresponda
            1. perro
            2. gato
            ");
            string? animalType = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre de animal que desea ver: ");
            // name = Console.ReadLine();
            name = name.Trim().ToLower();

            switch (animalType)
            {
                case "1":
                    Dog dog = Dogs.Find(d => d.GetName() == name);
                    dog.ShowInformation();
                    break;
                case "2":
                    Cat cat = Cats.Find(d => d.GetName() == name);
                    cat.ShowInformation();
                    break;

            }

        }

    }
}