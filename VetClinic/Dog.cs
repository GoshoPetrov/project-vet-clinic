using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic
{
    internal class Dog : IAnimal
    {
        public Dog(string name, DateTime birthDay,
            string breed, string medicalHistory,
            double weight, string color)
        {
            this.Name = name;
            this.BirthDay = birthDay;
            this.Breed = breed;
            this.MedicalHistory = medicalHistory;
            this.Weight = weight;
            this.Color = color;
            this.Status = Status.NotAdopted;
        }

        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string Breed { get; set; }

        public double Weight { get; set; }

        public string MedicalHistory { get; set; }

        public string Color { get; set; }

        public Status Status { get; set; }

        public string Image { get; set; }

    }
}
