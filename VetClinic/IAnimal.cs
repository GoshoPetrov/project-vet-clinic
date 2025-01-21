using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic
{
    public enum Status
    {
        Adopted,
        NotAdopted,
    }

    internal interface IAnimal
    {
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
